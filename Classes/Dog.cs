namespace prototypeHW.Classes
{
    public class Dog : LandCreature
    {
        public Dog(string name, int age, int maxLandspeed, string breed)
            : base(name, age, maxLandspeed)
        {
            Breed = breed;
        }

        /// <summary>
        /// Порода собаки
        /// </summary>
        public string Breed { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \n Age: {Age} \n MaxLandspeed: {MaxLandspeed} \n Breed: {Breed}";
        }

        public override Animal Clone()
        {
            return new Dog(Name, Age, MaxLandspeed, Breed);
        }
    }
}
