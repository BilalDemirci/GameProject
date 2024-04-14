using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth == 1999 && gamer.FirstName == "Bilal" && gamer.LastName == "Demirci" && gamer.IdentityNumber =="61075")
            {
                return true;
            }
            else {  return false; }
        }
    }
}
