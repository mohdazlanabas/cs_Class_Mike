﻿using cs_ClassGather;

namespace Proj01
{
    class GetterMovie
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine(avengers.Rating);
        }
    }
}