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

        /// <summary>
        /// Инициализация метода Eat из интерфейса IAnimal
        /// </summary>
        public override void Eat()
        {
            if (CurrentActivity != ActivityList[1])
            {
                CurrentActivity = ActivityList[1];
            }
        }

        /// <summary>
        /// Инициализация метода Sleep из интерфейса IAnimal
        /// </summary>
        public override void Sleep()
        {
            if (CurrentActivity != ActivityList[2])
            {
                CurrentActivity = ActivityList[2];
            }
        }


        /// <summary>
        /// Инициализация метода Walk из интерфейса IAnimal
        /// </summary>
        public override void Walk()
        {
            if (CurrentActivity != ActivityList[3])
            {
                CurrentActivity = ActivityList[3];
            }
        }

        public override string ToString()
        {
            return $"\tDog: {base.ToString()}, Breed: {Breed}, Color: {Color}, Purebred: {(Purebred == true ? "Yes" : "No")}";
        }
    }
}
