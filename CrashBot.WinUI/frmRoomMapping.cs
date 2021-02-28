using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashBot.WinUI
{
    public partial class frmRoomMapping : Form
    {
        string poruka = "";
        Pen p = new Pen(Color.Red, 10);
        public frmRoomMapping()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            backgroundWorker1.RunWorkerAsync();

            //for (int i = 0; i < 100; i++)
            //{
            //    stopwatch.Stop();
            //    time = stopwatch.Elapsed;
            //    zadnjiProlaz = (int)time.TotalSeconds - ukupno;
            //    ukupno += zadnjiProlaz;                
            //    a = zadnjiProlaz;
            //    duzina = a * 10;
            //    if (gore)
            //    {
            //        shape.Y -= duzina;
            //        g.DrawRectangle(p, shape);
            //        stopwatch.Start();
            //        gore = false;
            //        lijevo = true;
            //        dolje = false;
            //        desno = false;
            //    }
            //    else if (lijevo)
            //    {
            //        shape.X -= duzina;
            //        g.DrawRectangle(p, shape);
            //        stopwatch.Start();
            //        gore = false;
            //        lijevo = false;
            //        dolje = true;
            //        desno = false;
            //    }
            //    else if (dolje)
            //    {
            //        shape.Y += duzina;
            //        g.DrawRectangle(p, shape);
            //        stopwatch.Start();
            //        gore = false;
            //        lijevo = false;
            //        dolje = false;
            //        desno = true;
            //    }
            //    else if (desno)
            //    {
            //        shape.X += duzina;
            //        g.DrawRectangle(p, shape);
            //        stopwatch.Start();
            //        gore = true;
            //        lijevo = false;
            //        dolje = false;
            //        desno = false;
            //    }

            //}




            //shape.Y -= 200;
            //g.DrawRectangle(p, shape);

            //shape.X -= 100;
            //g.DrawRectangle(p, shape);

            //shape.Y += 100;
            //g.DrawRectangle(p, shape);

            //shape.X += 250;
            //g.DrawRectangle(p, shape);

            //shape.Y -= 50;
            //g.DrawRectangle(p, shape);
            //for (int i = 0; i < 100; i++)
            //{ 
            //   time = stopwatch.Elapsed;
            //    stopwatch.Stop();
            //    stopwatch.Start();
            //int a = (int)time.TotalSeconds;                               
            //}

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            serialPort1.Write("S");

            MessageBox.Show("Room mapping is done.","",MessageBoxButtons.OK);

            btnExit.Enabled = true;
            btnExit.Visible = true;
            btnStart.Enabled = false;
            btnStart.Visible = false;
            btnStop.Enabled = false;
            btnStop.Visible = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync();
            //serialPort1.Open();
            int duzina = 0;
            //tmrTimer.Start();
            //tmrTimer.ToString();
            TimeSpan time;
            int a = 0;
            int zadnjiProlaz = 0;
            int ukupno = 0;

            bool prolaz = true;
            bool gore = true;
            bool lijevo = false;
            bool dolje = false;
            bool desno = false;
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            //Brush aBrush = (Brush)Brushes.Red;
            Graphics g = this.CreateGraphics();

            Rectangle shape = new Rectangle(466, 500, 1, 1);
            //g.FillRectangle(aBrush, 544, 466, 1, 1);
            g.DrawRectangle(p, shape);



            serialPort1.Write("A");


            do
            {


                poruka = serialPort1.ReadLine();
                if (poruka == "PREPREKA")
                {

                    stopwatch.Stop();
                    time = stopwatch.Elapsed;
                    zadnjiProlaz = (int)time.TotalSeconds - ukupno;
                    ukupno += zadnjiProlaz;
                    a = zadnjiProlaz;
                    duzina = a * 10;
                    if (gore)
                    {
                        shape.Y -= duzina;
                        g.DrawRectangle(p, shape);
                        stopwatch.Start();
                        gore = false;
                        lijevo = true;
                        dolje = false;
                        desno = false;
                    }
                    else if (lijevo)
                    {
                        shape.X -= duzina;
                        g.DrawRectangle(p, shape);
                        stopwatch.Start();
                        gore = false;
                        lijevo = false;
                        dolje = true;
                        desno = false;
                    }
                    else if (dolje)
                    {
                        shape.Y += duzina;
                        g.DrawRectangle(p, shape);
                        stopwatch.Start();
                        gore = false;
                        lijevo = false;
                        dolje = false;
                        desno = true;
                    }
                    else if (desno)
                    {
                        shape.X += duzina;
                        g.DrawRectangle(p, shape);
                        stopwatch.Start();
                        gore = true;
                        lijevo = false;
                        dolje = false;
                        desno = false;
                    }
                    //prolaz = false;
                }
            } while (prolaz);





            if (!prolaz)
            {
                serialPort1.Write("S");
            }

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Close();

           
        }

        
    }
}
