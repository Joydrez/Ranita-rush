using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ranita_rush
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int xRana, yRana;
            xRana = pBoxRana.Location.X;
            yRana = pBoxRana.Location.Y;

            if (e.KeyChar==119)
            {
                pBoxRana.Location = new Point(xRana, yRana - 60);
                pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita-rush\Ranita rush\Resources\Frog_back.png");
            }
            else if (e.KeyChar == 115)
            {
                pBoxRana.Location = new Point(xRana, yRana + 60);
                pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita-rush\Ranita rush\Resources\froggy_character.png");
            }
            else if (e.KeyChar == 97)
            {
                pBoxRana.Location = new Point(xRana - 60, yRana);
            }
            else if (e.KeyChar == 100)
            {
                pBoxRana.Location = new Point(xRana + 60, yRana);
            }


            if (pBoxRana.Location.X+79>=940)
            {
                pBoxRana.Location = new Point(xRana, yRana);
            }
            if (pBoxRana.Location.X<=9)
            {
                pBoxRana.Location = new Point(xRana, yRana);
            }
            if (pBoxRana.Location.Y <= 5)
            {
                pBoxRana.Location = new Point(xRana, yRana);
            }
            if (pBoxRana.Location.Y + 50 >= 670)
            {
                pBoxRana.Location = new Point(xRana, yRana);
            }
        }

        public void tmrCar1_Tick(object sender, EventArgs e)
        {
            int Carx1 = pBoxCar1.Location.X, Cary1 = pBoxCar1.Location.Y;                                                            
            bool avanzar = true, dead = false;
            int hitboxRanaY1 = pBoxRana.Location.Y, hitboxRanaY2 = pBoxRana.Location.Y + 55;
            int hitboxRanaX1 = pBoxRana.Location.X, hitboxRanaX2 = pBoxRana.Location.X + 80;

            tmrCar1.Interval = 50;
            int hitboxCarro1Y1 = pBoxCar1.Location.Y, hitboxCarro1Y2 = pBoxCar1.Location.Y + 50;
            int hitboxCarro1X1 = pBoxCar1.Location.X, hitboxCarro1X2 = pBoxCar1.Location.X + 80;                                           

            if (avanzar)
            {
                pBoxCar1.Location = new Point(Carx1 + 5, Cary1);                

                if (Carx1 + 90 >= 1000)
                {
                    avanzar = false;
                }
            }

            //hitbox1
            if (hitboxRanaX1 <= hitboxCarro1X2)
            {
                if (hitboxRanaY1 <= hitboxCarro1Y2)
                {
                    if (hitboxRanaX2 >= hitboxCarro1X1)
                    {
                        if (hitboxRanaY2 >= hitboxCarro1Y2)
                        {
                            avanzar = false;
                            dead = true;
                        }
                    }
                }              
            }                                                            
            //ciclo autos
            if (avanzar == false)
            {
                if (dead == false)
                {
                    pBoxCar1.Location = new Point(-90, Cary1);                    
                    avanzar = true;                    
                }
                else if (dead == true)
                {
                    tmrCar1.Enabled = false;                    
                    pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita-rush\Ranita rush\Resources\Frogdead.png");
                    
                }
            }
            if (tmrCar1.Enabled == false)
            {
                tmrCar2.Enabled = false;
                tmrCar3.Enabled = false;
                tmrCar4.Enabled = false;
                tmrCar5.Enabled = false;
                tmrCar6.Enabled = false;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            int x = pBoxCar1.Location.X, y = pBoxCar1.Location.Y;

            tmrCar1.Enabled = true;
            tmrCar2.Enabled = true;
            tmrCar3.Enabled = true;
            tmrCar4.Enabled = true;
            tmrCar5.Enabled = true;
            tmrCar6.Enabled = true;
                       
        }
        public void tmrCar2_Tick(object sender, EventArgs e)
        {
            int Carx2 = pBoxCar2.Location.X, Cary2 = pBoxCar2.Location.Y;
            int hitboxCarro2Y1 = pBoxCar2.Location.Y, hitboxCarro2Y2 = pBoxCar2.Location.Y + 50;
            int hitboxCarro2X1 = pBoxCar2.Location.X, hitboxCarro2X2 = pBoxCar2.Location.X + 80;
            bool avanzar = true, dead = false;
            int hitboxRanaY1 = pBoxRana.Location.Y, hitboxRanaY2 = pBoxRana.Location.Y + 55;
            int hitboxRanaX1 = pBoxRana.Location.X, hitboxRanaX2 = pBoxRana.Location.X + 80;
            tmrCar2.Interval = 1;

            if (avanzar)
            {
                pBoxCar2.Location = new Point(Carx2 - 5, Cary2);

                if (Carx2 <= 0)
                {
                    avanzar = false;
                }
            }
            //hitbox2
            if (hitboxRanaX1 <= hitboxCarro2X2)
            {
                if (hitboxRanaY1 <= hitboxCarro2Y2)
                {
                    if (hitboxRanaX2 >= hitboxCarro2X1)
                    {
                        if (hitboxRanaY2 >= hitboxCarro2Y2)
                        {
                            avanzar = false;
                            dead = true;
                        }
                    }
                }
            }
            //ciclo autos
            if (avanzar == false)
            {
                if (dead == false)
                {
                    pBoxCar2.Location = new Point(900, Cary2);
                    avanzar = true;
                }
                else if (dead == true)
                {
                    tmrCar2.Enabled = false;
                    pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita rush\Ranita rush\Resources\Frogdead.png");
                }
            }
            if (tmrCar2.Enabled == false)
            {
                tmrCar1.Enabled = false;
                tmrCar3.Enabled = false;
                tmrCar4.Enabled = false;
                tmrCar5.Enabled = false;
                tmrCar6.Enabled = false;
            }
        }

        public void tmrCar3_Tick(object sender, EventArgs e)
        {
            int Carx3 = pBoxCar3.Location.X, Cary3 = pBoxCar3.Location.Y;

            int hitboxCarro3Y1 = pBoxCar3.Location.Y, hitboxCarro3Y2 = pBoxCar3.Location.Y + 50;
            int hitboxCarro3X1 = pBoxCar3.Location.X, hitboxCarro3X2 = pBoxCar3.Location.X + 80;
            bool avanzar = true, dead = false;
            int hitboxRanaY1 = pBoxRana.Location.Y, hitboxRanaY2 = pBoxRana.Location.Y + 55;
            int hitboxRanaX1 = pBoxRana.Location.X, hitboxRanaX2 = pBoxRana.Location.X + 80;
            tmrCar3.Interval = 60;

            if (avanzar)
            {
                pBoxCar3.Location = new Point(Carx3 + 5, Cary3);

                if (Carx3 + 90 >= 1000)
                {
                    avanzar = false;
                }
            }
            //hitbox3
            if (hitboxRanaX1 <= hitboxCarro3X2)
            {
                if (hitboxRanaY1 <= hitboxCarro3Y2)
                {
                    if (hitboxRanaX2 >= hitboxCarro3X1)
                    {
                        if (hitboxRanaY2 >= hitboxCarro3Y2)
                        {
                            avanzar = false;
                            dead = true;
                        }
                    }
                }
            }
            //ciclo autos
            if (avanzar == false)
            {
                if (dead == false)
                {
                    pBoxCar3.Location = new Point(-90, Cary3);
                    avanzar = true;
                }
                else if (dead == true)
                {
                    tmrCar3.Enabled = false;
                    pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita rush\Ranita rush\Resources\Frogdead.png");
                }
            }
            if (tmrCar3.Enabled == false)
            {
                tmrCar1.Enabled = false;
                tmrCar2.Enabled = false;
                tmrCar4.Enabled = false;
                tmrCar5.Enabled = false;
                tmrCar6.Enabled = false;
            }
        }

        public void tmrCar4_Tick(object sender, EventArgs e)
        {
            int Carx4 = pBoxCar4.Location.X, Cary4 = pBoxCar4.Location.Y;

            int hitboxCarro4Y1 = pBoxCar4.Location.Y, hitboxCarro4Y2 = pBoxCar4.Location.Y + 50;
            int hitboxCarro4X1 = pBoxCar4.Location.X, hitboxCarro4X2 = pBoxCar4.Location.X + 80;
            bool avanzar = true, dead = false;
            int hitboxRanaY1 = pBoxRana.Location.Y, hitboxRanaY2 = pBoxRana.Location.Y + 55;
            int hitboxRanaX1 = pBoxRana.Location.X, hitboxRanaX2 = pBoxRana.Location.X + 80;
            tmrCar4.Interval = 100 ;

            if (avanzar)
            {
                pBoxCar4.Location = new Point(Carx4 + 5, Cary4);

                if (Carx4 + 90 >= 1000)
                {
                    avanzar = false;
                }
            }
            //hitbox4
            if (hitboxRanaX1 <= hitboxCarro4X2)
            {
                if (hitboxRanaY1 <= hitboxCarro4Y2)
                {
                    if (hitboxRanaX2 >= hitboxCarro4X1)
                    {
                        if (hitboxRanaY2 >= hitboxCarro4Y2)
                        {
                            avanzar = false;
                            dead = true;
                        }
                    }
                }
            }
            //ciclo autos
            if (avanzar == false)
            {
                if (dead == false)
                {
                    pBoxCar4.Location = new Point(-90, Cary4);
                    avanzar = true;
                }
                else if (dead == true)
                {
                    tmrCar4.Enabled = false;
                    pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita rush\Ranita rush\Resources\Frogdead.png");
                }
            }
            if (tmrCar4.Enabled == false)
            {
                tmrCar2.Enabled = false;
                tmrCar3.Enabled = false;
                tmrCar1.Enabled = false;
                tmrCar5.Enabled = false;
                tmrCar6.Enabled = false;
            }
        }

        public void tmrCar5_Tick(object sender, EventArgs e)
        {
            int Carx5 = pBoxCar5.Location.X, Cary5 = pBoxCar5.Location.Y;

            int hitboxCarro5Y1 = pBoxCar5.Location.Y, hitboxCarro5Y2 = pBoxCar5.Location.Y + 50;
            int hitboxCarro5X1 = pBoxCar5.Location.X, hitboxCarro5X2 = pBoxCar5.Location.X + 80;
            bool avanzar = true, dead = false;
            int hitboxRanaY1 = pBoxRana.Location.Y, hitboxRanaY2 = pBoxRana.Location.Y + 55;
            int hitboxRanaX1 = pBoxRana.Location.X, hitboxRanaX2 = pBoxRana.Location.X + 80;
            tmrCar5.Interval = 2;

            if (avanzar)
            {
                pBoxCar5.Location = new Point(Carx5 - 5, Cary5);

                if (Carx5 <= 0)
                {
                    avanzar = false;
                }
            }
            //hitbox5
            if (hitboxRanaX1 <= hitboxCarro5X2)
            {
                if (hitboxRanaY1 <= hitboxCarro5Y2)
                {
                    if (hitboxRanaX2 >= hitboxCarro5X1)
                    {
                        if (hitboxRanaY2 >= hitboxCarro5Y2)
                        {
                            avanzar = false;
                            dead = true;
                        }
                    }
                }
            }
            //ciclo autos
            if (avanzar == false)
            {
                if (dead == false)
                {
                    pBoxCar5.Location = new Point(900, Cary5);
                    avanzar = true;
                }
                else if (dead == true)
                {
                    tmrCar5.Enabled = false;
                    pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita rush\Ranita rush\Resources\Frogdead.png");
                }
            }
            if (tmrCar5.Enabled == false)
            {
                tmrCar2.Enabled = false;
                tmrCar3.Enabled = false;
                tmrCar4.Enabled = false;
                tmrCar1.Enabled = false;
                tmrCar6.Enabled = false;
            }
        }

        public void tmrCar6_Tick(object sender, EventArgs e)
        {
            int Carx6 = pBoxCar6.Location.X, Cary6 = pBoxCar6.Location.Y;

            int hitboxCarro6Y1 = pBoxCar6.Location.Y, hitboxCarro6Y2 = pBoxCar6.Location.Y + 50;
            int hitboxCarro6X1 = pBoxCar6.Location.X, hitboxCarro6X2 = pBoxCar6.Location.X + 80;
            bool avanzar = true, dead = false;
            int hitboxRanaY1 = pBoxRana.Location.Y, hitboxRanaY2 = pBoxRana.Location.Y + 55;
            int hitboxRanaX1 = pBoxRana.Location.X, hitboxRanaX2 = pBoxRana.Location.X + 80;
            tmrCar6.Interval = 0001;

            if (avanzar)
            {
                pBoxCar6.Location = new Point(Carx6 - 5, Cary6);

                if (Carx6 <= 0)
                {
                    avanzar = false;
                }
            }
            //hitbox6
            if (hitboxRanaX1 <= hitboxCarro6X2)
            {
                if (hitboxRanaY1 <= hitboxCarro6Y2)
                {
                    if (hitboxRanaX2 >= hitboxCarro6X1)
                    {
                        if (hitboxRanaY2 >= hitboxCarro6Y2)
                        {
                            avanzar = false;
                            dead = true;
                        }
                    }
                }
            }
            //ciclo autos
            if (avanzar == false)
            {
                if (dead == false)
                {
                    pBoxCar6.Location = new Point(900, Cary6);
                    avanzar = true;
                }
                else if (dead == true)
                {
                    tmrCar6.Enabled = false;
                    pBoxRana.Image = Image.FromFile(@"C:\Users\johan\source\repos\Ranita rush\Ranita rush\Resources\Frogdead.png");
                }
            }
            if (tmrCar6.Enabled == false)
            {
                tmrCar2.Enabled = false;
                tmrCar3.Enabled = false;
                tmrCar4.Enabled = false;
                tmrCar5.Enabled = false;
                tmrCar1.Enabled = false;
            }
        }
    }
}
