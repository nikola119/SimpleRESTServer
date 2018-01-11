using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleRESTServer
{
    public class Person
    {
        private string ime;
        public string Ime { get; set; }
        private string prezime;
        public string Prezime { get; set; }

        public Person(string ime, string prezime)
        {
            this.ime = ime; this.prezime = prezime;
        }
    }
}
