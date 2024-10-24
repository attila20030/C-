using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
        public Parent(Guid id, string firstName, string lastName, bool gender, string address)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
        }

        public Parent(string firstName, string lastName, bool gender, string address)
        {
            Id = new Guid();
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Address = address;
        }

        public Parent()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = false;
            Address= string.Empty;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; private set; }
        public string Address { get; private set; }
    }
}
