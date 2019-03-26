namespace GuildCars.Models.Tables
{
    public class Sale
    {
        public int SalesId { get; set; }
        public int Price { get; set; }
        public Special SpecialId{ get; set; }
        public Car CarId { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
