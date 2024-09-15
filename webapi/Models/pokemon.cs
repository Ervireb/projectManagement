namespace webapi.Models
{
    public class pokemon
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }

        public ICollection<review> reviews { get; set; }

    }
}
