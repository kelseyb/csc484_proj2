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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        /* V original. 
         * 
		if (pRODUCTDataGridView.CurrentRow.Index < 0)
    		MessageBox.Show("Please select a product");
 		else if (txtQuantity.Text == "")
      	    MessageBox.Show("Please enter a quantity value");
 		else
  		{
     		object prodID = salesDataSet.Tables["PRODUCT"].Rows[pRODUCTDataGridView.CurrentRow.Index]["ProductID"];
 			int prodIndex = pRODUCTDataGridView.CurrentRow.Index;
    		object qtyInStock = salesDataSet.Tables["PRODUCT"].Rows[pRODUCTDataGridView.CurrentRow.Index]["QuantityInStock"];

     		if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(qtyInStock.ToString()))
      		MessageBox.Show("Insufficient number of items for the product on stock");
     	else
         { 
       		object[] array = new object[4];
        		Form4 frmOD = new Form4();
        		array[0] = txtOrder.Text;
     			array[1] = prodID.ToString();
    			array[2] = txtQuantity.Text;
     			array[3] = 0;
    			salesDataSet.Tables["ORDERDETAIL"].Rows.Add(array);
                    frmOD.oRDERDETAILTableAdapter.Update(this.salesDataSet.ORDERDETAIL);
salesDataSet.Tables["PRODUCT"].Rows[pRODUCTDataGridView.CurrentRow.Index]["QuantityInStock"] = 
Convert.ToInt32(qtyInStock.ToString()) - Convert.ToInt32(txtQuantity.Text);
          	this.pRODUCTTableAdapter.Update(this.salesDataSet.PRODUCT);
     			btnExit.PerformClick();
         * */


            //hmmmm. this doesn't really correlate. at all?
            //hmmmmmm.
            //unless we have a list of /possible/ treatments. (as opposed to treatments that have happened.) then it works.


		    //if (pRODUCTDataGridView.CurrentRow.Index < 0)
    		    //MessageBox.Show("Please select a product");
 		    //else if (txtQuantity.Text == "")
      	        //MessageBox.Show("Please enter a quantity value");
 		    //else
  		    //{
     		    //object patientID = hospitalDataSet.Tables["PATIENT"].Rows[pRODUCTDataGridView.CurrentRow.Index]["PatientID"];
 			    //int patientIndex = pRODUCTDataGridView.CurrentRow.Index;
    		    //prob dont need?//object qtyInStock = salesDataSet.Tables["PRODUCT"].Rows[pRODUCTDataGridView.CurrentRow.Index]["QuantityInStock"];

     		    //if (Convert.ToInt32(txtQuantity.Text) > Convert.ToInt32(qtyInStock.ToString()))
      		    //MessageBox.Show("Insufficient number of items for the product on stock");

       		    object[] array = new object[4];
                Form4 frmOD = new Form4();
        	    array[0] = txtPatient.Text;
     		    //array[1] = patientID.ToString();
    		    array[2] = txtPhysician.Text;
     		    //array[3] = physicianID.ToString();

    		    //hospitalDataSet.Tables["TREATMENT"].Rows.Add(array);
                //frmOD.oRDERDETAILTableAdapter.Update(this.salesDataSet.ORDERDETAIL);
                //not necessary? //hospitalDataSet.Tables["PRODUCT"].Rows[pRODUCTDataGridView.CurrentRow.Index]["QuantityInStock"] = 
                //unnecessary? //Convert.ToInt32(qtyInStock.ToString()) - Convert.ToInt32(txtQuantity.Text);

          	    //this.pRODUCTTableAdapter.Update(this.hospitalDataSet.PRODUCT);


     	        btnExit.PerformClick();
     		
		    //}//end else
 	    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
