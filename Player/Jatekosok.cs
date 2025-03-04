using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyeroesvesztojatekos.Models
{
    class Jatekosok
    {
        public string Nev { get; set; }
        public string Email { get; }
        public int Pontszam { get; private set; }
        public int Gyozelmek { get; private set; }
        public int Vereseg { get; private set; }

        public Jatekosok(string nev, string email, int kezdoPont)
        {
            if (kezdoPont < 0)
                throw new ArgumentException("A kezdő pontszám nem lehet negatív!");
            Nev = nev;
            Email = email;
            Pontszam = kezdoPont;
            Gyozelmek = 0;
            Vereseg = 0;
        }

        public void GetVictory(int pont)
        {
            if (Pontszam < 0)
                throw new InvalidOperationException("A játékos kiesett, nem nyerhet többé!");
            Pontszam += pont;
            Gyozelmek++;
        }

        public void GetLose(int pont)
        {
            if (Pontszam < 0)
                throw new InvalidOperationException("A játékos kiesett, nem veszíthet többé!");
            Pontszam -= pont;
            Vereseg++;
        }

        public bool NyeresreAll()
        {
            return Gyozelmek > Vereseg;
        }

        public override string ToString()
        {
            return $"{Nev} ({Email}) -> {Pontszam} pont";
        }
    }
}
