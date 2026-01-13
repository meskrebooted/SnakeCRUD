using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SnakeForms
{
    public partial class Form1 : Form
    {
        // Gioco
        Parte[] serpe = new Parte[100];
        int lung = 0;
        Parte cibo = new Parte();
        int larghMax, altMax;
        int punti;
        string verso = "destra";
        Random caso = new Random();
        Brush colSerpe = Brushes.Green;

        // Classifica (array)
        Classifica classifica = new Classifica();
        string fileClassifica = "punteggi.xml";

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
            CaricaClassifica();
            MostraMenu();
        }

        // ----- UI switching -----
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
            CaricaListaSalvataggi();
        }

        // ----- Bottoni menu -----
        private void btnGioca_Click(object sender, EventArgs e)
        {
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
        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ----- Classifica -----

        private void CaricaListaSalvataggi()
        {
            lstSalvataggi.Items.Clear();
            for (int i = 0; i < classifica.Count; i++)
            {
                lstSalvataggi.Items.Add(classifica.Punteggi[i]);
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int index = lstSalvataggi.SelectedIndex;
            if (index < 0 || index >= classifica.Count) return;

            classifica.Elimina(index);
            SalvaClassifica();
            CaricaListaSalvataggi();
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            MostraMenu();
        }

        private void btnModificaSel_Click(object sender, EventArgs e)
        {
            int index = lstSalvataggi.SelectedIndex;
            if (index < 0 || index >= classifica.Count) return;

            Punteggio selezionato = classifica.Punteggi[index];

            using (var frm = new InserisciNomeForm(selezionato.Nome))
            {
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    string nuovoNome = frm.NomeGiocatore;
                    if (!string.IsNullOrWhiteSpace(nuovoNome))
                    {
                        selezionato.Nome = nuovoNome;
                        SalvaClassifica();
                        CaricaListaSalvataggi();
                    }
                }
            }
        }

        // ----- Persistenza XML -----

        private void SalvaClassifica()
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Classifica));
                using (FileStream fs = new FileStream(fileClassifica, FileMode.Create))
                {
                    xml.Serialize(fs, classifica);
                }
            }
            catch { }
        }

        private void CaricaClassifica()
        {
            if (!File.Exists(fileClassifica)) return;

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(Classifica));
                using (FileStream fs = new FileStream(fileClassifica, FileMode.Open))
                {
                    classifica = (Classifica)xml.Deserialize(fs);
                }
            }
            catch { }
        }

        // ----- Gioco -----

        private void AggiornaGriglia()
        {
            int w = panelGame.ClientSize.Width;
            int h = panelGame.ClientSize.Height;

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

            timerGioco.Interval = 120;
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

            if (serpe[0].x < 0 || serpe[0].y < 0 ||
                serpe[0].x >= larghMax || serpe[0].y >= altMax)
            {
                FinePartita();
                return;
            }

            for (int i = 1; i < lung; i++)
            {
                if (serpe[0].x == serpe[i].x && serpe[0].y == serpe[i].y)
                {
                    FinePartita();
                    return;
                }
            }

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
            if (nome == "") nome = "Anonimo";

            Punteggio p = new Punteggio
            {
                Nome = nome,
                Punti = punti,
                Data = DateTime.Now
            };

            classifica.Aggiungi(p);
            SalvaClassifica();

            txtNome.Visible = false;
            btnSalva.Visible = false;
            lblEsito.Text = "";
            MostraMenu();
        }

        // ----- Input -----

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Se sto scrivendo il nome, NON permettere P o O
            if (txtNome.Visible && txtNome.Focused)
            {
                // Permetti solo lettere, numeri, backspace ecc.
                return;
            }

            // Se siamo nel gioco
            if (panelGame.Visible)
            {
                // Tasto P = apri salvataggi SOLO se non sto scrivendo
                if (e.KeyCode == Keys.P)
                {
                    timerGioco.Stop();
                    MostraSalvataggi();
                    return;
                }

                // Tasto O = cambia colore SOLO se non sto scrivendo
                if (e.KeyCode == Keys.O)
                {
                    timerGioco.Stop();
                    using (ColorDialog dlg = new ColorDialog())
                    {
                        dlg.Color = Color.Green;
                        dlg.FullOpen = true;
                        if (dlg.ShowDialog() == DialogResult.OK)
                            colSerpe = new SolidBrush(dlg.Color);
                    }
                    timerGioco.Start();
                    return;
                }


                // --- Controlli movimento serpente ---
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

        }

        // ----- Disegno -----

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cell = 20;

            // Colori esatti dall'immagine
            Color verdeChiaro = ColorTranslator.FromHtml("#aad751"); // RGB(168, 221, 168)
            Color verdeScuro = ColorTranslator.FromHtml("#a2d149");  // RGB(109, 168, 109)

            // Sfondo checkerboard
            for (int y = 0; y < altMax; y++)
            {
                for (int x = 0; x < larghMax; x++)
                {
                    bool pari = (x + y) % 2 == 0;
                    using (Brush sfondo = new SolidBrush(pari ? verdeChiaro : verdeScuro))
                    {
                        g.FillRectangle(sfondo, new Rectangle(x * cell, y * cell, cell, cell));
                    }
                }
            }

            // Ombra serpente
            for (int i = 0; i < lung; i++)
            {
                Rectangle rOmbra = new Rectangle(serpe[i].x * cell + 2, serpe[i].y * cell + 2, cell, cell);
                g.FillRectangle(Brushes.Black, rOmbra);
            }

            // Serpente
            for (int i = 0; i < lung; i++)
            {
                Rectangle r = new Rectangle(serpe[i].x * cell, serpe[i].y * cell, cell, cell);
                g.FillRectangle(colSerpe, r);
            }

            // Ombra mela
            Rectangle rOmbraMela = new Rectangle(cibo.x * cell + 2, cibo.y * cell + 2, cell, cell);
            g.FillRectangle(Brushes.Black, rOmbraMela);

          

            // Mela
            g.FillRectangle(Brushes.Red, new Rectangle(cibo.x * cell, cibo.y * cell, cell, cell));
        }

    }
}

