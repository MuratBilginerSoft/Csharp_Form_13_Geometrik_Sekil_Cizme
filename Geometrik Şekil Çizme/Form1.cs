using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrik_Şekil_Çizme
{
    public partial class Form1 : Form
    {
        #region Definitions

        Graphics G;
        SolidBrush Fırça = new SolidBrush(Color.Black);
        Pen Kalem = new Pen(Color.Black, 5);
        Font Fontum = new Font("Georgia", 20);

        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Çember":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawEllipse(Kalem,200,100,80,80);
                        G.Dispose();
                        break;
                    }

                case "Elips":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawEllipse(Kalem, 200, 100, 80, 60);
                        G.Dispose();
                        break;
                    }

                case "Kare":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawRectangle(Kalem, 200, 100, 100, 100);
                        G.Dispose();
                        break;
                    }

                case "Dikdörtgen":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawRectangle(Kalem, 200, 100, 100, 80);
                        G.Dispose();
                        break;
                    }

                case "Yazı yaz":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawString("Industryolog Akademi", Fontum, Fırça, 50, 50);
                        G.Dispose();
                        break;
                    }

                case "Yay":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawBezier(Kalem,100,100,130,150,80,90,250,95);
                        G.Dispose();
                        break;
                    }

                case "Serbest Yay":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawBezier(Kalem, 100, 75, 135, 100, 170, 100, 200, 75);
                        G.Dispose();
                        break;
                    }

                case "Serbest Çizim":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        Point[] p1 = { new Point(100, 70), new Point(125, 100), new Point(150, 150), new Point(200, 60) };
                        G.DrawCurve(Kalem, p1, 2);
                        G.Dispose();
                        break;
                    }
                case "Çizgi":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawLine(Kalem, 100, 100, 300, 100);
                        G.Dispose();
                        break;
                    }
                case "Çeyrek Çember":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        G.DrawPie(Kalem, 100, 100, 150, 100, 200, 100);
                        G.Dispose();
                        break;
                    }
                case "Çokgen":
                    {
                        G = this.CreateGraphics();
                        G.Clear(this.BackColor);
                        Point[] p2 = { new Point(150, 100), new Point(200, 150), new Point(200, 200), new Point(150, 250), new Point(100, 150), new Point(100, 110), new Point(300,250) };
                        G.DrawPolygon(Kalem, p2);
                        G.Dispose();
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
