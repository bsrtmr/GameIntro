using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager()); //Hangi sistemi kullanmak istersek onu dahil ederiz.
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1992,
                FirstName = "Büşra",
                LastName = "Tamer",
                IdentityNumber = 123456
            });
        }
    }
}
