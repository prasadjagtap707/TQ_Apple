using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TQ_Apple.CollectionAssignment
{
    class Player
    {
        int pid;
        string pname;
        string country;
        string team;

        public Player(int pid, string pname, string country, string team)
        {
            this.Pid = pid;
            this.Pname = pname;
            this.Country = country;
            this.Team = team;
        }

        public int Pid { get => pid; set => pid = value; }
        public string Pname { get => pname; set => pname = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        public override string ToString()
        {
            return "pid:" + Pid + " " + "player name:" + Pname + " " + "country:" + Country + " " + "Team:" + Team;
        }



    }
    class Player1
    {

        static void Main(string[] args)
        {

            ArrayList al = new ArrayList();

            al.Add(new Player(1, "sachin", "India", "mumbai indians"));
            al.Add(new Player(2, "Ricky ponting", "australia", "rajasthan royals"));
            al.Add(new Player(3, "gill christ", "australia", "rajasthan royals"));
            al.Add(new Player(4, "Mahendra sing dhoni", "India", "chennai super kings"));
            al.Add(new Player(5, "suresh raina", "India", "chennai super kings"));
            al.Add(new Player(6, "sanju samson", "India", "mumbai indians"));

            string max_teamName = "";
            int max_count = 0;
            foreach (Player p in al)
            {
                string t = p.Team;
                int c = 0;
                foreach (Player p2 in al)
                {
                    if (p2.Team == t && p2.Country == "australia")
                    {
                        c++;
                    }
                }
                if (max_count < c)
                {
                    max_teamName = p.Team;
                    max_count = c;
                }

            }
            Console.WriteLine($"Maximum Austrelian player are there in {max_teamName} : {max_count}");
        }
    }
}
