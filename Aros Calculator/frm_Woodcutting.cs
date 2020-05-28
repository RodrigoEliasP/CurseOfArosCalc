using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Aros_Calculator.Classes;
using Aros_Calculator.Classes.Serialization;

namespace Aros_Calculator
{
    public partial class frm_Woodcutting : Form
    {
        public frm_Woodcutting()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                //gets the json file
                var jsonLogs = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Woodcutting.json");
                // the deserialization classes can be founded in Clases->Serilization
                var Logs = JsonConvert.DeserializeObject<List<Logs>>(jsonLogs);
                // instances the user
                User user = new User(txt_lvl.Text, txt_percentage.Text, txt_desire.Text);
                //cleans the list view
                lsb_woods.Items.Clear();
                // search in the ores list the ores wich can be minned by the player
                foreach (var log in Logs)
                {
                    if (user.getLvl() >= log.level)
                    {
                        double logsNeeded = Math.Ceiling(user.calculateXp()[1] / log.xp);
                        lsb_woods.Items.Add("Log: " + log.log + ", Quantity required: " + logsNeeded);
                    }
                }
                // shows on the user screen the XP required to the leveling and the XP the player have
                lbl_required.Text = "Xp required: " + user.calculateXp()[1].ToString("0");
                lbl_XP.Text = "Your xp: " + user.calculateXp()[0].ToString("0");
            }catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            //return to menu
            frm_Welcome welcome = new frm_Welcome();
            welcome.Show();
            this.Close();
        }
    }
}
