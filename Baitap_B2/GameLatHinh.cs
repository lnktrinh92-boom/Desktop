using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap_B2
{
    public partial class GameLatHinh : Form
    {
        public GameLatHinh()
        {
            InitializeComponent();
            AssignIcons();

            timer.Interval = 700;
            timer.Tick += Timer_Tick;
        }

        List<string> icons = new List<string>()
        {
            "A","A","B","B","C","C","D","D","E","E"
        };

        Button firstClicked = null;
        Button secondClicked = null;

        int player = 1;
        int score1 = 0;
        int score2 = 0;

        Timer timer = new Timer();

        void AssignIcons()
        {
            Random rand = new Random();

            foreach (Button btn in tableLayoutPanel1.Controls)
            {
                int index = rand.Next(icons.Count);
                btn.Text = "";
                btn.Tag = icons[index];
                icons.RemoveAt(index);

                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (timer.Enabled) return;

            Button clicked = sender as Button;

            if (clicked.Text != "") return;

            clicked.Text = clicked.Tag.ToString();

            if (firstClicked == null)
            {
                firstClicked = clicked;
                return;
            }

            secondClicked = clicked;

            CheckMatch();
        }

        void CheckMatch()
        {
            if (firstClicked.Tag.ToString() == secondClicked.Tag.ToString())
            {
                if (player == 1) score1++;
                else score2++;

                ResetTurn();

                if (tableLayoutPanel1.Controls
                .Cast<Button>()
                .All(b => b.Text != ""))
                {
                    ShowWinner();
                }
            }
            else
            {
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            firstClicked.Text = "";
            secondClicked.Text = "";

            if (player == 1)
                player = 2;
            else
                player = 1;

            ResetTurn();
        }

        void ResetTurn()
        {
            firstClicked = null;
            secondClicked = null;
            UpdateUI();
        }

        void UpdateUI()
        {
            labelScoreDisplay1.Text = score1.ToString();
            labelScoreDisplay2.Text = score2.ToString();

            if (player == 1)
            {
                labelPlayer1.ForeColor = Color.Red;
                labelPlayer2.ForeColor = Color.Black;
            }
            else
            {
                labelPlayer1.ForeColor = Color.Black;
                labelPlayer2.ForeColor = Color.Red;
            }
        }

        void ShowWinner()
        {
            string winner = "";

            if (score1 > score2) winner = "Player 1 thắng";
            else if (score2 > score1) winner = "Player 2 thắng";
            else winner = "Hòa";

            MessageBox.Show(winner);
        }
    }
}
