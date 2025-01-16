using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;

/// <summary>
/// Lab 1
/// Author(s): Will Otterbein
/// Date: January 15 2024
/// Revision: 2
/// </summary>
namespace COMP3951_Lab1_WillOtterbein
{
    /// <summary>
    /// Simple form for viewing db records.
    /// </summary>
    public class DBList : Form
    {
        private RichTextBox dbRecordsList;

        /// <summary>
        /// Constructs a DBList Form.
        /// </summary>
        public DBList()
        {
            // Is a form, should call form constructor implicitly
            this.Text = "Database Records";
            this.Size = new Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add a rich text box to the form
            // This rich text box is what will be used to show records in the fake database
            dbRecordsList = new System.Windows.Forms.RichTextBox();
            dbRecordsList.Name = "dbRecordsList";
            dbRecordsList.Dock = DockStyle.Fill;
            dbRecordsList.Text = "ID\tFN\tLN\tMN\r\n";
            dbRecordsList.ReadOnly = true;
            this.Controls.Add(dbRecordsList);
        }

        /// <summary>
        /// Re-draw the records in the dbRecordsList RichTextBox.
        /// </summary>
        public void refreshRecordsList()
        {
            // Empty text in the rich text box
            // Add strings for each of the records (not ideal)
            dbRecordsList.Text = "ID\tFN\tLN\tMN\r\n";
            Hashtable records = DBFake.GetRecords();
            foreach (DBFake.DBRecord record in records.Values)
            {
                dbRecordsList.Text += record.ToString() + "\r\n";
            }
        }
    }
}
