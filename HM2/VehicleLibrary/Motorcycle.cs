namespace VehicleLibrary
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string company, string model, int yearRelease)
        {
            this.Company = company;
            this.Model = model;
            this.YearRelease = yearRelease;
            this.NumWheels = 2;
        }

        public override void Park() => this.Speed = 0;
        public override void TestDrive() => this.Speed = 75;
    }
}
