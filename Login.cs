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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_id.Text))
            {
                MessageBox.Show("You need to enter ID and Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Focus();
                return;
            }
            
            Entities ae = new Entities(); // creating an object for the database
            var query = from u in ae.users
                          where u.Id == txt_id.Text && u.Password == txt_password.Text 
                          select u;
            if (query.SingleOrDefault() != null) // if the login details match
            {
                MessageBox.Show("Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_main_menu mm = new frm_main_menu();
                this.Hide();
                mm.Show();
            }
            else
                MessageBox.Show("Login failed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            


        }
    }
}
