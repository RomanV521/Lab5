using System;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Lab5
{
    public class Animals
    {
        private Animal[] _animals;
        
        /// <summary>
        /// Проверка на null
        /// </summary>
        /// <param name="animals">массив животных</param>
        public Animals(params Animal[] animals)
        {
            if (animals is not null)
            {
                _animals = animals;
            }
            else
            {
                _animals = new Animal[0];
            }
        }

        /// <summary>
        /// Добавление животного
        /// </summary>
        /// <param name="animal">Объект который содержит информацию о животном</param>
        public void Add(Animal animal)
        {
            if(animal is not null)
            {
                Array.Resize(ref _animals, _animals.Length+1);
                _animals[_animals.Length-1] = animal;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Удаление животного при помощи объекта
        /// </summary>
        /// <param name="animal">Обект который мы собираемся удалять</param>
        public void Remove(Animal animal) 
        {
            if (animal is not null)
            {
                for (int i = 0; i < _animals.Length; i++)
                {
                    if (_animals[i] == animal)
                    {
                        for (int j=i; j < _animals.Length-1; j++)
                        {
                            _animals[j] = _animals[j+1];
                        }
                        Array.Resize(ref _animals, _animals.Length - 1);
                        break;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Удаление животного при помощи его id
        /// </summary>
        /// <param name="index">Id</param>
        public void Remove(int index) 
        {
            if (index >= 0 && index < _animals.Length)
            {
                for (int i = index; i < _animals.Length - 1; i++)
                {
                    _animals[i] = _animals[i + 1];
                }
                Array.Resize(ref _animals, _animals.Length - 1);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Редактирование животного по его id
        /// </summary>
        /// <param name="index">Id</param>
        /// <param name="Animal">Новые данные для животного</param>
        public void Edit(int index, Animal Animal)
        {
            if (index >= 0 && index < _animals.Length)
            {
                _animals[index]= Animal;
            }
            else 
            {
                throw new ArgumentOutOfRangeException(); 
            }
        }

        /// <summary>
        /// Редактирование животного при помощи предыдущих данных
        /// </summary>
        /// <param name="editableAnimal">Старые данные животного</param>
        /// <param name="animal">Новые данные для животного</param>
        public void Edit(Animal editableAnimal, Animal animal)
        {
            if (editableAnimal is not null && animal is not null)
            {
                for (int i = 0; i < _animals.Length; i++)
                {
                    if (_animals[i] == editableAnimal)
                    {
                        _animals[i] = animal;
                        break;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach(Animal animal in _animals)
            {
                result.Append(animal + "\n");
            }
            return "Animals:\n"+result;
        }
    }
}
