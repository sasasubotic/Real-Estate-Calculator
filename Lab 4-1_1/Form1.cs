using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_1_1
{
    public partial class Lab_4_1 : Form
    {
        //declare class-level constants for tax rates and commison rates
        private const decimal STATE_SALES_TAX_RATE = 0.06m;
        private const decimal HILLSBOROUGH_SALES_TAX_RATE = 0.01m;
        private const decimal PASCO_SALES_TAX_RATE = 0m;
        private const decimal POLK_SALES_TAX_RATE = 0.005m;
        private const decimal RESIDENTIAL_COMMISSION_RATE = 0.06m;
        private const decimal COMMERCIAL_COMMISSION_RATE = 0.05m;

        //declare class level variables
        private decimal propertyPrice = 0m;
        private decimal stateSalesTax = 0m;
        private decimal countySalesTax = 0m;
        private decimal commission = 0m;
        private decimal totalPrice = 0m;

        public Lab_4_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //displays current date
            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            //Disables save button until property price is updated with a value bigger than zero
            saveButton.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salesDateMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Handles the Property Price text change event
        private void propertyPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = false; //Disables the save button until the UpdateTotals are done
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateTotals(); //Call Custom Method to update calculated totals
            saveButton.Focus(); // Send focus to save button
        }

        private void UpdateTotals()
        {
            if (decimal.TryParse(propertyPriceTextBox.Text, out propertyPrice))
            {
                //set property price variable equal to text property of text box
                propertyPrice = decimal.Parse(propertyPriceTextBox.Text);

                //calculate state sales tax amount
                stateSalesTax = propertyPrice * STATE_SALES_TAX_RATE;

                //calculate coutnry sales tax amount based on county selected
                if (hillsboroughRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * HILLSBOROUGH_SALES_TAX_RATE;
                }
                else if (pascoRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * PASCO_SALES_TAX_RATE;
                }
                else if (polkRadioButton.Checked)
                {
                    countySalesTax = propertyPrice * POLK_SALES_TAX_RATE;
                }

                //calculate commission based on property type
                if (residentialRadioButton.Checked)
                {
                    commission = propertyPrice * RESIDENTIAL_COMMISSION_RATE;
                }
                else
                {
                    commission = propertyPrice * COMMERCIAL_COMMISSION_RATE;
                }

                //calcualte total price
                totalPrice = propertyPrice + stateSalesTax + countySalesTax + commission;

                //Format and display correct calculated numeric values w/currency format
                stateSalesTaxAmntLabel.Text = stateSalesTax.ToString("c");
                countySalesTaxAmntLabel.Text = countySalesTax.ToString("c");
                commissionAmntLabel.Text = commission.ToString("c");
                totalLabel.Text = totalPrice.ToString("c");

                if (propertyPrice > 0) //verifies that a price is greater than zero
                {
                    saveButton.Enabled = true; //enables the save button
                }
                else //if null or non-numeric value is in for property price
                {
                    MessageBox.Show("You must enter a numeric value for Property Price." +
                                    "\nEnter digits only (no dollar sign) for Property Price",
                                    "Blank value or non-numeric character entered",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    propertyPriceTextBox.Focus();
                }
            }
        }

        private void pascoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void residentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try //write data to external text file
            {
                System.IO.StreamWriter outputfile;
                outputfile = System.IO.File.AppendText("Properties.txt");
                outputfile.WriteLine("Date: " + saleDateMaskedTextBox.Text);
                outputfile.WriteLine("Property Price: " +propertyPrice.ToString("c"));
                outputfile.WriteLine("State Sales Tax: " +stateSalesTax.ToString("c"));
                outputfile.WriteLine("County Sales Tax: " +countySalesTax.ToString("c"));
                outputfile.WriteLine("Commission: " +commission.ToString("c"));
                outputfile.WriteLine("Total Price: " +totalPrice.ToString("c"));
                outputfile.WriteLine();
                outputfile.Close();

                MessageBox.Show("Data successfully saved to file.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information); //display confirmation message

                ClearForm(); //call custom method to clear form
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Handle Clear form event handler
        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


    //custom method to clear form
        private void ClearForm()
        {
            //Clear controls and reset form
            saleDateMaskedTextBox.Text = DateTime.Now.ToString("MM/dd/yyyy");
            residentialRadioButton.Checked = true;
            hillsboroughRadioButton.Checked = true;
            propertyPriceTextBox.Text = "$0.00";
            stateSalesTaxAmntLabel.Text = "$0.00";
            countySalesTaxAmntLabel.Text = "$0.00";
            commissionAmntLabel.Text = "$0.00";
            totalLabel.Text = "$0.00";
            saveButton.Enabled = false;
            propertyPriceTextBox.Focus();

        }

        private void hillsboroughRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void polkRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void countySalesTaxAmntLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
