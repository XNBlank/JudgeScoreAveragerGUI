using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudgeScoreAveragerGUI
{
    public partial class InputAcceptor : Form
    {
        public float Result { get; set; }

        public InputAcceptor()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
        }

        public InputAcceptor(int judgeNumber)
        {
            InitializeComponent();
            this.label1.Text = "Input Score for Judge " + judgeNumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Result = Convert.ToSingle(inputTextbox.Text);
            }
            catch
            {
                MessageBox.Show("Input was not a number!", "Judge Score Averager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.Result = Convert.ToSingle(inputTextbox.Text);
                }
                catch
                {
                    MessageBox.Show("Input was not a number!", "Judge Score Averager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
