using System;


namespace Laba_6_V_1
{
    public class Animals
    {
        private Animal[] _animals;
        /// <summary>
        /// если параметром приходит ноль инициализируем с нулевой длиной массив 
        /// </summary>
        /// <param name="animals">елементы вставляемые в массив, нащадки класса Animal</param>
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
        /// добавление елемента в конец массива
        /// </summary>
        /// <param name="animal">обьект для добавления в массив</param>
        public void Add(Animal animal)
        {
            Array.Resize(ref _animals, _animals.Length + 1);
            _animals[_animals.Length - 1] = animal;
        }
        /// <summary>
        /// удаления елемента массива по индексу, вернет ArgumentOutOfRangeException, если некоректный индекс
        /// </summary>
        /// <param name="indexRemove">индекс удаляемого обьекта</param>
        public void RemoveByIndex(int indexRemove)
        {
            if (indexRemove >= 0 && indexRemove < _animals.Length)
            {
                Animal[] newAnimals = new Animal[_animals.Length - 1];
                for (int i = 0, j = 0; i < _animals.Length; i++)
                {
                    if (i != indexRemove)
                    {
                        newAnimals[j] = _animals[i];
                        j++;
                    }
                }
                _animals = newAnimals;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        /// <summary>
        /// обновление елемента по индексу , вернет ArgumentOutOfRangeException, если некоректный индекс
        /// </summary>
        /// <param name="updateAnimal"> новый елемент</param>
        /// <param name="indexUpdate">индекс куда обновляемого елемента</param>
        public void UpdateByIndex(Animal updateAnimal, uint indexUpdate)
        {
            if (indexUpdate >= 0 && indexUpdate < _animals.Length)
            {
                _animals[indexUpdate] = updateAnimal;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public override string ToString()
        {
            String result = "";
            foreach (Animal animal in _animals)
            {
                result += animal + "\n";
            }
            return result;
        }
    }
}
