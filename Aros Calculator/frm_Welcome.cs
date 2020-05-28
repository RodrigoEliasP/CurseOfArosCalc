using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aros_Calculator
{
    public partial class frm_Welcome : Form
    {
        public frm_Welcome()
        {
            InitializeComponent();
        }

        private void btn_mining_Click(object sender, EventArgs e)
        {
            frm_Mining mining = new frm_Mining();
            mining.Show();
            this.Hide();
        }

        private void btn_woodcutting_Click(object sender, EventArgs e)
        {
            frm_Woodcutting wood = new frm_Woodcutting();
             wood.Show();
             this.Hide();
        }

        private void btn_smithing_Click(object sender, EventArgs e)
        {
            frm_Smithing smith = new frm_Smithing();
            smith.Show();
            this.Hide();
        }

        private void btn_crafting_Click(object sender, EventArgs e)
        {
            frm_Crafting craft = new frm_Crafting();
            craft.Show();
            this.Hide();
        }
    }
}
