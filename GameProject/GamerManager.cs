﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService) 
        { 
            _userValidationService = userValidationService;
        }
            
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kullanıcı Eklendi : " + gamer.FirstName);
            }
            else 
            {
                Console.WriteLine("Kimlik Doğrulaması Başarısız! Lütfen Doğru Bilgiler ile tekrar deneyiniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı Silindi : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi : " + gamer.FirstName);
        }
    }
}
