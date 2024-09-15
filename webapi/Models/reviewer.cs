namespace webapi.Models
{
    public class reviewer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection <review> Reviews { get; set;
    }
}
