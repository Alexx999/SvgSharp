using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SvgSharp
{
    public class Svg : Group
    {
        public const string Namespace = "http://www.w3.org/2000/svg";

        public string Version { get; set; }
        public string BaseProfile { get; set; }

        public static Svg FromFile(string path)
        {
            var file = File.OpenRead(path);

            return FromStream(file);
        }

        private static Svg FromStream(Stream stream)
        {

            Svg result = null;
            var settings = new XmlReaderSettings
            {
                ConformanceLevel = ConformanceLevel.Document,
                IgnoreComments = true,
                IgnoreWhitespace = true
            };
            using (var reader = XmlReader.Create(stream, settings))
            {
                if (reader.IsStartElement("svg"))
                {
                    result = new Svg();
                    result.FromXml(reader);
                }
            }

            return result;
        }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "version":
                {
                    Version = reader.Value;
                    return;
                }
                case "baseProfile":
                {
                    BaseProfile = reader.Value;
                    return;
                }
                default:
                {
                    base.ReadAttribute(reader);
                    return;
                }
            }
        }
    }
}
