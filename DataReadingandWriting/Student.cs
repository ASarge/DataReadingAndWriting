using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace DataReadingandWriting
{
    class Student
    {
        /*
         * Student's need to hold:
         * Voter Name
         * A List of <ID>
         */

        string nameVoter;
        public string[] preference;
        List<ID> pref; //make a list of IDs here!
        DataManager handler = new DataManager();
        ListBox studentVote;

        public Student(string voterName, ListBox box)
        {
            preference = handler.readAllData(voterName);
            nameVoter = voterName;
            pref = new List<ID>();
            studentVote = box;
        }

        public void assignID()
        {
            for (int i = 0; i < preference.Length; i++)
            {
                pref.Add(new ID(preference[i], i));
            }
           // handler.loadAllDataToListBox(preference, studentVote);
        }
    }
}
