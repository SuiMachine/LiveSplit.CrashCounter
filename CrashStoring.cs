using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace LiveSplit.CrashCounter
{
    class CrashStoring
    {
        const string XMLFILENAME = "Components/LiveSplit.CrashCounter.xml";
        const string XMLROOTNODE = "CrashGameRoot";
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode;


        public CrashStoring()
        {

            if(!File.Exists(XMLFILENAME))
            {
                var element = xmlDoc.CreateElement(XMLROOTNODE);
                rootNode = xmlDoc.AppendChild(element);
                xmlDoc.Save(XMLFILENAME);
            }
            else
            {
                xmlDoc.Load(XMLFILENAME);
                rootNode = GetCreateNode(XMLROOTNODE);
            }
        }

        public uint GetTotalCrashes(string processName)
        {
            processName = processName.ToLower();
            if(rootNode[processName] != null)
            {
                if(uint.TryParse(rootNode[processName].InnerText, out uint val))
                    return val;
                else
                    return 0;
            }
            else
                return 0;
        }

        public void UpdateGameInfo(string processName, uint totalCrashes)
        {
            if(processName != null && processName != String.Empty)
            {
                processName = processName.ToLower();
                if(rootNode[processName] != null)
                {
                    rootNode[processName].InnerText = totalCrashes.ToString();
                    xmlDoc.Save(XMLFILENAME);
                }
                else
                {
                    var nuNode = xmlDoc.CreateElement(processName);
                    nuNode.InnerText = totalCrashes.ToString();
                    rootNode.AppendChild(nuNode);
                    xmlDoc.Save(XMLFILENAME);
                }
            }
        }

        private XmlNode GetCreateNode(string NodeName)
        {
            XmlNode retNode;
            if(xmlDoc[NodeName] == null)
            {
                retNode = xmlDoc.CreateElement(NodeName);
                xmlDoc.AppendChild(retNode);
            }
            else
                retNode = xmlDoc[NodeName];

            return retNode;
        }
    }
}
