using System;
using System.Windows.Forms;

namespace Magic_Trick
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetBTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.range = (int)RangeChooser.Value;
            Properties.Settings.Default.Save();
            int range = (int)RangeChooser.Value;
            int theNumber = 0;
            string textForMsgBox;
            this.Hide();
            if (MessageBox.Show("Think of a number between 0 and " + range, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                Application.Exit();
            for (int i = 0; i < Math.Ceiling(Math.Log(range + 1) / Math.Log(2)); i++)
            {
                textForMsgBox = "";
                int number = (int)Math.Pow(2, i);
                while (number <= range)
                {
                    for (int k = 0; k < Math.Pow(2, i) && number <= range; k++)
                    {
                        textForMsgBox = textForMsgBox + number + ", ";
                        number++;
                    }
                    for (int k = 0; k < Math.Pow(2, i); k++)
                        number++;
                }
                switch (MessageBox.Show(textForMsgBox.TrimEnd(' ').TrimEnd(','), $"(Card {i+1} of {Math.Ceiling(Math.Log(range + 1) / Math.Log(2))}) Is your number on the screen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes: theNumber += (int)Math.Pow(2, i); break;
                    case DialogResult.Cancel: Application.Exit(); break;
                }
            }
            if (theNumber <= range)
            {
                if (MessageBox.Show(theNumber.ToString(), "Is this your number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    MessageBox.Show("It is not possible...\nPlease look carefully for your number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This number does not exist...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (MessageBox.Show("Do you want to play again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Show();
            else
                Application.Exit();
        }

        private void Range_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetBTN.PerformClick();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RangeChooser.Value = Properties.Settings.Default.range;
        }
    }
}