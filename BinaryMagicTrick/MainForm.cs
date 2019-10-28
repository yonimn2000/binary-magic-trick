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
            Hide();
            Properties.Settings.Default.UpperBound = (int)UpperBoundNUD.Value;
            Properties.Settings.Default.Save();

            BinaryMagicTrickController trickController = new BinaryMagicTrickController((int)UpperBoundNUD.Value);

            if (MessageBox.Show("Think of a number between 0 and " + trickController.Bound, "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                Application.Exit();

            while (trickController.HasNextCard())
            {
                List<int> cardMembers = trickController.GetNextCardMembers();
                DialogResult isThisYourCardDialogResult = MessageBox.Show(string.Join(",\t", cardMembers),
                    $"(Card {trickController.CurrentCardNumber} of {trickController.NumberOfCards}) " +
                    $"Is your number on the screen?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (isThisYourCardDialogResult == DialogResult.Yes)
                    trickController.CardHasNumber();
                else if(isThisYourCardDialogResult == DialogResult.Cancel)
                    Application.Exit();
            }

            if (trickController.TheGuessedNumber <= trickController.Bound)
                MessageBox.Show(trickController.TheGuessedNumber.ToString(), "Your number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("This number is outside the range...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Show();
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