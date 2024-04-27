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


        public static IEnumerable<object[]> IsEvenTestDataModels
        {
            get
            {
                List<object[]> data = new List<object[]>
                {
                    new object[] { new IsEvenTestDataModel() {Input = 1, Result = false} },
                    new object[] { new IsEvenTestDataModel() {Input = 2, Result = true} },
                    new object[] { new IsEvenTestDataModel() {Input = 3, Result = false } },
                    new object[] { new IsEvenTestDataModel() {Input = 4, Result = true} },
                    new object[] { new IsEvenTestDataModel() {Input = 5, Result = false } },
                    new object[] { new IsEvenTestDataModel() {Input = 6, Result = true} },
                    new object[] { new IsEvenTestDataModel() {Input = 7, Result = false } },
                    new object[] { new IsEvenTestDataModel() {Input = 8, Result = true} },
                    new object[] { new IsEvenTestDataModel() {Input = 9, Result = false} },
                    new object[] { new IsEvenTestDataModel() {Input = 10, Result = true} },
                };

                return data;
            }
        }
    }

    public class IsEvenTestDataModel
    {
        public int Input { get; set; }
        public bool Result { get; set; }
    }
}
