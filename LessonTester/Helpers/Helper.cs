using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonTester.Helpers
{
    public class Helper
    {
        private Helper()
        {

        }

        public static Helper Instance = new Helper();
        public bool IsSequenceEqual(int[] array1, int[] array2)
        {
            return Enumerable.SequenceEqual(array1, array2);
        }
    }
}
