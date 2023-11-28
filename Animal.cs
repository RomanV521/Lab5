using System;
using System.Diagnostics;

namespace Lab5
{
    public abstract class Animal : IAnimal
    {
        private readonly string _name;
        private string _currentActivity;
        private static readonly string[] _activityList = { "No activity", "Eat", "Sleep", "Walk" };

        /// <summary>
        /// Имя/Кличка
        /// </summary>
        public string Name
        {
            get { return _name; }
            init
            {
                string valueTrim = value.Trim();
                if(valueTrim.Length > 1 && !string.IsNullOrEmpty(value))
                {
                    _name = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Текущая активность
        /// </summary>
        public string CurrentActivity
        {
            get { return _currentActivity; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _currentActivity = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public string[] ActivityList
        {
            get { return _activityList; }
        }

        public Animal(string name)
        {
            CurrentActivity = _activityList[0];
            Name = name;
        }

        /// <summary>
        /// Метод который изменяет статус деятельности на "Eat"
        /// </summary>
        public abstract void Eat();
        
        /// <summary>
        /// Метод который изменяет статус деятельности на "Sleep"
        /// </summary>
        /// 
        public abstract void Sleep();
        /// <summary>
        /// Метод который изменяет статус деятельности на "Walk"
        /// </summary>
        public abstract void Walk();

        public override string ToString()
        {
            return $"Name: {Name}, Activity: {CurrentActivity}";
        }
    }
}
