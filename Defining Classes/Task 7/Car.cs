using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Car
    {
        public Car() {}

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires) : this()
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires = new List<Tire>();

        public string Model
        {
            get => model;
            set => model = value;
        }

        public Engine Engine
        {
            get => engine;
            set => engine = value;
        }

        public Cargo Cargo
        {
            get => cargo;
            set => cargo = value;
        }

        public List<Tire> Tires
        {
            get => tires;
            set => tires = value;
        }
        
    }
}