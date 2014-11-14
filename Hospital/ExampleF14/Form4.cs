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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            button1.PerformClick(); 
        }

        private void tREATMENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tREATMENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s7032956DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7032956DataSet.TREATMENT' table. You can move, or remove it, as needed.
            this.tREATMENTTableAdapter.Fill(this.s7032956DataSet.TREATMENT);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool byPatient = true;
            bool byPhysician = true; 

            if (String.IsNullOrEmpty(txtPatient.Text))
            {
                byPatient = false; 
            }
            if (String.IsNullOrEmpty(txtPhysician.Text))
            {
                byPhysician = false; 
            }

            this.tREATMENTTableAdapter.Update(this.s7032956DataSet.TREATMENT);

            for (int i = 0; i < tREATMENTDataGridView.Rows.Count - 1; i++ )
            {
                tREATMENTDataGridView.Rows[i].Visible = true; 
            }
            if (!byPatient && !byPhysician)
            {
                return; 
            }
            if (byPatient)
            {
                for (int i = 0; i < tREATMENTDataGridView.Rows.Count - 1; i++)
                {
                    if ((Int64)s7032956DataSet.Tables["TREATMENT"].Rows[i]["PatientID"] != Int64.Parse(txtPatient.Text))
                    {
                        tREATMENTDataGridView.CurrentCell = null; 
                        tREATMENTDataGridView.Rows[i].Visible = false;
                        //CurrencyManager currencyManager1 = (CurrencyManager)tREATMENTBindingSource.CurrencyManager;
                        //currencyManager1.SuspendBinding();
                    }
                }
            }
            if (byPhysician)
            {
                for (int i = 0; i < tREATMENTDataGridView.Rows.Count - 1; i++)
                {
                    if ((Int64)s7032956DataSet.Tables["TREATMENT"].Rows[i]["PhysicianID"] != Int64.Parse(txtPhysician.Text))
                    {
                        tREATMENTDataGridView.CurrentCell = null;
                        tREATMENTDataGridView.Rows[i].Visible = false;
                        //CurrencyManager currencyManager1 = (CurrencyManager)tREATMENTBindingSource.CurrencyManager;
                        //currencyManager1.SuspendBinding();
                    }
                }
            }
        }


    }
}
