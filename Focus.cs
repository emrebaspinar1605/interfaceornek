namespace interfaceornek
{
    public class Focus : ICar
    {
        public Marka HangiMarkaArac─▒()
        {
            return Marka.Ford;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}