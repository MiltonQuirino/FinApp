using System.Collections.Generic;
using FinApp.Domain.Entity;

namespace FinApp.Domain.Interface
{
    public interface IMath
    {
        MathCore Run(IList<int> numbers);

        void Print();
    }
}