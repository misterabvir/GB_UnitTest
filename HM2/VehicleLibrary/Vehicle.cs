namespace VehicleLibrary
{
    public abstract class Vehicle
    {
        public string Company { get; init; } = null!;
        public string Model { get; init; } = null!;
        public int YearRelease { get; init; }
        public int NumWheels { get; init; }
        public int Speed { get; protected set; }

        public abstract void TestDrive();
        public abstract void Park();
    }
}
