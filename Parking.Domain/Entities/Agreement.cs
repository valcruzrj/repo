namespace Parking.Domain
{
    public class Agreement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal DiscountAmount { get; set; }
        public double DiscountPercentual { get; set; }
    }
}
