﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
