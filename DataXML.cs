
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CSharpExcercises
{
    [XmlRoot("data")]
    public class DataXML
    {
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("surname")]
        public string Surname { get; set; }
        [XmlElement("occupation")]
        public string Ocuppation { get; set; }
        [XmlAttribute("company")]
        public string Company { get; set; }
        [XmlElement("book")]
        public List<string> Books { get; set; }
    }
}