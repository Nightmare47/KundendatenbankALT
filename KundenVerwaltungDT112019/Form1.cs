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
        public struct TKunde
        {
            public int kundenNr;
            public string vorname;
            public string nachname;
            public int plz;
            public string ort;
            public int telefonnummer;
            public int fax;
            public string email;
        }

        TKunde meinKunde;
        int i = 0;
        int letzter = 0;


        TKunde []kundenDB = new TKunde[100];

        public void schreiben()
        {
            int z;
            System.IO.StreamWriter meineDatei;
            meineDatei = new System.IO.StreamWriter("kundendaten.txt");
            meineDatei.WriteLine(letzter);
            for (z = 0; z < letzter; z++)

            {
                meineDatei.WriteLine(kundenDB[z].kundenNr);
                meineDatei.WriteLine(kundenDB[z].vorname);
                meineDatei.WriteLine(kundenDB[z].nachname);
                meineDatei.WriteLine(kundenDB[z].plz);
                meineDatei.WriteLine(kundenDB[z].ort);
                meineDatei.WriteLine(kundenDB[z].telefonnummer);
                meineDatei.WriteLine(kundenDB[z].fax);
                meineDatei.WriteLine(kundenDB[z].email);
            }
            meineDatei.Close();
        }

        public void anzeigen()
        {
            textBoxKundenNr.Text = Convert.ToString(kundenDB[i].kundenNr);
            textBoxVorName.Text = kundenDB[i].vorname;
            textBoxNachName.Text = kundenDB[i].nachname;
            textBoxPLZ.Text = Convert.ToString(kundenDB[i].plz);
            textBoxOrt.Text = kundenDB[i].ort;
            textBoxPLZ.Text = Convert.ToString(kundenDB[i].telefonnummer);
            textBoxPLZ.Text = Convert.ToString(kundenDB[i].fax);
            textBoxOrt.Text = kundenDB[i].email;
        }

        public void loeschen()
        {
            textBoxKundenNr.Text = "";
            textBoxVorName.Text = "";
            textBoxNachName.Text = "";
            textBoxPLZ.Text = "";
            textBoxTelefonnummer.Text = "";
            textBoxFax.Text = "";
            textBoxEmail.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBoxPLZ);

            kundenDB[i].kundenNr = Convert.ToInt32(textBoxKundenNr.Text);
            kundenDB[i].vorname = textBoxVorName.Text;
            kundenDB[i].nachname = textBoxNachName.Text;
            kundenDB[i].plz = Convert.ToInt32(textBoxPLZ.Text);
            kundenDB[i].ort = textBoxOrt.Text;
            kundenDB[i].telefonnummer = Convert.ToInt32(textBoxTelefonnummer.Text);
            kundenDB[i].fax = Convert.ToInt32(textBoxFax.Text);
            kundenDB[i].ort = textBoxEmail.Text;
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
        }

        private void buttonAnfang_Click(object sender, EventArgs e)
        {
            i = 0;
            anzeigen();
        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            i = 99;
            anzeigen();
        }

        private void buttonZurueck_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i = i - 1;
            }
            anzeigen();
        }

        private void buttonVor_Click(object sender, EventArgs e)
        {
            if (i< 99)
            {
                i = i + 1;
            }
            anzeigen();
        }

        private void buttonHinzufuegen_Click(object sender, EventArgs e)
        {
            loeschen();
            i = letzter;
            textBoxKundenNr.Text = Convert.ToString(i);
            buttonSpeichern.Enabled = true;
            letzter = letzter + 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSpeichern.Enabled = false;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
    }
}
