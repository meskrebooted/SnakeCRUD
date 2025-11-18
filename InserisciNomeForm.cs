using System;
using System.Windows.Forms;

public class InserisciNomeForm : Form
{
    public string NomeGiocatore { get; private set; }
    private TextBox textBox;
    private Button okButton;

    public InserisciNomeForm()
    {
        this.Text = "Inserisci il tuo nome";
        this.Width = 300;
        this.Height = 120;

        var label = new Label() { Text = "Nome:", Left = 10, Top = 20, Width = 50 };
        textBox = new TextBox() { Left = 70, Top = 18, Width = 200 };
        okButton = new Button() { Text = "OK", Left = 200, Top = 50, Width = 70 };
        okButton.Click += (s, e) => { NomeGiocatore = textBox.Text; this.DialogResult = DialogResult.OK; this.Close(); };

        this.Controls.Add(label);
        this.Controls.Add(textBox);
        this.Controls.Add(okButton);
        this.AcceptButton = okButton;
        this.StartPosition = FormStartPosition.CenterParent;
    }
}
