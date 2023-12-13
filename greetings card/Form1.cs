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

namespace greetings_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen greenPen = new Pen(Color.Green, 20);
            Pen darkGoldenrodPen = new Pen(Color.DarkGoldenrod, 15);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Ariel", 15, FontStyle.Bold);


            g.DrawEllipse(darkGoldenrodPen, 200, 75, 200, 200);
            g.DrawEllipse(darkGoldenrodPen, 50, 112, 500, 125);
            g.FillEllipse(greenBrush, 200, 75, 200, 200);
            g.FillEllipse(greenBrush, 50, 135, 500, 75);
            g.DrawString("You are invited to the annual work christmas party", drawFont, whiteBrush, 60, 160);


        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redPen = new Pen(Color.Red, 20);
            Pen darkGoldenrodPen = new Pen(Color.DarkGoldenrod, 10);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            SolidBrush redBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Ariel", 15, FontStyle.Bold);
            //g.DrawArc(redPen, 300, 20, 50, 50, 90, 270);
            //g.DrawPie(redPen, 300, 100, 50, 50, 210, 60);

            //   g.DrawEllipse(redPen, 295, 95, 195, 195);
            //  g.DrawEllipse(redPen, 345, 145, 95, 95);
            //  g.FillEllipse(redBrush, 345, 150, 100, 100);
            //  g.DrawString("Target", drawFont, redBrush, 30, 30);


            for (int i = 2; i <= 300; i = i + 2)
            {
                //clear
                g.Clear(Color.SeaShell);
                //  draw
                g.DrawEllipse(darkGoldenrodPen, 200, 75 - i, 200, 200);
                g.DrawEllipse(darkGoldenrodPen, 50, 112 - i, 500, 125);
                g.FillEllipse(greenBrush, 200, 75 - i, 200, 200);
                g.FillEllipse(greenBrush, 50, 135 - i, 500, 75);
                g.DrawString("You are invited to the annual work christmas party", drawFont, whiteBrush, 60, 160 - i);

                Thread.Sleep(1);
            }
            SoundPlayer player = new SoundPlayer(Properties.Resources.Windows_95_Startup_Microsoft_2077254053);

            player.Play();

            for (int i = 2; i <= 450; i = i + 2)
            {
                g.Clear(Color.SeaShell);

                

                g.DrawEllipse(darkGoldenrodPen, 500-i, 112, 500, 125);
                g.FillEllipse(greenBrush, 502-i, 125, 497, 100);
                g.DrawString("     You can bring one plus one and at least one\n                                    food item", drawFont, whiteBrush, 510-i, 160);
                g.FillEllipse(greenBrush, 40 + i, 30, 50, 50);
                g.FillEllipse(greenBrush, 508 - i, 30, 50, 50);
                Thread.Sleep(1);
            }
        }

    }
}
