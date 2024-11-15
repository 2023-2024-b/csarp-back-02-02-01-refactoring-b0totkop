namespace Kreata.Backend.Datas.Entities
{
    public class Janitor
    {
        public Janitor()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            IsWoomen = false;
            IsAdministrator = false;
        }
        public Janitor(string firstName, string lastName, DateTime birthsDay, bool isWoomen, bool isAdministrator)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoomen = isWoomen;
            IsAdministrator = isAdministrator;
        }
        public Janitor(Guid id, string firstName, string lastName, DateTime birthsDay, bool isWoomen, bool isAdministrator)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoomen = isWoomen;
            IsAdministrator = isAdministrator;
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public bool IsWoomen { get; set; }
        public bool IsAdministrator { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
