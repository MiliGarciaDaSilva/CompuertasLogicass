namespace TestProject1;
using Compuertas_Logicas;

public class TestAnd
{
    private And and;
    
    [SetUp] //crea una instancia de setup
    public void Setup()
    {
        and = new And(true, true);
    }

    [Test]
    public void AndOperarConTrueYTrue()
    {
        Assert.IsTrue(and.Operar());
    }

    [Test]
    public void AndOperarConFalseYTrue()
    {
        and.AgregarEntrada(false);
        Assert.IsFalse(and.Operar());
    }

    [Test]
    public void AndAgregarEntrada()
    {
        Assert.That(2, Is.EqualTo(and.Entradas.Count));
        and.AgregarEntrada(true);
        Assert.That(3, Is.EqualTo(and.Entradas.Count));
    }

    [Test]
    public void AndConstructor()
    {
        and = new And(true, true);
        Assert.That(and.Entradas[0], Is.EqualTo(true));
        Assert.That(and.Entradas[1], Is.EqualTo(true));
    }
}