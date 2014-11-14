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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pHYSICIANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHYSICIANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.s7032956DataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's7032956DataSet.PHYSICIAN' table. You can move, or remove it, as needed.
            this.pHYSICIANTableAdapter.Fill(this.s7032956DataSet.PHYSICIAN);

        }
    }
}
