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
    public partial class frm_remove_members : Form
    {
        member selected_member;
        Entities ed;
        List<member> member_list;
        public frm_remove_members()
        {
            InitializeComponent();
            txt_email.Enabled = false;
            txt_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            txt_phonenumber.Enabled = false;
            cmb_gender.Enabled = false;
            cmb_membertype.Enabled = false;
            btn_remove.Enabled = false;
            ed = new Entities();
            member_list = new List<member>();
            member_list = ed.members.ToList();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frm_remove_members_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < member_list.Count; i++)
            {
                cmb_id.Items.Add(member_list[i].Id);
            }

        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cmb_id.SelectedIndex;
            txt_email.Text = member_list[i].Email;
            txt_firstname.Text = member_list[i].Firstname;
            txt_lastname.Text = member_list[i].Lastname;
            txt_phonenumber.Text = member_list[i].Phone;
            cmb_gender.Text = member_list[i].Gender;
            cmb_membertype.Text = member_list[i].Member_type;
            btn_remove.Enabled = true;
            pictureBox1.Image = new Bitmap(member_list[i].Pictures);

            selected_member = member_list[i];//stores the selected member to the object

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure want to remove (Y/N)", "WARNING!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                ed.members.Remove(selected_member);
                ed.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
