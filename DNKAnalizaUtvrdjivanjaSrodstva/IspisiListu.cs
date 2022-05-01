namespace DNKAnalizaUtvrdjivanjaSrodstva
{
    public static class IspisiListu
    {
        public static void Ispis(double[] lista)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (i == 0) Console.Write("[ " + lista[i] + ", ");
                else if (i == lista.Length - 1) Console.Write(lista[i] + "]");
                else Console.Write(lista[i] + ", ");
            }
        }
    }
}
