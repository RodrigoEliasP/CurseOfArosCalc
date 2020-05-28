using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using Aros_Calculator.Classes;
using Aros_Calculator.Classes.Serialization;
using System.Windows.Forms;

namespace Aros_Calculator
{
    public partial class frm_Smithing : Form
    {
        public frm_Smithing()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            frm_Welcome welcome = new frm_Welcome();
            welcome.Show();
            this.Close();
        }

        private void cb_smelt_CheckedChanged(object sender, EventArgs e)
        {
            //when the user checks the checkbox activates the btn_calc
            this.btn_calc_Click(sender, e);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
                //gets the json file
                var jsonBars = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Smithing.json");
                // the deserialization classes can be founded in Clases->Serilization
                var Bars = JsonConvert.DeserializeObject<List<Smithing>>(jsonBars);



                // creates the object user
                User user = new User(txt_lvl.Text, txt_percentage.Text, txt_desire.Text);
                //cleans the list box
                lsb_bars.Items.Clear();
                // search in the bars list the bars wich can be smelted by the player
                foreach (var bar in Bars)
                {
                    if (bar.level <= user.getLvl())
                    {
                        //if the user wants to count with the bar smelting, barxp = smelting xp + forging xp
                        double barXp = cb_smelt.Checked ? bar.smeltingXp + bar.forgingXp : bar.forgingXp;
                        double barsNeeded = Math.Ceiling(user.calculateXp()[1] / barXp);
                        lsb_bars.Items.Add("Bar:" + bar.item + ", Quantity required:" + barsNeeded);
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

        private void lsb_bars_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gets the json file
            var jsonBars = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Smithing.json");
            // the deserialization classes can be founded in Clases->Serilization
            var Bars = JsonConvert.DeserializeObject<List<Smithing>>(jsonBars);
            

            //breaks the string in 4 args
            char[] charSeparators = new char[] { ',',':' };
            string[] args = lsb_bars.SelectedItem.ToString().Split( charSeparators);
            // args[1] bar name, args[3] quantity of bars needed 

            foreach (var bar in Bars)
            {
                if(bar.item == args[1])
                {
                    //search in the json the bar selected
                    string message = "you will need:\n";
                    foreach (var item in bar.items)
                    {
                        //when the bar is founded pushes the info about the quantity of ores needed
                        message += item.quantity * int.Parse(args[3].Trim()) +" "+ item.item + "\n";
                    }
                    MessageBox.Show(message);
                    //shows the message in a message box;
                }
            }
        }
    }
}
