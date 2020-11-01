using System;
using System.Collections.Generic;
using FinApp.Domain.Service;

namespace FinApp.Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(12);

            var math = new MathService();
            math.Run(numbers);
            math.Print();
        }
    }
}
