using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class CalculationDataShare
    {
        public static IEnumerable<object[]> IsEvenData
        {
            get
            {
                List<object[]> data = new List<object[]>()
                {
                    new object[] {1, false },
                    new object[] {2, true },
                    new object[] {3, false },
                    new object[] {4, true},
                    new object[] {5, false },
                    new object[] {6, true },
                    new object[] {7, false },
                    new object[] {8, true},
                    new object[] {9, false },
                    new object[] {10, true},
                };

                return data;
            }
        }
    }
}
