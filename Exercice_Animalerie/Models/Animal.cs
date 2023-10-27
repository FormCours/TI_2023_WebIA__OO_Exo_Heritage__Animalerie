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
        #region Fields
        private bool _isAlive;
        #endregion

        #region Props
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

        /// <summary>
        /// Symbolise state (Life or Death) of this animal
        /// </summary>
        public bool IsAlive {
            get { return _isAlive; }
        }
        #endregion

        #region Ctor

        /// <summary>
        /// Permet de créer un animal
        /// </summary>
        public Animal(string name, double weight, double size, SexEnum sex, int age)
        {
            this._isAlive = true;

            this.Name = name;
            this.Weight = weight;
            this.Size = size;
            this.Sex = sex;
            this.Age = age;
            this.ArrivalDate = DateTime.Today;
        }

        /// <summary>
        /// Permet de restaurer un animal depuis la DB
        /// </summary>
        public Animal(string name, double weight, double size, SexEnum sex, int age, DateTime arrivalDate)
            : this(name, weight, size, sex, age)
        {
            this.ArrivalDate = arrivalDate;
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Method to get scream of animal
        /// </summary>
        /// <returns>Scream of animal</returns>
        public abstract string Scream();


        /// <summary>
        /// Procedure with all event during start of day
        /// </summary>
        public virtual void startOfDay()
        {
            if(DiedInNigth())
            {
                Console.WriteLine("EVENT : " + Name + " " + Scream() + " et meurt..." );

                _isAlive = false;
            }
        }

        /// <summary>
        /// Procedure with all event during end of day
        /// </summary>
        public virtual void EndOfDay() { }

        /// <summary>
        /// Check if animal dead in the nigth
        /// </summary>
        /// <returns>Death or Life</returns>
        private bool DiedInNigth()
        {
            double proba = new Random().NextDouble() * 100;

            return proba <= DeathProba;
        }
        #endregion
    }
}
