using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {
        class Dog
        {
            public string name;
            public string owner;
            public int age;
            public Gender gender;

            public enum Gender
            {
                Male, Female
            };

            public Dog(string name, string owner, int age, Gender gender)
            {
                this.name = name;
                this.owner = owner;
                this.age = age;
                this.gender = gender;
            }

            public void Bark(int x)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("Woof!");

                }
                Console.WriteLine();
            }

            public string GetTag()
            {
                string pronoun = GetPronoun(gender).ToString();
                string possessivepronoun;

                if (pronoun == "he")
                {
                    possessivepronoun = "His";
                }
                else
                {
                    possessivepronoun = "Her";
                }
                return "If lost, call " + owner + ". " + possessivepronoun + " name is " + name + " and " + pronoun + " is " + age + " years old.";
            }

            public static string GetPronoun(Gender gender)
            {
                if (gender == Gender.Female)
                    return "she";
                else
                    return "he";
            }

            static void Main(string[] args)
            {
                Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);
                puppy.Bark(3);
                Console.WriteLine(puppy.GetTag());

                Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);
                myDog.Bark(1);
                Console.WriteLine(myDog.GetTag());

                Console.ReadLine();
            }
        }
    }
}
