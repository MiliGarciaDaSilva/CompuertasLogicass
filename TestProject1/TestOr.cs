namespace TestProject1;
using Compuertas_Logicas;

public class TestOr
{
    private Or _or;

    [SetUp]
    public void Setup()
    {
        _or = new Or(false, false);
    }

    [Test]
    public void OrOperarConFalseYFalse()
    { 
        Assert.IsFalse(_or.Operar());
    }

    [Test]
    public void OperarConTrueYTrue()
    {
        _or.Entradas = new List<bool> { true, true };
        Assert.IsTrue(_or.Operar());
    }

    [Test]
    public void OrAgregarEntrada()
    {
        Assert.That(_or.Entradas.Count, Is.EqualTo(2));
        _or.AgregarEntrada(false);
        Assert.That(_or.Entradas.Count, Is.EqualTo(3));
    }
}