using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;
using Aros_Calculator.Classes;
using Aros_Calculator.Classes.Serialization;

namespace Aros_Calculator
{
    public partial class frm_Mining : Form
    {
        public frm_Mining()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            //return to menu
            frm_Welcome welcome = new frm_Welcome();
            welcome.Show();
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                
                var jsonOres = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Mining.json");
                // the deserialization classes can be founded in Clases->Serilization
                var Ores = JsonConvert.DeserializeObject<List<Ores>>(jsonOres);



                // creates the object user
                User user = new User(txt_lvl.Text, txt_percentage.Text, txt_desire.Text);
                //cleans the list box
                lsb_ores.Items.Clear();
                // search in the ores list the ores wich can be minned by the player
                foreach (var ore in Ores)
                {
                    if (user.getLvl() >= ore.levelRequired) 
                    {
                        double oresNeeded = Math.Ceiling(user.calculateXp()[1] / ore.xp);
                        lsb_ores.Items.Add("Ore: " + ore.ore + ", Quantity required: "+ oresNeeded); 
                    }
                }
                // shows on the user screen the XP required to the leveling and the XP the player have
                lbl_required.Text = "Xp required: " + user.calculateXp()[1].ToString("0");
                lbl_XP.Text = "Your xp: " + user.calculateXp()[0].ToString("0");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex.Message);
            }
        }
    }
}
