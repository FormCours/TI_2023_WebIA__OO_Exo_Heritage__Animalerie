using Exercice_Animalerie.Enums;
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

        #region Props
        public string Color { get; set; }

        public HabitatEnum Habitat { get; set; }

        public override double DeathProba
        {
            get { return 3; }
        }
        #endregion

        #region Ctor
        public Bird(string name, double weight, double size, SexEnum sex, int age, string color, HabitatEnum habitat)
            : base(name, weight, size, sex, age)
        {
            Color = color;
            Habitat = habitat;
        }

        public Bird(string name, double weight, double size, SexEnum sex, int age, DateTime arrivalDate, string color, HabitatEnum habitat)
            : base(name, weight, size, sex, age, arrivalDate)
        {
            Color = color;
            Habitat = habitat;
        }
        #endregion

        #region Methods
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
        #endregion
    }
}
