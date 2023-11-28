using System;
using System.Diagnostics;

namespace Lab5
{
    public abstract class Animal : IAnimal
    {
        private readonly string _name;
        private string _currentActivity;
        private string[] activityList = { "No activity", "Eat", "Sleep", "Walk" };

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

        public Animal(string name)
        {
            CurrentActivity = activityList[0];
            Name = name;
        }

        /// <summary>
        /// Метод который изменяет статус деятельности на "Eat"
        /// </summary>
        public void Eat()
        {
            if(CurrentActivity != activityList[1])
            {
                CurrentActivity = activityList[1];
            }
        }
        /// <summary>
        /// Метод который изменяет статус деятельности на "Sleep"
        /// </summary>
        public void Sleep()
        {
            if (CurrentActivity != activityList[2])
            {
                CurrentActivity = activityList[2];
            }
        }
        /// <summary>
        /// Метод который изменяет статус деятельности на "Walk"
        /// </summary>
        public void Walk()
        {
            if (CurrentActivity != activityList[3])
            {
                CurrentActivity = activityList[3];
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Activity: {CurrentActivity}";
        }
    }
}
