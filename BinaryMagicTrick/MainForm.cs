using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YonatnanMankovich.BinaryMagicTrickCore;

namespace YonatnanMankovich.BinaryMagicTrick
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetBTN_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UpperBound = (int)UpperBoundNUD.Value;
            Properties.Settings.Default.Save();

            BinaryMagicTrickController trickController = new BinaryMagicTrickController(0, (int)UpperBoundNUD.Value);

            Hide();
            if (MessageBox.Show("Think of a number between 0 and " + trickController.UpperBound, "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                Application.Exit();

            while (true)
            {
                List<int> cardMembers = trickController.GetNextCardMembers();
                if (cardMembers == null)
                    break;
                switch (MessageBox.Show(string.Join(", ",cardMembers),
                    $"(Card {trickController.CurrentCardNumber + 1} of {trickController.NumberOfCards}) " +
                    $"Is your number on the screen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes: trickController.CardHasNumber(); break;
                    case DialogResult.Cancel: Application.Exit(); break;
                }
            }

            if (trickController.TheGuessedNumber <= trickController.UpperBound)
            {
                if (MessageBox.Show(trickController.TheGuessedNumber.ToString(), "Is this your number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    MessageBox.Show("It is not possible...\nPlease look carefully for your number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("This number does not exist...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Do you want to play again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Show();
            else
                Application.Exit();
        }

        private void UpperBoundNUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SetBTN.PerformClick();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpperBoundNUD.Value = Properties.Settings.Default.UpperBound;
        }
    }
}