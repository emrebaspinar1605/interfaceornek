namespace interfaceornek
{
    public abstract class Car
    {
        public int KacTekerlektenOlusur()
        { return 4;}

        public virtual Renk StandartRengi(){
            return Renk.Beyaz;
        }
        public abstract Marka HangiMarkanınAraci();
    }
}