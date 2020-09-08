using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostcodeLookup;

namespace PostcodeLookup
{
    public partial class LookupDialog : Form
    {
        public LookupDialog()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Will use if any code needs to run on opening the program
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            linkMap.Visible = false;
        }

        private void txtPostcode_TextChanged(object sender, EventArgs e)
        {
            //safely handle any errors
            try
            {
                lblRawSearch.Text = "You searched for: " + txtPostcode.Text;
                if(!string.IsNullOrEmpty(txtPostcode.Text))
                {
                    linkMap.Visible = true;
                    //build a new customer object to operate on with our postcode checking method
                    Customer newCustomer = new Customer(txtPostcode.Text);
                    //clear the listbox to allow us to populate it with the next search
                    lbValidOptions.Items.Clear();
                    //call the method and iterate over the results, adding each to the listbox
                    foreach (string validOption in newCustomer.getValidDeliveryOptions(newCustomer.PostCode))
                    {
                        lbValidOptions.Items.Add(validOption);
                    }
                    //if nothing was found for that postcode, it hits the "All others", so delivery by courier
                    if (lbValidOptions.Items.Count == 0)
                    {
                        lbValidOptions.Items.Add("Delivery by Courier");
                    }
                }
                else
                {
                    lbValidOptions.Items.Clear();
                    linkMap.Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                //handled error displayed to user safely to avoid confusing them
                lbValidOptions.Items.Add("Something went wrong! Please contact an administrator!");
            }
        }

        private void lblRelevant_Click(object sender, EventArgs e)
        {

        }

        private void linkMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtPostcode.Text))
            {
                System.Diagnostics.Process.Start("https://www.google.co.uk/maps?q=" + txtPostcode.Text.Replace(" ", ""));
            }
        }
    }
}
