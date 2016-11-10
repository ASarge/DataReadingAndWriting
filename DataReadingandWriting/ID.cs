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

        int value;
        string voterName; 

        public ID(string name, int weight)
        {
            voterName = name;
            value = weight;
        }

        public string studentID()
        {
            return voterName;
        }
        public int studentValue()
        {
            return value;
        }
    }
}
