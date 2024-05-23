using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal
{
    public partial class FormConfirm : Form
    {
        FormDashboardSalesPerson f; User u; DataTable dtItem; DataTable dt; string time;
        double discount;
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

        DataTable Dt
        {
            get { return this.dt; }
            set { this.dt = value; }
        }

        DataTable DtItem
        {
            get { return this.dtItem; }
            set { this.dtItem = value; }
        }

        String Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        UseDB udb;

        public FormConfirm()
        {
            InitializeComponent();
        }

        internal FormConfirm(FormDashboardSalesPerson f, User u, DataTable dtItem, DataTable dt, string time, double discount, UseDB udb) : this()
        {
            this.F = f;
            this.U = u;
            this.DtItem = dtItem;
            this.Dt = dt;
            this.Time = time;
            this.discount = discount;
            this.udb = udb;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtCustomerName.Text) || string.IsNullOrEmpty(this.txtCustomerContact.Text))
                {
                    MessageBox.Show("Please enter all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataTable temp = this.DtItem;
                    DataSet ds = udb.getInfo("select * from item;");
                    this.DtItem = ds.Tables[0];
                    

                    this.F.Hide();
                    new FormReceipt(this.F, this.txtCustomerName.Text, this.txtCustomerContact.Text, this.U, temp, this.DtItem, this.Dt, this.Time, this.discount, this.udb).Show();
                    this.Dt.Clear();
                    this.F.updatePriceLabels(Dt);
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
