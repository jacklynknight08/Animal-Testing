using System;

namespace Animals
{
    public class Animal
    {
        private string _species;
        private double _walkingSpeed;
        public string Name { get; } //do not need a set because we set it in the constructor 
        public string Species
        {
            get
            {
                return _species;
            }
        }

        public double WalkingSpeed 
        { 
            get 
            {
            return _walkingSpeed;
            } 
        }

        public Animal(string name) //input for the constructor method
        {
            this.Name = name; //this refers to the object instance itself
        }

        public void SetSpecies(string species)
        {
            //this.Species = species; //only the constructor can set readonly properties
            _species = species;
        }

        public void Walk(double speed)
        {
            _walkingSpeed = speed;
        }
    }
}