﻿using Microsoft.AspNetCore.Identity;
using SocialDatingApp.Application.Account.DTOs;
using SocialDatingApp.Application.Services;
using SocialDatingApp.Core;
using SocialDatingApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialDatingApp.Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<User> LoginAsync(LoginDTO loginDTO)
        {
            var user = await _userManager.FindByNameAsync(loginDTO.Login);

            if(user is null)
                throw new ArgumentException();

            var result = await _signInManager.PasswordSignInAsync(loginDTO.Login, loginDTO.Password, false, false);

            if (!result.Succeeded)
                throw new ArgumentException();

            return user;
        }

        public async Task<User> RegisterAsync(RegisterDTO registerDTO)
        {
            var user = new User();
            user.Email = registerDTO.Email;
            user.UserName = registerDTO.Login;
            user.FirstName = registerDTO.FirstName;
            user.LastName = registerDTO.LastName;
            user.Age = registerDTO.Age;
            try
            {
                var result = await _userManager.CreateAsync(user, registerDTO.Password);
                if (!result.Succeeded)
                    throw new ArgumentException();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);

            }

            //if (!result.Succeeded)
            //    throw new ArgumentException();

            return user;
        }
    }
}
