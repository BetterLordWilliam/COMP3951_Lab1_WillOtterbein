namespace COMP3951_Lab1_WillOtterbein
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
            this.components = new System.ComponentModel.Container();
            this.personalInformation = new System.Windows.Forms.GroupBox();
            this.LastName = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.middleNameField = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.FormControlPanel = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.accountPreviewBox = new System.Windows.Forms.GroupBox();
            this.dbPreviewPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.personalInformation.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.accountPreviewBox.SuspendLayout();
            this.dbPreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // personalInformation
            // 
            this.personalInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.personalInformation.Controls.Add(this.LastName);
            this.personalInformation.Controls.Add(this.lastNameField);
            this.personalInformation.Controls.Add(this.middleNameField);
            this.personalInformation.Controls.Add(this.MiddleName);
            this.personalInformation.Controls.Add(this.FirstName);
            this.personalInformation.Controls.Add(this.firstNameField);
            this.personalInformation.Location = new System.Drawing.Point(12, 12);
            this.personalInformation.Name = "personalInformation";
            this.personalInformation.Size = new System.Drawing.Size(776, 175);
            this.personalInformation.TabIndex = 0;
            this.personalInformation.TabStop = false;
            this.personalInformation.Text = "Personal Information";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(31, 126);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(106, 25);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last Name";
            // 
            // lastNameField
            // 
            this.lastNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameField.Location = new System.Drawing.Point(177, 126);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(536, 29);
            this.lastNameField.TabIndex = 4;
            // 
            // middleNameField
            // 
            this.middleNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameField.Location = new System.Drawing.Point(177, 79);
            this.middleNameField.Name = "middleNameField";
            this.middleNameField.Size = new System.Drawing.Size(536, 29);
            this.middleNameField.TabIndex = 3;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(31, 79);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(127, 25);
            this.MiddleName.TabIndex = 2;
            this.MiddleName.Text = "Middle Name";
            this.MiddleName.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(31, 32);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(106, 25);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameField.Location = new System.Drawing.Point(177, 32);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(536, 29);
            this.firstNameField.TabIndex = 0;
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormControlPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormControlPanel.Controls.Add(this.clear);
            this.FormControlPanel.Controls.Add(this.submit);
            this.FormControlPanel.Location = new System.Drawing.Point(12, 445);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(776, 68);
            this.FormControlPanel.TabIndex = 2;
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.clear.Location = new System.Drawing.Point(381, 18);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 35);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.submit.Location = new System.Drawing.Point(266, 18);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(109, 35);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // accountPreviewBox
            // 
            this.accountPreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountPreviewBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accountPreviewBox.Controls.Add(this.dbPreviewPanel);
            this.accountPreviewBox.Location = new System.Drawing.Point(12, 194);
            this.accountPreviewBox.Name = "accountPreviewBox";
            this.accountPreviewBox.Size = new System.Drawing.Size(776, 245);
            this.accountPreviewBox.TabIndex = 3;
            this.accountPreviewBox.TabStop = false;
            this.accountPreviewBox.Text = "Preview Accounts";
            // 
            // dbPreviewPanel
            // 
            this.dbPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbPreviewPanel.BackColor = System.Drawing.SystemColors.Info;
            this.dbPreviewPanel.Controls.Add(this.vScrollBar1);
            this.dbPreviewPanel.Controls.Add(this.hScrollBar1);
            this.dbPreviewPanel.Location = new System.Drawing.Point(6, 28);
            this.dbPreviewPanel.Name = "dbPreviewPanel";
            this.dbPreviewPanel.Size = new System.Drawing.Size(764, 211);
            this.dbPreviewPanel.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(740, 13);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(10, 167);
            this.vScrollBar1.TabIndex = 4;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(10, 190);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(741, 10);
            this.hScrollBar1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.accountPreviewBox);
            this.Controls.Add(this.FormControlPanel);
            this.Controls.Add(this.personalInformation);
            this.Name = "Form1";
            this.Text = "MyAccount";
            this.personalInformation.ResumeLayout(false);
            this.personalInformation.PerformLayout();
            this.FormControlPanel.ResumeLayout(false);
            this.accountPreviewBox.ResumeLayout(false);
            this.dbPreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox personalInformation;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.Label MiddleName;
        private System.Windows.Forms.TextBox middleNameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Panel FormControlPanel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.GroupBox accountPreviewBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel dbPreviewPanel;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
    }
}

