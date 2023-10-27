using Exercice_Animalerie.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public class Cat : Animal
    {
        #region Fields
        private int _clawSize;
        private bool _isLongHair;
        #endregion

        #region Props
        public string? Charcater { get; set; }

        public bool CuttedClaw
        {
            get { return _clawSize <= 10; }
        }

        public bool IsLongHair
        {
            get { return _isLongHair; }
            set { _isLongHair = value; }
        }

        public bool IsShortHair
        {
            get { return !_isLongHair; }
            set { _isLongHair = !value; }
        }

        public override double DeathProba
        {
            get { return 0.5; }
        }
        #endregion


        #region Ctor
        private void Initialize(string? charcater, bool isLongHair)
        {
            Charcater = charcater;
            IsLongHair = isLongHair;
            _clawSize = (new Random()).Next(0, 11);
        }

        public Cat(string name, double weight, double size, SexEnum sex, int age, string? charcater, bool isLongHair)
            : base(name, weight, size, sex, age)
        {
            Initialize(charcater, isLongHair);
        }

        public Cat(string name, double weight, double size, SexEnum sex, int age, DateTime arrivalDate, string? charcater, bool isLongHair)
            : base(name, weight, size, sex, age, arrivalDate)
        {
            Initialize(charcater, isLongHair);
        }
        #endregion


        #region Methods
        public override string Scream()
        {
            return "Miaou";
        }

        public void CutClaw()
        {
            _clawSize = 0;
        }

        public override void EndOfDay()
        {
            _clawSize++;
        }
        #endregion
    }
}
