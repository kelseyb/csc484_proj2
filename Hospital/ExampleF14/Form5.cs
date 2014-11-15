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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pATIENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pATIENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s7032956DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.tREATMENTTableAdapter.Fill(this.s7032956DataSet.TREATMENT);
            this.pHYSICIANTableAdapter.Fill(this.s7032956DataSet.PHYSICIAN);
            this.pATIENTTableAdapter.Fill(this.s7032956DataSet.PATIENT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //find the largest Treatment Id and get a bigger one 
            Int64 largest = (Int64)s7032956DataSet.Tables["TREATMENT"].Rows[0]["TreatmentID"]; 
            for (int i = 1; i < s7032956DataSet.Tables["TREATMENT"].Rows.Count; i++)
            {
                if (largest < (Int64)s7032956DataSet.Tables["TREATMENT"].Rows[i]["TreatmentID"])
                {
                    largest = (Int64)s7032956DataSet.Tables["TREATMENT"].Rows[i]["TreatmentID"];
                }
            }

            largest = largest + 1;

            //create the treatment row 
            object[] array = new object[6];
            array[0] = largest; //treatment id
            array[1] = s7032956DataSet.Tables["PATIENT"].Rows[pATIENTDataGridView.CurrentRow.Index]["PatientID"]; //patient
            array[2] = s7032956DataSet.Tables["PHYSICIAN"].Rows[pHYSICIANDataGridView.CurrentRow.Index]["PhysicianID"]; //physician
            array[3] = textBox1.Text; //treatment name 
            array[4] = dateTimePicker1.Value; //date 

            //treatment dosage : if empty or null return null otherwise give the value. 
            if (String.IsNullOrEmpty(textBox2.Text)) 
            {
                array[5] = null;
            }
            else
            {
                array[5] = Int64.Parse(textBox2.Text);
            }

            //add the treatment row to the treatment table 
            s7032956DataSet.Tables["TREATMENT"].Rows.Add(array);

            //update all stuff 
            this.Validate();
            this.pATIENTBindingSource.EndEdit();
            this.pHYSICIANBindingSource.EndEdit();
            this.tREATMENTBindingSource.EndEdit(); 
            this.tableAdapterManager.UpdateAll(this.s7032956DataSet);

            //close this form. 
            this.Close(); 
        }
    }
}
