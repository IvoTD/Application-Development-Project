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
    public partial class frm_adding_member : Form
    {
        String fn;
        String path; // this will store the path of storage
        public frm_adding_member()
        {
            InitializeComponent();
            fn = "";  // stores the picture location along with its name
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
                pictureBox1.Image = new Bitmap(fn);              
            }

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (fn != "" || txt_id.Text !="" || txt_firstname.Text != "" || txt_lastname.Text != "" || cmb_gender.SelectedIndex != -1 || cmb_membertype.SelectedIndex != -1)
            {

                string folder = @"members_pictures\";
                path = Path.Combine(folder, Path.GetFileName(fn));
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
             
                if (!File.Exists(path))
                    File.Copy(fn, path);

                using (Entities ae = new Entities())
                {
                    member mem = new member();
                    mem.Id = txt_id.Text;
                    mem.Firstname = txt_firstname.Text;
                    mem.Lastname = txt_lastname.Text;
                    mem.Gender = cmb_gender.SelectedItem.ToString();
                    mem.Phone = txt_phonenumber.Text;
                    mem.Email = txt_email.Text;
                    mem.Member_type = cmb_membertype.SelectedItem.ToString();
                    mem.Pictures = path.ToString();


                    ae.members.Add(mem);
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
