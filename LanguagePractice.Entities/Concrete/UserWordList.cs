using LanguagePractice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Entities.Concrete
{
    public class UserWordList : IEntity 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ListName { get; set; }
        public int EngWordId { get; set; }
        public int TotalRepeatCount { get; set; } = 10;
        public int RepeatedCount { get; set; } = 0;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool isActive { get; set; }
    }

}
