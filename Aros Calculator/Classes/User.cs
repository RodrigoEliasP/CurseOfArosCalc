using System;
using System.Collections.Generic;
using System.IO;
using Aros_Calculator.Classes.Serialization;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aros_Calculator.Classes
{
    class User
    {
        private int _lvl;
        private double _percentage;
        private int _desire;

        public User(string lvl, string percentage, string desire)
        {
            //assigin the values before validate whether all txtboxes were filled
            if(lvl == String.Empty || percentage == String.Empty || desire == String.Empty)
            {
                throw new Exception("Fill all text boxes in user information");
            }
            else
            {
                // if werw filled assigns the values
                this.setLvl(int.Parse(lvl));
                this.setDesire(int.Parse(desire));
                this.setPercentage(double.Parse(percentage));
               
            }
        }
        public double[] calculateXp()
        {
            // get an convert the json files with the game information (requires newtonsoft libraries)
            var jsonLevels = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Json\Levels.json");
            var levels = JsonConvert.DeserializeObject<List<Levels>>(jsonLevels);


            double xpLvl = 0;
            double desiredXp = 0;
            double nextLvlXp = 0;
            double[] resultado = new double[2];

            // search in the list "levels" xp infos
            foreach (var lvl in levels)
            {
                
                //userlvl
                if (Convert.ToInt32(lvl.level) == this.getLvl())
                {
                    //getIntXp returns the int parsed value, since the json returns an string value
                    xpLvl = lvl.getIntXp();
                }
                //desiredlvl
                if (Convert.ToInt32(lvl.level) == this.getDesire())
                {
                    desiredXp = lvl.getIntXp();
                }
                //nextlvl
                if (Convert.ToInt32(lvl.level) == this.getLvl() + 1)
                {
                    nextLvlXp = lvl.getIntXp();
                }
            }
            //calculate the experience and assigins the values at an array
            resultado[0] = Math.Floor(xpLvl + (nextLvlXp - xpLvl) * (this.getPercentage() / 100));
            resultado[1] = desiredXp - resultado[0];
            return resultado;
        }
        public void setLvl(int lvl)
        {
            //validate lvl
            if (lvl < 1 || lvl > 115)
            {
                throw new Exception("lvl must be bigger then 0 and lesser then 116");
            }
            else
            {
                this._lvl = lvl;
            }
            
        }
        public void setDesire(int desire)
        {
            //validate lvl desired
            if (desire < 2 || desire > 115)
            {
                throw new Exception("lvl desired must be bigger then 1 and lesser then 116");
            }
            else if(desire <= this._lvl)
            {
                throw new Exception("lvl desired must be bigger then lvl");
            }
            else
            {
                this._desire = desire;
            }
        }
        public void setPercentage(double percentage)
        {
            //validate percentage
            if (percentage >= 100 || percentage < 0)
            {
                throw new Exception("percentage must be bigger or equals at 0 and lesser then 100");
            }
            else
            {
                this._percentage = percentage;
            }
        }
        public int getLvl()
        {
            return this._lvl;
        }
        public int getDesire()
        {
            return this._desire;
        }
        public double getPercentage()
        {
            return this._percentage;
        }
    }
}
