namespace interfaceornek
{
    public class Civic : ICar
    {
        public Marka HangiMarkaArac─▒()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}