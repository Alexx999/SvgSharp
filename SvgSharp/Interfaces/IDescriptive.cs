using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvgSharp.Interfaces
{
    public interface IDescriptive
    {
        Title Title { get; set; }
        Metadata Metadata { get; set; }
        Description Description { get; set; }
    }
}
