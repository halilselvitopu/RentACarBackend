﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.EntityAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.EntityDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.EntityListed);
        }

        public IDataResult<Customer> GetCustomerByUserId(int id)
        {
             return new SuccessDataResult<Customer>(_customerDal.Get(x => x.UserId == id),Messages.EntityListed);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.EntityUpdated);
        }
    }
}
