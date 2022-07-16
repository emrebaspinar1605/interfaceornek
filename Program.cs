using System;

namespace interfaceornek
{
    public class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("******** Interface ********");
        Civic civ=new Civic();
        Console.WriteLine(civ.HangiMarkaAracı());
        Console.WriteLine(civ.KacTekerlektenOlusur().ToString());
        Console.WriteLine(civ.StandartRengiNe());

        Focus focus=new Focus();
        Console.WriteLine(focus.HangiMarkaAracı());
        Console.WriteLine(focus.StandartRengiNe());
        Console.WriteLine(focus.KacTekerlektenOlusur().ToString());

        Console.WriteLine("******** Abstract ********");
        
        NewClio clio=new NewClio();
        Console.WriteLine(clio.KacTekerlektenOlusur().ToString());
        Console.WriteLine(clio.StandartRengi());
        Console.WriteLine(clio.HangiMarkanınAraci());
        
        NewCivic civic =new NewCivic();
        Console.WriteLine(civic.HangiMarkanınAraci());
        Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
        Console.WriteLine(civic.StandartRengi());

        NewFocus focus1=new NewFocus();
        Console.WriteLine(focus1.HangiMarkanınAraci());
        Console.WriteLine(focus1.StandartRengi());
        Console.WriteLine(focus1.KacTekerlektenOlusur().ToString());
        }
    }
}