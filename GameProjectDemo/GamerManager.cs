﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
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
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
