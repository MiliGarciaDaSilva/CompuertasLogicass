namespace TestProject1;
using Compuertas_Logicas;

public class TestAnd
{
    private And _and;
    
    [SetUp] //crea una instancia de setup
    public void Setup()
    {
        _and = new And(true, true);
    }

    [Test]
    public void AndOperarConTrueYTrue()
    {
        Assert.IsTrue(_and.Operar());
    }

    [Test]
    public void AndOperarConFalseYTrue()
    {
        _and.AgregarEntrada(false);
        Assert.IsFalse(_and.Operar());
    }

    [Test]
    public void AndAgregarEntrada()
    {
        Assert.That(_and.Entradas.Count, Is.EqualTo(2));
        _and.AgregarEntrada(true);
        Assert.That(_and.Entradas.Count, Is.EqualTo(3));
    }

    [Test]
    public void AndConstructor()
    {
        _and = new And(true, true);
        Assert.That(_and.Entradas[0], Is.EqualTo(true));
        Assert.That(_and.Entradas[1], Is.EqualTo(true));
    }
}