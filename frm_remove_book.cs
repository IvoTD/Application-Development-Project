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
    public partial class frm_remove_book : Form
    {
        book selected_book;
        Entities ed;
        List<book> book_list;
        public frm_remove_book()
        {
            InitializeComponent();
            txt_bookname.Enabled = false;
            cmb_booktype.Enabled = false;
            txt_authorsname.Enabled = false;
            cmb_booklocation.Enabled = false;
            ed = new Entities();
            book_list = new List<book>();
            book_list = ed.books.ToList();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frm_remove_book_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < book_list.Count; i++)
            {
                cmb_isbn.Items.Add(book_list[i].ISBN);
            }
        }

        private void cmb_isbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmb_isbn.SelectedIndex;
            txt_bookname.Text = book_list[i].Book_name;
            cmb_booktype.Text = book_list[i].Book_type;
            txt_authorsname.Text = book_list[i].Book_author;
            cmb_booklocation.Text = book_list[i].Book_location;
            pb_bookpicture.Image = new Bitmap(book_list[i].Book_picture);
            btn_delete.Enabled = true;
            selected_book = book_list[i];


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to remove (Y/N)", "WARNING!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ed.books.Remove(selected_book);
                ed.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
