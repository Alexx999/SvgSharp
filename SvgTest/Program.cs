using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvgSharp;

namespace SvgTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var svg = Svg.FromFile("paths-data-01-t.svg");
        }
    }
}
