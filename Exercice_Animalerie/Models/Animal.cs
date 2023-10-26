using Exercice_Animalerie.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public abstract class Animal
    {
        private bool _isAlive = true;

        /// <summary>
        /// Animal's name
        /// </summary>
        public string Name { get; set; } = null! ;

        /// <summary>
        /// Animal's weight in "Kg"
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Animal's size in "cm"
        /// </summary>
        public double Size { get; set; }

        /// <summary>
        /// Animal's sex
        /// </summary>
        public SexEnum Sex { get; set; }

        /// <summary>
        /// Animal's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Arrival date of animal
        /// </summary>
        public DateTime ArrivalDate { get; set; }

        /// <summary>
        /// Probability of death
        /// </summary>
        public abstract double DeathProba { get; }

        public bool IsAlive {
            get { return _isAlive; }
        }


        /// <summary>
        /// Method to get scream of animal
        /// </summary>
        /// <returns>Scream of animal</returns>
        public abstract string Scream();


        public virtual void startOfDay()
        {
            if(DiedInNigth())
            {
                Console.WriteLine("EVENT : " + Name + " " + Scream() + " et meurt..." );

                _isAlive = false;
            }
        }

        public virtual void EndOfDay() { }

        private bool DiedInNigth()
        {
            double proba = new Random().NextDouble() * 100;

            return proba <= DeathProba;
        }
    }
}
