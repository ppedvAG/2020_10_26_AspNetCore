using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace AnonymeTypenVsTypisierteTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Person> personenListe = new List<Person>();

            Person person = new Person();
        }
    }

    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

    }
}
