using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace graf_All_Az_Alku
{
    class Taska : Control
    {
        PictureBox kep;
        Label felirat;
        int id, osszeg;
        bool nyitva;
        static int valasztott = -1;



        public PictureBox Kep() { return kep; }

        public static void SetValasztott(int id) 
        {
            valasztott = id;
        }
        public void SetValasztott()
        {
            this.BackColor = Color.Red;
            kep.Width = 132;
            kep.Height = 94;
            kep.Location = new Point(4, 10);
            kep.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        public static int GetValasztott() { return valasztott; }

        public int GetOsszeg() { return osszeg; }
        public bool GetNyitva() { return nyitva; }
        public static int GetOsszegek(Taska[] taskak) 
        {
            int osszegek = 0;
            for (int i = 0; i < taskak.Length; i++)
            {
                if (!taskak[i].nyitva)
                {
                    osszegek += taskak[i].osszeg;
                }
                
            }
            return osszegek; 
        }

        public static int GetZarva(Taska[] taskak)
        {
            int zarva = 0;
            for (int i = 0; i < taskak.Length; i++)
            {
                if (!(taskak[i].nyitva))
                {
                    zarva++;
                }
            }
            return zarva;
        }


        public Taska(int id, int osszeg, Point loc) : base()
        {
            this.Height = 158;
            this.Width = 140;
            this.Location = loc;

            kep = new PictureBox();
            kep.Name = "kep" + id;
            kep.Image = Image.FromFile("taska_zarva.jpg");
            kep.SizeMode = PictureBoxSizeMode.StretchImage;
            kep.Location = new Point(0, 0);
            kep.Width = 138;
            kep.Height = 120;
            this.Controls.Add(kep);

            felirat = new Label();
            felirat.Name = "lab" + id;
            felirat.Text = id.ToString();
            felirat.Location = new Point(0, 120);
            felirat.Width = 148;
            felirat.Height = 20;
            felirat.TextAlign = ContentAlignment.MiddleCenter;
            felirat.Font = new Font("Microsoft Sans Serif", 15);
            this.Controls.Add(felirat);

            this.id = id;
            this.osszeg = osszeg;
            this.nyitva = false;

        }

        public void TaskaNyitas()
        {
            this.Height = 158;
            this.Width = 140;
            nyitva = true;
            kep.Location = new Point(0, 0);
            kep.Image = Image.FromFile("taska_nyitva.jpg");
            kep.SizeMode = PictureBoxSizeMode.StretchImage;
            kep.Width = 138;
            kep.Height = 120;
            felirat.Text = osszeg.ToString();
        }
    }
}
