using SnakeForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SnakeForms
{
    public partial class Form1 : Form
    {
        // Stato gioco
        Parte[] serpe = new Parte[100];
        int lung = 0;
        Parte cibo = new Parte();
        int larghMax, altMax;      // celle in larghezza/altezza (20px per cella)
        int punti;
        string verso = "destra";
        Random caso = new Random();
        Brush colSerpe = Brushes.Green; // colore serpente (default)

        // Flag
        bool coloreAperto = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timerGioco.Tick += timerGioco_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaGriglia();
            MostraMenu();
        }

        // --- UI switching ---
        private void MostraMenu()
        {
            panelMenu.Visible = true;
            panelGame.Visible = false;
            panelSalvataggi.Visible = false;
        }

        private void MostraGioco()
        {
            panelMenu.Visible = false;
            panelGame.Visible = true;
            panelSalvataggi.Visible = false;

        }

        private void MostraSalvataggi()
        {
            panelMenu.Visible = false;
            panelGame.Visible = false;
            panelSalvataggi.Visible = true;
        }

        // --- Bottoni Menu ---
        private void btnGioca_Click(object sender, EventArgs e)
        {
            // Chiedi colore una volta per sessione
            if (!coloreAperto)
            {
                using (ColorDialog dlg = new ColorDialog())
                {
                    dlg.Color = Color.Green;
                    dlg.FullOpen = true;
                    if (dlg.ShowDialog() == DialogResult.OK)
                        colSerpe = new SolidBrush(dlg.Color);
                }
                coloreAperto = true;
            }

            MostraGioco();
            AvviaGioco();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            MostraSalvataggi();
            CaricaSalvataggi();
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }

        // --- Bottoni Salvataggi ---
        private void btnElimina_Click(object sender, EventArgs e)
        {
            if (lstSalvataggi.SelectedItem == null) return;
            string daEliminare = lstSalvataggi.SelectedItem.ToString();
            var righe = new List<string>();
            if (File.Exists("punteggio.txt"))
                righe.AddRange(File.ReadAllLines("punteggio.txt"));

            righe.Remove(daEliminare);
            File.WriteAllLines("punteggio.txt", righe.ToArray());
            CaricaSalvataggi();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            MostraMenu();
        }

        private void CaricaSalvataggi()
        {
            lstSalvataggi.Items.Clear();
            if (File.Exists("punteggio.txt"))
            {
                string[] righe = File.ReadAllLines("punteggio.txt");
                lstSalvataggi.Items.AddRange(righe);
            }
        }

        // --- Gioco ---
        private void AggiornaGriglia()
        {
            // Calcola dimensioni della griglia in base al panelGame
            int w = panelGame.ClientSize.Width;
            int h = panelGame.ClientSize.Height;
            if (w <= 0 || h <= 0)
            {
                w = this.ClientSize.Width;
                h = this.ClientSize.Height;
            }
            larghMax = Math.Max(1, w / 20);
            altMax = Math.Max(1, h / 20);
        }

        private void panelGame_Resize(object sender, EventArgs e)
        {
            AggiornaGriglia();
        }

        private void AvviaGioco()
        {
            timerGioco.Stop();

            lung = 1;
            serpe[0] = new Parte { x = 5, y = 5 };
            verso = "destra";
            punti = 0;
            lblPunti.Text = "Punti: 0";
            lblEsito.Text = "";
            txtNome.Visible = false;
            btnSalva.Visible = false;

            AggiornaGriglia();
            CreaCibo();
            timerGioco.Interval = 120; // velocità base
            timerGioco.Start();
            panelGame.Invalidate();
        }

        private void CreaCibo()
        {
            cibo.x = caso.Next(0, larghMax);
            cibo.y = caso.Next(0, altMax);
        }

        private void timerGioco_Tick(object sender, EventArgs e)
        {
            MuoviSerpe();
            panelGame.Invalidate();
        }

        private void MuoviSerpe()
        {
            // scorrimento corpo
            for (int i = lung - 1; i > 0; i--)
            {
                serpe[i].x = serpe[i - 1].x;
                serpe[i].y = serpe[i - 1].y;
            }

            // direzione
            switch (verso)
            {
                case "sinistra": serpe[0].x--; break;
                case "destra": serpe[0].x++; break;
                case "su": serpe[0].y--; break;
                case "giu": serpe[0].y++; break;
            }

            // collisione con bordo
            if (serpe[0].x < 0 || serpe[0].y < 0 || serpe[0].x >= larghMax || serpe[0].y >= altMax)
            {
                FinePartita();
                return;
            }

            // collisione con se stesso
            for (int i = 1; i < lung; i++)
            {
                if (serpe[0].x == serpe[i].x && serpe[0].y == serpe[i].y)
                {
                    FinePartita();
                    return;
                }
            }

            // mangia cibo
            if (serpe[0].x == cibo.x && serpe[0].y == cibo.y)
            {
                if (lung < serpe.Length)
                {
                    serpe[lung] = new Parte
                    {
                        x = serpe[lung - 1].x,
                        y = serpe[lung - 1].y
                    };
                    lung++;
                }
                punti++;
                lblPunti.Text = "Punti: " + punti;
                CreaCibo();
            }
        }

        private void FinePartita()
        {
            timerGioco.Stop();
            lblEsito.Text = $"Hai perso! Punti: {punti}";
            txtNome.Visible = true;
            btnSalva.Visible = true;
            txtNome.Focus();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome)) nome = "Anonimo";

            File.AppendAllText("punteggio.txt", $"{nome}:{punti}{Environment.NewLine}");

            // reset UI e torna al menu
            txtNome.Visible = false;
            btnSalva.Visible = false;
            lblEsito.Text = "";
            MostraMenu();
        }

        // --- Input tastiera ---
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // durante gioco: P apre salvataggi, O cambia colore
            if (panelGame.Visible)
            {
                if (e.KeyCode == Keys.P)
                {
                    timerGioco.Stop();
                    CaricaSalvataggi();
                    MostraSalvataggi();
                    e.Handled = true;
                    return;
                }

                if (e.KeyCode == Keys.O)
                {
                    // Metti in pausa
                    timerGioco.Stop();

                    using (ColorDialog dlg = new ColorDialog())
                    {
                        dlg.Color = Color.Green;
                        dlg.FullOpen = true;
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            colSerpe = new SolidBrush(dlg.Color);
                            panelGame.Invalidate();
                        }
                    }

                    // Riprendi il gioco dopo la scelta
                    timerGioco.Start();

                    e.Handled = true;
                    return;
                }

            }

            // controllo direzioni (wasd + frecce)
            switch (e.KeyCode)
            {
                case Keys.Left:
                case Keys.A:
                    if (verso != "destra") verso = "sinistra";
                    break;
                case Keys.Right:
                case Keys.D:
                    if (verso != "sinistra") verso = "destra";
                    break;
                case Keys.Up:
                case Keys.W:
                    if (verso != "giu") verso = "su";
                    break;
                case Keys.Down:
                case Keys.S:
                    if (verso != "su") verso = "giu";
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // --- Disegno sul panel di gioco ---
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics graf = e.Graphics;
            Brush colCibo = Brushes.Red;
            int cell = 20;

            // Disegna serpente
            for (int i = 0; i < lung; i++)
            {
                graf.FillRectangle(
                    colSerpe,
                    new Rectangle(serpe[i].x * cell, serpe[i].y * cell, cell, cell)
                );
            }

            // Disegna cibo
            graf.FillRectangle(
                colCibo,
                new Rectangle(cibo.x * cell, cibo.y * cell, cell, cell)
            );
        }
    }
}
