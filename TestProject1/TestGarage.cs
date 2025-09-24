namespace TestProject1;
using Compuertas_Logicas;

public class TestGarage
{
    private GarageGate _garageAbierto;
    private GarageGate _garageCerrado;
    
    [SetUp]
    public void Setup()
    {
        _garageAbierto = new GarageGate(false, false, true);
        _garageCerrado = new GarageGate(false, false, false);
    }

    [Test]

    public void GarageAbierto()
    {
        Assert.IsTrue(_garageAbierto.Operar());
    }

    [Test]

    public void GarageCerrado()
    {
        Assert.IsFalse(_garageCerrado.Operar());
    }
    
}