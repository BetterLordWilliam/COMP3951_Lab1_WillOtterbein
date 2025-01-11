namespace COMP3951_Lab1_WillOtterbein
{
    partial class WillFormApp
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
            this.ShowHideAccounts = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.accountPreviewBox = new System.Windows.Forms.GroupBox();
            this.dbText = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.fNameFormFieldToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mNameToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.personalInformation.SuspendLayout();
            this.FormControlPanel.SuspendLayout();
            this.accountPreviewBox.SuspendLayout();
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
            this.personalInformation.Location = new System.Drawing.Point(7, 6);
            this.personalInformation.Margin = new System.Windows.Forms.Padding(2);
            this.personalInformation.Name = "personalInformation";
            this.personalInformation.Padding = new System.Windows.Forms.Padding(2);
            this.personalInformation.Size = new System.Drawing.Size(423, 95);
            this.personalInformation.TabIndex = 0;
            this.personalInformation.TabStop = false;
            this.personalInformation.Text = "Personal Information";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(17, 68);
            this.LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "Last Name";
            // 
            // lastNameField
            // 
            this.lastNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameField.Location = new System.Drawing.Point(97, 68);
            this.lastNameField.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(294, 20);
            this.lastNameField.TabIndex = 4;
            this.lNameToolTip.SetToolTip(this.lastNameField, "Last name is a required field");
            // 
            // middleNameField
            // 
            this.middleNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleNameField.Location = new System.Drawing.Point(97, 43);
            this.middleNameField.Margin = new System.Windows.Forms.Padding(2);
            this.middleNameField.Name = "middleNameField";
            this.middleNameField.Size = new System.Drawing.Size(294, 20);
            this.middleNameField.TabIndex = 3;
            this.mNameToolTip.SetToolTip(this.middleNameField, "Middle name is not a required field");
            this.middleNameField.TextChanged += new System.EventHandler(this.middleNameField_TextChanged);
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSize = true;
            this.MiddleName.Location = new System.Drawing.Point(17, 43);
            this.MiddleName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(69, 13);
            this.MiddleName.TabIndex = 2;
            this.MiddleName.Text = "Middle Name";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(17, 17);
            this.FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameField.Location = new System.Drawing.Point(97, 17);
            this.firstNameField.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(294, 20);
            this.firstNameField.TabIndex = 0;
            this.fNameFormFieldToolTip.SetToolTip(this.firstNameField, "First name is a required field");
            // 
            // FormControlPanel
            // 
            this.FormControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormControlPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormControlPanel.Controls.Add(this.ShowHideAccounts);
            this.FormControlPanel.Controls.Add(this.clear);
            this.FormControlPanel.Controls.Add(this.submit);
            this.FormControlPanel.Location = new System.Drawing.Point(7, 241);
            this.FormControlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.FormControlPanel.Name = "FormControlPanel";
            this.FormControlPanel.Size = new System.Drawing.Size(423, 37);
            this.FormControlPanel.TabIndex = 2;
            // 
            // ShowHideAccounts
            // 
            this.ShowHideAccounts.Location = new System.Drawing.Point(11, 8);
            this.ShowHideAccounts.Name = "ShowHideAccounts";
            this.ShowHideAccounts.Size = new System.Drawing.Size(129, 23);
            this.ShowHideAccounts.TabIndex = 2;
            this.ShowHideAccounts.Text = "Show/Hide Accounts";
            this.ShowHideAccounts.UseVisualStyleBackColor = true;
            this.ShowHideAccounts.Click += new System.EventHandler(this.ShowHideAccounts_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Location = new System.Drawing.Point(356, 10);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(61, 19);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.Location = new System.Drawing.Point(293, 10);
            this.submit.Margin = new System.Windows.Forms.Padding(2);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(59, 19);
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
            this.accountPreviewBox.Controls.Add(this.dbText);
            this.accountPreviewBox.Location = new System.Drawing.Point(7, 105);
            this.accountPreviewBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountPreviewBox.Name = "accountPreviewBox";
            this.accountPreviewBox.Padding = new System.Windows.Forms.Padding(2);
            this.accountPreviewBox.Size = new System.Drawing.Size(423, 133);
            this.accountPreviewBox.TabIndex = 3;
            this.accountPreviewBox.TabStop = false;
            this.accountPreviewBox.Text = "Preview Accounts";
            // 
            // dbText
            // 
            this.dbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dbText.Location = new System.Drawing.Point(6, 19);
            this.dbText.Name = "dbText";
            this.dbText.ReadOnly = true;
            this.dbText.Size = new System.Drawing.Size(411, 109);
            this.dbText.TabIndex = 0;
            this.dbText.Text = "ID\tFN\tLN\tMN\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // fNameFormFieldToolTip
            // 
            this.fNameFormFieldToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.fNameFormFieldToolTip.ToolTipTitle = "Form Field";
            this.fNameFormFieldToolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.firstNameRequired_Popup);
            // 
            // lNameToolTip
            // 
            this.lNameToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.lNameToolTip.ToolTipTitle = "Form Field";
            // 
            // mNameToolTip
            // 
            this.mNameToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mNameToolTip.ToolTipTitle = "Form Field";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(436, 284);
            this.Controls.Add(this.accountPreviewBox);
            this.Controls.Add(this.FormControlPanel);
            this.Controls.Add(this.personalInformation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MyAccount";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.personalInformation.ResumeLayout(false);
            this.personalInformation.PerformLayout();
            this.FormControlPanel.ResumeLayout(false);
            this.accountPreviewBox.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox dbText;
        private System.Windows.Forms.Button ShowHideAccounts;
        private System.Windows.Forms.ToolTip fNameFormFieldToolTip;
        private System.Windows.Forms.ToolTip lNameToolTip;
        private System.Windows.Forms.ToolTip mNameToolTip;
    }
}

