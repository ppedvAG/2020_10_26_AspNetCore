using System;

namespace NullableTypesSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;

            int? nullableInteger = null;


            if (nullableInteger.HasValue)
                Console.WriteLine(nullableInteger.Value);


            Console.ReadKey();
        }

        public static void MachWas(int? A, int? B, string c)
        {
            if (!A.HasValue || !B.HasValue)
                throw new ArgumentException("Parameter wurde nicht gesetzt");


            if (!string.IsNullOrEmpty(c))
                throw new ArgumentException("Parameter wurde nicht gesetzt");

            // Ab hier können wir ausgehen, das A und B valide für unsere Berechnung sind....bzw es stecken korrekte Werte drin. 

        }


        public static void WeitereDatentypen()
        {
            DateTime? nullableDateTime = null;

            string nullableString = null;




        }
    }
}
