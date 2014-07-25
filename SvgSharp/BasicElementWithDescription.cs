using System.Xml;
using SvgSharp.Interfaces;

namespace SvgSharp
{
    public class BasicElementWithDescription : BasicElement, IDescriptive
    {
        public Title Title { get; set; }
        public Metadata Metadata { get; set; }
        public Description Description { get; set; }


        protected override void ReadElement(XmlReader reader)
        {
            if(ElementHelper.ReadDescriptive(this, reader)) return;
            switch (reader.Name)
            {
                default:
                {
                    base.ReadElement(reader);
                    return;
                }
            }
        }
    }
}