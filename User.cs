using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEatestat
{
     public class User
    {
        private string name;
        private int highscore;
        private string date;
    
        public User ( string name, int highscore, string date)
        {
            this.name = name;
            this.highscore = highscore;
            this.date = date;
        }
        public string getName()
        {
            return name;
        }
        public int getHighscore()
        {
            return highscore;
        }
        public string getDate()
        {
            return date;
        }
        public void setName( string name )
        {
            this.name = name;
        }
        public void setHighscore ( int highscore )
        {
            this.highscore = highscore;
        }
        public void setDate ( string date )
        {
            this.date = date;
        }
    }
}
