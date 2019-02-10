using System;
using System.Xml;

namespace OfficeEasyInstaller
{
    class PIDKEY
    {
        public static void WriteXML(String receivedKey)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("configuration.xml");

            XmlNode node = xmlDoc.SelectSingleNode("Configuration/Add/Product");
            node.Attributes["PIDKEY"].Value = receivedKey;

            xmlDoc.Save("configuration.xml");
        }

        public static void WriteXMLOfficeClientEdition(string receivedOfficeClientEdition)
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.Load("configuration.xml");

            XmlNode node = xmlDoc.SelectSingleNode("Configuration/Add");
            node.Attributes["OfficeClientEdition"].Value = receivedOfficeClientEdition;

            xmlDoc.Save("configuration.xml");
        }
    }
}