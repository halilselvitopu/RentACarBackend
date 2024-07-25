﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColourManager : IColourService
    {
        IColourDal _colourDal;

        public ColourManager(IColourDal colourDal)
        {
            _colourDal = colourDal;
        }

        public IResult Add(Colour colour)
        {
            return new SuccessResult(Messages.EntityAdded);
        }

        public IResult Delete(Colour colour)
        {
            return new SuccessResult(Messages.EntityDeleted);
        }

        public IDataResult<List<Colour>> GetAll()
        {
            return new SuccessDataResult<List<Colour>>(_colourDal.GetAll(), Messages.EntityListed);
        }

        public IResult Update(Colour colour)
        {
            return new SuccessResult(Messages.EntityUpdated);
        }
    }
}
