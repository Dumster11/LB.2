﻿using System;

namespace ConsoleApp1
{
    class Adress
    {
        string index;
        public string Index
        {
            set
            {
                index = value;
            }
            get
            {
                return index;
            }
        }
        private string country;
        public string Country
        {
            set
            {
                country = value;
            }
            get
            {
                return country;
            }
        }
        string city;
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        string street;
        public string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        string house;
        public string House
        {
            set
            {
                house = value;
            }
            get
            {
                return house;
            }
        }
        string apartment;
        public string Apartment
        {
            set
            {
                apartment = value;
            }
            get
            {
                return apartment;
            }
        }
        string ggg;
        class Program
        {
            static void Main()
            {
                Adress program = new Adress();
                program.Index = "08333";
                Console.WriteLine(program.Index);
                Console.WriteLine(new string('-', 50));
                program.Country = "Ukraine";
                Console.WriteLine(program.Country);
                Console.WriteLine(new string('-', 50));
                program.City = "Rivne";
                Console.WriteLine(program.City);
                program.City = "Kyiv";
                Console.WriteLine(program.City);
                program.City = "Lviv";
                Console.WriteLine(program.City);
                Console.ReadKey();

            }
        }
    }
}

