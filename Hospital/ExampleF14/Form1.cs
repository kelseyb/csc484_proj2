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

        //shouldn't you be btnPatients??
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
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
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPhysicians_Click(object sender, EventArgs e)
        {
            try
            {
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
                Form4 frmC = new Form4();

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
