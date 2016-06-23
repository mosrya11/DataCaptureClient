using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;


namespace BayerDataClient_v4
{
    class Configuration
    {
        public string site;
        public string connection_string;
        public int ResX;
        public int ResY;
        
        bool British;

        public List<EVO_DataLog> Treaters = new List<EVO_DataLog>();

        public Configuration(string xmlString)
        {

            XmlDocument xml = new XmlDocument();
            xml.Load(xmlString); // suppose that myXmlString contains "<Names>...</Names>"

            site = xml.DocumentElement.SelectSingleNode("/config/site").InnerText.Trim();
            connection_string = xml.DocumentElement.SelectSingleNode("/config/connection_string").InnerText.Trim();
            //connection_string.Replace(@"\", "");


            XmlNodeList xnList = xml.SelectNodes("config/treaters/treater");
            foreach (XmlNode xn in xnList)
            {

                EVO_DataLog Treater = new EVO_DataLog(connection_string, Convert.ToInt16(xn["flowmeters"].InnerText.Trim()), xn["table"].InnerText.Trim());
                Treaters.Add(Treater);
            }

            foreach (EVO_DataLog t in Treaters)
            { Console.WriteLine(t.sTable);  }
            
        }
    }
}
