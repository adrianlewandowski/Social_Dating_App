﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialDatingApp.Application.Users.DTOs
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string KnownAs { get; set; }
        public string Description { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string Photo { get; set; }
        public int Age { get; set; }
        public string Localization { get; set; }
        public string Email { get; set; }

    }
}
