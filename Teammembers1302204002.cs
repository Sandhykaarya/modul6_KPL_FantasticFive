using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace modul6_FantasticFive_47
{
    internal class Teammembers1302204002
    {
        class TeamMembers_1302204056
        {
            public TeamMember[] member { get; set; }

            public void ReadJSON()
            {
                string jsonFile = "jurnal6_2_1302204002.json";

                string jsonString = File.ReadAllText(jsonFile);

                TeamMembers_1302204056 jsonData = JsonSerializer.Deserialize<TeamMembers_1302204056>(jsonString);

                this.member = jsonData.member;

                this.info();
            }

            public void info()
            {
                Console.WriteLine("Team member list:");
                foreach (var team in member)
                {
                    team.info();
                }
            }
        }

        class TeamMember
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }

            public void info()
            {
                Console.WriteLine(this.nim + " " + this.firstName + " " + this.lastName + " (" + this.age + " " + this.gender + ")");
            }
        }
    }
}
