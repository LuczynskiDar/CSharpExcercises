using System.IO;
using System.Xml.Serialization;

namespace CSharpExcercises
{
    public class SerdesXML
    {
        public void serialize(DataXML data, string fullPath)
        {
            using ( var stream= new FileStream(fullPath, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(DataXML));
                xml.Serialize(stream, data);
            }
        }

        public DataXML deserialize(string fullPath)
        {
            DataXML data = null;
            using ( var stream = new FileStream(fullPath, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(DataXML));
                data = (DataXML)xml.Deserialize(stream);
            }
            return data;
        }
    }
}