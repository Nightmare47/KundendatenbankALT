using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundenverwaltungV1
{
    public partial class Form1 : Form
    {
        public struct Kundendaten
        {
            public int Kundennummer;
            public string Vorname;
            public string Nachname;
            public int Postleitzahl;
            public string Wohnort;
            public string Telefonnummer;
            public string Faxnummer;
            public string Emailadresse;
            public string Land;
            public string Sprache;
        }

        int a = 0;
        int schlusswert = 0;


        Kundendaten[] Kundendatenbank = new Kundendaten[210];

        public void Lesen()
        {
            System.IO.StreamReader datensatz;
            datensatz = new System.IO.StreamReader("Kundendatensaetze.txt");
            schlusswert = Convert.ToInt32(datensatz.ReadLine());
            for (int b = 0; b < schlusswert; b++)
            {
                Kundendatenbank[b].Kundennummer = Convert.ToInt32(datensatz.ReadLine());
                Kundendatenbank[b].Vorname = datensatz.ReadLine();
                Kundendatenbank[b].Nachname = datensatz.ReadLine();
                Kundendatenbank[b].Postleitzahl = Convert.ToInt32(datensatz.ReadLine());
                Kundendatenbank[b].Wohnort = datensatz.ReadLine();
                Kundendatenbank[b].Telefonnummer = datensatz.ReadLine();
                Kundendatenbank[b].Faxnummer = datensatz.ReadLine();
                Kundendatenbank[b].Emailadresse = datensatz.ReadLine();
                Kundendatenbank[b].Land = datensatz.ReadLine();
                Kundendatenbank[b].Sprache = datensatz.ReadLine();
            }
            datensatz.Close();
        }

        public void Schreiben()
        {
            int z;
            System.IO.StreamWriter Kundendatzensatze;
            Kundendatzensatze = new System.IO.StreamWriter("Kundendatensaetze.txt");
            Kundendatzensatze.WriteLine(schlusswert);
            for (z = 0; z < schlusswert; z++)

            {
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Kundennummer);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Vorname);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Nachname);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Postleitzahl);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Wohnort);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Telefonnummer);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Faxnummer);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Emailadresse);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Land);
                Kundendatzensatze.WriteLine(Kundendatenbank[z].Sprache);
            }
            Kundendatzensatze.Close();
        }

        public void Anzeigen()
        {
            textBoxKundenNr.Text = Convert.ToString(Kundendatenbank[a].Kundennummer);
            textBoxVorName.Text = Kundendatenbank[a].Vorname;
            textBoxNachName.Text = Kundendatenbank[a].Nachname;
            textBoxPLZ.Text = Convert.ToString(Kundendatenbank[a].Postleitzahl);
            textBoxOrt.Text = Kundendatenbank[a].Wohnort;
            textBoxTelefonnummer.Text = Kundendatenbank[a].Telefonnummer;
            textBoxFax.Text = Kundendatenbank[a].Faxnummer;
            textBoxEmail.Text = Kundendatenbank[a].Emailadresse;
            textBoxLand.Text = Kundendatenbank[a].Land;
            textBoxSprache.Text = Kundendatenbank[a].Sprache;
        }

        public void Loeschen()
        {
            textBoxKundenNr.Text = "";
            textBoxVorName.Text = "";
            textBoxNachName.Text = "";
            textBoxPLZ.Text = "";
            textBoxTelefonnummer.Text = "";
            textBoxOrt.Text = "";
            textBoxFax.Text = "";
            textBoxEmail.Text = "";
            textBoxLand.Text = "";
            textBoxSprache.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            Kundendatenbank[a].Kundennummer = Convert.ToInt32(textBoxKundenNr.Text);
            Kundendatenbank[a].Vorname = textBoxVorName.Text;
            Kundendatenbank[a].Nachname = textBoxNachName.Text;
            Kundendatenbank[a].Postleitzahl = Convert.ToInt32(textBoxPLZ.Text);
            Kundendatenbank[a].Wohnort = textBoxOrt.Text;
            Kundendatenbank[a].Telefonnummer = textBoxTelefonnummer.Text;
            Kundendatenbank[a].Faxnummer = textBoxFax.Text;
            Kundendatenbank[a].Emailadresse = textBoxEmail.Text;
            Kundendatenbank[a].Land = textBoxEmail.Text;
            Kundendatenbank[a].Sprache = textBoxEmail.Text;
            buttonSpeichern.Enabled = false;
        }

        private void buttonAendern_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            textBoxKundenNr.Text = "";
            textBoxVorName.Text = "";
            textBoxNachName.Text = "";
            textBoxPLZ.Text = "";
            textBoxOrt.Text = "";
            textBoxTelefonnummer.Text = "";
            textBoxFax.Text = "";
            textBoxEmail.Text = "";
            textBoxLand.Text = "";
            textBoxSprache.Text = "";
        }

        private void buttonAnfang_Click(object sender, EventArgs e)
        {
            a = 0;
            Anzeigen();
        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            a = Kundendatenbank.Length -1;
            Anzeigen();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            if (a > 0)
            {
                a = a - 1;
            }
            Anzeigen();
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            if (a < Kundendatenbank.Length - 1)
            {
                a = a + 1;
            }
            Anzeigen();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            Loeschen();
            a = schlusswert;
            textBoxKundenNr.Text = Convert.ToString(a);
            buttonSpeichern.Enabled = true;
            schlusswert = schlusswert + 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSpeichern.Enabled = false;
        }

        private void ButtonLaden_Click(object sender, EventArgs e)
        {
            Lesen();
            Anzeigen();
        }

        private void ButtonSchreiben_Click(object sender, EventArgs e)
        {
            Schreiben();
        }

        private void Buttonallesloeschen_Click(object sender, EventArgs e)
        {
            DialogResult Ergebnis1 = MessageBox.Show("Möchten Sie wirklich alle Datensätze löschen?",
              "Alle Datensätze löschen",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2);

            if (Ergebnis1 == DialogResult.Yes)
            {
                Kundendatenbank = new Kundendaten[210];
                a = 0;
                schlusswert = 0;
                Loeschen();
                buttonSpeichern.Enabled = false;
            }
        }
    }
}
