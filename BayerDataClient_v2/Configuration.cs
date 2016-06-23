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
        string site;
        string connection_string;
        int ResX;
        int ResY;
        
        bool British;

        List<EVO_DataLog> Treaters = new List<EVO_DataLog>();

        public Configuration(string xmlString)
        {
            //// Create an XmlReader
            //using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
            //{
            //    string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            //    if (reader.StartsWith(_byteOrderMarkUtf8))
            //    {
            //        xml = xml.Remove(0, _byteOrderMarkUtf8.Length);
               
            //    }

            //    reader.ReadToFollowing("site");
            //    reader.MoveToFirstAttribute();
            //    site = reader.Value;

            //    Console.WriteLine(site);

            //    reader.ReadToFollowing("title");

            //}

            XmlDocument xml = new XmlDocument();
            xml.Load(xmlString); // suppose that myXmlString contains "<Names>...</Names>"

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
