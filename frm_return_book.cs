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
    public partial class frm_return_book : Form
    {
        Entities ed = new Entities();
        List<lend> list_of_lends = new List<lend>();
        lend l;
        double fine;
        public frm_return_book()
        {
            InitializeComponent();
            
        }

        private void frm_return_book_Load(object sender, EventArgs e)
        {
            list_of_lends = ed.lends.ToList();
            foreach (var x in list_of_lends)
            {
                cmb_isbn.Items.Add(x.ISBN);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            int i = cmb_isbn.SelectedIndex;
            l = list_of_lends[i];
            int diff_of_dates = (DateTime.Today - l.Date_borrowed).Days;
            if (diff_of_dates > 14)
            {
                fine = (diff_of_dates - 14) * .50;
                MessageBox.Show("Your exceeded the number of days and the fine is: " + fine.ToString() + " £");
            }
            ed.lends.Remove(l);
            ed.SaveChanges();
            MessageBox.Show("Your book has been returned");
            this.DialogResult = DialogResult.OK;
            
        }

        private void cmb_isbn_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_return.Enabled = true;
        }
    }
}
