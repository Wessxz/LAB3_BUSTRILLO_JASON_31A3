namespace LAB3_BUSTRILLO_JASON_31A3.Models
{
    public class Customers : BaseEntityCustomer
    {
        public override string Describe()
        {
            return $"Customer: {FullName}, Age: {Age}";
        }
    }
}
