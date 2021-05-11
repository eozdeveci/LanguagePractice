using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Data.Abstract;
using LanguagePractice.Data.Constants;
using LanguagePractice.DataAccess.Abstract;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Concrete
{
    public class EngTurRelationManager : IEngTurRelationService
    {
        private IEngTurRelationDal _engTurRelationDal;
        public EngTurRelationManager(IEngTurRelationDal engTurRelationDal)
        {
            _engTurRelationDal = engTurRelationDal;
        }
        public IResult Add(EngTurRelation engTurRelation)
        {
            var relationToCheck = _engTurRelationDal.Get(w => w.EngId == engTurRelation.EngId);
            if (relationToCheck != null)
                new ErrorResult(Messages.RecordAlreadyExists);
            _engTurRelationDal.Add(engTurRelation);
            return new SuccessResult(Messages.RecordAdded);
        }

        public IDataResult<List<EngTurRelation>> GetAll()
        {
            return new SuccessDataResult<List<EngTurRelation>>(_engTurRelationDal.GetAll());
        }

        public IDataResult<EngTurRelation> GetById(int id)
        {
            return new SuccessDataResult<EngTurRelation>(_engTurRelationDal.Get(w => w.EngId == id));
        }

        public IResult Update(EngTurRelation engTurRelation)
        {

            var relationToUpdate = _engTurRelationDal.Get(w => w.EngId == engTurRelation.EngId && w.TurId == engTurRelation.TurId);
            if (relationToUpdate == null)
                new ErrorResult(Messages.RecordNotFound);
            _engTurRelationDal.Update(engTurRelation);
            return new SuccessResult(Messages.RecordUpdated);
        }
    }
}
