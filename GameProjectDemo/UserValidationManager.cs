using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1992 && gamer.FirstName == "Büşra" && gamer.LastName == "Tamer" && gamer.IdentityNumber == 123456)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
