using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CustomEnumerable : IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator() => new CustomEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
