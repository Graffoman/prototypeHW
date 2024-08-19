using prototypeHW.Interfaces;

namespace prototypeHW.Classes
{
    /// <summary>
    /// Базовый класс животное
    /// </summary>
    public abstract class Animal : IMyCloneable<Animal> 
    {
        /// <summary>
        /// Имя животного
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст животного
        /// </summary>
        public int Age { get; set; }

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract Animal Clone();
    }
}
