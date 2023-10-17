using System;


namespace Laba_6_V_1
{
    public class Snake:Animal
    {
        private readonly int MAX_BODY_LENGTH = 7500;
        private readonly int MIN_BODY_LENGTH = 10;

        private int _bodyLength;
        private bool _isHavePoison;
        private bool _isCaught;


        public Snake(string name, int bodyLength, bool isHavePoison, bool isCaught) : base(name)
        {
            BodyLength = bodyLength;
            IsHavePoison = isHavePoison;
            IsCaught = isCaught;
        }


        /// <summary>
        ///СВойство длина тела , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимально допустимого значения(MAX_BODY_LENGTH) или меньше минимального (MIN_BODY_LENGTH)
        /// </summary>
        private int BodyLength
        {
            get => _bodyLength;
            set
            {
                if (value >= 0 && value>MIN_BODY_LENGTH && value < MAX_BODY_LENGTH)
                {
                    _bodyLength = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство ядовитая ли змея
        /// </summary>
        private bool IsHavePoison
        {
            get => _isHavePoison;
            set => _isHavePoison = value;
        }
        /// <summary>
        /// Свойство поймана ли змея
        /// </summary>
        private bool IsCaught
        {
            get => _isCaught;
            set => _isCaught = value;
        }
        public override string ToString()
        {
            return base.ToString() + $"Snake\nbody length={BodyLength} (cm); Is сaught={IsCaught};is have poison={IsHavePoison}\n";
        }
    }
}
