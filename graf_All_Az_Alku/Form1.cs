using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace graf_All_Az_Alku
{
    public partial class Form1 : Form
    {
        Taska[] taskak;
        static int[] nyitas_db = new int[] { 5, 3, 3, 3, 2, 2, 2, 1, 1 };
        static int index = 0;
        int nyitas = nyitas_db[index];
        double ajanlat = 0;
        bool sajat_nyitas = false;
        public Form1()
        {
            InitializeComponent();
            
            TaskakInit();
            Connection.Connect();
            Connection.FillListBox(lb);
        }

        private void TaskakInit()
        {
            int W = jatekter.Width;

            int x = 4;
            int y = 4;

            Osszegek o = new Osszegek();

            if (taskak is Taska[])
            {
                for (int i = 0; i < taskak.Length; i++)
                {
                    taskak[i].Hide();
                }
                taskak = null;
            }

            taskak = new Taska[23];
            for (int i = 0; i < taskak.Length; i++)
            {
                if (x > (W-170))
                {
                    x = 4;
                    y += 150;
                }

                taskak[i] = new Taska(i+1, o.Pop(), new Point(x, y));

                x += 155;

                taskak[i].Kep().Click += Kep_Click;

                this.jatekter.Controls.Add(taskak[i]);
            }   
        }

        private void Kep_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                int id = int.Parse((sender as PictureBox).Name.Substring(3));

                if (Taska.GetValasztott() == -1)
                {
                    Taska.SetValasztott(id - 1);
                    taskak[Taska.GetValasztott()].SetValasztott();
                    info.Text = "Most válasz újabb " + nyitas + "db táskát!";
                }
                else
                {
                    if (Taska.GetValasztott() == id - 1 && !sajat_nyitas)
                    {
                        MessageBox.Show("A saját táskád még nem nyithatodki!");
                    }
                    else if (Taska.GetValasztott() == id - 1 && sajat_nyitas)
                    {
                        info.Font = new Font("Microsoft Sans Serif", 18);
                        info.ForeColor = Color.PaleVioletRed;
                        info.Text = "Vége a játéknak!";
                        info.Text += Environment.NewLine;
                        info.Text += "A Te nyereményed:";
                        info.Text += Environment.NewLine;
                        info.Text += ajanlat + "Ft";
                    }
                    else
                    {
                        if (!taskak[id-1].GetNyitva())
                        {
                            taskak[id - 1].TaskaNyitas();
                            nyitas--;
                            sajat_nyitas = false;
                            info.Text = "Most válasz újabb " + nyitas + "db táskát!";
                            if (nyitas == 0)
                            {
                                BankAjanlat();
                            }
                        }
                        else
                        {
                            info.Text = "Ez a táska már nyitva van!";
                        }
                    }
                    
                }
                
            }
        }
        private void BankAjanlat()
        {
            int osszeg = Taska.GetOsszegek(taskak);
            double zarva_db = Math.Sqrt(Taska.GetZarva(taskak));
            double  ajanlat = Math.Round(osszeg / zarva_db, 0);
            info.Text = "Most a Bank ajánlata következik: ";
            info.Text += ajanlat;
            info.Text += "Ft";

            this.ajanlat = ajanlat;

            sajat_nyitas = true;

            index++;
            if (!(index >= nyitas_db.Length))
            {
                nyitas = nyitas_db[index];
                info.Text += Environment.NewLine;
                info.Text += "Ha elfogadod a Bank ajánlatát kattints a saját táskádra, a játék folytatásához újabb " + nyitas + "db táskát!";
            }
            else
            {
                info.Font = new Font("Microsoft Sans Serif", 18);
                info.ForeColor = Color.PaleVioletRed;
                info.Text = "Vége a játéknak!";
                info.Text += Environment.NewLine;
                info.Text += "A Te nyereményed:";
                info.Text += Environment.NewLine;
                int nyeremeny = taskak[Taska.GetValasztott()].GetOsszeg();
                info.Text += nyeremeny + "Ft";
            }
            
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void újJátékToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskakInit();
            index = 0;
            nyitas = nyitas_db[index];
            info.Font = new Font("Microsoft Sans Serif", 14);
            info.ForeColor = Color.Black;
            Taska.SetValasztott(-1);
        }

        private void jatekter_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
