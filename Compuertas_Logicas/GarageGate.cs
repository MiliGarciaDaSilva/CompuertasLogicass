namespace Compuertas_Logicas;

public class GarageGate(bool a, bool b, bool c)
{
    private bool A = a;
    private bool B = b;
    private bool C = c;

    public bool Operar()
    {
        Not not = new Not(this.B);
        Not not2 = new Not(this.A);
        
        And and = new And(this.A, this.B);
        and.AgregarEntrada(this.C);
        And and2 = new And(this.C, not.Operar());
        
        and2.AgregarEntrada(not2.Operar());
        
        Or or = new Or(and.Operar(), and2.Operar());
        
        if (or.Operar())
        {
            Console.WriteLine("La puerta se abrió!");
            return true;
        }
        Console.WriteLine("La puerta está cerrada :/");
        return false;
    }
}