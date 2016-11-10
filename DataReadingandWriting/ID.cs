using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataReadingandWriting
{
    class ID
    {
        /*
         * ID's need to hold:
         * A Student Name (done)
         * A Numeric Value
         */

        int numStudents = 19; //19 students
        int value;
        string voterName; 

        public ID(string name, int weight)
        {
            voterName = name;
            value = weight;
        }

        //public int[] weighting()
        //{
        //    int[] tempArray = new int[numStudents];
        //    for (int i = 0; i < numStudents; i++)
        //    {
        //        tempArray[i] = i;
        //    }

        //    return tempArray;
        //}
    }
}
