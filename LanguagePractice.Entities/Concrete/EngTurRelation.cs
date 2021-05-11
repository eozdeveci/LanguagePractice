using LanguagePractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Entities.Concrete
{
    public class EngTurRelation : IEntity
    {
        public int Id { get; set; }
        public int EngId { get; set; }
        public int TurId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool isActive { get; set; }
    }
}
