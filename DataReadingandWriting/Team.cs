using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataReadingandWriting
{
    class Team
    {
        /*
         * Team must include/incorporate:
         * A List of Students
         * - Must be able to compare Student ID Lists and create lowest possible value group
         * Team Capacity
         */
        int teamCapacity; //set team capacity (make sure it includes the voter)
        List<Student> tempTeam;
        DataManager holder = new DataManager();
        string[] classList;
        public Team(int teamNum) //figure out how to incorporate team cap
        {
            teamCapacity = teamNum;
            tempTeam = new List<Student>();
        }

        public void makeTeam () //how to compare value of ID?
        {
            classList = holder.readAllData("ics4u101_students");
            for (int i = 0; i < classList.Length; i++)
            {
                tempTeam.Add(new Student(classList[i]));
            }
        }

    }
}
