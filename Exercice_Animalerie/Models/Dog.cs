using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public class Dog : Animal
    {
        public string? CollarColor { get; set; }
        public string Race { get; set; } = null! ;
        public bool IsTrained { get; set; }
        public override double DeathProba
        {
            get { return 1; }
        }

        public override string Scream()
        {
            return "WOUF";
        }
    }
}
