namespace LAB3_BUSTRILLO_JASON_31A3.Models
{
    public class PremiumCustomer : Customers
    {
        public bool IsVIP { get; set; } = true;

        public override string Describe()
        {
            return $"Premium Customer: {FullName}, Age: {Age}, VIP: {IsVIP}";
        }
    }
}
