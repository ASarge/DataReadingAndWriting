using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace DataReadingandWriting
{
    class DataManager
    {
        public string[] readAllData(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName);
            }
            catch (Exception e)
            {
                return File.ReadAllLines(fileName + ".txt");
            }
        }

        public void loadAllDataToListBox(string[] data, ListBox box)
        {
            box.ResetText();
            foreach (string d in data)
            {
                box.Items.Add(d);
            }
        }

        public void writeAllDataToFile(string fileName, string[] data)
        {
            var writer = new StreamWriter(fileName);

            foreach (string d in data)
            {
                writer.WriteLine(d);
            }

            writer.Close();
        }

        public void writeAllDataToFile(string fileName, ListBox data)
        {
            var writer = new StreamWriter(fileName);

            foreach (object d in data.Items)
            {
                writer.WriteLine(d);
            }

            writer.Close();
        }
    }
}
