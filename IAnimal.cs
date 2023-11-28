using System;

namespace Lab5
{
    public interface IAnimal
    {
        /// <summary>
        /// Кушать
        /// </summary>
        void Eat();

        /// <summary>
        /// Спать
        /// </summary>
        void Sleep();

        /// <summary>
        /// Гулять
        /// </summary>
        void Walk();
    }
}