using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace ClassLibrary3
{
    public class GameFactory
    {
        List<Game> gameList = new List<Game>();
        const String FilePath = @"../../games.xml";
        Game g = new Game("", "", 0, 0);
        StreamWriter sw;
        XmlSerializer Serial;

        public void CreateGameList()
        {
            Game g = new Game("Hornets", "Bulldogs", 50, 75);
            gameList.Add(g);
            Game  g1 = new Game("Sports", "Ball", 25, 65);
            gameList.Add(g1);
            Game g2 = new Game("Bees", "Dogbull", 40, 85);
            gameList.Add(g2);
            Game g3 = new Game("Karps", "Sharks", 90, 75);
            gameList.Add(g3);
            Game g4 = new Game("Lions", "Wolfs", 80, 45);
            gameList.Add(g4);
        }

        public Boolean SerializeGameList()
        {
            sw = new StreamWriter(FilePath);
            Serial = new XmlSerializer(gameList.GetType());
            Serial.Serialize(sw,gameList);
            sw.Close();
            return true;
        }
    }
}
