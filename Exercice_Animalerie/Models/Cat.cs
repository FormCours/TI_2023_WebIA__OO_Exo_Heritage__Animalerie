using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public class Cat : Animal
    {
        private int _clawSize;
        private bool _isLongHair;

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

    }
}
