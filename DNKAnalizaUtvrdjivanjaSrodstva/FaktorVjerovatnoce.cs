namespace DNKAnalizaUtvrdjivanjaSrodstva
{
    public static class FaktorVjerovatnoce
    {
        public static double Vrati((double, double) osobaA, (double, double) osobaB, double[] k, ILokus lokus)
        {

            if (osobaA.Item1 == osobaA.Item2)
            {
                if (osobaB.Item1 == osobaB.Item2)
                {
                    if (osobaA.Item1 == osobaB.Item2) return k[0] + (2 * k[1]) / lokus.Vrati(osobaA.Item1) + k[2] / (lokus.Vrati(osobaA.Item1) * lokus.Vrati(osobaA.Item1));
                    else return k[0];
                }
                else if (osobaA.Item1 == osobaB.Item1) return k[0] + k[1] / lokus.Vrati(osobaA.Item1);
                else return k[0];
            }
            else
            {
                if (osobaA.Item1 == osobaB.Item1)
                {
                    if (osobaA.Item2 == osobaB.Item2) return k[0] + ((k[1] * (lokus.Vrati(osobaA.Item1) + lokus.Vrati(osobaA.Item2)) / (2 * lokus.Vrati(osobaA.Item1) * lokus.Vrati(osobaA.Item2)) + k[2] / (2 * lokus.Vrati(osobaA.Item1) * lokus.Vrati(osobaA.Item2))));
                    else return k[0] + k[1] / (2 * lokus.Vrati(osobaA.Item1));
                }
                else return k[0];
            }
        }
    }
}
