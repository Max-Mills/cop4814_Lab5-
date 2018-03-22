//I added this in step 7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary3
{
    public class Game
    {

        public String Team_1  { get; set; }
        public String Team_2 { get; set; }
        public int Team_1_Score { get; set; }
        public int Team_2_Score { get; set; }

        public Game() { }
        public Game(String Team_1, String Team_2, int Team_1_Score, int Team_2_Score)
        {
            this.Team_1 = Team_1;
            this.Team_2 = Team_2;
            this.Team_1_Score = Team_1_Score;
            this.Team_2_Score = Team_2_Score;
        }

        public override string ToString()
        {
            String gameData = Team_1 + " (" + Team_1_Score + ")  -" + 
                Team_2 + " (" + Team_2_Score + ")";
            return String.Format("{0}", gameData);
        }


    }
}
