﻿using DomainLayer.Interfaces;
using RepositoryLayer.Contexts;
using RepositoryLayer.Repositories;
using ServiceLayer.DTOs;
using ServiceLayer.Interfaces;
using AutoMapper;
using DomainLayer.DomainModels;
using System.Collections.Generic;

namespace ServiceLayer.Services
{
    public class UserService : IUserService
    {
        MarketContext _context = new MarketContext();

        private readonly IUnitOfWork _unitOfWork;

        private Mapper mapper;

        public UserService()
        {
            _unitOfWork = new UnitOfWork(_context);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Users, UserDTO>();
                cfg.CreateMap<UserDTO, Users>();
            });
            mapper = new Mapper(config);
        }

        public IEnumerable<UserDTO> GetAllUsers()
        {
            var userDTO = mapper.Map<List<UserDTO>>(_unitOfWork.UserRepo.GetAll());
            return userDTO;
        }

        public void CreateUser(UserDTO userDTO)
        {
            var user = mapper.Map<Users>(userDTO);
            _unitOfWork.UserRepo.Insert(user);
            _unitOfWork.commit();
        }

        public void EditUser(UserDTO userDTO)
        {
            var user = mapper.Map<Users>(userDTO);
            if (user != null)
            {
                _unitOfWork.UserRepo.Update(user);
                _unitOfWork.commit();
            }
        }
    }
}