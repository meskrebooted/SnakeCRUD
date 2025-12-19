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
            this.btnGioca = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnEsci = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.lblPunti = new System.Windows.Forms.Label();
            this.lblEsito = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.panelSalvataggi = new System.Windows.Forms.Panel();
            this.lstSalvataggi = new System.Windows.Forms.ListBox();
            this.btnEliminaSel = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.panelSalvataggi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnGioca);
            this.panelMenu.Controls.Add(this.btnModifica);
            this.panelMenu.Controls.Add(this.btnEsci);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 450);
            this.panelMenu.TabIndex = 2;
            // 
            // btnGioca
            // 
            this.btnGioca.Location = new System.Drawing.Point(20, 20);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(160, 30);
            this.btnGioca.TabIndex = 0;
            this.btnGioca.Text = "Gioca";
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(20, 60);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(160, 30);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica/Elimina salvataggi";
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnEsci
            // 
            this.btnEsci.Location = new System.Drawing.Point(20, 100);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(160, 30);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "Esci";
            this.btnEsci.Click += new System.EventHandler(this.btnEsci_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.White;
            this.panelGame.Controls.Add(this.label1);
            this.panelGame.Controls.Add(this.lblPunti);
            this.panelGame.Controls.Add(this.lblEsito);
            this.panelGame.Controls.Add(this.txtNome);
            this.panelGame.Controls.Add(this.btnSalva);
            this.panelGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGame.Location = new System.Drawing.Point(0, 0);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(800, 450);
            this.panelGame.TabIndex = 0;
            this.panelGame.Visible = false;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            this.panelGame.Resize += new System.EventHandler(this.panelGame_Resize);
            // 
            // lblPunti
            // 
            this.lblPunti.AutoSize = true;
            this.lblPunti.Location = new System.Drawing.Point(10, 10);
            this.lblPunti.Name = "lblPunti";
            this.lblPunti.Size = new System.Drawing.Size(43, 13);
            this.lblPunti.TabIndex = 0;
            this.lblPunti.Text = "Punti: 0";
            // 
            // lblEsito
            // 
            this.lblEsito.AutoSize = true;
            this.lblEsito.Location = new System.Drawing.Point(10, 40);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Size = new System.Drawing.Size(0, 13);
            this.lblEsito.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Visible = false;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(220, 68);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(120, 24);
            this.btnSalva.TabIndex = 3;
            this.btnSalva.Text = "Salva punteggio";
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // panelSalvataggi
            // 
            this.panelSalvataggi.Controls.Add(this.lstSalvataggi);
            this.panelSalvataggi.Controls.Add(this.btnEliminaSel);
            this.panelSalvataggi.Controls.Add(this.btnIndietro);
            this.panelSalvataggi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalvataggi.Location = new System.Drawing.Point(0, 0);
            this.panelSalvataggi.Name = "panelSalvataggi";
            this.panelSalvataggi.Size = new System.Drawing.Size(800, 450);
            this.panelSalvataggi.TabIndex = 1;
            this.panelSalvataggi.Visible = false;
            // 
            // lstSalvataggi
            // 
            this.lstSalvataggi.Location = new System.Drawing.Point(10, 10);
            this.lstSalvataggi.Name = "lstSalvataggi";
            this.lstSalvataggi.Size = new System.Drawing.Size(450, 355);
            this.lstSalvataggi.TabIndex = 0;
            // 
            // btnEliminaSel
            // 
            this.btnEliminaSel.Location = new System.Drawing.Point(10, 380);
            this.btnEliminaSel.Name = "btnEliminaSel";
            this.btnEliminaSel.Size = new System.Drawing.Size(160, 30);
            this.btnEliminaSel.TabIndex = 1;
            this.btnEliminaSel.Text = "Elimina selezionato";
            this.btnEliminaSel.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(180, 380);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(160, 30);
            this.btnIndietro.TabIndex = 2;
            this.btnIndietro.Text = "Indietro";
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Premi \"P\" per abbandonare\r\nPremi \"O\" per cambiare colore\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelSalvataggi);
            this.Controls.Add(this.panelMenu);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelMenu.ResumeLayout(false);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelSalvataggi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGioco;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnGioca;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnEsci;

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label lblPunti;
        private System.Windows.Forms.Label lblEsito;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalva;

        private System.Windows.Forms.Panel panelSalvataggi;
        private System.Windows.Forms.ListBox lstSalvataggi;
        private System.Windows.Forms.Button btnEliminaSel;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Panel panelPausa;
        private System.Windows.Forms.ListBox lstClassifica;
        private System.Windows.Forms.Button btnRiprendi;
        private System.Windows.Forms.Button btnPausaColor;
        private System.Windows.Forms.Button btnPausaMenu;
        private System.Windows.Forms.Label label1;
    }
}
