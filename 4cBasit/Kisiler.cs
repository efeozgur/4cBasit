namespace _4cBasit
{
    class Kisiler
    {
        public int CalistigiGunSayisi { get; set; }

        public int OkulSec { get; set; }
        public float fazlaMesai { get; set; }
        public float SozlesmeTutari
        {
            get
            {
                if (OkulSec == 1)
                    return Sabitler.MemurMaasKatsayisi * Sabitler.ilkogretim;
                else if (OkulSec == 2)
                    return Sabitler.MemurMaasKatsayisi * Sabitler.Lise;
                else if (OkulSec == 3)
                    return Sabitler.MemurMaasKatsayisi * Sabitler.Yuksekokul;
                else return 0;
                    
            }
        }

        public float BrutUcretTahakkuk
        {
            get { return SozlesmeTutari + sgkisveren + topluSozlesmePrimi + esYardimi + cocukYardimi+fazlaMesai+ekOdeme; }
        }
        public bool esYardimiVarmi { get; set; }
        public bool TopluSozlesmePrimiVarmi { get; set; }
        public bool SendikaVarmi { get; set; }

        public int altiYasBuyuk { get; set; }
        public int altiYasKucuk { get; set; }

        public float sgkMatrahinaDahilCocukistisna
        {
            get
            {
                if (altiYasKucuk > 0 && altiYasKucuk <= 2)
                    return altiYasKucuk * Sabitler.CocukZamistisnasi;
                else return 0;
            }
        }

        public float sgkPrimineEsasAylikKazanc
        {
            get { return SozlesmeTutari + sgkMatrahinaDahilCocukistisna+fazlaMesai; }
        }

        public float sgkisci
        {
            get { return sgkPrimineEsasAylikKazanc * Sabitler.sgkIsciOran/100; }
        }

        public float sgkisveren
        {
            get { return sgkPrimineEsasAylikKazanc * Sabitler.sgkIsverenOran / 100; }
        }

        public float cocukYardimi
        {
            get { return altiYasBuyuk * (Sabitler.altiYasUzeri * Sabitler.MemurMaasKatsayisi) + altiYasKucuk * (Sabitler.altiYasAsagi*Sabitler.MemurMaasKatsayisi); }
        }
        public float esYardimi
        {
            get
            {
                if (esYardimiVarmi)
                    return Sabitler.AileYardimGostergesi * Sabitler.MemurMaasKatsayisi;
                else return 0;

            }
        }

        public float AgiGetir { get; set; }

        public float AGI
        {
            get
            {
                if (AgiGetir == 1)
                    return Sabitler.bekar;
                else if (AgiGetir == 2)
                    return Sabitler.escalismayan;
                else if (AgiGetir == 3)
                    return Sabitler.escalismayan1;
                else if (AgiGetir == 4)
                    return Sabitler.escalismayan2;
                else if (AgiGetir == 5)
                    return Sabitler.escalismayan3;
                else if (AgiGetir == 6)
                    return Sabitler.escalisan;
                else if (AgiGetir == 7)
                    return Sabitler.escalisan1;
                else if (AgiGetir == 8)
                    return Sabitler.escalisan2;
                else if (AgiGetir == 9)
                    return Sabitler.escalisan3;
                else if (AgiGetir == 10)
                    return Sabitler.escalisan4;
                else if (AgiGetir == 11)
                    return Sabitler.escalisan5;
                else return 0;
                    
            }
        } 


        public float topluSozlesmePrimi
        {
            get
            {
                if (TopluSozlesmePrimiVarmi)
                    return Sabitler.topluSozlesmePrimUcreti;
                else return 0;
            }
        }



        public float sendikaAidati
        {
            get
            {
                if (SendikaVarmi)
                    return SozlesmeTutari * Sabitler.SendikaAidatOrani;
                else return 0;
            }
        }

        public float GelirVergisiMatrahi
        {
            get { return (sgkPrimineEsasAylikKazanc - sgkisci) + (esYardimi + cocukYardimi) - sendikaAidati; }
        }

        public float GelirVergisi
        {
            get { return GelirVergisiMatrahi * 15 / 100; }
        }

        public float AsilGelirVergisi
        {
            get { return GelirVergisi - AGI; }
        }

        public float DamgaVergisi
        {
            get { return (SozlesmeTutari + cocukYardimi + esYardimi + topluSozlesmePrimi+ekOdeme)*Sabitler.DamgaVergisiOrani/1000; }
        }

        public float icraKesintisi { get; set; }
        public float NafakaKesintisi { get; set; }


        public float kesintiToplami
        {
            get { return sgkisci + sgkisveren + DamgaVergisi + GelirVergisi + sendikaAidati + icraKesintisi + NafakaKesintisi; }
        }

        public float netOdenen
        {
            get { return BrutUcretTahakkuk + AGI - kesintiToplami; }
        }

        public float ekOdeme
        {
            get { return Sabitler.ekOdemeOrani * Sabitler.MemurMaasKatsayisi; }
        }
    }
}
