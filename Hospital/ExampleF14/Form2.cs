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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pATIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pATIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s7032956DataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7032956DataSet.PHYSICIANID' table. You can move, or remove it, as needed.
            this.pHYSICIANIDTableAdapter.Fill(this.s7032956DataSet.PHYSICIANID);
            // TODO: This line of code loads data into the 's7032956DataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.s7032956DataSet.PATIENT);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object patientNum = pATIENTDataGridView.CurrentRow.Cells[0].Value;
            Form4 frmTreatment = new Form4();

            try
            {
                frmTreatment.txtPatient.Text = patientNum.ToString();
                frmTreatment.button1.PerformClick(); 
                frmTreatment.ShowDialog(this);
                frmTreatment.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }

        }
    }
}
