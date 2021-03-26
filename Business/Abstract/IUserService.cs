﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetRentalByRentalId(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IResult Update(User user);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}
