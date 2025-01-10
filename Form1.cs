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

namespace COMP3951_Lab1_WillOtterbein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

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
            dbText.Text += nRec.ToString();
        }

        /// <summary>
        /// Handle submission of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            // Field values
            String firstNameValue = firstNameField.Text;
            String middleNameValue = middleNameField.Text;
            String lastNameValue = lastNameField.Text;

            // First name and last name are required to have values
            Boolean fnameEmptyNull = String.IsNullOrEmpty(firstNameValue);
            Boolean lnameEmptyNull = String.IsNullOrEmpty(lastNameValue);

            if (fnameEmptyNull || lnameEmptyNull)
            {
                MessageBox.Show("First name and last name cannot be empty");
                if (fnameEmptyNull)
                    errorProvider1.SetError(firstNameField, "First name cannot be empty");
                if (lnameEmptyNull)
                    errorProvider2.SetError(lastNameField, "Second name cannot be empty");
                return;
            }

            // Clear errors and errors
            ClearErrors();
            ClearFormFields();

            // Add record to the database and records preview panel
            DBFake.DBRecord nRec = DBFake.AddRecordToDB(firstNameValue, lastNameValue, middleNameValue);

            // Create a simple message string using fomatted string shorthand and
            // the multiline string shorthand
            String message = "Form submitted"
                + $"First name: {firstNameValue}"
                + $"Middle name: {middleNameValue}"
                + $"Last name: {lastNameValue}";

            // Show message that the form is submitted
            MessageBox.Show(message);

            // Update records panel TBD...
            // Literally just a big label
            // Add to the label
            // Rich text which is read only, maybe this is better than a label
            AddDBObjToLabel(nRec);
        }

        /// <summary>
        /// Clear form data and errors (if present).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            ClearErrors();
            ClearFormFields();
        }
    }
}
