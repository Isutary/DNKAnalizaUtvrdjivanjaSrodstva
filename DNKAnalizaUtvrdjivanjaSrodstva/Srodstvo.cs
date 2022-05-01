namespace DNKAnalizaUtvrdjivanjaSrodstva
{
    public enum Srodstva
    {
        Brat,
        PoluBrat,
        DjedUnuk,
        Ujak,
        PrviRodjaci,
        DrugiRodjaci,

    }
    public static class Srodstvo
    {
        private static double[] _k1 = { 0.25, 0.25, 0.25 };
        private static double[] _k2 = { 0.5, 0.25, 0 };
        private static double[] _k3 = { 0.75, 0.25, 0 };
        private static double[] _k4 = { 0.9375, 0.0625, 0 };

        public static double[] Vrati(Srodstva srodstva) {

            switch (srodstva) 
            { 
                case Srodstva.Brat:
                    return _k1;
                case Srodstva.PoluBrat:
                case Srodstva.DjedUnuk:
                case Srodstva.Ujak:
                    return _k2;
                case Srodstva.PrviRodjaci:
                    return _k3;
                case Srodstva.DrugiRodjaci:
                    return _k4;
                default:
                    throw new Exception("Pogresno srodstvo!");
            }
        }
    }
}
