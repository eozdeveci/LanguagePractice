using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Entities
{
    public class EngTur : BaseEntity
    {
        public string EnglishWord { get; set; }
        public string TurkishWord { get; set; }
        public byte TotalRepeatCount { get; set; }
        public byte RepeatedCount { get; set; }
    }
}
