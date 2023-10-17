using System;


namespace Laba_6_V_1
{
    public abstract class Animal : IAnimal
    {
        private readonly string _name;
        private string _currentAction;

        protected Animal(string name)
        {
            CurrentAction = AnimalActions.REST;
            Name = name;
        }

        /// <summary>
        /// Свойство имя животного, возвращает ArgumentNullException, если пытаемся присвоить пустую строку или строку с одним символом
        /// </summary>
        public string Name
        {
            get => _name;

            init
            {
                string valueTrim = value.Trim();
                if (!string.IsNullOrEmpty(value) && valueTrim.Length > 1)
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
        /// Свойство текущее действие, возвращает ArgumentNullException, если пытаемся присвоить пустую строку 
        /// </summary>
        private string CurrentAction
        {
            get => _currentAction;

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _currentAction = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// метод изменяющий свойстов текущее действие на "есть"
        /// </summary>
        public void Eat()
        {
            if(CurrentAction != AnimalActions.EAT)
            {
                CurrentAction = AnimalActions.EAT;
            }
        }
        /// <summary>
        /// метод изменяющий свойстов текущее действие на "спать"
        /// </summary>
        public void Sleep()
        {
            if (CurrentAction != AnimalActions.SLEAP)
            {
                CurrentAction = AnimalActions.SLEAP;
            }
        }
        public override string ToString()
        {
            return $"Animal\nname={Name},action={CurrentAction}\n";
        }
    }
}
