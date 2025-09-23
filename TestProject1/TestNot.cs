namespace TestProject1;
using Compuertas_Logicas;

public class TestNot
{
    private Not not;

    [SetUp]
    public void Setup()
    {
        not = new Not(true);
    }

    [Test]
    public void NotOperarTrue()
    {
        Assert.IsFalse(not.Operar());
    }

    [Test]
    public void NotOperarFalse()
    {
        not.AgregarEntrada(false);
        Assert.IsTrue(not.Operar());
    }
}