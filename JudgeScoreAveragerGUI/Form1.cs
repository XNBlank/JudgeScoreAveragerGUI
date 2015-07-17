using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JudgeScoreAveragerGUI
{
    public partial class Form1 : Form
    {

        private int judges;
        private float topscore;
        private int ii;
        private int i;
        private List<float> scoreList = new List<float>();


        public Form1()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
        }

        

        private void setupBtn_Click(object sender, EventArgs e)
        {
            
            string judgestxt = judgesNum.Text;
            string topscoretxt = topscoreText.Text;

            try
            {
                judges = Convert.ToInt32(judgestxt);
                topscore = Convert.ToSingle(topscoretxt);
            }
            catch
            {
                MessageBox.Show("You must enter a number!", "Judge Score Averager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (topscore <= 0)
            {
                MessageBox.Show("You can't have a top score of " + topscore + "!", "Judge Score Averager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                outputText.AppendText("\nJudges set to " + judges);
                outputText.AppendText("\nHighest score set to " + topscore);
                outputText.ScrollToCaret();

                for (int i = 0; i < judges; i++)
                {
                    ii = i + 1;
                    outputText.AppendText("\nPlease input score #" + ii);
                    outputText.ScrollToCaret();
                    InputAcceptor ia = new InputAcceptor(ii);
                    if (ia.ShowDialog() == DialogResult.OK)
                    {
                        if (ia.Result > topscore)
                        {
                            outputText.AppendText("\nYou can't have a score higher than " + topscore);
                            outputText.ScrollToCaret();
                            i--;
                        }
                        else if (ia.Result == null||ia.Result == 0)
                        {
                            i--;
                        }
                        else
                        {
                            scoreList.Add(ia.Result);
                            outputText.AppendText("\nSet score #" + ii + " to " + ia.Result);
                            outputText.ScrollToCaret();
                        }
                    }
                }

                outputText.AppendText("\n\nList of input scores\n");
                try
                {
                    foreach (float ii in scoreList)
                    {
                        outputText.AppendText("\n" + ii);
                    }

                    outputText.AppendText("\nYour average score is " + Math.Round(scoreList.Average(), 3) + "\n\n");
                    outputText.ScrollToCaret();
                }
                catch
                {
                    MessageBox.Show("Either input was invalid or you did not enter any value!", "Judge Score Averager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void resetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outputText.Clear();
            judges = default(int);
            topscore = default(int);
            scoreList.Clear();
            outputText.AppendText("Welcome to the score average calculator.");
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveMyFile();
        }

        private void SaveMyFile()
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Plain Text Files|*.txt|RTF Files|*.rtf|All Files|*.*";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                outputText.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("Saved file!", "Judge Score Averager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

    }
}
