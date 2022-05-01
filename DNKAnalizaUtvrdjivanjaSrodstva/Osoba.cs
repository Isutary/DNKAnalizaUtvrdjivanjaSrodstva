namespace DNKAnalizaUtvrdjivanjaSrodstva
{
    public class Osoba
    {
        public (double, double) D3S1358 { get; set; }
        public (double, double) D1S1656 { get; set; }
        public (double, double) D2S441 { get; set; }
        public (double, double) D10S1248 { get; set; }
        public (double, double) D13S317 { get; set; }
        public (double, double) D16S539 { get; set; }
        public (double, double) D18S51 { get; set; }
        public (double, double) D2S1338 { get; set; }
        public (double, double) CSF1PO { get; set; }
        public (double, double) TH01 { get; set; }
        public (double, double) Vwa { get; set; }
        public (double, double) D21S11 { get; set; }
        public (double, double) D7S820 { get; set; }
        public (double, double) D5S818 { get; set; }
        public (double, double) TPOX { get; set; }
        public (double, double) D8S1179 { get; set; }
        public (double, double) D12S391 { get; set; }
        public (double, double) D19S433 { get; set; }
        public (double, double) FGA { get; set; }
        public (double, double) D22S1045 { get; set; }

        public (double, double)[] AlelneVrijednosti { get; set; }

        public Osoba((double, double)[] listaLokusa)
        {
            AlelneVrijednosti = listaLokusa;
            D3S1358 = listaLokusa[0];
            D1S1656 = listaLokusa[1];
            D2S441 = listaLokusa[2];
            D10S1248 = listaLokusa[3];
            D13S317 = listaLokusa[4];
            D16S539 = listaLokusa[5];
            D18S51 = listaLokusa[6];
            D2S1338 = listaLokusa[7];
            CSF1PO = listaLokusa[8];
            TH01 = listaLokusa[9];
            Vwa = listaLokusa[10];
            D21S11 = listaLokusa[11];
            D7S820 = listaLokusa[12];
            D5S818 = listaLokusa[13];
            TPOX = listaLokusa[14];
            D8S1179 = listaLokusa[15];
            D12S391 = listaLokusa[16];
            D19S433 = listaLokusa[17];
            FGA = listaLokusa[18];
            D22S1045 = listaLokusa[19];
        }
    }
}
