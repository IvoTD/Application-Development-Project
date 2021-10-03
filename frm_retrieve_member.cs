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
    public partial class frm_retrieve_member : Form
    {
        
        public frm_retrieve_member()
        {
            InitializeComponent();
            
        }

        private void frm_retrieve_member_Load(object sender, EventArgs e)
        {
            Entities en = new Entities();
            dataGridView1.DataSource = en.members.ToList();
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
