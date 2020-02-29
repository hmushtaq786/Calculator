namespace ConsoleApplication1
{
    class Car
    {
        private string make;
        private string model;
        private int enginePower;
        private int modelYear;

        public string CarMake
        {
            get { return this.make; }
            set { this.make = value; }
        }
        public string CarModel
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int CarEnginePower
        {
            get { return this.enginePower; }
            set { this.enginePower = value; }
        }
        public int CarModelYear
        {
            get { return this.modelYear; }
            set { this.modelYear = value; }
        }
    }
}
