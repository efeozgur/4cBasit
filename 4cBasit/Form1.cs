using System;
using System.Windows.Forms;
using DevLib.ModernUI;
namespace _4cBasit
{
    public partial class Form1 : DevLib.ModernUI.Forms.ModernForm
    {
        Kisiler kisi = new Kisiler();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisi.OkulSec = 1;
            kisi.altiYasKucuk = 1;
            kisi.altiYasBuyuk = 1;
            kisi.esYardimiVarmi = true;
            kisi.AgiGetir = 4;
            kisi.TopluSozlesmePrimiVarmi = false;
            kisi.SendikaVarmi = false;
            kisi.fazlaMesai = 50;
            label1.Text = kisi.SozlesmeTutari.ToString();
        }
    }
}
