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
using System.Media;
/// ANDREW LANGFORD
/// functioning cash machine
/// 15/10/18
namespace CashMachine
{
    public partial class Form1 : Form
    {
        //global varible

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
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.cash);

        double stickCount, totalP1, leafCount, totalP2, shellCount, totalP3, rockCount, totalP4, totalP, totalp_HST, amount, change, sChange;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buyButton(object sender, EventArgs e)
        {
            //math
            Graphics g = this.CreateGraphics();

            player1.Play();

            stickCount = Convert.ToInt16(stickUpDown.Value);
            totalP1 = STICK * stickCount;

            leafCount = Convert.ToInt16(leafUpDown.Value);
            totalP2 = LEAF * leafCount;

            shellCount = Convert.ToInt16(shellUpDown.Value);
            totalP3 = SHELL * shellCount;

            rockCount = Convert.ToInt16(rockUpDown.Value);
            totalP4 = ROCK * rockCount;

            totalP = totalP1 + totalP2 + totalP3 + totalP4;
            totalp_HST = totalP * HST;

            //draw recipt

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
                //enter amount of gp buttons dissapear
                g.DrawRectangle(Outline, x, y, w, h);
                g.FillRectangle(Paper, x, y, w, h);

                g.DrawString("Hey, buddy.\nDon't waist my time."
                , Text, Fill, x + 65, y + 70);

                amountTendered.Visible = false;
                tenderedInput.Visible = false;
                confirm.Visible = false;
            }

            if (stickCount != 0 || leafCount != 0 || shellCount != 0 || rockCount != 0)
            {
                //enter amount of gp buttons appear
                amountTendered.Visible = true;
                tenderedInput.Visible = true;
                confirm.Visible = true;
            }

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            player1.Play();

            //math

            Graphics g = this.CreateGraphics();

            try
            {
                // display tendered and change
                amount = Convert.ToInt16(tenderedInput.Text);

                change = amount - totalp_HST;
                sChange = change * 10;

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
                    //redraw entire recipt with error message

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
                //redraw entire recipt with error message

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
            player1.Play();

            //reset all variables

            stickCount = 0;
            leafCount = 0;
            rockCount = 0;
            shellCount = 0;

            stickUpDown.Value = 0;
            leafUpDown.Value = 0;
            shellUpDown.Value = 0;
            rockUpDown.Value = 0;
            tenderedInput.Text = "";

            amountTendered.Visible = false;
            tenderedInput.Visible = false;
            confirm.Visible = false;
            this.Refresh();
        }
    }
}