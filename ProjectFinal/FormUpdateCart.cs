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
    public partial class FormUpdateCart : Form
    {
        FormDashboardSalesPerson fd;

        public FormUpdateCart()
        {
            InitializeComponent();
        }

        public FormUpdateCart(FormDashboardSalesPerson fd): this()
        {
            try
            {
                this.fd = fd;
                this.lblAvailableAmount.Text = @"Available amount for " + this.fd.Dt.Rows[fd.SelectedIndex][2].ToString().Trim().ToUpper() + " " + this.fd.Dt.Rows[fd.SelectedIndex][3].ToString().Trim() + " " + this.fd.Dt.Rows[fd.SelectedIndex][1].ToString().Trim() + ": " + this.fd.DtItem.Rows[fd.getIndex(this.fd.DtItem, this.fd.Dt.Rows[fd.SelectedIndex][0].ToString())][5].ToString().Trim();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured: "+exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(this.txtEnterAmount.Text, out int amount))
                {
                    if (amount >= 0)
                    {
                        int availableAmount = Int32.Parse(this.fd.DtItem.Rows[fd.getIndex(this.fd.DtItem, this.fd.Dt.Rows[fd.SelectedIndex][0].ToString())][5].ToString());

                        if (amount > availableAmount)
                        {
                            MessageBox.Show($"Sorry. Availabe amount is: {availableAmount} ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int currentAmount = Int32.Parse(this.fd.Dt.Rows[fd.SelectedIndex][5].ToString());
                            currentAmount = amount + currentAmount;
                            this.fd.Dt.Rows[fd.SelectedIndex][5] = currentAmount.ToString();
                            availableAmount = availableAmount - amount;
                            this.fd.DtItem.Rows[fd.getIndex(this.fd.DtItem, this.fd.Dt.Rows[fd.SelectedIndex][0].ToString())][5] = availableAmount.ToString();
                            this.lblAvailableAmount.Text = @"Available amount for " + this.fd.Dt.Rows[fd.SelectedIndex][2].ToString().Trim().ToUpper() + " " + this.fd.Dt.Rows[fd.SelectedIndex][3].ToString().Trim() + " " + this.fd.Dt.Rows[fd.SelectedIndex][1].ToString().Trim() + ": " + this.fd.DtItem.Rows[fd.getIndex(this.fd.DtItem, this.fd.Dt.Rows[fd.SelectedIndex][0].ToString())][5].ToString().Trim();
                            this.fd.updatePriceLabels(this.fd.Dt);
                            this.txtEnterAmount.Text = String.Empty;
                        }
                    }
                    else
                        MessageBox.Show($"Entered value can not be negative.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Enter an integer value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occured: " + exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
