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
    public partial class frm_main_menu : Form
    {
        public frm_main_menu()
        {
            InitializeComponent();
        }

        private void addMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_adding_member am = new frm_adding_member();
            am.ShowDialog();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_adding_books ab = new frm_adding_books();
            ab.ShowDialog();
        }

        private void removeMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_remove_members rm = new frm_remove_members();
            rm.ShowDialog();
        }

        private void retrieveMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_retrieve_member rrm = new frm_retrieve_member();
            rrm.ShowDialog();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_remove_book rb = new frm_remove_book();
            rb.ShowDialog();
        }

        private void lendBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lend_books lb = new frm_lend_books();
            lb.ShowDialog();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_return_book rb = new frm_return_book();
            rb.ShowDialog();
        }

        private void retrieveBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_retrieve_book retb = new frm_retrieve_book();
            retb.ShowDialog();
        }

        private void viewLendedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_view_lended_books vlb = new frm_view_lended_books();
            vlb.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
