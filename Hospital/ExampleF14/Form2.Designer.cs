﻿namespace ExampleF14
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.s7032956DataSet = new ExampleF14.s7032956DataSet();
            this.pATIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTTableAdapter = new ExampleF14.s7032956DataSetTableAdapters.PATIENTTableAdapter();
            this.tableAdapterManager = new ExampleF14.s7032956DataSetTableAdapters.TableAdapterManager();
            this.pATIENTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pATIENTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhysician = new System.Windows.Forms.ComboBox();
            this.pHYSICIANIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHYSICIANIDTableAdapter = new ExampleF14.s7032956DataSetTableAdapters.PHYSICIANIDTableAdapter();
            this.pATIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pATIENTDataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.s7032956DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingNavigator)).BeginInit();
            this.pATIENTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHYSICIANIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // s7032956DataSet
            // 
            this.s7032956DataSet.DataSetName = "s7032956DataSet";
            this.s7032956DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pATIENTBindingSource
            // 
            this.pATIENTBindingSource.DataMember = "PATIENT";
            this.pATIENTBindingSource.DataSource = this.s7032956DataSet;
            // 
            // pATIENTTableAdapter
            // 
            this.pATIENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PATIENTTableAdapter = this.pATIENTTableAdapter;
            this.tableAdapterManager.PHYSICIANIDTableAdapter = null;
            this.tableAdapterManager.PHYSICIANTableAdapter = null;
            this.tableAdapterManager.TREATMENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ExampleF14.s7032956DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pATIENTBindingNavigator
            // 
            this.pATIENTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pATIENTBindingNavigator.BindingSource = this.pATIENTBindingSource;
            this.pATIENTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pATIENTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pATIENTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pATIENTBindingNavigatorSaveItem});
            this.pATIENTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pATIENTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pATIENTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pATIENTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pATIENTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pATIENTBindingNavigator.Name = "pATIENTBindingNavigator";
            this.pATIENTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pATIENTBindingNavigator.Size = new System.Drawing.Size(681, 25);
            this.pATIENTBindingNavigator.TabIndex = 0;
            this.pATIENTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pATIENTBindingNavigatorSaveItem
            // 
            this.pATIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pATIENTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pATIENTBindingNavigatorSaveItem.Image")));
            this.pATIENTBindingNavigatorSaveItem.Name = "pATIENTBindingNavigatorSaveItem";
            this.pATIENTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pATIENTBindingNavigatorSaveItem.Text = "Save Data";
            this.pATIENTBindingNavigatorSaveItem.Click += new System.EventHandler(this.pATIENTBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Physician ID:";
            // 
            // cboPhysician
            // 
            this.cboPhysician.DataSource = this.pHYSICIANIDBindingSource;
            this.cboPhysician.DisplayMember = "PhysicianID";
            this.cboPhysician.FormattingEnabled = true;
            this.cboPhysician.Location = new System.Drawing.Point(242, 53);
            this.cboPhysician.Name = "cboPhysician";
            this.cboPhysician.Size = new System.Drawing.Size(224, 21);
            this.cboPhysician.TabIndex = 4;
            this.cboPhysician.ValueMember = "PhysicianID";
            // 
            // pHYSICIANIDBindingSource
            // 
            this.pHYSICIANIDBindingSource.DataMember = "PHYSICIANID";
            this.pHYSICIANIDBindingSource.DataSource = this.s7032956DataSet;
            // 
            // pHYSICIANIDTableAdapter
            // 
            this.pHYSICIANIDTableAdapter.ClearBeforeFill = true;
            // 
            // pATIENTBindingSource1
            // 
            this.pATIENTBindingSource1.DataMember = "FK__PATIENT__Physici__382F56611";
            this.pATIENTBindingSource1.DataSource = this.pHYSICIANIDBindingSource;
            // 
            // pATIENTDataGridView
            // 
            this.pATIENTDataGridView.AutoGenerateColumns = false;
            this.pATIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pATIENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pATIENTDataGridView.DataSource = this.pATIENTBindingSource1;
            this.pATIENTDataGridView.Location = new System.Drawing.Point(12, 80);
            this.pATIENTDataGridView.Name = "pATIENTDataGridView";
            this.pATIENTDataGridView.Size = new System.Drawing.Size(657, 220);
            this.pATIENTDataGridView.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmergencyContact";
            this.dataGridViewTextBoxColumn4.HeaderText = "Emergency Contact";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AdmittedDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "Admitted Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PhysicianID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Physician ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 341);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pATIENTDataGridView);
            this.Controls.Add(this.cboPhysician);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pATIENTBindingNavigator);
            this.Name = "Form2";
            this.Text = "Patients";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s7032956DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingNavigator)).EndInit();
            this.pATIENTBindingNavigator.ResumeLayout(false);
            this.pATIENTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHYSICIANIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pATIENTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private s7032956DataSet s7032956DataSet;
        private System.Windows.Forms.BindingSource pATIENTBindingSource;
        private s7032956DataSetTableAdapters.PATIENTTableAdapter pATIENTTableAdapter;
        private s7032956DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pATIENTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pATIENTBindingNavigatorSaveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhysician;
        private System.Windows.Forms.BindingSource pHYSICIANIDBindingSource;
        private s7032956DataSetTableAdapters.PHYSICIANIDTableAdapter pHYSICIANIDTableAdapter;
        private System.Windows.Forms.BindingSource pATIENTBindingSource1;
        private System.Windows.Forms.DataGridView pATIENTDataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}