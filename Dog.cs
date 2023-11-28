using System;

namespace Lab5
{
    public class Dog : Animal
    {
        private string _breed;
        private string _color;
        private bool _purebred;

        /// <summary>
        /// Порода собаки
        /// </summary>
        public string Breed
        {
            get { return _breed; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _breed = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Окраска собаки
        /// </summary>
        public string Color
        {
            get { return _color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Чистокровная ли собака 
        /// </summary>
        public bool Purebred
        {
            get { return _purebred; }
            set { _purebred = value; }
        }

        /// <summary>
        /// Конструктор с параметрами для собаки
        /// </summary>
        /// <param name="name">Имя/Кличка собаки</param>
        /// <param name="breed">Порода собаки</param>
        /// <param name="color">Окраска собаки</param>
        /// <param name="purebred">Чистокровность</param>
        public Dog(string name, string breed, string color, bool purebred) : base(name)
        {
            Breed = breed;
            Color = color;
            Purebred = purebred;
        }

        public override string ToString()
        {
            return $"\tDog: {base.ToString()}, Breed: {Breed}, Color: {Color}, Purebred: {(Purebred == true ? "Yes" : "No")}";
        }
    }
}
