
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectFinal
{
    public partial class FormReceipt : Form
    {
        FormDashboardSalesPerson f; string customerName; string customerContact; User u; DataTable dtUpdated; DataTable dtItem; DataTable dt; string time; double discount;
        FormDashboardSalesPerson F
        {
            get { return this.f; }
            set { this.f = value; }
        }

        User U
        {
            get { return this.u; }
            set { this.u = value; }
        }

        DataTable DtItem
        { get { return dtItem; }
          set { this.dtItem = value; } 
        }

        DataTable DtUpdated
        {
            get { return dtUpdated; }
            set { this.dtUpdated = value; }
        }


        DataTable Dt
        {
            get { return this.dt; }
            set { this.dt = value; }
        }

        String Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        String CustomerName
        {
            get { return this.customerName; }
            set { this.customerName = value; }
        }

        String CustomerContact
        {
            get { return this.customerContact; }
            set { this.customerContact = value; }
        }


        UseDB udb;

        public FormReceipt()
        {
            InitializeComponent();
        }

        internal FormReceipt(FormDashboardSalesPerson f, string customerName, string customerContact, User u, DataTable dtUpdated, DataTable dtItem, DataTable dt, string time, double discount, UseDB udb): this()
        {
            this.F = f;
            this.CustomerName = customerName;
            this.CustomerContact = customerContact;
            this.U = u;
            this.DtUpdated = dtUpdated;
            this.DtItem = dtItem;
            this.Dt = dt;
            this.Time = time;
            this.discount = discount;
            this.udb = udb;
        }

        internal void populateListView()
        {
            try
            {
                this.writeOnFile($"-----------------------------------------------------------------------");

                string newTID = this.udb.getNewId("[transection]", "tid");
                string newBillID = this.udb.getNewId("[bill]", "billid");

                this.writeOnFile($"Bill ID: {newBillID}" + Environment.NewLine);

                for (int i = 0; i < this.DtUpdated.Rows.Count; i++)
                {
                    if (this.udb.executeQuery($"update item set IStockStatus = {this.DtUpdated.Rows[i][5].ToString()} where iid = '{DtUpdated.Rows[i][0].ToString()}';") == 1)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                int sumItems = 0;
                double sumTotal = 0;

                this.lvCart.Items.Clear();

                for (int i = 0; i < this.Dt.Rows.Count; i++)
                {
                    if (Int32.Parse(this.Dt.Rows[i]["Amount"].ToString()) != 0)
                    {
                        var manufacturer = this.Dt.Rows[i]["Manufacturer"].ToString().Trim();
                        var model = this.Dt.Rows[i]["Model"].ToString().Trim();
                        var type = this.Dt.Rows[i]["Type"].ToString().Trim();
                        var amount = Int32.Parse(this.Dt.Rows[i]["Amount"].ToString().Trim());
                        var price = Double.Parse(this.Dt.Rows[i][4].ToString().Trim());

                        var totalPrice = amount * price;

                        sumItems += amount;
                        sumTotal += totalPrice;

                        ListViewItem item = new ListViewItem((i+1).ToString());

                        item.SubItems.Add(manufacturer);
                        item.SubItems.Add(model);
                        item.SubItems.Add(type);
                        item.SubItems.Add(amount.ToString());
                        item.SubItems.Add(totalPrice.ToString());

                        this.writeOnFile($"{i+1}. {manufacturer} - {model} - {type} - {amount} quantity - {totalPrice}");

                        lvCart.Items.Add(item);
                    }
                }

                double finalPrice = sumTotal - (sumTotal * (discount/100));

                int resultBill = udb.executeQuery($"insert into bill values('{newBillID}', '{this.Time}', '{sumTotal}');");

                string command = $"";
                int result = udb.executeQuery($"insert into [transection] values('{newTID}', '{this.CustomerName}', '{newBillID}', {sumItems}, {finalPrice}, '{this.U.Id}');");

                this.lblTotalItems.Text = $"Total items: {sumItems}";
                this.lblTotalPrice.Text = $"Total price with {this.discount}% discount (BDT): {finalPrice}";

                this.writeOnFile(Environment.NewLine);
                this.writeOnFile($"Total items: {sumItems} - Total cost (BDT): {sumTotal} - Final cost (BDT): {finalPrice} including discount: {this.discount}%");
                this.writeOnFile($"-----------------------------------------------------------------------");
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured in populateListView: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                this.populateListView();
                this.txtCustomerName.Text = this.CustomerName;
                this.txtCustomerContact.Text = this.CustomerContact;
                this.lblSalesPerson.Text += $"  {this.U.Name} (Id: {this.U.Id})";
                this.lblTime.Text += " "+this.Time;
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured in FormLoad: " + exc.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.F.Show();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured in BtnOK click: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormReceipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.F.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured in FormClosed: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void writeOnFile(string text)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.Parent.FullName;
            string fileName = @"\Bill extended information.txt";
            string fullPath = projectDirectory + fileName;

            File.AppendAllText(fullPath, text + Environment.NewLine);
        }
    }
}
