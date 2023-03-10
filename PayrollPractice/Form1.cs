using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int dep;
            double hours;
            string[] name = new string[2];

            while(double.TryParse(txtBxWrk.Text, out hours)== false)
            {
                MessageBox.Show("Numeric value should be entered for hours");
                txtBxWrk.Text = "0";
                txtBxWrk.Focus();

            } 
            if(int.TryParse(txtBxDpd.Text, out dep) == false)
            {
                MessageBox.Show("Invalid input, default vaule 0 will be saved");
                txtBxDpd.Text = "0";
                txtBxDpd.Focus();
            }

            name = txtBxName.Text.Split(' ');
            if(name.Length < 2)
            {
                txtBxName.Text = "Please enter full name";
                txtBxName.Focus();
            }

            else
            {
                if(hours > 0)
                {
                    Employee emp = new Employee(name[0], name[1], dep, hours);
                    txtGross.Text = emp.DetermineGross().ToString("c");
                    txtFed.Text = emp.DetermineFederalTax().ToString("c");  
                    txtSoc.Text = emp.SocialSecurity().ToString("c");
                    txtAgency.Text = emp.DetermineAgencyFee().ToString("c");
                    txtNet.Text = emp.DetermineNet().ToString("c");

                    // code write to the text file
                    try
                    {
                        StreamWriter fil = new StreamWriter("EmployeeData.txt", true);
                        fil.WriteLine(emp);
                        MessageBox.Show("Writing to the file is done");
                        fil.Close();
                    } catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    lblNet.Visible = true;
                    lblFed.Visible = true;
                    lblGross.Visible = true;   
                    lblAgency.Visible= true;
                    lblSoc.Visible = true;
                    lblHours.Visible = false;
                    lblDep.Visible = false;

                    txtBxWrk.Visible = false;
                    txtBxDpd.Visible = false;
                    txtGross.Visible = true;
                    txtFed.Visible = true;
                    txtSoc.Visible = true;
                    txtAgency.Visible = true;
                    txtNet.Visible = true;
                    txtBxName.Enabled = false;

                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBxName.Clear();
            txtBxWrk.Text = "0";
            txtBxDpd.Text= "0";

            lblNet.Visible = false;
            lblFed.Visible = false;
            lblGross.Visible = false;
            lblAgency.Visible = false;
            lblSoc.Visible = false;
            lblHours.Visible = true;
            lblDep.Visible = true;

            txtBxDpd.Visible = true;
            txtBxWrk.Visible = true;
            txtGross.Visible = false;
            txtFed.Visible = false;
            txtSoc.Visible = false;
            txtAgency.Visible = false;
            txtNet.Visible = false;
            txtBxName.Enabled = true;
        }

        private void txtFed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
