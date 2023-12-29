using System.Linq.Expressions;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("What is your favorite subject?");

                string favSubject = Console.ReadLine().ToLower();
                switch (favSubject)
                {
                    case "math":
                        Console.WriteLine("Well what's the solution to the Millenium Prize if you're so good at math?");
                        break;
                    case "science":
                        Console.WriteLine("Ok, brainiac. Calm down. You're no MD.");
                        break;
                    case "history":
                        Console.WriteLine("Just because you watch History Channel doesn't make you a history buff.");
                        break;
                    case "gym":
                        Console.WriteLine("Gym? Really? Why don't you just say recess?");
                        break;
                    case "music":
                        Console.WriteLine("Well let's see that music degree pay the bills, Beethoven.");
                        break;
                    case "art":
                        Console.WriteLine("Anyone can doodle. Just because you drew an S on a notebook in 3rd grade doesn't make you Picasso.");
                        break;
                    default:
                        Console.WriteLine("Really? Never heard of that subject. Must be boring.");
                        break;
            }

            // CodeWars Challenge

            Console.WriteLine("Enter your profession, and we'll tell you the best way to wash down your sorrows after a long day.");
            string job = Console.ReadLine().ToLower();

            switch (job)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;

                case "school counselor":
                    Console.WriteLine("Anything with Alcohol");
                    break;

                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;

                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;

                case "politician":
                    Console.WriteLine("Moonshine");
                    break;

                case "rapper":
                    Console.WriteLine("Cristal");
                    break;

                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
    }
}