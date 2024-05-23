using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public partial class FormDashboardSalesPerson : Form
    {
        DataSet ds;
        DataTable dt, dtItem, dtSearch;
        UseDB u;
        Form f;

        User user;

        string currentTime;

        int selectedIndex, totalItems, selectedItemIndex;
        double totalPrice;
        double discount = 0;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        internal DataTable Dt
        { get
            {  return dt; }
          set
            { this.dt = value; } }

        internal DataTable DtItem
        {
            get
            { return dtItem; }
            set
            { this.dtItem = value; }
        }

        internal DataTable DtSearch
        {
            get
            { return dtSearch; }
            set
            { this.dtSearch = value; }
        }

        internal int SelectedIndex
        {
            get { return this.selectedIndex; }
            set { this.selectedIndex = value; }
        }

        internal FormDashboardSalesPerson()
        {
            InitializeComponent();

            try
            {
                u = new UseDB();

                this.ds = u.getInfo("select * from item;");
                this.DtSearch = ds.Tables[0];
                this.dtItem = (DataTable)ds.Tables[0];
                this.dgvItem.DataSource = dtItem;

                this.dgvItem.AutoGenerateColumns = false;

                this.dt = new DataTable();
                this.dt.Clear();
                this.dt.Columns.Add("Id");
                this.dt.Columns.Add("Type");
                this.dt.Columns.Add("Manufacturer");
                this.dt.Columns.Add("Model");
                this.dt.Columns.Add("Price");
                this.dt.Columns.Add("Amount");

                this.dgvCart.AutoGenerateColumns = false;
                this.dgvItem.DataSource = ds.Tables[0];

                this.pnlCart.Enabled = false;
                this.pnlPrice.Enabled = false;
                this.btnUpdateSelected.Enabled = false;
                this.btnRemoveSelected.Enabled = false;
                this.pnlUpdateAmount.Enabled = false;

                this.cbSearch.SelectedIndex = 1;
                this.lblTotalItems.Text += $" {this.totalItems}";
                this.lblTotalPrice.Text += $" {this.totalPrice}";
                this.lblFinalPrice.Text += $" {this.totalPrice}";
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An Error occured. Error: {exc.Message}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public FormDashboardSalesPerson(Form f, User user) :this()
        {
            this.user = user;
            this.f = f;
        }

        public FormDashboardSalesPerson(User user) : this()
        {
            this.user = user;
            //this.f = f;
        }

        private void dgvItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    if(Int32.Parse(dtItem.Rows[e.RowIndex][5].ToString()) > 0)
                    {
                        UpdateCarts(ref this.dgvItem, ref this.dtItem, ref this.dt, dgvItem.Rows[e.RowIndex].Cells[0].Value.ToString(), e.RowIndex, Int32.Parse(dgvItem.Rows[e.RowIndex].Cells[5].Value.ToString()), 1, 1);

                        this.updatePriceLabels(this.dt);

                        this.updateDataTableAmount(this.dtItem, ref this.dtSearch);

                        this.dtItem = this.dtSearch;

                        this.dgvCart.DataSource = this.Dt;
                        this.dgvItem.DataSource = this.dtItem;

                        this.txtSearch.Text = "";
                    }
                    else
                        MessageBox.Show("No amount available", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }      
                else
                    this.dgvItem.ClearSelection();
            }
            catch (Exception)
            {

            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int targetRow = this.getIndex(dtItem, dgvCart.Rows[this.SelectedIndex].Cells[0].Value.ToString());
                if (targetRow == -1)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int amount = Int32.Parse(dgvCart.Rows[SelectedIndex].Cells[4].Value.ToString());

                    int value = Int32.Parse(this.dtItem.Rows[targetRow][5].ToString());
                    value = value + amount;
                    this.dtItem.Rows[targetRow][5] = value.ToString();

                    this.dt.Rows.RemoveAt(this.SelectedIndex);

                    this.updatePriceLabels(dt);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No row selected in cart.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConfirmCart_Click(object sender, EventArgs e)
        {
            try
            {
                bool isZero = false;

                for(int i = 0; i<dt.Rows.Count; i++)
                {
                    if (Int32.Parse(dt.Rows[i]["Amount"].ToString()) == 0)
                    {
                        isZero = true;
                        break;
                    }
                }
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No items in cart.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if(isZero)
                    {
                        MessageBox.Show("Cart has rows with zero items.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                        new FormConfirm(this, this.user, this.dtItem, this.Dt, this.currentTime, this.discount, this.u).Show();
                }
                    
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An Error occured. Error: {exc.Message}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvItem_Click(object sender, EventArgs e)
        {
            this.pnlCart.Enabled = true;
            this.pnlPrice.Enabled = true;
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DtItem = this.DtSearch;
            this.SelectedIndex = e.RowIndex;
            this.btnUpdateSelected.Enabled = true;
            this.btnRemoveSelected.Enabled = true;

            try
            {
                if (e.ColumnIndex == 0)
                    this.UpdateCarts(ref this.dgvCart, ref this.dt, ref this.dtItem, dgvCart.Rows[e.RowIndex].Cells[0].Value.ToString(), e.RowIndex, Int32.Parse(dgvCart.Rows[e.RowIndex].Cells[4].Value.ToString()), 1, 1);
                
                if (Int32.Parse(this.dgvCart.Rows[e.RowIndex].Cells[4].Value.ToString()) == 0)
                {
                    this.dgvCart.Rows.RemoveAt(e.RowIndex);
                this.pnlUpdateAmount.Enabled = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An Error occured. Error: {exc.Message}", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.updatePriceLabels(dt);
            this.dgvItem.DataSource = this.DtSearch;
            this.txtSearch.Clear();
        }


        private void btnUpdateSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int targetRow = this.getIndex(dtItem, dgvCart.Rows[this.SelectedIndex].Cells[0].Value.ToString());
                if (targetRow == -1)
                {
                    MessageBox.Show("An error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                new FormUpdateCart(this).Show();
   
                this.dgvCart.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("No row selected in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        internal void UpdateCarts(ref DataGridView dgv, ref DataTable source, ref DataTable destination, string id, int RowIndex,int min, int input, int increment)
        {
            try
            {
                int indexDestination = -1;
                int indexSource = -1;

                if (min >= input)
                {
                    for (int i = 0; i < destination.Rows.Count; i++)
                    {
                        if (destination.Rows[i][0].ToString() == id)
                        {
                            indexDestination = i; break;
                        }
                    }

                    for (int i = 0; i < source.Rows.Count; i++)
                    {
                        if (source.Rows[i][0].ToString() == id)
                        {
                            indexSource = i; break;
                        }
                    }

                    if (indexDestination == -1)
                    {
                        DataRow cartOrder = destination.NewRow();
                        cartOrder["Id"] = dgv.Rows[RowIndex].Cells[0].Value.ToString();
                        cartOrder["Type"] = dgv.Rows[RowIndex].Cells[1].Value.ToString();
                        cartOrder["Manufacturer"] = dgv.Rows[RowIndex].Cells[2].Value.ToString();
                        cartOrder["Model"] = dgv.Rows[RowIndex].Cells[3].Value.ToString();
                        cartOrder["Price"] = dgv.Rows[RowIndex].Cells[4].Value.ToString();
                        cartOrder["Amount"] = "1";
                        destination.Rows.Add(cartOrder);
                    }
                    else
                    {
                        int value = Int32.Parse(destination.Rows[indexDestination][5].ToString());
                        value = value + increment;
                        destination.Rows[indexDestination][5] = value.ToString();
                    }

                    if (indexSource == -1)
                    {

                    }
                    else
                    {
                        int val = Int32.Parse(source.Rows[indexSource][5].ToString());
                        val = val - increment;
                        source.Rows[indexSource][5] = val.ToString();
                    }
                }
                else
                    MessageBox.Show("No amount availabe for that item. Try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occure. Error: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtDiscount.Text))
            {
                return;
            }
            else
            {

                if(Double.TryParse(txtDiscount.Text, out discount))
                {
                    if (discount >= 0 && discount <= 100)
                    {
                        double totalPrice = Convert.ToDouble(lblTotalPrice.Text.Remove(0, 18).Trim());
                        double price = totalPrice - totalPrice * (this.discount / 100);
                        this.lblFinalPrice.Text = $"Final Price (BDT): {price}";
                    }
                    else
                    {
                        MessageBox.Show("Discount value must be within 0 to 100%.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtDiscount.Text = "0";
                    }
                }
                else
                {
                    MessageBox.Show("Enter a floating point value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtDiscount.Text = "0";
                }
            }
        }

        internal int getIndex(DataTable dt, string target)
        {
            try
            {
                int result = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == target)
                    {
                        result = i; break;
                    }
                }
                return result;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtTemp = new DataTable();

                if (String.IsNullOrEmpty(txtSearch.Text))
                    this.dgvItem.DataSource = this.DtSearch;

                switch (this.cbSearch.SelectedIndex)
                {
                    case 0:
                        dtTemp = this.u.getQueryTable($"select * from item where iid like '%{this.txtSearch.Text}%';");
                        this.updateDataTableAmount(this.DtSearch, ref dtTemp);
                        break;
                    case 1:
                        dtTemp = this.u.getQueryTable($"select * from item where itype like '%{this.txtSearch.Text}%';");
                        this.updateDataTableAmount(this.DtSearch, ref dtTemp);
                        break;
                    case 2:
                        dtTemp = this.u.getQueryTable($"select * from item where ibrand like '%{this.txtSearch.Text}%';");
                        this.updateDataTableAmount(this.DtSearch, ref dtTemp);
                        break;
                    case 3:
                        dtTemp = this.u.getQueryTable($"select * from item where imodelno like '%{this.txtSearch.Text}%';");
                        this.updateDataTableAmount(this.DtSearch, ref dtTemp);
                        break;
                    case 4:
                        bool isNumeric = Double.TryParse(txtSearch.Text, out double result);
                        if (isNumeric)
                        {
                            dtTemp = this.u.getQueryTable($"select * from item where iprice = {result};");
                            this.updateDataTableAmount(this.DtSearch, ref dtTemp);
                        }
                        else
                            MessageBox.Show("Not a numeric value.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
                //this.updateDataTableAmount(this.dtItem, ref dtTemp);
                dtItem = dtTemp;
                this.dgvItem.DataSource = dtItem;
            }
            catch (Exception exc)
            { 
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.lblExchange.Text = "Exchanging items " + "From Inventory to cart";
                    this.pnlUpdateAmount.Enabled = true;
                    this.btnEnterCart.Visible = false;
                    this.btnEnteritem.Visible = true;

                    DataTable source = this.DtSearch;

                    this.lblItem.Text = "Item: " + source.Rows[e.RowIndex][2].ToString().Trim() + " " + source.Rows[e.RowIndex][3].ToString().Trim() + " " + source.Rows[e.RowIndex][1].ToString().Trim();
                    this.lblAvailableAmount.Text = "Availabe amount: " + source.Rows[e.RowIndex][5].ToString();

                    this.selectedItemIndex = e.RowIndex;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    this.lblExchange.Text = "Exchanging items " + "From Cart to Inventory";
                    this.pnlUpdateAmount.Enabled = true;
                    this.btnEnterCart.Visible = true;
                    this.btnEnteritem.Visible = false;

                    DataTable source = this.Dt;

                    this.lblItem.Text = "Item: " + source.Rows[e.RowIndex][2].ToString().Trim() + " " + source.Rows[e.RowIndex][3].ToString().Trim() + " " + source.Rows[e.RowIndex][1].ToString().Trim();
                    this.lblAvailableAmount.Text = "Availabe amount: " + source.Rows[e.RowIndex][5].ToString();

                    this.selectedItemIndex = e.RowIndex;
                }  
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDashboardSalesPerson_Load(object sender, EventArgs e)
        {
            this.lblId.Text = this.user.Id;
            this.lblName.Text = this.user.Name;
            this.lblUserCategory.Text = this.user.Role;
            this.lblCurrentTime.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm");

            this.InitializeTimer();

            this.lblInstruction1.Text = "1. Click on 'itemId' column to add item to cart.";
            this.lblInstruction2.Text = "2. Double clicking 'itemId' to add multiple amounts of an item \nto cart.";
            this.lblInstruction3.Text = "3. Clicking on the 'itemId' column of the cart will move the item \nback to inventory 1 by 1.";
            this.lblInstruction4.Text = "4. Double clicking 'itemId' to add multiple amounts of an item \nto cart";
            this.lblInstruction5.Text = "5. Can apply discounts if applicable using the textfield below.";
            this.lblInstruction6.Text = "6. After finalizing, press 'Confirm cart' button to store \ntransaction.";

            this.lblDesc.Text = "Salesperson Dashboard";
        }

        private void btnEnterCart_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable source = this.Dt;
                DataTable destination = this.DtSearch;

                if (Int32.TryParse(this.txtEnterAmount.Text, out int amount))
                {
                    if (amount >= 0)
                    {
                        this.UpdateCarts(ref this.dgvItem, ref source, ref destination, source.Rows[this.selectedItemIndex]["Id"].ToString(), this.selectedItemIndex, Int32.Parse(source.Rows[this.selectedItemIndex][5].ToString()), amount, amount);

                        this.lblItem.Text = "Item: " + source.Rows[this.selectedItemIndex][1].ToString();
                        this.lblAvailableAmount.Text = "Availabe amount: " + source.Rows[this.selectedItemIndex][5].ToString();

                        this.txtEnterAmount.Clear();
                        this.pnlUpdateAmount.Enabled = false;
                        this.lblAvailableAmount.Text = "";
                        this.lblItem.Text = "";
                        this.updatePriceLabels(dt);
                    }
                    else
                        MessageBox.Show("Entered value can not be negative.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Enter an integer value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtEnterAmount.Text = string.Empty;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnterItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable source = this.DtSearch;
                DataTable destination = this.Dt;

                if (Int32.TryParse(this.txtEnterAmount.Text, out int amount))
                {
                    if (amount >= 0)
                    {
                        this.UpdateCarts(ref this.dgvItem, ref source, ref destination, source.Rows[this.selectedItemIndex][0].ToString(), this.selectedItemIndex, Int32.Parse(source.Rows[this.selectedItemIndex][5].ToString()), amount, amount);

                        this.lblItem.Text = "Item: " + source.Rows[this.selectedItemIndex][1].ToString();
                        this.lblAvailableAmount.Text = "Availabe amount: " + source.Rows[this.selectedItemIndex][5].ToString();

                        this.txtEnterAmount.Clear();
                        this.pnlUpdateAmount.Enabled = false;
                        this.lblAvailableAmount.Text = "";
                        this.lblItem.Text = "";
                        this.updatePriceLabels(dt);
                    }
                    else
                        MessageBox.Show("Entered value can not be negative.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Enter an integer value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtEnterAmount.Text = string.Empty;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            new FormUpdatePassword(this.user, this.u).Show();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            this.lblAvailableAmount.Text = "Available amount: ";
            this.pnlUpdateAmount.Enabled=false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.f.Show();
            this.Hide();
        }

        private void FormDashboardSalesPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnShowBills_Click(object sender, EventArgs e)
        {
            new FormBills(this.u, this.user).Show();
        }

        internal void updatePriceLabels(DataTable dt)
        {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int amount = Int32.Parse(this.dt.Rows[i][5].ToString());
                    this.totalItems = this.totalItems + amount;

                    double price = Double.Parse(this.dt.Rows[i][4].ToString());
                    this.totalPrice = this.totalPrice + (double)(amount * price);
                }
                this.lblTotalItems.Text = $"Total Items: {this.totalItems}";
                this.lblTotalPrice.Text = $"Total Price (BDT): {this.totalPrice}";

                double finalPrice = this.totalPrice - this.totalPrice * (this.discount / 100);
                this.lblFinalPrice.Text = $"Final Price (BDT): {finalPrice}";

                //this.txtDiscount.Clear();

                this.totalItems = 0;
                this.totalPrice = 0;
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void updateDataTableAmount(DataTable source, ref DataTable destination)
        {
            try
            {
                for (int i = 0; i < source.Rows.Count; i++)
                {
                    for (int j = 0; j < destination.Rows.Count; j++)
                    {
                        if (source.Rows[i][0].ToString() == destination.Rows[j][0].ToString())
                        {
                            destination.Rows[j][5] = source.Rows[i][5].ToString();
                            break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeTimer()
        {
            myTimer.Interval = 1000;
            myTimer.Tick += new EventHandler(Timer1_Tick);
            myTimer.Enabled = true;

        }

        private void Timer1_Tick(object Sender, EventArgs e)
        {
            this.currentTime = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
            this.lblCurrentTime.Text = this.currentTime;
            this.currentTime = DateTime.Now.ToString("MM-dd-yyyy");
        }
    }
}

