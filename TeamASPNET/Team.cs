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
                new Player(){ Name = "Alexander", Nickname = "S1mple", Team = "Na'Vi"}
            };
            



        }

    }
}
