using System;
using System.IO;
using System.Xml.Serialization;

namespace CSharpExcercises {
    public class SerdesXML {

        public delegate void DataSerdesEventHandler (object source, SerdesEventArgs args);

        // public event DataSerdesEventHandler Serdesing;

        public EventHandler<SerdesEventArgs> Serdesed;
        public void serialize (DataXML data, string fullPath) {
            using (var stream = new FileStream (fullPath, FileMode.Create)) {
                var xml = new XmlSerializer (typeof (DataXML));
                xml.Serialize (stream, data);
            }
            OnSerdesed(data);
        }

        public DataXML deserialize (string fullPath) {
            DataXML data = null;
            using (var stream = new FileStream (fullPath, FileMode.Open)) {
                var xml = new XmlSerializer (typeof (DataXML));
                data = (DataXML) xml.Deserialize (stream);
            }
            return data;
        }

        protected virtual void OnSerdesed (DataXML data) {
            if (Serdesed != null)
                Serdesed (this, new SerdesEventArgs () { Data = data });
        }
    }

    public class SerdesEventArgs : EventArgs {
        public DataXML Data { get; set; }
    }

}