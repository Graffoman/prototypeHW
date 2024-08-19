using prototypeHW.Classes;
using prototypeHW.Tests;

//Dog dog1 = new Dog("Charly", 5, 30, "Husky");
//Dog dog2 = (Dog)dog1.Clone();

//Console.WriteLine("Stage 1. Two dogs ctreated. (dog2 is clone of dog1)");
//Console.WriteLine("______________________________");
//Console.WriteLine();

//Console.WriteLine(dog1.ToString());
//Console.WriteLine();
//Console.WriteLine(dog2.ToString());

//dog2.Name = "Willy";
//dog2.Age = 7;
//dog2.MaxLandspeed = 35;
//dog2.Breed = "Rottweiler";
//Console.WriteLine("______________________________");
//Console.WriteLine();

//Console.WriteLine("Stage 2. dog2 was updated");
//Console.WriteLine("______________________________");
//Console.WriteLine();

//Console.WriteLine(dog1.ToString());
//Console.WriteLine();
//Console.WriteLine(dog2.ToString());

CustomCloneTest test1 = new CustomCloneTest();
StandardCloneTest test2  = new StandardCloneTest();

test1.Run();