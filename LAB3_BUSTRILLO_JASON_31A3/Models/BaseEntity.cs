namespace LAB3_BUSTRILLO_JASON_31A3.Models
{
    public abstract class BaseEntityCustomer : IDescribable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        public abstract string Describe();
    }
}
