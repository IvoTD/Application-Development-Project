using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development_Project
{
    public partial class frm_adding_books : Form
    {
        String fn;
        String path;
        public frm_adding_books()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_upload_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Select a picture, and upload";
            // file type restrictions
            file.Filter = "jpg files(*.jpg) |*.jpg|PNG files (*png)|*png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                fn = file.FileName;
                pb_bookpicture.Image = new Bitmap(fn);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (fn != "" || txt_isbn.Text != "" || txt_authorsname.Text != "" || cmb_booktype.SelectedIndex != -1 || cmb_booklocation.SelectedIndex != -1)
            {

                string folder = @"books_pictures\";
                path = Path.Combine(folder, Path.GetFileName(fn));
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                if (!File.Exists(path))
                    File.Copy(fn, path);

                using (Entities ae = new Entities())
                {
                    book boo = new book();
                    boo.ISBN = txt_isbn.Text;
                    boo.Book_name = txt_bookname.Text;
                    boo.Book_type = cmb_booktype.SelectedItem.ToString();
                    boo.Book_author = txt_authorsname.Text;
                    boo.Book_location = cmb_booklocation.SelectedItem.ToString();
                    boo.Book_picture = path.ToString();

                    ae.books.Add(boo);
                    int i = ae.SaveChanges();
                }
                MessageBox.Show("Data added successfully");
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Warning", "All fields should be filled up");
        }
    }
}
