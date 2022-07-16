namespace interfaceornek
{
    public class NewFocus : Car
    {
        public override Marka HangiMarkanınAraci()
        {
            return Marka.Ford;
        }
        public override Renk StandartRengi()
        {
            return Renk.Gri;
        }
    }
}