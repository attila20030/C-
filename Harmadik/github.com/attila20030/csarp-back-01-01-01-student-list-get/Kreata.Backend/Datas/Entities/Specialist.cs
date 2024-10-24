using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class Specialist
    {
        public Specialist(Guid id, string firstName, string lastName, DateTime birthsDay,bool isWooman)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoomen = isWooman;
        }

        public Specialist(string firstName, string lastName, DateTime birthsDay,bool isWooman)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            BirthsDay = birthsDay;
            IsWoomen = isWooman;
        }

        public Specialist()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            BirthsDay = new DateTime();
            IsWoomen = false;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthsDay { get; set; }
        public bool IsWoomen { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, Szül: ({String.Format("{0:yyyy.MM.dd.}", BirthsDay)})";
        }
    }
}

