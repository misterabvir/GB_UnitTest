using VehicleLibrary;

namespace VehicleTests;

public class CarTests
{
    private Car car;
    
    [SetUp]
    public void Setup()
    {
        car = new Car("Tesla","Model-S", 2010);
    }

    /// <summary>
    /// Проверить, что экземпляр объекта Car также является экземпляром 
    /// транспортного средства.
    /// </summary>
    [Test]
    public void TestCarIsInstanceOfVehicle()
    {
        Assert.That(car, Is.InstanceOf<Vehicle>());
        Assert.IsInstanceOf<Vehicle>(car);
    }


    /// <summary>
    /// Проверить, что объект Car создается с 4-мя колесами.
    /// </summary>
    [TestCase(4)]
    public void TestCarHas4Wheels(int wheels)
    {
        Assert.That(car.NumWheels, Is.EqualTo(wheels));
    }

    /// <summary>
    /// Проверить, что объект Car развивает скорость 60 в режиме тестового вождения 
    /// (используя метод TestDrive()).
    /// </summary>
    [TestCase(60)]
    public void TestCarSpeedInTestDriveEqual60(int speed)
    {
        car.TestDrive();
        Assert.That(car.Speed, Is.EqualTo(speed));
    }

    /// <summary>
    /// Проверить, что в режиме парковки 
    /// (сначала TestDrive, потом Park, т.е. эмуляция движения транспорта)
    /// машина останавливается (speed = 0).
    /// </summary>
    [TestCase(0)]
    public void TestCarSpeedInParkModeEqual0(int speed)
    {
        car.TestDrive();
        car.Park();
        Assert.That(car.Speed, Is.EqualTo(speed));
    }
}