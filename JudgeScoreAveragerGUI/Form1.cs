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
        private string input;
        private float topscore;
        private int ii;
        private int i;
        private List<float> scoreList = new List<float>();
        private float aNumber;

        public Form1()
        {
            InitializeComponent();


        }

        public void confirmBtn_Click(object sender, EventArgs e)
        {
            string input = inputText.Text;
            inputText.Clear();
            if (input.Length >= 1)
                    {
                        if (judges != 0 && topscore != 0)
                        {
                            //outputText.AppendText("\n" + input);
                            outputText.ScrollToCaret();
                            RequestInput(aNumber);
                        }
                        else
                        {
                            outputText.AppendText("\nPlease set the number of judges and high score first.");
                            outputText.ScrollToCaret();
                        }
                    }
            else
            {
                outputText.AppendText("\nInvalid input.");
                outputText.ScrollToCaret();
            }

            
        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            
            string judgestxt = judgesNum.Text;
            string topscoretxt = topscoreText.Text;
            

            judges = Convert.ToInt32(judgestxt);
            topscore = Convert.ToSingle(topscoretxt);

            if (topscore <= 0)
            {
                outputText.AppendText("\nYou can't have a high score of " + topscore);
                outputText.ScrollToCaret();
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

                    
                }
            }


            
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = inputText.Text;
                inputText.Clear();
                if (input.Length >= 1)
                {
                    //outputText.AppendText("\n" + input);
                    //outputText.ScrollToCaret();
                    RequestInput(aNumber);
                }
            }
        }

        private void resetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            outputText.Clear();
            aNumber = default(float);
            judges = default(int);
            topscore = default(int);
            outputText.AppendText("Welcome to the score average calculator.");
        }

        private void saveLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Does nothing right now.
        }

        //Non-GUI Voids.
        private void RequestInput(float aNumber)
        {
            try
            {
                //aNumber = Convert.ToSingle(input); Doesn't work?
                aNumber = float.Parse(input, CultureInfo.InvariantCulture.NumberFormat); //Does this work?

                if (aNumber > topscore)
                {
                    outputText.AppendText("\nYou can't have a score higher than the highest score.");
                    i--;
                }
                else
                {
                    outputText.AppendText("\nSet score #" + ii + " to " + aNumber);
                    scoreList.Add(aNumber);
                    ii++;
                }
            }
            catch
            {
                outputText.AppendText("\nThat is not a number!"); //A first chance exception of type 'System.ArgumentNullException' occurred in mscorlib.dll?
            }
        }
    }
}
