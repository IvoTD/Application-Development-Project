using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Project
{
    public partial class frm_view_lended_books : Form
    {
        public frm_view_lended_books()
        {
            InitializeComponent();
            pull_data();
        }
        private void pull_data()
        {
            //create lists
            Entities ed = new Entities();
            List<lend> list_of_lends = new List<lend>();
            List<member> list_of_members = new List<member>();
            List<book> list_of_books = new List<book>();
            //convert the database into the lists
            list_of_lends = ed.lends.ToList();
            list_of_members = ed.members.ToList();
            list_of_books = ed.books.ToList();

            string[] row = new string[7];

            foreach (var x in list_of_lends)
            {
                row[0] = x.ISBN;
                row[4] = x.Date_borrowed.ToString();
                row[5] = x.Id;
                foreach (var y in list_of_books)
                {
                    if (y.ISBN == x.ISBN)
                    {
                        row[1] = y.Book_type;
                        row[2] = y.Book_name;
                        row[3] = y.Book_author;
                    }
                }
                foreach (var z in list_of_members)
                {
                    if (x.Id == z.Id)
                    {
                        row[6] = z.Firstname + " " + z.Lastname;
                    }
                }
                dgv_view_lends.Rows.Add(row);
            }
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
