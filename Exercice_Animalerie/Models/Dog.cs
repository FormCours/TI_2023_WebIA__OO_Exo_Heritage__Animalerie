using Exercice_Animalerie.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public class Dog : Animal
    {
        
        #region Props
        public string? CollarColor { get; set; }
        public string Race { get; set; } = null! ;
        public bool IsTrained { get; set; }
        public override double DeathProba
        {
            get { return 1; }
        }
        #endregion

        #region Ctor
        private void Initialize(string? collarColor, string race, bool isTrained)
        {
            CollarColor = collarColor;
            Race = race;
            IsTrained = isTrained;
        }

        public Dog(string name, double weight, double size, SexEnum sex, int age, string? collarColor, string race, bool isTrained)
            : base(name, weight, size, sex, age)
        {
            Initialize(collarColor, race, isTrained);
        }

        public Dog(string name, double weight, double size, SexEnum sex, int age, DateTime arrivalDate, string? collarColor, string race, bool isTrained)
            : base(name, weight, size, sex, age, arrivalDate)
        {
            Initialize(collarColor, race, isTrained);
        }
        #endregion

        #region Methods
        public override string Scream()
        {
            return "WOUF";
        }
        #endregion
    }
}
