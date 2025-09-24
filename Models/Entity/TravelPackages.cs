namespace Travel_Service.Models.Entity
{
    public class TravelPackages
    {
        public Guid PackageId { get; set;}
        public string PackageClass { get; set;}
        public string Amount { get; set;}
        public string Destination { get; set;}
        public int NoOfDays { get; set;}


    }
}
