namespace webapi.Models
{
    public class category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public  ICollection<pokemon_category> pokemon_Categories { get; set; }
    }
}
