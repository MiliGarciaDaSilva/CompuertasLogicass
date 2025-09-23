using System.ComponentModel;

namespace Compuertas_Logicas;

class Program
{
    static void Main(string[] args)
    {
        /*
        And and = new And(true, true);
        Console.WriteLine("And de true + true : " + and.Operar());
        
        and.AgregarEntrada(false);
        Console.WriteLine("And de true + true + false : " +  and.Operar());

        Or or = new Or(false, false);
        Console.WriteLine("Or de false + false : " + or.Operar());
        
        or.AgregarEntrada(true);
        Console.WriteLine("Or de false + false + true : " + or.Operar());

        Not not = new Not(true);
        Console.WriteLine("Not de true : " + not.Operar());
        
        not.AgregarEntrada(false);
        Console.WriteLine("Not de false : " + not.Operar());
        */

        GarageGate garage = new GarageGate(true, true, true);
        garage.Operar();
        
        GarageGate garage2 = new GarageGate(false, true, true);
        garage2.Operar();
        
        GarageGate garage3 = new GarageGate(false, false, true);
        garage3.Operar();
    }
}