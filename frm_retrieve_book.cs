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
    public partial class frm_retrieve_book : Form
    {
        Entities ed;
        book b;
        List<book> list_of_books;
        public frm_retrieve_book()
        {
            InitializeComponent();
            ed = new Entities();
        }

        private void frm_retrieve_book_Load(object sender, EventArgs e)
        {
            list_of_books = ed.books.ToList();
            foreach (var x in list_of_books)
            {
                cmb_isbn.Items.Add(x.ISBN);
            }
        }

        private void cmb_isbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int book_index = cmb_isbn.SelectedIndex;
            b = list_of_books[book_index];
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
    }
}
