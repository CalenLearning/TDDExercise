using System;

namespace TDDExercise.Business
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Voer voornaam in");
            string firstName = Console.ReadLine();

            Console.WriteLine("Voer achternaam in");
            string lastName = Console.ReadLine();

            Console.WriteLine("Voer email-adres in");
            string email = Console.ReadLine();

            //TODO Add EntityFramework eventually?
            int id = 1;

            User user = new User() { FirstName = firstName, LastName = lastName, Email = email, Id = id };

            bool validEntry = ValidateService.Validate(user);

            if (validEntry)
            {
                //TODO Fix error - TDDExercise.Business.SaveService.Save(user);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
