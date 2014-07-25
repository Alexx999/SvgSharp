using System.Xml;
using SvgSharp.Interfaces;

namespace SvgSharp
{
    internal static class ElementHelper
    {
        public static T Create<T>(XmlReader reader) where T : BasicElement, new()
        {
            var result = new T();
            result.FromXml(reader);
            return result;
        }

        public static bool ReadDescriptive(IDescriptive descriptive, XmlReader reader)
        {
            switch (reader.Name)
            {
                case "title":
                {
                    descriptive.Title = Create<Title>(reader);
                    return true;
                }
                case "desc":
                {
                    descriptive.Description = Create<Description>(reader);
                    return true;
                }
                case "metadata":
                {
                    descriptive.Metadata = Create<Metadata>(reader);
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
}