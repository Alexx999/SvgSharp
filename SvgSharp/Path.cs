using System.Xml;

namespace SvgSharp
{
    public class Path : GraphicsElement
    {
        public string Class { get; set; }
        public string Style { get; set; }
        public string ExternalResourcesRequired { get; set; }
        public string Transform { get; set; }
        public string Data { get; set; }
        public string PathLength { get; set; }

        protected override void ReadAttribute(XmlReader reader)
        {
            switch (reader.Name)
            {
                case "class":
                {
                    Class = reader.Value;
                    return;
                }
                case "style":
                {
                    Style = reader.Value;
                    return;
                }
                case "externalResourcesRequired":
                {
                    ExternalResourcesRequired = reader.Value;
                    return;
                }
                case "transform":
                {
                    Transform = reader.Value;
                    return;
                }
                case "d":
                {
                    Data = reader.Value;
                    return;
                }
                case "pathLength":
                {
                    PathLength = reader.Value;
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