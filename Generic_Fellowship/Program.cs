// See https://aka.ms/new-console-template for more information

/*

The goal of this assignment is to create a fellowship of the ring using generics in C#. 
In the Lord of the Rings universe, the fellowship is a group of characters with different skills and abilities 
who join together to destroy the One Ring and defeat the evil Sauron. In this assignment, 
you will create a generic class to represent the fellowship, 
and you will use it to create a fellowship of characters from the Lord of the Rings.

 

Instructions:
Add a new generic class to the project called "Fellowship<T>". 
The type parameter T represents the type of character that can be part of the fellowship. 
The class should have the following properties and methods:
    A private List<T> field called "members" to store the characters in the fellowship.
    A public constructor that initializes the "members" list.
    A public method called "AddMember" that takes a parameter of type T and adds it to the "members" list.A public method called "RemoveMember" that takes a parameter of type T and removes it from the "members" list.
    A public method called "GetMembers" that returns the "members" list.

Create a new class called "Character". This class should have the following properties and methods:
    A public string property called "Name" to store the name of the character.
    A public string property called "Race" to store the race of the character.
    A public int property called "Level" to store the level of the character.
    A public method called "Attack" that takes a parameter of type Character and simulates an attack on that character. 
    For example, you could print a message like "{Name} attacks {otherCharacter.Name} for {damage} damage!”.
    
    
Create several subclasses of the "Character" class to represent different characters from the Lord of the Rings universe. For example, you could create a "Human" class, an "Elf" class, a "Dwarf" class, and so on. Each subclass should override the "Attack" method to provide a unique implementation.
Create a new method in the "Program" class called "CreateFellowship" that creates a new instance of the "Fellowship" class and adds several characters to it. For example, you could add a "Human" character, an "Elf" character, a "Dwarf" character, and so on.
In the "Main" method, call the "CreateFellowship" method and then loop through the members of the fellowship, calling the "Attack" method on each one.

*/

using System;
using System.Collections.Generic;
using Generic_Fellowship;

namespace Generic_Fellowship
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Character> members = new List<Character>
            {
                new ("Hobbit", "Frodo", 5),
                new ("Orc", "Uruk", 8),
                new ("Dwarf", "Gimli", 10),
                new ("Elf", "Legolas", 15),
                new ("Wizard", "Gandalf", 20),
            };
            Fellowship<Character> fellowship = new Fellowship<Character>(members);

            List<Character> enemies = new List<Character>
            {
                new ("Orc", "Uruk", 24),
                new ("Orc", "Snaga", 5),
                new ("Troll", "Mountain Troll", 16),
                new ("Nazgul", "Witch King", 16),
                new ("Warg", "Feral Warg", 10)
            };

            foreach (var enemy in enemies)
            {
                foreach (var fellowshipMember in fellowship.Members.ToArray())
                {
                    if (fellowshipMember.Attack(enemy))
                    {
                        break;
                    }
                    else
                    {
                        fellowship.RemoveMember(fellowshipMember); 
                    }
                }

                if (fellowship.Members.Count == 0)
                {
                    break;
                }
            }

            if (fellowship.Members.Count == 0)
            {
                Console.WriteLine("The enemies won");
            }
            else
            {
                Console.WriteLine("The fellowship won");
            }
        }
    }

}
