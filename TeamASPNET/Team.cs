using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamASPNET
{
    public static class Team
    {
        public static List<Player> players;

        static Team()
        {
            players = new List<Player>() {
                new Player(){ Name = "Alexander", Nickname = "S1mple", Team = "Na'Vi"},
                new Player(){ Name = "Denis", Nickname = "electroNic", Team = "Na'Vi"},
                new Player(){ Name = "Kirill", Nickname = "Boombl4", Team = "Na'Vi"},
                new Player(){ Name = "Ilya", Nickname = "Perfecto", Team = "Na'Vi"},
                new Player(){ Name = "b1t", Nickname = "Valerii", Team = "Na'Vi"},
            };
            



        }

    }
}
