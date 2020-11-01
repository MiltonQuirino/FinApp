using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using FinApp.Domain.Entity;
using FinApp.Domain.Interface;

namespace FinApp.Domain.Service
{
    public class MathService : IMath
    {
        private MathCore _result = new MathCore()
        {
            OddNumbers = new List<int>(),
            EvenNumbers = new List<int>()
        };

        public MathCore Run(IList<int> numbers)
        {
            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    _result.OddNumbers.Add(item);
                }
                else
                {
                    _result.EvenNumbers.Add(item);
                }

            }
            return _result;
        }

        public void Print()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Impares");
            foreach (var even in _result.EvenNumbers)
            {
                Console.WriteLine(even);

            }
            Console.WriteLine("-----------------");

            Console.WriteLine("Pares");
            foreach (var odd in _result.OddNumbers)
            {
                Console.WriteLine(odd);

            }
            Console.WriteLine("-----------------");
        }
    }
}