
using Exercice_Animalerie.Enums;
using Exercice_Animalerie.Models;

PetStore petStore = new PetStore();
petStore.Name = "TechniAnimals";

Cat a1 = new Cat();
a1.Name = "Le Chat";
a1.Age = 2;
a1.Charcater = "Calin";
a1.IsShortHair = true;
a1.Sex = SexEnum.F;
a1.Size = 40;
a1.Weight = 3.5;
petStore.AddAnimal(a1);

Cat a2 = new Cat();
a2.Name = "Robert";
a2.Age = 5;
a2.Charcater = "Bouffi";
a2.IsLongHair = true;
a2.Sex = SexEnum.M;
a2.Size = 72;
a2.Weight = 14.5;
petStore.AddAnimal(a2);

Cat a3 = new Cat();
a3.Name = "Alexys";
a3.Age = 3;
a3.IsShortHair = false;
a3.Sex = SexEnum.X;
a3.Size = 61;
a3.Weight = 7.9;
petStore.AddAnimal(a3);


Dog a4 = new Dog();
a4.Name = "Snoopy";
a4.IsTrained = false;
a4.CollarColor = "Rouge";
a4.Race = "Beagle";
a4.Sex = SexEnum.M;
a4.Age = 5;
a4.Size = 45;
a4.Weight = 5.7;
petStore.AddAnimal(a4);

Dog a5 = new Dog();
a5.Name = "Grey";
a5.IsTrained = false;
a5.CollarColor = "Rose bonbon avec un noeud";
a5.Race = "Chihuahua";
a5.Sex = SexEnum.F;
a5.Age = 9;
a5.Size = 15;
a5.Weight = 0.7;
petStore.AddAnimal(a5);

Bird a6 = new Bird();
a6.Name = "Titi";
a6.Habitat = Bird.HabitatEnum.CAGE;
a6.Color = "Jaune";
a6.Age = 6;
a6.Sex = SexEnum.F;
a6.Size = 10;
a6.Weight = 0.1;
petStore.AddAnimal(a6);

while(petStore.Animals.Count() > 0)
{
    petStore.NextDay();
    Console.ReadLine();
}