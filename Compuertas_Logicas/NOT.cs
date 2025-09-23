namespace Compuertas_Logicas;

public class Not : ICompuerta
{
    public bool Entrada;
    
    public Not(bool entrada)
    {
        this.Entrada = entrada;
    }
    
    public bool Operar()
    {
        return !this.Entrada;
    }
    
    public void AgregarEntrada(bool entrada)
    {
        this.Entrada = entrada;
    }
}