namespace SnakeForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerGioco = new System.Windows.Forms.Timer(this.components);
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.btnGioca = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.panelDifficolta = new System.Windows.Forms.Panel();
            this.lblScegliDifficolta = new System.Windows.Forms.Label();
            this.btnFacile = new System.Windows.Forms.Button();
            this.btnNormale = new System.Windows.Forms.Button();
            this.btnDifficile = new System.Windows.Forms.Button();
            this.btnImpossibile = new System.Windows.Forms.Button();
            this.panelScegliColore = new System.Windows.Forms.Panel();
            this.lblScegliColore = new System.Windows.Forms.Label();
            this.panelInfoLaterale = new System.Windows.Forms.Panel();
            this.lblPunti = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEsito = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.panelSalvataggi = new System.Windows.Forms.Panel();
            this.txtModificaNome = new System.Windows.Forms.TextBox();
            this.btnConfermaModifica = new System.Windows.Forms.Button();
            this.lblMessaggioClassifica = new System.Windows.Forms.Label();
            this.lstSalvataggi = new System.Windows.Forms.ListBox();
            this.btnEliminaSel = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnModificaSel = new System.Windows.Forms.Button();
            this.btnEliminaZeroPunti = new System.Windows.Forms.Button();
            this.panelGame = new SnakeForms.DoubleBufferedPanel();
            this.panelMenu.SuspendLayout();
            this.panelDifficolta.SuspendLayout();
            this.panelScegliColore.SuspendLayout();
            this.panelInfoLaterale.SuspendLayout();
            this.panelSalvataggi.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGioco
            // 
            this.timerGioco.Interval = 120;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelMenu.Controls.Add(this.lblTitolo);
            this.panelMenu.Controls.Add(this.btnGioca);
            this.panelMenu.Controls.Add(this.btnModifica);
            this.panelMenu.Controls.Add(this.btnEsci);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1000, 600);
            this.panelMenu.TabIndex = 2;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTitolo.Location = new System.Drawing.Point(320, 50);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(417, 65);
            this.lblTitolo.TabIndex = 3;
            this.lblTitolo.Text = "🐍 SNAKE GAME";
            // 
            // btnGioca
            // 
            this.btnGioca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGioca.FlatAppearance.BorderSize = 0;
            this.btnGioca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnGioca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGioca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioca.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnGioca.ForeColor = System.Drawing.Color.White;
            this.btnGioca.Location = new System.Drawing.Point(380, 170);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(240, 55);
            this.btnGioca.TabIndex = 0;
            this.btnGioca.Text = "▶ GIOCA";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(380, 240);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(240, 55);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "📊 PUNTEGGI";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEsci.FlatAppearance.BorderSize = 0;
            this.btnEsci.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEsci.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEsci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEsci.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnEsci.ForeColor = System.Drawing.Color.White;
            this.btnEsci.Location = new System.Drawing.Point(380, 310);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(240, 55);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "✖ ESCI";
            this.btnEsci.UseVisualStyleBackColor = false;
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // panelDifficolta
            // 
            this.panelDifficolta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelDifficolta.Controls.Add(this.lblScegliDifficolta);
            this.panelDifficolta.Controls.Add(this.btnFacile);
            this.panelDifficolta.Controls.Add(this.btnNormale);
            this.panelDifficolta.Controls.Add(this.btnDifficile);
            this.panelDifficolta.Controls.Add(this.btnImpossibile);
            this.panelDifficolta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDifficolta.Location = new System.Drawing.Point(0, 0);
            this.panelDifficolta.Name = "panelDifficolta";
            this.panelDifficolta.Size = new System.Drawing.Size(1000, 600);
            this.panelDifficolta.TabIndex = 7;
            this.panelDifficolta.Visible = false;
            // 
            // lblScegliDifficolta
            // 
            this.lblScegliDifficolta.AutoSize = true;
            this.lblScegliDifficolta.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblScegliDifficolta.ForeColor = System.Drawing.Color.White;
            this.lblScegliDifficolta.Location = new System.Drawing.Point(280, 80);
            this.lblScegliDifficolta.Name = "lblScegliDifficolta";
            this.lblScegliDifficolta.Size = new System.Drawing.Size(457, 59);
            this.lblScegliDifficolta.TabIndex = 0;
            this.lblScegliDifficolta.Text = "⚡ Scegli la difficoltà";
            // 
            // btnFacile
            // 
            this.btnFacile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnFacile.FlatAppearance.BorderSize = 0;
            this.btnFacile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnFacile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnFacile.ForeColor = System.Drawing.Color.White;
            this.btnFacile.Location = new System.Drawing.Point(320, 160);
            this.btnFacile.Name = "btnFacile";
            this.btnFacile.Size = new System.Drawing.Size(360, 70);
            this.btnFacile.TabIndex = 1;
            this.btnFacile.Text = "😊 FACILE (1x)";
            this.btnFacile.UseVisualStyleBackColor = false;
            this.btnFacile.Click += new System.EventHandler(this.btnDifficolta_Click);
            // 
            // btnNormale
            // 
            this.btnNormale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnNormale.FlatAppearance.BorderSize = 0;
            this.btnNormale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnNormale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormale.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnNormale.ForeColor = System.Drawing.Color.White;
            this.btnNormale.Location = new System.Drawing.Point(320, 245);
            this.btnNormale.Name = "btnNormale";
            this.btnNormale.Size = new System.Drawing.Size(360, 70);
            this.btnNormale.TabIndex = 2;
            this.btnNormale.Text = "😐 NORMALE (2x)";
            this.btnNormale.UseVisualStyleBackColor = false;
            this.btnNormale.Click += new System.EventHandler(this.btnDifficolta_Click);
            // 
            // btnDifficile
            // 
            this.btnDifficile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDifficile.FlatAppearance.BorderSize = 0;
            this.btnDifficile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDifficile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifficile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnDifficile.ForeColor = System.Drawing.Color.White;
            this.btnDifficile.Location = new System.Drawing.Point(320, 330);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(360, 70);
            this.btnDifficile.TabIndex = 3;
            this.btnDifficile.Text = "😈 DIFFICILE (3x)";
            this.btnDifficile.UseVisualStyleBackColor = false;
            this.btnDifficile.Click += new System.EventHandler(this.btnDifficolta_Click);
            // 
            // btnImpossibile
            // 
            this.btnImpossibile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnImpossibile.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnImpossibile.FlatAppearance.BorderSize = 3;
            this.btnImpossibile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnImpossibile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpossibile.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnImpossibile.ForeColor = System.Drawing.Color.Red;
            this.btnImpossibile.Location = new System.Drawing.Point(320, 415);
            this.btnImpossibile.Name = "btnImpossibile";
            this.btnImpossibile.Size = new System.Drawing.Size(360, 70);
            this.btnImpossibile.TabIndex = 4;
            this.btnImpossibile.Text = "😱 IMPOSSIBILE (6.7x)";
            this.btnImpossibile.UseVisualStyleBackColor = false;
            this.btnImpossibile.Click += new System.EventHandler(this.btnDifficolta_Click);
            // 
            // panelScegliColore
            // 
            this.panelScegliColore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelScegliColore.Controls.Add(this.lblScegliColore);
            this.panelScegliColore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScegliColore.Location = new System.Drawing.Point(0, 0);
            this.panelScegliColore.Name = "panelScegliColore";
            this.panelScegliColore.Size = new System.Drawing.Size(1000, 600);
            this.panelScegliColore.TabIndex = 6;
            this.panelScegliColore.Visible = false;
            // 
            // lblScegliColore
            // 
            this.lblScegliColore.AutoSize = true;
            this.lblScegliColore.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblScegliColore.ForeColor = System.Drawing.Color.White;
            this.lblScegliColore.Location = new System.Drawing.Point(300, 50);
            this.lblScegliColore.Name = "lblScegliColore";
            this.lblScegliColore.Size = new System.Drawing.Size(415, 51);
            this.lblScegliColore.TabIndex = 0;
            this.lblScegliColore.Text = "🎨 Scegli il tuo colore";
            // 
            // panelInfoLaterale
            // 
            this.panelInfoLaterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelInfoLaterale.Controls.Add(this.lblPunti);
            this.panelInfoLaterale.Controls.Add(this.lblHighScore);
            this.panelInfoLaterale.Controls.Add(this.label1);
            this.panelInfoLaterale.Controls.Add(this.lblEsito);
            this.panelInfoLaterale.Controls.Add(this.txtNome);
            this.panelInfoLaterale.Controls.Add(this.btnSalva);
            this.panelInfoLaterale.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelInfoLaterale.Location = new System.Drawing.Point(800, 0);
            this.panelInfoLaterale.Name = "panelInfoLaterale";
            this.panelInfoLaterale.Size = new System.Drawing.Size(200, 600);
            this.panelInfoLaterale.TabIndex = 5;
            this.panelInfoLaterale.Visible = false;
            // 
            // lblPunti
            // 
            this.lblPunti.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPunti.ForeColor = System.Drawing.Color.White;
            this.lblPunti.Location = new System.Drawing.Point(10, 10);
            this.lblPunti.Name = "lblPunti";
            this.lblPunti.Size = new System.Drawing.Size(180, 40);
            this.lblPunti.TabIndex = 0;
            this.lblPunti.Text = "Punti: 0";
            this.lblPunti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHighScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.lblHighScore.Location = new System.Drawing.Point(10, 140);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Padding = new System.Windows.Forms.Padding(10);
            this.lblHighScore.Size = new System.Drawing.Size(180, 80);
            this.lblHighScore.TabIndex = 5;
            this.lblHighScore.Text = "🏆 Record\r\n0\r\nNessuno";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(180, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "P - Torna al menu\r\nO - Cambia colore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEsito
            // 
            this.lblEsito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblEsito.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEsito.ForeColor = System.Drawing.Color.White;
            this.lblEsito.Location = new System.Drawing.Point(10, 230);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Padding = new System.Windows.Forms.Padding(5);
            this.lblEsito.Size = new System.Drawing.Size(180, 70);
            this.lblEsito.TabIndex = 1;
            this.lblEsito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEsito.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(10, 310);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(180, 25);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.Visible = false;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalva.ForeColor = System.Drawing.Color.White;
            this.btnSalva.Location = new System.Drawing.Point(10, 345);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(180, 35);
            this.btnSalva.TabIndex = 3;
            this.btnSalva.Text = "💾 Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // panelSalvataggi
            // 
            this.panelSalvataggi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelSalvataggi.Controls.Add(this.txtModificaNome);
            this.panelSalvataggi.Controls.Add(this.btnConfermaModifica);
            this.panelSalvataggi.Controls.Add(this.lblMessaggioClassifica);
            this.panelSalvataggi.Controls.Add(this.lstSalvataggi);
            this.panelSalvataggi.Controls.Add(this.btnEliminaSel);
            this.panelSalvataggi.Controls.Add(this.btnIndietro);
            this.panelSalvataggi.Controls.Add(this.btnModificaSel);
            this.panelSalvataggi.Controls.Add(this.btnEliminaZeroPunti);
            this.panelSalvataggi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalvataggi.Location = new System.Drawing.Point(0, 0);
            this.panelSalvataggi.Name = "panelSalvataggi";
            this.panelSalvataggi.Size = new System.Drawing.Size(1000, 600);
            this.panelSalvataggi.TabIndex = 1;
            this.panelSalvataggi.Visible = false;
            // 
            // txtModificaNome
            // 
            this.txtModificaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtModificaNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtModificaNome.Location = new System.Drawing.Point(150, 340);
            this.txtModificaNome.Name = "txtModificaNome";
            this.txtModificaNome.Size = new System.Drawing.Size(500, 29);
            this.txtModificaNome.TabIndex = 5;
            this.txtModificaNome.Visible = false;
            // 
            // btnConfermaModifica
            // 
            this.btnConfermaModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfermaModifica.FlatAppearance.BorderSize = 0;
            this.btnConfermaModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnConfermaModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfermaModifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfermaModifica.ForeColor = System.Drawing.Color.White;
            this.btnConfermaModifica.Location = new System.Drawing.Point(660, 340);
            this.btnConfermaModifica.Name = "btnConfermaModifica";
            this.btnConfermaModifica.Size = new System.Drawing.Size(190, 29);
            this.btnConfermaModifica.TabIndex = 6;
            this.btnConfermaModifica.Text = "✓ Conferma";
            this.btnConfermaModifica.UseVisualStyleBackColor = false;
            this.btnConfermaModifica.Visible = false;
            this.btnConfermaModifica.Click += new System.EventHandler(this.btnConfermaModifica_Click);
            // 
            // lblMessaggioClassifica
            // 
            this.lblMessaggioClassifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMessaggioClassifica.ForeColor = System.Drawing.Color.White;
            this.lblMessaggioClassifica.Location = new System.Drawing.Point(150, 440);
            this.lblMessaggioClassifica.Name = "lblMessaggioClassifica";
            this.lblMessaggioClassifica.Size = new System.Drawing.Size(700, 30);
            this.lblMessaggioClassifica.TabIndex = 4;
            this.lblMessaggioClassifica.Text = "";
            this.lblMessaggioClassifica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSalvataggi
            // 
            this.lstSalvataggi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lstSalvataggi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstSalvataggi.FormattingEnabled = true;
            this.lstSalvataggi.ItemHeight = 21;
            this.lstSalvataggi.Location = new System.Drawing.Point(150, 50);
            this.lstSalvataggi.Name = "lstSalvataggi";
            this.lstSalvataggi.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSalvataggi.Size = new System.Drawing.Size(700, 277);
            this.lstSalvataggi.TabIndex = 0;
            // 
            // btnEliminaSel
            // 
            this.btnEliminaSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminaSel.FlatAppearance.BorderSize = 0;
            this.btnEliminaSel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminaSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaSel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminaSel.ForeColor = System.Drawing.Color.White;
            this.btnEliminaSel.Location = new System.Drawing.Point(150, 380);
            this.btnEliminaSel.Name = "btnEliminaSel";
            this.btnEliminaSel.Size = new System.Drawing.Size(200, 45);
            this.btnEliminaSel.TabIndex = 1;
            this.btnEliminaSel.Text = "🗑 Elimina";
            this.btnEliminaSel.UseVisualStyleBackColor = false;
            this.btnEliminaSel.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnIndietro
            // 
            this.btnIndietro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnIndietro.FlatAppearance.BorderSize = 0;
            this.btnIndietro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnIndietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndietro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIndietro.ForeColor = System.Drawing.Color.White;
            this.btnIndietro.Location = new System.Drawing.Point(400, 380);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(200, 45);
            this.btnIndietro.TabIndex = 2;
            this.btnIndietro.Text = "⬅ Indietro";
            this.btnIndietro.UseVisualStyleBackColor = false;
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // btnModificaSel
            // 
            this.btnModificaSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModificaSel.FlatAppearance.BorderSize = 0;
            this.btnModificaSel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnModificaSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaSel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnModificaSel.ForeColor = System.Drawing.Color.White;
            this.btnModificaSel.Location = new System.Drawing.Point(650, 380);
            this.btnModificaSel.Name = "btnModificaSel";
            this.btnModificaSel.Size = new System.Drawing.Size(200, 45);
            this.btnModificaSel.TabIndex = 3;
            this.btnModificaSel.Text = "✏ Modifica";
            this.btnModificaSel.UseVisualStyleBackColor = false;
            this.btnModificaSel.Click += new System.EventHandler(this.btnModificaSel_Click);
            // 
            // btnEliminaZeroPunti
            // 
            this.btnEliminaZeroPunti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnEliminaZeroPunti.FlatAppearance.BorderSize = 0;
            this.btnEliminaZeroPunti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnEliminaZeroPunti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaZeroPunti.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminaZeroPunti.ForeColor = System.Drawing.Color.White;
            this.btnEliminaZeroPunti.Location = new System.Drawing.Point(150, 485);
            this.btnEliminaZeroPunti.Name = "btnEliminaZeroPunti";
            this.btnEliminaZeroPunti.Size = new System.Drawing.Size(700, 40);
            this.btnEliminaZeroPunti.TabIndex = 7;
            this.btnEliminaZeroPunti.Text = "🗑️ Elimina Tutti con 0 Punti";
            this.btnEliminaZeroPunti.UseVisualStyleBackColor = false;
            this.btnEliminaZeroPunti.Click += new System.EventHandler(this.btnEliminaZeroPunti_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(800, 600);
            this.panelGame.TabIndex = 0;
            this.panelGame.Visible = false;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            this.panelGame.Resize += new System.EventHandler(this.panelGame_Resize);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelInfoLaterale);
            this.Controls.Add(this.panelSalvataggi);
            this.Controls.Add(this.panelDifficolta);
            this.Controls.Add(this.panelScegliColore);
            this.Controls.Add(this.panelMenu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelDifficolta.ResumeLayout(false);
            this.panelDifficolta.PerformLayout();
            this.panelScegliColore.ResumeLayout(false);
            this.panelScegliColore.PerformLayout();
            this.panelInfoLaterale.ResumeLayout(false);
            this.panelInfoLaterale.PerformLayout();
            this.panelSalvataggi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGioco;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnEsci;
        private SnakeForms.DoubleBufferedPanel panelGame;
        private System.Windows.Forms.Panel panelInfoLaterale;
        private System.Windows.Forms.Label lblPunti;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblEsito;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Panel panelSalvataggi;
        private System.Windows.Forms.ListBox lstSalvataggi;
        private System.Windows.Forms.Button btnEliminaSel;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnModificaSel;
        private System.Windows.Forms.TextBox txtModificaNome;
        private System.Windows.Forms.Button btnConfermaModifica;
        private System.Windows.Forms.Label lblMessaggioClassifica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Panel panelDifficolta;
        private System.Windows.Forms.Label lblScegliDifficolta;
        private System.Windows.Forms.Button btnFacile;
        private System.Windows.Forms.Button btnNormale;
        private System.Windows.Forms.Button btnDifficile;
        private System.Windows.Forms.Button btnImpossibile;
        private System.Windows.Forms.Panel panelScegliColore;
        private System.Windows.Forms.Button btnEliminaZeroPunti;
        private System.Windows.Forms.Label lblScegliColore;
    }
}
