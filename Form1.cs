using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SnakeForms
{
    public partial class Form1 : Form
    {
        // Gioco
        Parte[] serpe = new Parte[100];
        Timer timerFPS = new Timer();
        int lung = 0;
        Parte cibo = new Parte();
        int larghMax, altMax;
        int punti;
        string verso = "destra";
        Random caso = new Random();
        Brush colSerpe = Brushes.Green;
        string difficoltaScelta = "Normale";

        // Classifica (array)
        Classifica classifica = new Classifica();
        string fileClassifica = "punteggi.xml";

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            timerGioco.Tick += timerGioco_Tick;
            timerFPS.Interval = 16; // ~60 FPS 
            timerFPS.Tick += (s, e) => panelGame.Invalidate();
            timerFPS.Start();
            CreaBottoniColore();
        }

        private void CreaBottoniColore()
        {
            // Array di 36 colori ordinati per spettro RGB (arcobaleno)
            Color[] colori = new Color[]
            {
                Color.Red, Color.Crimson, Color.OrangeRed, Color.DarkRed,
                Color.Orange, Color.DarkOrange, Color.Coral, Color.Tomato,
                Color.Yellow, Color.Gold, Color.Orange, Color.Goldenrod,
                Color.GreenYellow, Color.Lime, Color.LimeGreen, Color.Green,
                Color.DarkGreen, Color.ForestGreen, Color.SeaGreen, Color.Teal,
                Color.Cyan, Color.Aqua, Color.Turquoise, Color.DeepSkyBlue,
                Color.Blue, Color.DodgerBlue, Color.RoyalBlue, Color.Navy,
                Color.Indigo, Color.Purple, Color.BlueViolet, Color.DarkViolet,
                Color.Magenta, Color.Violet, Color.Orchid, Color.Pink
            };

            int startX = 200;
            int startY = 150;
            int btnWidth = 100;
            int btnHeight = 60;
            int spacing = 10;
            int colonne = 6;

            // Crea dinamicamente 36 bottoni disposti in griglia (6 colonne)
            for (int i = 0; i < colori.Length; i++)
            {
                Button btn = new Button
                {
                    BackColor = colori[i],
                    FlatStyle = FlatStyle.Flat,
                    Width = btnWidth,
                    Height = btnHeight,
                    // Calcolo posizione in griglia: X = colonna, Y = riga
                    Left = startX + (i % colonne) * (btnWidth + spacing),  // i%6 = colonna (0-5)
                    Top = startY + (i / colonne) * (btnHeight + spacing),  // i/6 = riga (0-5)
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.BorderColor = Color.White;
                btn.Click += BtnColoreEGioca_Click;  // Tutti i bottoni chiamano la stessa funzione
                panelScegliColore.Controls.Add(btn);
            }
        }

        // Quando clicchi un colore: salva il colore e avvia il gioco
        private void BtnColoreEGioca_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                colSerpe = new SolidBrush(btn.BackColor);
            }
            MostraGioco();
            AvviaGioco();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AggiornaGriglia();
            CaricaClassifica();
            MostraMenu();
        }

        // ----- UI switching -----
        // Queste funzioni controllano quale schermata è visibile.
        // Solo UN pannello principale è visibile alla volta (Dock=Fill, come fogli impilati)
        private void MostraMenu()
        {
            panelMenu.Visible = true;
            panelGame.Visible = false;
            panelInfoLaterale.Visible = false;
            panelSalvataggi.Visible = false;
            panelDifficolta.Visible = false;
            panelScegliColore.Visible = false;
        }

        private void MostraDifficolta()
        {
            panelMenu.Visible = false;
            panelGame.Visible = false;
            panelInfoLaterale.Visible = false;
            panelSalvataggi.Visible = false;
            panelDifficolta.Visible = true;
            panelScegliColore.Visible = false;
        }

        private void MostraScegliColore()
        {
            panelMenu.Visible = false;
            panelGame.Visible = false;
            panelInfoLaterale.Visible = false;
            panelSalvataggi.Visible = false;
            panelDifficolta.Visible = false;
            panelScegliColore.Visible = true;
        }

        private void MostraGioco()
        {
            panelMenu.Visible = false;
            panelGame.Visible = true;
            panelInfoLaterale.Visible = true;  // Pannello laterale con info
            panelSalvataggi.Visible = false;
            panelDifficolta.Visible = false;
            panelScegliColore.Visible = false;
        }

        private void MostraSalvataggi()
        {
            panelMenu.Visible = false;
            panelGame.Visible = false;
            panelInfoLaterale.Visible = false;
            panelSalvataggi.Visible = true;
            panelDifficolta.Visible = false;
            panelScegliColore.Visible = false;
            CaricaListaSalvataggi();
        }

        // ----- Bottoni menu -----
        private void btnGioca_Click(object sender, EventArgs e)
        {
            MostraDifficolta();
        }

        private void btnDifficolta_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == btnFacile)
            {
                difficoltaScelta = "Facile";
                timerGioco.Interval = 150;
            }
            else if (btn == btnNormale)
            {
                difficoltaScelta = "Normale";
                timerGioco.Interval = 100;
            }
            else if (btn == btnDifficile)
            {
                difficoltaScelta = "Difficile";
                timerGioco.Interval = 50;
            }
            else if (btn == btnImpossibile)
            {
                difficoltaScelta = "Impossibile";
                timerGioco.Interval = 15;
            }
            MostraScegliColore();
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
            lblEsito.Visible = false;
            txtNome.Visible = false;
            txtNome.Text = "Inserisci nome";
            btnSalva.Visible = false;

            AggiornaGriglia();
            CreaCibo();

            // L'intervallo è già stato impostato in btnDifficolta_Click
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
            // FASE 1: Sposta tutti i segmenti (dal fondo verso la testa)
            // Ogni segmento prende la posizione del segmento davanti a lui
            for (int i = lung - 1; i > 0; i--)
            {
                serpe[i].x = serpe[i - 1].x;
                serpe[i].y = serpe[i - 1].y;
            }

            // FASE 2: Muovi la testa nella direzione corrente
            switch (verso)
            {
                case "sinistra": serpe[0].x--; break;
                case "destra": serpe[0].x++; break;
                case "su": serpe[0].y--; break;
                case "giu": serpe[0].y++; break;
            }

            // FASE 3: Controlla collisione con i MURI (fuori dalla griglia)
            if (serpe[0].x < 0 || serpe[0].y < 0 ||
                serpe[0].x >= larghMax || serpe[0].y >= altMax)
            {
                FinePartita();
                return;
            }

            // FASE 4: Controlla collisione con SE STESSO
            // Controlla se la testa (serpe[0]) tocca qualsiasi altro segmento
            for (int i = 1; i < lung; i++)
            {
                if (serpe[0].x == serpe[i].x && serpe[0].y == serpe[i].y)
                {
                    FinePartita();
                    return;
                }
            }

            // FASE 5: Controlla se ha MANGIATO IL CIBO
            if (serpe[0].x == cibo.x && serpe[0].y == cibo.y)
            {
                // Aggiungi un nuovo segmento in fondo al serpente
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
                CreaCibo();  // Genera nuovo cibo in posizione random
            }
        }

        private void FinePartita()
        {
            timerGioco.Stop();
            lblEsito.Text = $"Hai perso! Punti: {punti}";
            lblEsito.Visible = true;
            txtNome.Visible = true;
            btnSalva.Visible = true;
            txtNome.Focus();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (nome == "" || nome == "Inserisci nome") nome = "Anonimo";

            Punteggio p = new Punteggio
            {
                Nome = nome,
                Punti = punti,
                Data = DateTime.Now,
                Difficolta = difficoltaScelta
            };

            classifica.Aggiungi(p);
            SalvaClassifica();

            txtNome.Visible = false;
            txtNome.Text = "Inserisci nome";
            btnSalva.Visible = false;
            lblEsito.Visible = false;
            lblEsito.Text = "";
            MostraMenu();
        }

        // ----- Input -----

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Se sto scrivendo il nome, NON intercettare i tasti P e O
            if (txtNome.Visible && txtNome.Focused)
            {
                return;
            }

            // Se siamo nel gioco
            if (panelGame.Visible)
            {
                // Tasto P = torna al menu principale
                if (e.KeyCode == Keys.P)
                {
                    timerGioco.Stop();
                    MostraMenu();
                    return;
                }

                // Tasto O = cambia colore (riapre selezione colori)
                if (e.KeyCode == Keys.O)
                {
                    timerGioco.Stop();
                    MostraScegliColore();
                    return;
                }


                // --- Controlli movimento serpente ---
                // IMPORTANTE: impedisce di tornare indietro su se stesso!
                // Esempio: se vai a destra, NON puoi andare subito a sinistra
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
            int cell = 20;  // Dimensione di ogni cella in pixel

            // Colori dello sfondo a scacchiera (stile Game Boy)
            Color verdeChiaro = ColorTranslator.FromHtml("#aad751");
            Color verdeScuro = ColorTranslator.FromHtml("#a2d149");

            // FASE 1: Disegna sfondo a scacchiera
            for (int y = 0; y < altMax; y++)
            {
                for (int x = 0; x < larghMax; x++)
                {
                    // Checkerboard: (x+y) pari = chiaro, dispari = scuro
                    bool pari = (x + y) % 2 == 0;
                    using (Brush sfondo = new SolidBrush(pari ? verdeChiaro : verdeScuro))
                    {
                        g.FillRectangle(sfondo, new Rectangle(x * cell, y * cell, cell, cell));
                    }
                }
            }

            // FASE 2: Disegna OMBRA del serpente (effetto 3D semplice)
            // L'ombra è spostata di +2 pixel a destra e in basso
            for (int i = 0; i < lung; i++)
            {
                Rectangle rOmbra = new Rectangle(serpe[i].x * cell + 2, serpe[i].y * cell + 2, cell, cell);
                g.FillRectangle(Brushes.Black, rOmbra);
            }

            // FASE 3: Disegna SERPENTE con il colore scelto
            for (int i = 0; i < lung; i++)
            {
                Rectangle r = new Rectangle(serpe[i].x * cell, serpe[i].y * cell, cell, cell);
                g.FillRectangle(colSerpe, r);
            }
            
            // FASE 4: Disegna OMBRA della mela
            Rectangle rOmbraMela = new Rectangle(cibo.x * cell + 2, cibo.y * cell + 2, cell, cell);
            g.FillRectangle(Brushes.Black, rOmbraMela);

            // FASE 5: Disegna MELA (cibo)
            g.FillRectangle(Brushes.Red, new Rectangle(cibo.x * cell, cibo.y * cell, cell, cell));
        }


    }
}
