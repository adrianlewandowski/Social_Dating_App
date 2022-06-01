﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialDatingApp.Application.Repositories;
using SocialDatingApp.Application.Users.DTOs;
using SocialDatingApp.Application.Users.Interfaces;
using SocialDatingApp.Core;
using SocialDatingApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace SocialDatingApp.Application.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContext;
        public UserService(UserManager<User> userManager, IUnitOfWork unitOfWork, IHttpContextAccessor httpContext)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;
            _httpContext = httpContext;
        }

        public async Task<UserDTO> GetSelfAsync()
        {
            var user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);

            var userDTO = new UserDTO();
            userDTO.Id = user.Id;
            userDTO.UserName = user.UserName;
            userDTO.FirstName = user.FirstName;
            userDTO.LastName = user.LastName;
            userDTO.Age = user.Age;
            userDTO.Email = user.Email;
            userDTO.Localization = user.Localization;

            return userDTO;
        }

        public async Task<IEnumerable<UserDTO>> GetUsersAsync()
        {
            var users = await _userManager.Users.ToListAsync();

            var usersList = new List<UserDTO>();

            foreach (var user in users)
            {
                var userDTO = new UserDTO();
                userDTO.Id = user.Id;
                userDTO.UserName = user.UserName;
                userDTO.FirstName = user.FirstName;
                userDTO.LastName = user.LastName;
                userDTO.Age = user.Age;
                userDTO.Email = user.Email;
                userDTO.Localization = user.Localization;

                usersList.Add(userDTO);
            }

            return usersList;
        }

        public async Task<IEnumerable<UserDTO>> GetAllMatchesAsync()
        {
            var user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);
            
            return await _unitOfWork.ConnectionRepository.GetAllMatchesAsync(user.Id);
        }

        public async Task AddMatchAsync(string userName)
        {
            var user = await _userManager.GetUserAsync(_httpContext.HttpContext.User);

            var friend = await _userManager.FindByNameAsync(userName);

            var connection = new Connection()
            {
                User1 = user,
                User2 = friend,
                Confirmed = false
            };

            await _unitOfWork.ConnectionRepository.AddMatchAsync(connection);

            await _unitOfWork.SaveChangesAsync();
        }
    }
}