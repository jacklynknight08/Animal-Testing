using System;

namespace Animals
{
    public class Dog: Animal 
    {
        public string FavoriteToy { get; }
        public Dog(string name): base(name)
        {
            //simply saying this is a sub-type of Animal
            //Animal already does everything we need
            //this.FavoriteToy = toy; //this is now just specific to the Dog
        }
    }
}