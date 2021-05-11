using LanguagePractice.Core.Utilities.Results;
using LanguagePractice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Abstract
{
    public interface IEngTurRelationService
    {
        IResult Add(EngTurRelation engTurRelation);
        IResult Update(EngTurRelation engTurRelation);
        IDataResult<EngTurRelation> GetById(int id);
        IDataResult<List<EngTurRelation>> GetAll();
    }
}
