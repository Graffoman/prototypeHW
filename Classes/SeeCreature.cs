namespace prototypeHW.Classes
{
    /// <summary>
    /// Морское животное
    /// </summary>
    public class SeeCreature : Animal
    {
        public SeeCreature(string name, int age, bool hasUnderwaterTimeLimit) : base(name, age)
        {
            HasUnderwaterTimeLimit = hasUnderwaterTimeLimit;
        }

        /// <summary>
        /// Флаг имеется ли лимит по времени нахождения под водой
        /// </summary>
        public bool HasUnderwaterTimeLimit { get; set; }

        public override Animal Clone()
        {
            throw new NotImplementedException();
        }
    }
}
