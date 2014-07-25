using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvgSharp.Interfaces
{
    public interface ICore
    {
        string Id { get; set; }
        string XmlBase { get; set; }
        string XmlLang { get; set; }
        string XmlSpace { get; set; }
    }
}
