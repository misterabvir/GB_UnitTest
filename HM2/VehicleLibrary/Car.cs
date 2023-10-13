namespace VehicleLibrary
{
    public class Car : Vehicle
    {
        public Car(string company, string model, int yearRelease)
        {
            this.Company = company;
            this.Model = model;
            this.YearRelease = yearRelease;
            this.NumWheels = 4;
        }

        public override void Park() => this.Speed = 0;
        public override void TestDrive() => this.Speed = 60;
    }
}
