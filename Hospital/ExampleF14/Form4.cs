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
    }
}
