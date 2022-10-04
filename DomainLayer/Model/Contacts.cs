namespace DomainLayer.Model
{
    public class Contacts: BaseEntity 
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Enterprise { get; set; }
        public string Area { get; set; }
    }
}