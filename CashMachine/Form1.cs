using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashMachine
{
    public partial class Form1 : Form
    {
        int mrgX = 607;
        const int STICK = 5;
        const int LEAF = 3;
        const int SHELL = 30;
        const int ROCK = 3;
        const int FLAT_RATE = 2;
        const double HST = 2.5;

        const int x = 65;
        const int y = 265;

        Font Text = new Font("Prestige Elite Std", 10, FontStyle.Regular);
        SolidBrush Paper = new SolidBrush(Color.White);
        SolidBrush Fill = new SolidBrush(Color.Black);







        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
        for (mrgX = 607; mrgX >= 307; mrgX = mrgX - 2)
        {
            mrg.Location = new Point(mrgX, 93);
            this.Refresh();
            Thread.Sleep(100);
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buyButton(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            // string stickCount = ToString.p1UpDown;
            double stickCount = Convert.ToInt16(p1UpDown.Value);
            double totalP1 = STICK * stickCount;

            double leafCount = Convert.ToInt16(p2UpDown.Value);
            double totalP2 = LEAF * leafCount;

            double shellCount = Convert.ToInt16(p3UpDown.Value);
            double totalP3 = SHELL * shellCount;

            double rockCount = Convert.ToInt16(p4UpDown.Value);
            double totalP4 = ROCK * rockCount;

            double totalP = totalP1 + totalP2 + totalP3 + totalP4;
            double totalp_HST = totalP * HST;

            try
            {

                g.FillRectangle(Paper, x, y, x * 4, 300);

                g.DrawString("Mrgggle's Trade"
               , Text, Fill, x + 65, y);

                g.DrawString("Number of sticks:      " + stickCount
                , Text, Fill, x, y + 25);

                g.DrawString("Number of leaves:      " + leafCount
                , Text, Fill, x, y + 40);

                g.DrawString("Number of shells:      " + shellCount
                , Text, Fill, x, y + 55);

                g.DrawString("Number of rocks:       " + rockCount
                , Text, Fill, x, y + 70);

                g.DrawString("Subtotal:              " + totalP.ToString(",###.## gp")
                , Text, Fill, x, y + 95);

                g.DrawString("King Toggwagle's Tax:  " + (HST - 1).ToString("#.##%")
                , Text, Fill, x, y + 110);

                g.DrawString("Total:                 " + totalp_HST.ToString(",###.## gp")
                , Text, Fill, x, y + 125);

                if (stickCount == 0 && leafCount == 0 && shellCount == 0 && rockCount == 0)
                {
                    g.FillRectangle(Paper, x, y, x * 4, 300);

                    g.DrawString("Hey, buddy.\nDon't waist my time."
                    , Text, Fill, x + 65, y + 70);

                    amountTendered.Visible = false;
                    tInput.Visible = false;
                    confirm.Visible = false;
                }

                if (stickCount != 0 || leafCount != 0 || shellCount != 0 || rockCount != 0)
                {

                    amountTendered.Visible = true;
                    tInput.Visible = true;
                    confirm.Visible = true;

                }
            }

            catch
            {
                g.FillRectangle(Paper, x, y, x * 4, 300);

                g.DrawString("Amount must be an number."
                , Text, Fill, x, y + 70);
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            double stickCount = Convert.ToInt16(p1UpDown.Value);
            double totalP1 = STICK * stickCount;

            double leafCount = Convert.ToInt16(p2UpDown.Value);
            double totalP2 = LEAF * leafCount;

            double shellCount = Convert.ToInt16(p3UpDown.Value);
            double totalP3 = SHELL * shellCount;

            double rockCount = Convert.ToInt16(p4UpDown.Value);
            double totalP4 = ROCK * rockCount;

            double totalP = totalP1 + totalP2 + totalP3 + totalP4;
            double totalp_HST = totalP * HST;

            double amount = Convert.ToInt16(tInput.Text);

            double change = amount - totalp_HST;


            g.FillRectangle(Paper, x, y, x * 4, 300);

            g.DrawString("Mrgggle's Trade"
           , Text, Fill, x + 65, y);

            g.DrawString("Number of sticks:      " + stickCount
            , Text, Fill, x, y + 25);

            g.DrawString("Number of leaves:      " + leafCount
            , Text, Fill, x, y + 40);

            g.DrawString("Number of shells:      " + shellCount
            , Text, Fill, x, y + 55);

            g.DrawString("Number of rocks:       " + rockCount
            , Text, Fill, x, y + 70);

            g.DrawString("Subtotal:              " + totalP.ToString(",###.## gp")
            , Text, Fill, x, y + 95);

            g.DrawString("King Toggwagle's Tax:  " + (HST - 1).ToString("#.##%")
            , Text, Fill, x, y + 110);

            g.DrawString("Total:                 " + totalp_HST.ToString(",###.## gp")
            , Text, Fill, x, y + 125);

            g.DrawString("Tendered:              " + amount.ToString(",###.## gp")
            , Text, Fill, x, y + 150);

            g.DrawString("Change:                " + amount.ToString(",###.## gp")
            , Text, Fill, x, y + 165);

        }
    }
}
