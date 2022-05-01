namespace DNKAnalizaUtvrdjivanjaSrodstva // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            (double, double)[] listaLokusaOsobeA = { (13, 17), (10, 21), (10, 14), (11, 13), (9, 9), (11, 12), (12, 13), (0, 0), (10, 10), (6, 9.3), (0, 0), (0, 0), (0, 7.3), (9, 12), (8, 11), (12, 14), (0, 0), (0, 0), (17, 17), (11, 16) };
            (double, double)[] listaLokusaOsobeB = { (15, 17), (11, 15.3), (11, 14), (11, 13), (9, 9), (11, 11), (12, 13), (25, 25), (10, 12), (6, 7), (18, 18), (29, 31), (9, 9.3), (10, 13), (8, 11), (11, 13), (20.3, 20.3), (12, 12), (22, 25), (0, 0) };

            Osoba A = new Osoba(listaLokusaOsobeA);
            Osoba B = new Osoba(listaLokusaOsobeB);

            ILokus[] sviLokusi = {
                new D3S1358(),
                new D1S1656(),
                new D2S441(),
                new D10S1248(),
                new D13S317(),
                new D16S539(),
                new D18S51(),
                new D2S1338(),
                new CSF1PO(),
                new TH01(),
                new Vwa(),
                new D21S11(),
                new D7S820(),
                new D5S818(),
                new TPOX(),
                new D8S1179(),
                new D12S391(),
                new D19S433(),
                new FGA(),
                new D22S1045()
            };

            foreach (Srodstva srodstva in Enum.GetValues(typeof(Srodstva)))
            {
                double[] k = Srodstvo.Vrati(srodstva);
                double proizvodLokusa = 1;
                for (int i = 0; i < sviLokusi.Length; i++) proizvodLokusa *= FaktorVjerovatnoce.Vrati(A.AlelneVrijednosti[i], B.AlelneVrijednosti[i], k, sviLokusi[i]);
                var OLR = proizvodLokusa / (proizvodLokusa + 1);
                Console.WriteLine($"{srodstva} " + OLR * 100 + "%");
            }
        }
    }
}