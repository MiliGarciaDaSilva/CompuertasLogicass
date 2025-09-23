namespace TestProject1;
using Compuertas_Logicas;

public class TestOr
{
    private Or or;

    [SetUp]
    public void Setup()
    {
        or = new Or(false, false);
    }

    [Test]
    public void OrOperarConFalseYFalse()
    { 
        Assert.IsFalse(or.Operar());
    }

    [Test]
    public void OperarConTrueYTrue()
    {
        or.Entradas = new List<bool> { true, true };
        Assert.IsTrue(or.Operar());
    }

    [Test]
    public void OrAgregarEntrada()
    {
        Assert.That(or.Entradas.Count, Is.EqualTo(2));
        or.AgregarEntrada(false);
        Assert.That(or.Entradas.Count, Is.EqualTo(3));
    }
}