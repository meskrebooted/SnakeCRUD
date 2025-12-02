using SnakeForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeForms
{
    public partial class Form1 : Form
    {
        Parte[] serpe = new Parte[100];
        int lung = 0;
        Parte cibo = new Parte();
        int larghMax, altMax;
        int punti;
        string verso = "destra";
        Random caso = new Random();
        string migliorNome = "";
        int migliorPunteggio = 0;
        bool classificaAperta = false;
        bool coloreAperto = false;
        Brush colSerpe = Brushes.Green; // colore serpente (default verde)



        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;
            timerGioco.Tick += timerGioco_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            larghMax = this.ClientSize.Width / 20;
            altMax = this.ClientSize.Height / 20;
            AvviaGioco();
        }

        private void AvviaGioco()
        {
            timerGioco.Stop();
            if (coloreAperto == false)
            {
                MessageBox.Show("Scegli il colore del serpente", "Scegli il colore");
                using (ColorDialog dlg = new ColorDialog())
                {
                    dlg.Color = Color.Green; // colore iniziale
                    dlg.FullOpen = true;     // apre subito la palette

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        colSerpe = new SolidBrush(dlg.Color); // salva colore scelto
                    }
                }
            }
            coloreAperto = true;
            this.WindowState = FormWindowState.Normal; // se era minimizzata, torna normale
            this.Activate();                           // porta la finestra in primo piano
            this.Focus();                              // assicura il focus sulla finestra


            lung = 1;
            serpe[0] = new Parte { x = 5, y = 5 };
            verso = "destra";
            punti = 0;

            Snake.Text = "Punti: 0";
            CreaCibo();
            timerGioco.Start();
        }

        private void CreaCibo()
        {
            cibo.x = caso.Next(0, larghMax);
            cibo.y = caso.Next(0, altMax);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P && !classificaAperta)
            {
                classificaAperta = true;
                timerGioco.Stop();
                if (System.IO.File.Exists("punteggio.txt"))
                {
                    string classifica = System.IO.File.ReadAllText("punteggio.txt");
                    MessageBox.Show(classifica, "Classifica");
                }
                else
                    MessageBox.Show("Nessun punteggio registrato.", "Classifica");

                timerGioco.Start();
                e.Handled = true;
                return; 
            }
            if (e.KeyCode == Keys.O && coloreAperto)
            {
                coloreAperto = false;
                timerGioco.Stop(); 
                    using (ColorDialog dlg = new ColorDialog())
                     {
                         dlg.Color = Color.Green;
                         if (dlg.ShowDialog() == DialogResult.OK)
                         {
                           colSerpe = new SolidBrush(dlg.Color);
                             this.Invalidate(); // ridisegna subito
                         }
                     }
                         timerGioco.Start();
                         e.Handled = true;
                         return;
                       }
            coloreAperto = true;
            classificaAperta = false;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (verso != "destra") verso = "sinistra";
                    break;
                case Keys.Right:
                    if (verso != "sinistra") verso = "destra";
                    break;
                case Keys.Up:
                    if (verso != "giu") verso = "su";
                    break;
                case Keys.Down:
                    if (verso != "su") verso = "giu";
                    break;
                case Keys.A:
                    if (verso != "destra") verso = "sinistra";
                    break;
                case Keys.D:
                    if (verso != "sinistra") verso = "destra";
                    break;
                case Keys.W:
                    if (verso != "giu") verso = "su";
                    break;
                case Keys.S:
                    if (verso != "su") verso = "giu";
                    break;

            }
        }

        private void timerGioco_Tick(object sender, EventArgs e)
        {
            MuoviSerpe();
            this.Invalidate();
        }

        private void MuoviSerpe()
        {
            for (int i = lung - 1; i > 0; i--)
            {
                serpe[i].x = serpe[i - 1].x;
                serpe[i].y = serpe[i - 1].y;
            }

            switch (verso)
            {
                case "sinistra": serpe[0].x--; break;
                case "destra": serpe[0].x++; break;
                case "su": serpe[0].y--; break;
                case "giu": serpe[0].y++; break;
            }

            if (serpe[0].x < 0 || serpe[0].y < 0 || serpe[0].x >= larghMax || serpe[0].y >= altMax)
            {
                timerGioco.Stop();
                MessageBox.Show("Hai perso! Punti: " + punti);
                using (var form = new InserisciNomeForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        string nome = form.NomeGiocatore;
                        System.IO.File.AppendAllText("punteggio.txt", $"{nome}:{punti}{Environment.NewLine}");
                    }
                }
                AvviaGioco();
                return;
            }

            for (int i = 1; i < lung; i++)
            {
                if (serpe[0].x == serpe[i].x && serpe[0].y == serpe[i].y)
                {
                    timerGioco.Stop();
                    MessageBox.Show("Hai perso! Punti: " + punti);
                    using (var form = new InserisciNomeForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            string nome = form.NomeGiocatore;
                            System.IO.File.AppendAllText("punteggio.txt", $"{nome}:{punti}{Environment.NewLine}");
                        }
                    }
                    AvviaGioco();
                    return;
                }
            }

            if (serpe[0].x == cibo.x && serpe[0].y == cibo.y)
            {
                if (lung < serpe.Length)
                {
                    serpe[lung] = new Parte();
                    serpe[lung].x = serpe[lung - 1].x;
                    serpe[lung].y = serpe[lung - 1].y;
                    lung++;
                }
                punti++;
                Snake.Text = "Punti: " + punti;
                CreaCibo();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graf = e.Graphics;
            Brush colCibo = Brushes.Red;

            for (int i = 0; i < lung; i++)
                graf.FillRectangle(colSerpe, new Rectangle(serpe[i].x * 20, serpe[i].y * 20, 20, 20));

            graf.FillRectangle(colCibo, new Rectangle(cibo.x * 20, cibo.y * 20, 20, 20));
        }




    }
}
