using System;

namespace Laba_6_V_1
{
    public class Dog:Animal
    {
        private readonly int MAX_COUNT_VACCINATION = 100;

        private int _countVaccination;
        private string _breed;
        private bool _isHaveOwner;


        public Dog(string name, int countVaccination,string breed,bool isHaveOwner) : base(name)
        {
            СountVaccination = countVaccination;
            Breed = breed;
            IsHaveOwner = isHaveOwner;
        }


        /// <summary>
        ///СВойство количевство прививок у собаки, возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимально допустимого значения(MAX_COUNT_VACCINATION)
        /// </summary>
        private int СountVaccination
        {
            get => _countVaccination;
            set
            {
                if (value >= 0 && value < MAX_COUNT_VACCINATION)
                {
                    _countVaccination = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство порада собаки , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        private string Breed
        {
            get => _breed;
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
        /// Свойство есть ли хозяин у собаки 
        /// </summary>
        private bool IsHaveOwner
        {
            get => _isHaveOwner;
            set => _isHaveOwner = value;
        }
        public override string ToString()
        {
            return base.ToString()+ $"Dog\ncount vaccination={СountVaccination}; breed={Breed};has an owner={IsHaveOwner}\n";
        }
    }
}
