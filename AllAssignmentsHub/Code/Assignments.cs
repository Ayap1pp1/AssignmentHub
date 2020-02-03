using System;
using System.Collections.Generic;
using System.Text;

namespace AllAssignmentsHub.Code
{
    class Assignments
    {
        public static void Assignment1()
        {
            Console.WriteLine("Good morning World");            
        }

        public static void Assignment2()
        {
            int thisYear = 2019;
            int myBirthyear = 1987;
            int myAge = thisYear - myBirthyear;

            Console.WriteLine("I will be " + myAge + " years old in " + thisYear + ".");            
        }

        public static void Assignment3()
        {
            Console.WriteLine("You can see your grade here.");
            Console.WriteLine("Type your score on the test.: 0 out of 50");

            //läsa in värde från användaren
            string input = Console.ReadLine();
            int score;
            bool isAnInt;
            isAnInt = Int32.TryParse(input, out score);

            string result = "";

            if (isAnInt) // om input är int
            {
                if (score >= 0 && score <= 10)
                {
                    result = " You got E.";
                }
                if (score > 10 && score <= 20)
                {
                    result = " You got D.";
                }
                if (score > 20 && score <= 30)
                {
                    result = " You got C.";
                }
                if (score > 30 && score <= 40)
                {
                    result = " You got B.";
                }
                if (score > 40 && score <= 50)
                {
                    result = " You got A.";
                }
                else if (score > 50)
                {
                    result = " Error! You have to enter the score 0 our of 50.";
                }
                //skriv ut rätt betyg
            }
            else //om input är en string
            {
                result = " Error! Please enter the score 0 out of 50.";
                //vad vill jag ska hända om användaren inte skriver in en siffra?:
            }

            Console.WriteLine(result);            
        }
        public static void Assignment4()
        {
            for (int i = 0; i <= 9; i++)
            {
                int sum = (i * 2);
                Console.WriteLine(i.ToString() + " * 2 = " + sum);
            }         
        }

        public static void Assignment5()
        {
            string[] films = new string[] { "#1 Castle in the Sky", "#2 The Castle of Cagliostro", "#3 Sprited Away" };

            foreach (string film in films)
            {
                Console.WriteLine(film);
            }

            //for (int i = 0; i < films.Length; i++)
            //{
            //    Console.WriteLine(films[i]);
            //}

            Console.ReadLine();

            List<string> filmlist = new List<string> { "#1 Castle in the Sky", "#2 The Castle of Cagliostro", "#3 Sprited Away" };
            //filmlist.Add("#4 The room");
            //filmlist.Add("#5 Terminator");

            List<string> morefilms = new List<string> { "#4 The room", "#5 Terminator" };

            filmlist.AddRange(morefilms);

            foreach (string film in filmlist)
            {
                Console.WriteLine(film);
            }            
        }

        public static void Assignment6()
        {
            int dog = 7;
            int humanyears = DogToHumanYears(dog);


            Console.WriteLine("The dog is " + dog.ToString() + " years old.");
            Console.WriteLine("That is " + humanyears.ToString() + " years old in human age.");
            Console.WriteLine(String.Format("The dog is {0} years old. That is {1} years old in human age.", dog, humanyears));

            Console.ReadLine();



            int human = 56;
            int dogAge = humanToDogYears(human);

            Console.WriteLine("The man is " + human.ToString() + " years old.");
            Console.WriteLine("That is " + dogAge.ToString() + " years old in dog age.");
            Console.WriteLine(String.Format("The man is {0} years old. That is {1} years old in dog age.", human, dogAge));
        }

        public static void Assignment7()
        {
            int i = 0;
            while (i <= 9)
            {
                int sum = i * 2;
                Console.WriteLine(String.Format("{0} * 2 = {1}", i.ToString(), sum.ToString()));
                i++;
            }            
        }

        public static void Assignment8()
        {
            string tolkienQuote = "\"Little by little, one travels far\"";
            string hugoQuote = "\"Life is a flower of which love is the honey\"";
            string einsteinQuote = "\"I have no special talent.I am only passionately curious\"";

            string tolkien = "J.R.R. Tolkien";
            string hugo = "Victor Hugo";
            string einstein = "Albert Einstein";

            string quote1 = String.Format("{0} av {1}", tolkienQuote, tolkien);
            string quote2 = hugoQuote + " av " + hugo;
            string quote3 = einsteinQuote + " av " + einstein;

            Console.WriteLine(quote1);
            Console.WriteLine(quote2);
            Console.WriteLine(quote3);

        }

        public static void Assignment9()
        {
            Console.WriteLine("My favorite recipe");

            Class.Recipe recept = new Class.Recipe();
            recept.Name = "Sushi";
            recept.Portions = 2;
            recept.Ingredients = new List<string> { "Sushi rice", "Nori", "Fish", "Cucumber" };

            Console.WriteLine(String.Format("Recipe name: {0}", recept.Name));
            Console.WriteLine(String.Format("Total portions: {0}", recept.Portions));
            Console.WriteLine("Ingredients:");
            for (int i = 0; i < recept.Ingredients.Count; i++)
            {
                Console.WriteLine(String.Format("{0}: {1}", i + 1, recept.Ingredients[i]));
            }

        }
        private static int DogToHumanYears(int dogyears)
        {
            //räkna ut hund till människoår
            return dogyears * 7;

        }

        private static int humanToDogYears(int humanAge)
        {
            //räkna ut mäniskor till hund
            return humanAge / 7;
        }

    }
}


