using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 1
/// Author(s): Will Otterbein
/// Date: January 10 2024
/// Revision: 1
/// </summary>
namespace COMP3951_Lab1_WillOtterbein
{
    /// <summary>
    /// Partial class Form1 has six methods:
    /// - ClearFormFields
    /// - ClearErrors
    /// - AddDBObjToLabel
    /// - Submit_Click
    /// - Clear_Click
    /// </summary>
    public partial class WillFormApp : Form
    {
        public WillFormApp()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear data from form fields.
        /// </summary>
        private void ClearFormFields()
        {
            // Clear form data
            firstNameField.Text = "";
            middleNameField.Text = "";
            lastNameField.Text = "";
        }

        /// <summary>
        /// Clear errors from form fields.
        /// </summary>
        private void ClearErrors()
        {
            // Clear form errors, if previously there
            errorProvider1.Clear();
            errorProvider2.Clear();
        }

        /// <summary>
        /// Show records in the db.
        /// </summary>
        /// <param name="nRec"></param>
        private void AddDBObjToLabel(DBFake.DBRecord nRec)
        {
            dbText.Text += $"{nRec}\n";
        }

        private void ShowHideAccounts_Click(object sender, EventArgs e)
        {
            // Show/hide the accounts box
            if (accountPreviewBox.Visible) {
                accountPreviewBox.Visible = false;
            } else { 
                accountPreviewBox.Visible = true; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            accountPreviewBox.Visible = false;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Field values
            string firstNameValue = firstNameField.Text;
            string middleNameValue = middleNameField.Text;
            string lastNameValue = lastNameField.Text;

            // First name and last name are required to have values
            bool fnameEmptyNull = string.IsNullOrEmpty(firstNameValue);
            bool lnameEmptyNull = string.IsNullOrEmpty(lastNameValue);
            if (fnameEmptyNull || lnameEmptyNull)
            {
                MessageBox.Show("First name and last name cannot be empty");
                if (fnameEmptyNull)
                    errorProvider1.SetError(firstNameField, "First name cannot be empty");
                if (lnameEmptyNull)
                    errorProvider2.SetError(lastNameField, "Second name cannot be empty");
                return;
            }

            // Add record to the database and records preview panel
            DBFake.DBRecord nRec = DBFake.AddRecordToDB(firstNameValue, lastNameValue, middleNameValue);

            // Show message that the form is submitted
            MessageBox.Show("Form submitted");

            // Clear existing errors and field values
            ClearErrors();
            ClearFormFields();

            // Rich text which is read only
            // So user can see the data
            AddDBObjToLabel(nRec);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearErrors();
            ClearFormFields();
        }

        private void middleNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameRequired_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
