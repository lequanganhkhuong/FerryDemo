namespace FerryDemo.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string PlateNumber { get; set; }

        public int Fee { get; set; }

        public double GasPercentage { get; set; }

        public int FerryId { get; set; }

        public bool IsInspected { get; set; }

        public bool IsCargoOpened { get; set; }

        public string CurrentLocation { get; set; }
    }
}
