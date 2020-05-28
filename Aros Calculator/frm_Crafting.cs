using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aros_Calculator.Classes.Serialization;
using Aros_Calculator.Classes;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Aros_Calculator
{
    public partial class frm_Crafting : Form
    {
        public frm_Crafting()
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
            try {
                //gets the json file
                var jsonRelics = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Crafting.json");
                // the deserialization classes can be founded in Clases->Serilization
                var Relics = JsonConvert.DeserializeObject<List<Crafting>>(jsonRelics);
                // instances the user
                User user = new User(txt_lvl.Text, txt_percentage.Text, txt_desire.Text);
                //cleans the list view
                lsb_relics.Items.Clear();
                // search in the ores list the relics wich can be minned by the player
                foreach (var relic in Relics)
                {
                    if (user.getLvl() >= relic.level)
                    {
                        double logsNeeded = Math.Ceiling(user.calculateXp()[1] / relic.xp);
                        lsb_relics.Items.Add("Relic: " + relic.relic + ", Quantity required: " + logsNeeded);
                    }
                }
                // shows on the user screen the XP required to the leveling and the XP the player have
                lbl_required.Text = "Xp required: " + user.calculateXp()[1].ToString("0");
                lbl_XP.Text = "Your xp: " + user.calculateXp()[0].ToString("0");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void lsb_relics_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets the json file
            var jsonRelics = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Crafting.json");
            // the deserialization classes can be founded in Clases->Serilization
            var Relics = JsonConvert.DeserializeObject<List<Crafting>>(jsonRelics);


            //breaks the string in 4 args
            char[] charSeparators = new char[] { ',', ':' };
            string[] args = lsb_relics.SelectedItem.ToString().Split(charSeparators);
            // args[1] bar name, args[3] quantity of bars needed 

            foreach (var relic in Relics)
            {
                if (relic.relic == args[1].Trim())
                {
                    //search in the json the relic selected
                    string message = "you will need:\n";
                    foreach (var wood in relic.woods)
                    {
                        //when the relic is founded pushes the info about the quantity of logs needed
                        message += wood.quantity * int.Parse(args[3].Trim()) + " " + wood.name + "\n";
                    }
                    MessageBox.Show(message);
                    //shows the message in a message box;
                }
            }
        }
    }
}
