using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvgSharp.Interfaces
{
    public interface IConditionalProcessing
    {
        string RequiredFeatures { get; set; }
        string RequiredExtensions { get; set; }
        string SystemLanguage { get; set; }
    }
}
