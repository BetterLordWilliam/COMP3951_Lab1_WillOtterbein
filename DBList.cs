using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace COMP3951_Lab1_WillOtterbein
{
    public class DBList : Form
    {
        public DBList()
        {
            // Is a form, should call form constructor implicitly
            this.Text = "Database Records";
            this.Size = new Size(300, 150);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Add buttons to the form
            RichTextBox dbRecordsList = new System.Windows.Forms.RichTextBox();
            dbRecordsList.Dock = DockStyle.Fill;
            dbRecordsList.Text = "ID\tFN\tLN\tMN\r\n";
            dbRecordsList.ReadOnly = true;
            this.Controls.Add(dbRecordsList);
        } 
    }
}
