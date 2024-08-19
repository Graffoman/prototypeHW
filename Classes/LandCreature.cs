namespace prototypeHW.Classes
{
    /// <summary>
    /// Сухопутное животное
    /// </summary>
    public class LandCreature : Animal
    {
        public LandCreature(string name, int age, int maxLandspeed) : base(name, age)
        {
            MaxLandspeed = maxLandspeed;
        }

        /// <summary>
        /// Максимальная скорость бега (км/ч) 
        /// </summary>
        public int MaxLandspeed { get; set; }

        public override Animal Clone()
        {
            throw new NotImplementedException();
        }
    }
}
