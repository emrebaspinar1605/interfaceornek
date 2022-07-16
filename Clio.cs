namespace interfaceornek
{
    public class Clio : ICar
    {
        public Marka HangiMarkaAracı()
        {
            return Marka.Reno;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Kırmızı;
        }
    }
}