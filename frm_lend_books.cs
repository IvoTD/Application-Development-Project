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
    public partial class frm_lend_books : Form
    {
        Entities ed;
        book b;
        member m;
        lend l;
        List<book> list_of_books;
        List<member> list_members;
        List<lend> list_of_lends;
        public frm_lend_books()
        {
            InitializeComponent();
            ed = new Entities();
            l = new lend();
       
        }

        private void frm_lend_books_Load(object sender, EventArgs e)
        {
            
            list_of_books = ed.books.ToList();
            foreach (var x in list_of_books)
            {
                cmb_isbn.Items.Add(x.ISBN);
            }
            list_of_lends = new List<lend>();
            list_of_lends = ed.lends.ToList();

        }

        private void cmb_isbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int book_index = cmb_isbn.SelectedIndex;
            b = list_of_books[book_index];
            btn_lend.Enabled = true;
            txt_bookname.Text = list_of_books[book_index].Book_name;
            cmb_booktype.Text = list_of_books[book_index].Book_type;
            txt_authorsname.Text = list_of_books[book_index].Book_author;
            cmb_booklocation.Text = list_of_books[book_index].Book_location;
            pb_bookpicture.Image = new Bitmap(list_of_books[book_index].Book_picture);
 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_lend_Click(object sender, EventArgs e)
        {
            lbl_id.Visible = true;
            cmb_id.Visible = true;
            list_members = ed.members.ToList();
            foreach (var x in list_members)
            {
                cmb_id.Items.Add(x.Id);
            }

        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmb_id.SelectedIndex;
            m = list_members[i];
            DialogResult dr = MessageBox.Show("Are you sure want to lend (Y/N)", "Comfirm", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                int counter = 0;
                foreach (var x in list_of_lends)
                {
                    if (x.Id == m.Id)
                    {
                        counter++;
                        if (counter < 5)
                        {
                            l.ISBN = b.ISBN;
                            l.Id = m.Id;
                            l.Date_borrowed = DateTime.Today;
                            ed.lends.Add(l);
                            ed.SaveChanges();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Sorry we cant lend you more books");
                            this.DialogResult = DialogResult.OK;
                        }


                    }
                    
                }
                
            }
        }
    }
}
