using System;


namespace Laba_6_V_1
{
    public class Lion:Animal
    {

        private readonly int MAX_COUNT_HERDING_PER_DAY = 1440;
        
        private int _countHerdingPerDay;
        private string _habitat;
        private bool _isInTheRedBook;

        public Lion(string name,int countHerdingPerDay, string habitat, bool isInTheRedBook):base(name)
        {
            CountHerdingPerDay = countHerdingPerDay;
            Habitat = habitat;
            IsInTheRedBook = isInTheRedBook;
        }


        /// <summary>
        ///СВойство количевство добычи в день , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимально допустимого значения(MAX_COUNT_HERDING_PER_DAY)
        /// </summary>
        private int CountHerdingPerDay
        {
            get => _countHerdingPerDay;
            set
            {
                if (value >= 0 && value < MAX_COUNT_HERDING_PER_DAY)
                {
                    _countHerdingPerDay = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство место обитания , возвращает ArgumentNullException, если пытаемся присвоить пустую строку 
        /// </summary>
        private string Habitat
        {
            get => _habitat;
            set
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) )
                {
                    _habitat = valueTrim;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Свойство занесен ли он в Красную книгу
        /// </summary>
        private bool IsInTheRedBook
        {
            get => _isInTheRedBook;
            set => _isInTheRedBook = value;
        }
        public override string ToString()
        {
            return base.ToString() + $"Lion\ncount hearding per day={CountHerdingPerDay}; habitat={Habitat};is in the Red Book={IsInTheRedBook}\n";
        }
    }
}
