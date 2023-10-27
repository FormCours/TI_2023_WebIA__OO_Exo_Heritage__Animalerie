using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Animalerie.Models
{
    public class PetStore
    {
        #region Fields
        private List<Animal> _animals;
        #endregion

        #region Props
        public string Name { get; set; } = null!;
        public int Day { get; private set; }
        public IEnumerable<Animal> Animals
        {
            get { return _animals.AsReadOnly(); }
        }

        // TODO Use generic to simplify this 3 props
        public int NbDog
        {
            get
            {
                int nb = 0;
                foreach (Animal animal in _animals)
                {
                    if (animal.IsAlive && animal is Dog)
                    {
                        nb++;
                    }
                }
                return nb;
            }
        }
        public int NbCat
        {
            get
            {
                int nb = 0;
                foreach (Animal animal in _animals)
                {
                    if (animal.IsAlive && animal is Cat)
                    {
                        nb++;
                    }
                }
                return nb;
            }
        }
        public int NbBird
        {
            get
            {
                int nb = 0;
                foreach (Animal animal in _animals)
                {
                    if (animal.IsAlive && animal is Bird)
                    {
                        nb++;
                    }
                }
                return nb;
            }
        }
        #endregion

        public PetStore(string name)
        {
            Name = name;
            Day = 0;
            _animals = new List<Animal>();
        }

        #region Methods
        public void AddAnimal(Animal animal)
        {
            if (!animal.IsAlive) return;

            _animals.Add(animal);
        }
        public void AddAnimal(params Animal[] animals)
        {
            foreach (Animal animal in animals)
            {
                AddAnimal(animal);
            }
        }

        private void MorningEvent()
        {
            foreach (Animal animal in _animals)
            {
                animal.startOfDay();

                if (animal.IsAlive && animal is Cat cat)
                {
                    if (!cat.CuttedClaw)
                    {
                        Console.WriteLine($"EVENT : {animal.Name} griffe Jean-Michel");

                        cat.CutClaw();
                    }
                }
            }
        }

        private void NigthEvent()
        {
            foreach (Animal animal in _animals)
            {
                animal.EndOfDay();
            }
        }

        private void CleanDeathAnimal()
        {
            int i = 0;
            while (i < _animals.Count)
            {
                Animal animal = _animals[i];

                if (!animal.IsAlive)
                {
                    _animals.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }

        public void NextDay()
        {
            Day++;
            Console.WriteLine($"Journée {Day}");
            Console.WriteLine(" - Matin");
            MorningEvent();
            Console.WriteLine(" - Inventaire des annimaux");
            Console.WriteLine($"Chat:\t{NbCat}");
            Console.WriteLine($"Chien:\t{NbDog}");
            Console.WriteLine($"Oiseau:\t{NbBird}");
            Console.WriteLine(" - Nettoyage de l'animalerie...");
            CleanDeathAnimal();
            Console.WriteLine(" - Nuit");
            NigthEvent();
        }
        #endregion
    }
}
