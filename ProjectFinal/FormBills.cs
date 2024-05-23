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
    public partial class FormBills : Form
    {
        UseDB udb;
        User u;
        public FormBills(UseDB udb, User u)
        {
            InitializeComponent();
            this.udb = udb;
            this.u = u;
            this.dgvBills.AutoGenerateColumns = false;
        }

        private void FormBills_Load(object sender, EventArgs e)
        {
            try
            {
                this.dgvBills.DataSource = udb.getQueryTable($"select * from bill;");
            }
            catch (Exception exc)
            {
                MessageBox.Show($"An error occured. Error: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
