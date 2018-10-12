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

        const int x = 300;
        const int y = 75;
        const int w = 260;
        const int h = 300;

        Font Text = new Font("Prestige Elite Std", 10, FontStyle.Regular);
        SolidBrush Paper = new SolidBrush(Color.White);
        SolidBrush Fill = new SolidBrush(Color.Black);
        Pen Outline = new Pen(Color.Black);

        double stickCount, totalP1, leafCount, totalP2, shellCount, totalP3, rockCount, totalP4, totalP,totalp_HST,amount;






        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        for (mrgX = 607; mrgX >= 307; mrgX = mrgX - 2)
        {
            Point mrg = new Point(mrgX, 93);
            this.Refresh();
            Thread.Sleep(10);
        }

          //  mrgX = mrg.LocationX;
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buyButton(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            // string stickCount = ToString.p1UpDown;
            stickCount = Convert.ToInt16(p1UpDown.Value);
            totalP1 = STICK * stickCount;

            leafCount = Convert.ToInt16(p2UpDown.Value);
            totalP2 = LEAF * leafCount;

             shellCount = Convert.ToInt16(p3UpDown.Value);
             totalP3 = SHELL * shellCount;

            rockCount = Convert.ToInt16(p4UpDown.Value);
           totalP4 = ROCK * rockCount;

            totalP = totalP1 + totalP2 + totalP3 + totalP4;
            totalp_HST = totalP * HST;



            g.DrawRectangle(Outline, x, y, w, h);
            g.FillRectangle(Paper, x, y, w, h);

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
                g.DrawRectangle(Outline, x, y, w, h);
                g.FillRectangle(Paper, x, y, w, h);

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

        private void confirm_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();

            stickCount = Convert.ToInt16(p1UpDown.Value);
            totalP1 = STICK * stickCount;

            leafCount = Convert.ToInt16(p2UpDown.Value);
            totalP2 = LEAF * leafCount;

            shellCount = Convert.ToInt16(p3UpDown.Value);
            totalP3 = SHELL * shellCount;

            rockCount = Convert.ToInt16(p4UpDown.Value);
            totalP4 = ROCK * rockCount;

            totalP = totalP1 + totalP2 + totalP3 + totalP4;
            totalp_HST = totalP * HST;



            try
            {
                amount = Convert.ToInt16(tInput.Text);


                double change = amount - totalp_HST;
                double sChange = change * 10;

                g.DrawRectangle(Outline, x, y, w, h);
                g.FillRectangle(Paper, x, y, w, h);

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

                g.DrawString("Change:                " + change.ToString(",###.## gp")
                , Text, Fill, x, y + 165);

                g.DrawString("                       or\n" +
                             "                       " + sChange.ToString(",###.## sp")
                , Text, Fill, x, y + 180);

                if (totalp_HST > amount)
                {
                    g.DrawRectangle(Outline, x, y, w, h);
                    g.FillRectangle(Paper, x, y, w, h);

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

                    g.DrawString("Please enter the \ncorrect amount of gold pieces"
                    , Text, Fill, x, y + 150);
                }

            }
            catch
            {
                g.DrawRectangle(Outline, x, y, w, h);
                g.FillRectangle(Paper, x, y, w, h);

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

                g.DrawString("Amount must be an number."
                , Text, Fill, x, y + 150);
            }
        }

        private void newOrder_Click(object sender, EventArgs e)
        {

            stickCount = 0;
            leafCount = 0;
            rockCount = 0;
            shellCount = 0;

            p1UpDown.Value = 0;
            p2UpDown.Value = 0;
            p3UpDown.Value = 0;
            p4UpDown.Value = 0;

            amountTendered.Visible = false;
            tInput.Visible = false;
            confirm.Visible = false;
            this.Refresh();
        }
    }
}
