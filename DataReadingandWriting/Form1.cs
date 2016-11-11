using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataReadingandWriting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] data;
        protected string[] studentData;
        DataManager dataHandler = new DataManager();
        int voterCheck = 0;
        int checkData = 0;
        public string nameString;
        public bool teamStart = false;

        private void b_LoadAll_Click(object sender, EventArgs e)
        {
            if (checkData == 0 && !teamStart)
            {
                data = dataHandler.readAllData("ics4u101_students");
                dataHandler.loadAllDataToListBox(data, lb_studentPick);
                checkData++;
            }
            else if (teamStart)
            {
                //Student voter = new Student(tb_FileName.Text, lb_studentSelect); //only uncomment when all other components are complete
                //voter.assignID();
                for (int i = 0; i < (int)nUD_ClassSize.Value; i++) //try to figure out how to compare list of IDs/values
                {
                    Team trial = new Team((int)nUD_teamCap.Value, (int)nUD_ClassSize.Value);
                }
            }
        }

        private void lb_studentPick_SelectedIndexChanged(object sender, EventArgs e) //the listbox that all students start in
        {
            if(lb_studentPick.SelectedItem != null)
            {
                if (voterCheck == 0)
                {
                    nameString = lb_studentPick.SelectedItem.ToString() + ".txt";
                    string[] tempArray = nameString.Split(','); //get rid of the dumb comma
                    nameString = tempArray[0] + tempArray[1]; //put the two strings
                    tb_FileName.AppendText(nameString); //set file name to name of voter
                    lb_VoterName.Items.Add(lb_studentPick.SelectedItem);
                    lb_studentPick.Items.Remove(lb_studentPick.SelectedItem);
                    voterCheck++;
                }
                else
                {
                    lb_studentSelect.Items.Add(lb_studentPick.SelectedItem);
                    lb_studentPick.Items.Remove(lb_studentPick.SelectedItem);
                }
            }
        }

        private void lb_VoterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_VoterName.SelectedItem != null)
            {
                voterCheck = 0;
                tb_FileName.Clear();
                lb_studentPick.Items.Add(lb_VoterName.SelectedItem); //null?
                lb_VoterName.Items.Remove(lb_VoterName.SelectedItem);
            }
        }

        private void lb_studentSelect_SelectedIndexChanged(object sender, EventArgs e) //listbox that selected students go to
        {
            if (lb_studentSelect.SelectedItem != null) //did you change your mind mate?
            {
                lb_studentPick.Items.Add(lb_studentSelect.SelectedItem);
                lb_studentSelect.Items.Remove(lb_studentSelect.SelectedItem);
            }
        }

        private void b_ResetAll_Click(object sender, EventArgs e) //reset button!
        {
            checkData = 0;
            voterCheck = 0;
            tb_FileName.Clear();
            lb_studentPick.Items.Clear();
            lb_studentSelect.Items.Clear();
            lb_VoterName.Items.Clear();
        }

        private void b_SaveToFile_Click(object sender, EventArgs e) //writing to a file
        {
            if (lb_studentPick.Items.Count <= 1 && lb_studentSelect.Items.Count != 0)
            {
                dataHandler.writeAllDataToFile(nameString, lb_studentSelect);
            }
            else System.Console.WriteLine("Please select all students.");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void autoloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkData != 0)
            {
                if (voterCheck == 0)
                {
                    lb_VoterName.Items.Add(lb_studentPick.Items[0]);
                    lb_studentPick.Items.Remove(lb_studentPick.Items[0]);
                    nameString = (string)lb_VoterName.Items[0] + ".txt";
                    string[] tempArray = nameString.Split(','); //get rid of the dumb comma
                    nameString = tempArray[0] + tempArray[1]; //put the two strings
                    tb_FileName.AppendText(nameString);
                    voterCheck++;
                }

                for (int p = 0; p <= 5; p++)
                {
                    for (int l = 0; l < lb_studentPick.Items.Count; l++)
                    {
                        lb_studentPick.SetSelected(l, true);
                    }
                }
                lb_studentSelect.Items.Add(lb_studentPick.SelectedItems);
                lb_studentPick.Items.Remove(lb_studentPick.SelectedItems);
                checkData++;
            }
        }

        private void teamMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Making everything invisible/visible
            #region
            teamStart = true;
            b_LoadAll.Visible = true; //load .txt files into program here
            b_ResetAll.Visible = false;
            b_SaveToFile.Visible = false;
            tb_FileName.Visible = true; //keep the voter's name visible to see who's team is being created
            lb_studentPick.Visible = false;
            lb_studentSelect.Visible = true; //keep voter choices/weighting open
            lb_VoterName.Visible = false;
            l_FileName.Visible = false;
            l_Voter.Visible = false;
            lb_IdealTeam.Visible = true; //ideal team box
            b_Randomizer.Visible = true; //randomizer button
            autoloadToolStripMenuItem.Visible = false;
            l_teamCap.Visible = true;
            nUD_teamCap.Visible = true;
            #endregion 

            if (teamStart)
            {
                for (int c = 0; c < 5; c++)
                {
                    for (int s = 0; s < lb_studentSelect.Items.Count; s++)
                    {
                        lb_studentSelect.SetSelected(s, true);
                    }
                }
                lb_studentSelect.Items.Remove(lb_studentSelect.SelectedItems);
                tb_FileName.Clear();
            }

            //lb_studentSelect.SelectionMode = SelectionMode.None;
            Point voterLocation = new Point(550, 64);
            tb_FileName.Location = voterLocation; //update voterName location on form
        }

        private void voterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Making everything invisible/visible
            #region
            teamStart = !true;
            b_LoadAll.Visible = true; //load .txt files into program here
            b_ResetAll.Visible = !false;
            b_SaveToFile.Visible = !false;
            tb_FileName.Visible = true; //keep the voter's name visible to see who's team is being created
            lb_studentPick.Visible = !false;
            lb_studentSelect.Visible = true; //keep voter choices/weighting open
            lb_VoterName.Visible = !false;
            l_FileName.Visible = !false;
            l_Voter.Visible = !false;
            lb_IdealTeam.Visible = !true; //ideal team box
            b_Randomizer.Visible = !true; //randomizer button
            autoloadToolStripMenuItem.Visible = !false;
            l_teamCap.Visible = !true;
            nUD_teamCap.Visible = !true;
            #endregion 
        }
    }
}
