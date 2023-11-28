using System;

namespace Lab5
{
    public class Cat : Animal
    {
        private bool _lazy;
        private bool _haveWool;
        private double _jumpHeight;
        private static double maximumJumpHeight = 3;

        /// <summary>
        /// Ленивая ли кошка
        /// </summary>
        public bool Lazy
        {
            get { return _lazy; }
            set { _lazy = value; }
        }

        /// <summary>
        /// Есть ли шерсть
        /// </summary>
        public bool HaveWool
        {
            get { return _haveWool; }
            set { _haveWool = value; }
        }

        /// <summary>
        /// Высота прыжка
        /// </summary>
        public double JumpHeight
        {
            get { return _jumpHeight; }
            set 
            { 
                if(value > 0 && value <= maximumJumpHeight)
                {
                    _jumpHeight = value; 
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">Имя кота(-шки)</param>
        /// <param name="lazy">Ленивая</param>
        /// <param name="haveWool">Есть шерсть</param>
        /// <param name="jumpHeight">Высота прыжка</param>
        public Cat(string name, bool lazy, bool haveWool, double jumpHeight):base(name)
        {
            Lazy = lazy;
            HaveWool = haveWool;
            JumpHeight = jumpHeight;
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
            return $"\tCat: Name: {base.ToString()}, Lazy: {(Lazy == true ? "Yes" : "No")}, Have wool: {(HaveWool == true ? "Yes" : "No")}, Jump height: {JumpHeight}m";
        }
    }
}
