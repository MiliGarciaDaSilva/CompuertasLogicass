namespace TestProject1;
using Compuertas_Logicas;

public class TestNot
{
    private Not _not;

    [SetUp]
    public void Setup()
    {
        _not = new Not(true);
    }

    [Test]
    public void NotOperarTrue()
    {
        Assert.IsFalse(_not.Operar());
    }

    [Test]
    public void NotOperarFalse()
    {
        _not.AgregarEntrada(false);
        Assert.IsTrue(_not.Operar());
    }
}