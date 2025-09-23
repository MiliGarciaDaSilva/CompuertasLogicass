namespace TestProject1;
using Compuertas_Logicas;

public class TestGarage
{
    private GarageGate garageAbierto;
    private GarageGate garageCerrado;
    
    [SetUp]
    public void Setup()
    {
        garageAbierto = new GarageGate(false, false, true);
        garageCerrado = new GarageGate(false, false, false);
    }

    [Test]

    public void GarageAbierto()
    {
        Assert.IsTrue(garageAbierto.Operar());
    }

    [Test]

    public void GarageCerrado()
    {
        Assert.IsFalse(garageCerrado.Operar());
    }
    
}