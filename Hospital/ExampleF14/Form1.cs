using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleF14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //go to the patient form
                Form2 frmC = new Form2();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();
        }
        
        private void btnPhysicians_Click(object sender, EventArgs e)
        {
            try
            {
                //go to the physicians form 
                Form3 frmC = new Form3();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                //go to the treatments form. 
                Form4 frmC = new Form4();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                //go to the treatments form. 
                Form5 frmC = new Form5();

                frmC.ShowDialog(this);
                frmC.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Main Form - " + ex.Message);
            }
        }
    }
}
