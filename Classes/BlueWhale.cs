namespace prototypeHW.Classes
{
    public class BlueWhale : SeeCreature
    {
        public BlueWhale(string name, int age, bool hasUnderwaterTimeLimit, int maxWhistleLoudness)
            : base(name, age, hasUnderwaterTimeLimit)
        {
            MaxWhistleLoudness = maxWhistleLoudness;
        }

        /// <summary>
        /// Максимальная громкость свиста (db)
        /// </summary>
        public int MaxWhistleLoudness { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \n Age: {Age} \n HasUnderwaterTimeLimit: {HasUnderwaterTimeLimit} \n MaxWhistleLoudness:{MaxWhistleLoudness}";
        }

        public override Animal Clone()
        {
            return new BlueWhale(Name, Age, HasUnderwaterTimeLimit, MaxWhistleLoudness);
        }
    }
}
