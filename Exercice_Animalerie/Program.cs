using Exercice_Animalerie.Enums;
using Exercice_Animalerie.Models;

PetStore petStore = new PetStore("TechniAnimals");

Cat a1 = new Cat("Le Chat", 3.5, 40, SexEnum.F ,2, "Calin", false);
Cat a2 = new Cat("Robert", 14.5, 72, SexEnum.M, 5, "Bouffi", true);
Cat a3 = new Cat("Alexys", 7.9, 61, SexEnum.X, 3, null, false);
petStore.AddAnimal(a1, a2, a3);

petStore.AddAnimal(new Dog("Snoopy", 5.7, 45, SexEnum.M, 5, "Rouge", "Beagle", true));
petStore.AddAnimal(new Dog("Grey", 0.7, 15, SexEnum.F, 9, "Rose bonbon avec un noeud", "Chihuahua", false));

petStore.AddAnimal(new Bird("Titi", 0.1, 10, SexEnum.F, 6, "Jaune", Bird.HabitatEnum.CAGE));

while(petStore.Animals.Count() > 0)
{
    petStore.NextDay();
    Console.ReadLine();
}

