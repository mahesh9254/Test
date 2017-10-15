namespace Test.UserControls
{
    partial class TestUserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnxml = new System.Windows.Forms.Button();
            this.txtexcel = new System.Windows.Forms.TextBox();
            this.txtxml = new System.Windows.Forms.TextBox();
            this.btnexcelselect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnxmlselect = new System.Windows.Forms.Button();
            this.xmldataGridView = new System.Windows.Forms.DataGridView();
            this.btnsavexml = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmldataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnexcel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ImportData";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnexcelselect);
            this.groupBox2.Controls.Add(this.txtexcel);
            this.groupBox2.Controls.Add(this.btnxml);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(485, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ExportData";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.xmldataGridView);
            this.groupBox3.Controls.Add(this.btnxmlselect);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtxml);
            this.groupBox3.Location = new System.Drawing.Point(20, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1102, 429);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BindData";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Excel File";
            // 
            // btnexcel
            // 
            this.btnexcel.Location = new System.Drawing.Point(216, 50);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(194, 33);
            this.btnexcel.TabIndex = 1;
            this.btnexcel.Text = "Generate Excel File";
            this.btnexcel.UseVisualStyleBackColor = true;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Excel File";
            // 
            // btnxml
            // 
            this.btnxml.Location = new System.Drawing.Point(481, 45);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(136, 32);
            this.btnxml.TabIndex = 1;
            this.btnxml.Text = "Generate XML";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // txtexcel
            // 
            this.txtexcel.Location = new System.Drawing.Point(150, 50);
            this.txtexcel.Name = "txtexcel";
            this.txtexcel.Size = new System.Drawing.Size(274, 26);
            this.txtexcel.TabIndex = 2;
            // 
            // txtxml
            // 
            this.txtxml.Location = new System.Drawing.Point(11, 50);
            this.txtxml.Name = "txtxml";
            this.txtxml.Size = new System.Drawing.Size(334, 26);
            this.txtxml.TabIndex = 0;
            // 
            // btnexcelselect
            // 
            this.btnexcelselect.Location = new System.Drawing.Point(430, 50);
            this.btnexcelselect.Name = "btnexcelselect";
            this.btnexcelselect.Size = new System.Drawing.Size(45, 27);
            this.btnexcelselect.TabIndex = 3;
            this.btnexcelselect.Text = "...";
            this.btnexcelselect.UseVisualStyleBackColor = true;
            this.btnexcelselect.Click += new System.EventHandler(this.btnexcelselect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select XML File";
            // 
            // btnxmlselect
            // 
            this.btnxmlselect.Location = new System.Drawing.Point(364, 50);
            this.btnxmlselect.Name = "btnxmlselect";
            this.btnxmlselect.Size = new System.Drawing.Size(59, 30);
            this.btnxmlselect.TabIndex = 2;
            this.btnxmlselect.Text = "...";
            this.btnxmlselect.UseVisualStyleBackColor = true;
            this.btnxmlselect.Click += new System.EventHandler(this.btnxmlselect_Click);
            // 
            // xmldataGridView
            // 
            this.xmldataGridView.AllowUserToOrderColumns = true;
            this.xmldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xmldataGridView.Location = new System.Drawing.Point(11, 86);
            this.xmldataGridView.Name = "xmldataGridView";
            this.xmldataGridView.ReadOnly = true;
            this.xmldataGridView.RowTemplate.Height = 28;
            this.xmldataGridView.Size = new System.Drawing.Size(1071, 337);
            this.xmldataGridView.TabIndex = 3;
            this.xmldataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.xmldataGridView_CellClick);
            // 
            // btnsavexml
            // 
            this.btnsavexml.Location = new System.Drawing.Point(966, 639);
            this.btnsavexml.Name = "btnsavexml";
            this.btnsavexml.Size = new System.Drawing.Size(136, 44);
            this.btnsavexml.TabIndex = 3;
            this.btnsavexml.Text = "SaveXML";
            this.btnsavexml.UseVisualStyleBackColor = true;
            this.btnsavexml.Click += new System.EventHandler(this.btnsavexml_Click);
            // 
            // TestUserControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsavexml);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TestUserControls";
            this.Size = new System.Drawing.Size(1198, 683);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xmldataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnexcelselect;
        private System.Windows.Forms.Button btnxml;
        private System.Windows.Forms.Button btnxmlselect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsavexml;
        public System.Windows.Forms.DataGridView xmldataGridView;
        public System.Windows.Forms.TextBox txtexcel;
        public System.Windows.Forms.TextBox txtxml;
    }
}
