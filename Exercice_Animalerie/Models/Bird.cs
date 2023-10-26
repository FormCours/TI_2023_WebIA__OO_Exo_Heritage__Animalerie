using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public class Bird : Animal
    {
        public enum HabitatEnum
        {
            CAGE,
            AVIARY,
            OUTSIDE
        }

        public string Color { get; set; } = null!;

        public HabitatEnum Habitat { get; set; }

        public override double DeathProba
        {
            get { return 3; }
        }

        public override string Scream()
        {
            int nbScream = new Random().Next(2, 11);

            StringBuilder sb = new StringBuilder();
            sb.Append("Cui");
            for (int i = 1; i < nbScream; i++)
            {
                sb.Append(" Cui");
            }

            return sb.ToString();
        }

        public override void EndOfDay()
        {
            Console.WriteLine("EVENT : " + Name + " " + Scream());
        }
    }
}
