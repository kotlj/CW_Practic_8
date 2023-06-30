using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CW_Practic_8
{

    class Human
    {
        private short _age;
        public string Name { get; set; }
        public short Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("AgeError");
                }
            }
        }

        public Human()
        {
            Age = 30;
            Name = "NoName";
        }
        public Human(short age, string _Name)
        {
            Age = age;
            Name = _Name;
        }
    }
    class Builder : Human
    {
        private int _experience;
        public int Expirience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value >= 0)
                {
                    _experience = value;
                }
                else
                {
                    throw new Exception("ExperienceError");
                }
            }
        }
        public Builder() : base()
        {
            _experience = 0;
        }
        public Builder(int expiriance, short age, string _Name) : base(age, _Name)
        {
            _experience = expiriance;
        }
        public void build()
        {
            Console.WriteLine("Building...");
        }
    }
    class Sailor : Human
    {
        private string shipName;
        public string ShipName
        {
            get
            {
                return shipName;
            }
            set
            {
                shipName = value;
            }
        }
        public Sailor() : base()
        {
            ShipName = "noName";
        }
        public Sailor(string _shipName, short age, string _Name) : base(age, _Name)
        {
            ShipName = _shipName;
        }
        public void swim()
        {
            Console.WriteLine("raise anchor!");
        }
    }
    class Pilot : Human
    {
        private string planeModel;
        public string PlaneModel
        {
            get
            {
                return planeModel;
            }
            set 
            {
                planeModel = value; 
            }
        }
        public Pilot() : base()
        {
            PlaneModel = "NoneModel";
        }
        public Pilot(string _planeModel, short age, string _Name) : base(age, _Name)
        {
            PlaneModel = _planeModel;
        }
        public void fly()
        {
            Console.WriteLine("To the sky!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Builder(20, 40, "SomeOne");
            (human as Builder).build();
            human = new Sailor("Santa-Maria", 30, "AnotherOne");
            (human as Sailor).swim();
            human = new Pilot("A-48", 24, "WhoIsThis");
            (human as  Pilot).fly();
        }
    }
}
