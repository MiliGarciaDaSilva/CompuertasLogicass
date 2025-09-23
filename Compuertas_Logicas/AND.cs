namespace Compuertas_Logicas;

public class And : ICompuerta
{
    public List<bool> Entradas = new List<bool>();
    
    public And(bool entrada1, bool entrada2)
    {
        this.Entradas.Add(entrada1);
        this.Entradas.Add(entrada2);
    }
    
    public bool Operar()
    {
        if (this.Entradas.Contains(false))
        {
            return false;
        }
        return true;
    }
    
    public void AgregarEntrada(bool entrada)
    {
        this.Entradas.Add(entrada);
    }
}