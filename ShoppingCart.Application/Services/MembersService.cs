﻿using AutoMapper;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Services
{
    public class MembersService : IMembersService
    {
        private IMembersRepository _membersRepo;
        private IMapper _mapper;

        public MembersService(IMembersRepository memberRepo, IMapper mapper)
        {
            _membersRepo = memberRepo;
            _mapper = mapper;
        }

        public void AddMember(MemberViewModel data)
        {
            var m = _mapper.Map<Member>(data);
          
            _membersRepo.AddMember(m);
        }
    }
}
