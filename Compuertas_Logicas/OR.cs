namespace Compuertas_Logicas;

public class Or : ICompuerta
{   
    public List<bool> Entradas = new List<bool>();
    
    public Or(bool entrada1,  bool entrada2 )
    {
        this.Entradas.Add(entrada1);
        this.Entradas.Add(entrada2);
    }
    
    public bool Operar()
    {
        if (this.Entradas.Contains(true))
        {
            return true;
        }
        return false;
    }
    
    public void AgregarEntrada(bool entrada)
    {
        this.Entradas.Add(entrada);
    }
}