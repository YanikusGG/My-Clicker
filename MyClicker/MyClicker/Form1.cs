using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClicker
{
    public partial class Form1 : Form
    {
        const int win = 10000000;
        const double mult = 1.1;

        int money = 0;
        int perclick = 1;
        int persec = 0;

        int P1price = 100;
        int P2price = 800;
        int P3price = 4000;
        int P4price = 18000;
        int P5price = 90000;

        int A1price = 1000;
        int A2price = 8000;
        int A3price = 40000;
        int A4price = 180000;
        int A5price = 900000;

        public Form1()
        {
            InitializeComponent();

            labelTarget.Text = "Цель: " + win.ToString();

            Timer timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += updLabel;
            timer1.Tick += checker;

            Timer timer2 = new Timer();
            timer2.Interval = 1000;
            timer2.Start();
            timer2.Tick += addMoney;
        }

        private void updLabel(object sender, EventArgs e)
        {
            labelMoney.Text = "Деньги: " + money.ToString();
            labelShop1.Text = "Деньги за клик: " + perclick.ToString();
            labelShop2.Text = "Деньги в секунду: " + persec.ToString();

            buttonP1.Text = "+1 (" + P1price + ")";
            buttonP2.Text = "+10 (" + P2price + ")";
            buttonP3.Text = "+50 (" + P3price + ")";
            buttonP4.Text = "+200 (" + P4price + ")";
            buttonP5.Text = "+1000 (" + P5price + ")";

            buttonA1.Text = "+1 (" + A1price + ")";
            buttonA2.Text = "+10 (" + A2price + ")";
            buttonA3.Text = "+50 (" + A3price + ")";
            buttonA4.Text = "+200 (" + A4price + ")";
            buttonA5.Text = "+1000 (" + A5price + ")";
        }

        private void checker(object sender, EventArgs e)
        {
            if (money >= win)
            {
                DialogResult result = MessageBox.Show(
                "Поздравляем! Вы прошли игру!",
                "Поздравление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void addMoney(object sender, EventArgs e)
        {
            money += persec;
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            money += perclick;
        }

        private void buttonP1_Click(object sender, EventArgs e)
        {
            if (money >= P1price)
            {
                money -= P1price;
                P1price = (int)(P1price * mult);
                perclick += 1;
            }
        }

        private void buttonP2_Click(object sender, EventArgs e)
        {
            if (money >= P2price)
            {
                money -= P2price;
                P2price = (int)(P2price * mult);
                perclick += 10;
            }
        }

        private void buttonP3_Click(object sender, EventArgs e)
        {
            if (money >= P3price)
            {
                money -= P3price;
                P3price = (int)(P3price * mult);
                perclick += 50;
            }
        }

        private void buttonP4_Click(object sender, EventArgs e)
        {
            if (money >= P4price)
            {
                money -= P4price;
                P4price = (int)(P4price * mult);
                perclick += 200;
            }
        }

        private void buttonP5_Click(object sender, EventArgs e)
        {
            if (money >= P5price)
            {
                money -= P5price;
                P5price = (int)(P5price * mult);
                perclick += 1000;
            }
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            if (money >= A1price)
            {
                money -= A1price;
                A1price = (int)(A1price * mult);
                persec += 1;
            }
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (money >= A2price)
            {
                money -= A2price;
                A2price = (int)(A2price * mult);
                persec += 10;
            }
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (money >= A3price)
            {
                money -= A3price;
                A3price = (int)(A3price * mult);
                persec += 50;
            }
        }

        private void buttonA4_Click(object sender, EventArgs e)
        {
            if (money >= A4price)
            {
                money -= A4price;
                A4price = (int)(A4price * mult);
                persec += 200;
            }
        }

        private void buttonA5_Click(object sender, EventArgs e)
        {
            if (money >= A5price)
            {
                money -= A5price;
                A5price = (int)(A5price * mult);
                persec += 1000;
            }
        }
    }
}
