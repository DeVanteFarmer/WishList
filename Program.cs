// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
/*
                -   Main.js   -
function main() {
  const iWishFor = [
    "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
    "The ability to think of interesting wishes on short notice",
    "A washtub of Skittles",
    "World peace, but not the kind of world peace where all the humans are removed from existence",
    "A TV that is NOT internet-capable",
    "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
  ];

  console.log("My wishes...");
  for (const wish of iWishFor) {
    console.log(wish);
  }
}

main();               
*/


using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            Main();
        }

        static void Main()
        {
            List<string> iWishFor = new List<string>
            {
                "An original eight track of William Shatner's 'Lucy in the Sky with Diamonds'",
                "The ability to think of interesting wishes on short notice",
                "A washtub of Skittles",
                "World peace, but not the kind of world peace where all the humans are removed from existence",
                "A TV that is NOT internet-capable",
                "The ability to fly, but, like, really fast...not just, like, how fast I can walk, but, like, fast, you know?"
            };

            Console.WriteLine("My wishes...");
            foreach (string wish in iWishFor)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
