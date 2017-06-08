namespace Assignment7.V2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPatientsName = new System.Windows.Forms.TextBox();
            this.cmboPriority = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbPatients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patients Name";
            // 
            // txtPatientsName
            // 
            this.txtPatientsName.Location = new System.Drawing.Point(181, 42);
            this.txtPatientsName.Name = "txtPatientsName";
            this.txtPatientsName.Size = new System.Drawing.Size(495, 26);
            this.txtPatientsName.TabIndex = 1;
            this.txtPatientsName.TextChanged += new System.EventHandler(this.txtPatientsName_TextChanged);
            // 
            // cmboPriority
            // 
            this.cmboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboPriority.FormattingEnabled = true;
            this.cmboPriority.Items.AddRange(new object[] {
            "Please Select...",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmboPriority.Location = new System.Drawing.Point(181, 74);
            this.cmboPriority.Name = "cmboPriority";
            this.cmboPriority.Size = new System.Drawing.Size(495, 28);
            this.cmboPriority.TabIndex = 2;
            this.cmboPriority.SelectedIndexChanged += new System.EventHandler(this.cmboPriority_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priority";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(0, 0);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(313, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Patient to queue";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(363, 117);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(313, 36);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Call next Patient";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbPatients
            // 
            this.lbPatients.FormattingEnabled = true;
            this.lbPatients.ItemHeight = 20;
            this.lbPatients.Location = new System.Drawing.Point(27, 159);
            this.lbPatients.Name = "lbPatients";
            this.lbPatients.Size = new System.Drawing.Size(649, 224);
            this.lbPatients.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 394);
            this.Controls.Add(this.lbPatients);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmboPriority);
            this.Controls.Add(this.txtPatientsName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AE Department";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPatientsName;
        private System.Windows.Forms.ComboBox cmboPriority;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListBox lbPatients;
    }
}

