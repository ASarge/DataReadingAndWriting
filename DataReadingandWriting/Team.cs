using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataReadingandWriting
{
    class Team
    {
        int teamCapacity; //set team capacity (make sure it includes the voter)
        List<Student> tempTeam;
        public Team(int teamNum) //figure out how to incorporate team cap
        {
            teamCapacity = teamNum;
            tempTeam = new List<Student>();
        }
    }
}
