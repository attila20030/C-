using Kreata.Backend.Datas.Enums;

namespace Kreata.Backend.Datas.Entities
{
    public class Place
    {
        public Place(Guid id, string location, string maxhely, bool maxidopont, string payment)
        {//asd
            Id = id;
            Location = location;
            Maxhely = maxhely;
            Maxidopont = maxidopont;
            Payment = payment;
        }

        public Place(string location, string maxhely, bool maxidopont, string payment)
        {
            Id = new Guid();
            Location = location;
            Maxhely = maxhely;
            Maxidopont = maxidopont;
            Payment = payment;
        }

        public Place()
        {
            Id = new Guid();
            Location = string.Empty;
            Maxhely = string.Empty;
            Maxidopont = false;
            Payment = string.Empty;
        }

        public Guid Id { get; set; }
        public string Location { get;  set; }
        public string Maxhely { get;  set; }
        public bool Maxidopont { get; set; }
        public string Payment { get; set; }
    }
}
