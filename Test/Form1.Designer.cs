namespace Test
{
    partial class Form1
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
            this.testUserControls1 = new Test.UserControls.TestUserControls();
            this.SuspendLayout();
            // 
            // testUserControls1
            // 
            this.testUserControls1.Location = new System.Drawing.Point(12, 12);
            this.testUserControls1.Name = "testUserControls1";
            this.testUserControls1.Size = new System.Drawing.Size(1198, 683);
            this.testUserControls1.TabIndex = 0;
            this.testUserControls1.GenerateExcel += new System.EventHandler(this.testUserControls1_GenerateExcel);
            this.testUserControls1.GenerateXML += new System.EventHandler(this.testUserControls1_GenerateXML);
            this.testUserControls1.SaveXML += new System.EventHandler(this.testUserControls1_SaveXML);
            this.testUserControls1.SelectXML += new System.EventHandler(this.testUserControls1_SelectXML);
            this.testUserControls1.SelectExcel += new System.EventHandler(this.testUserControls1_SelectExcel);
            this.testUserControls1.GridClick += new System.EventHandler(this.testUserControls1_GridClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 690);
            this.Controls.Add(this.testUserControls1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.TestUserControls testUserControls1;
    }
}

