using System.Collections.Generic;

namespace FinApp.Domain.Entity
{
    public class MathCore
    {
        public IList<int> Numbers { get; set; }
        public IList<int> OddNumbers { get; set; }
        public IList<int> EvenNumbers { get; set; }

    }
}