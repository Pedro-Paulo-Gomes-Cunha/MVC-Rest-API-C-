namespace Rest_NetApi.Api.Views
{
    public class PersonView
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public string Nationality { get; set; }
        public string Description { get; set; }
        public string Genero { get; set; }
        public PersonView() { }
        public PersonView(Guid id, string firstname, string lastname, DateTime birthday, string desciption, string nacionality, string genero)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
            Description = desciption;
            Nationality = nacionality;
            Genero = genero;
        }
    }
}
