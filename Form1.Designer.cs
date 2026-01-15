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
            this.panelGame = new SnakeForms.DoubleBufferedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPunti = new System.Windows.Forms.Label();
            this.lblEsito = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.panelSalvataggi = new System.Windows.Forms.Panel();
            this.lstSalvataggi = new System.Windows.Forms.ListBox();
            this.btnEliminaSel = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.btnModificaSel = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelGame.SuspendLayout();
            this.panelSalvataggi.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGioco
            // 
            this.timerGioco.Interval = 120;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.lblTitolo);
            this.panelMenu.Controls.Add(this.btnGioca);
            this.panelMenu.Controls.Add(this.btnModifica);
            this.panelMenu.Controls.Add(this.btnEsci);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 450);
            this.panelMenu.TabIndex = 2;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.lblTitolo.Location = new System.Drawing.Point(220, 50);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(360, 65);
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
            this.btnGioca.Location = new System.Drawing.Point(280, 170);
            this.btnGioca.Name = "btnGioca";
            this.btnGioca.Size = new System.Drawing.Size(240, 55);
            this.btnGioca.TabIndex = 0;
            this.btnGioca.Text = "▶ GIOCA";
            this.btnGioca.UseVisualStyleBackColor = false;
            this.btnGioca.Click += new System.EventHandler(this.btnGioca_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(280, 240);
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
            this.btnEsci.Location = new System.Drawing.Point(280, 310);
            this.btnEsci.Name = "btnEsci";
            this.btnEsci.Size = new System.Drawing.Size(240, 55);
            this.btnEsci.TabIndex = 2;
            this.btnEsci.Text = "✖ ESCI";
            this.btnEsci.UseVisualStyleBackColor = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(190, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "P - Abbandona\r\nO - Cambia colore";
            // 
            // lblPunti
            // 
            this.lblPunti.AutoSize = true;
            this.lblPunti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPunti.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPunti.ForeColor = System.Drawing.Color.White;
            this.lblPunti.Location = new System.Drawing.Point(10, 10);
            this.lblPunti.Name = "lblPunti";
            this.lblPunti.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblPunti.Size = new System.Drawing.Size(99, 35);
            this.lblPunti.TabIndex = 0;
            this.lblPunti.Text = "Punti: 0";
            // 
            // lblEsito
            // 
            this.lblEsito.AutoSize = true;
            this.lblEsito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblEsito.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblEsito.ForeColor = System.Drawing.Color.White;
            this.lblEsito.Location = new System.Drawing.Point(10, 60);
            this.lblEsito.Name = "lblEsito";
            this.lblEsito.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.lblEsito.Size = new System.Drawing.Size(30, 46);
            this.lblEsito.TabIndex = 1;
            this.lblEsito.Text = "";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNome.Location = new System.Drawing.Point(10, 120);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.Visible = false;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSalva.FlatAppearance.BorderSize = 0;
            this.btnSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalva.ForeColor = System.Drawing.Color.White;
            this.btnSalva.Location = new System.Drawing.Point(270, 118);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(150, 33);
            this.btnSalva.TabIndex = 3;
            this.btnSalva.Text = "💾 Salva";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Visible = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // panelSalvataggi
            // 
            this.panelSalvataggi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSalvataggi.Controls.Add(this.lstSalvataggi);
            this.panelSalvataggi.Controls.Add(this.btnEliminaSel);
            this.panelSalvataggi.Controls.Add(this.btnIndietro);
            this.panelSalvataggi.Controls.Add(this.btnModificaSel);
            this.panelSalvataggi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalvataggi.Location = new System.Drawing.Point(0, 0);
            this.panelSalvataggi.Name = "panelSalvataggi";
            this.panelSalvataggi.Size = new System.Drawing.Size(800, 450);
            this.panelSalvataggi.TabIndex = 1;
            this.panelSalvataggi.Visible = false;
            // 
            // lstSalvataggi
            // 
            this.lstSalvataggi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lstSalvataggi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lstSalvataggi.FormattingEnabled = true;
            this.lstSalvataggi.ItemHeight = 21;
            this.lstSalvataggi.Location = new System.Drawing.Point(50, 50);
            this.lstSalvataggi.Name = "lstSalvataggi";
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
            this.btnEliminaSel.Location = new System.Drawing.Point(50, 360);
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
            this.btnIndietro.Location = new System.Drawing.Point(300, 360);
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
            this.btnModificaSel.Location = new System.Drawing.Point(550, 360);
            this.btnModificaSel.Name = "btnModificaSel";
            this.btnModificaSel.Size = new System.Drawing.Size(200, 45);
            this.btnModificaSel.TabIndex = 3;
            this.btnModificaSel.Text = "✏ Modifica";
            this.btnModificaSel.UseVisualStyleBackColor = false;
            this.btnModificaSel.Click += new System.EventHandler(this.btnModificaSel_Click);
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
            this.panelMenu.PerformLayout();
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
        private SnakeForms.DoubleBufferedPanel panelGame;
        private System.Windows.Forms.Label lblPunti;
        private System.Windows.Forms.Label lblEsito;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Panel panelSalvataggi;
        private System.Windows.Forms.ListBox lstSalvataggi;
        private System.Windows.Forms.Button btnEliminaSel;
        private System.Windows.Forms.Button btnIndietro;
        private System.Windows.Forms.Button btnModificaSel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitolo;
    }
}
