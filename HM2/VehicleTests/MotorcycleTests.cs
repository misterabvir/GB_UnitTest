using VehicleLibrary;

namespace VehicleTests;

public class MotorcycleTests
{
    private Motorcycle motorcycle;

    [SetUp]
    public void Setup()
    {
        motorcycle = new Motorcycle("Yamaha Motor Company", "FZ6 FAZER", 2010);
    }

    /// <summary>
    /// Проверить, что объект motorcycle создается с 4-мя колесами.
    /// </summary>
    [TestCase(2)]
    public void TestMotorcycleHas4Wheels(int wheels)
    {
        Assert.That(motorcycle.NumWheels, Is.EqualTo(wheels));
    }

    /// <summary>
    /// Проверить, что объект motorcycle развивает скорость 60 в режиме тестового вождения 
    /// (используя метод TestDrive()).
    /// </summary>
    [TestCase(75)]
    public void TestMotorcycleSpeedInTestDriveEqual60(int speed)
    {
        motorcycle.TestDrive();
        Assert.That(motorcycle.Speed, Is.EqualTo(speed));
    }

    /// <summary>
    /// Проверить, что в режиме парковки 
    /// (сначала TestDrive, потом Park, т.е. эмуляция движения транспорта)
    /// motorcycle останавливается (speed = 0).
    /// </summary>
    [TestCase(0)]
    public void TestMotorcycleSpeedInParkModeEqual0(int speed)
    {
        motorcycle.TestDrive();
        motorcycle.Park();
        Assert.That(motorcycle.Speed, Is.EqualTo(speed));
    }
}
