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

        public int[] GetAllowedReturnCodes(string processName)
        {
            processName = processName.ToLower();
            if (rootNode[processName] != null)
            {
                if(rootNode[processName].Attributes["ReturnCodes"] != null)
                {
                    var split = rootNode[processName].Attributes["ReturnCodes"].Value.Split(',');
                    List<int> returnCodesList = new List<int>();
                    foreach(var element in split)
                    {
                        if (int.TryParse(element, out int ReturnCode))
                        {
                            if (!returnCodesList.Contains(ReturnCode))
                                returnCodesList.Add(ReturnCode);
                        }

                    }
                    return returnCodesList.ToArray();

                }
                else
                    return new int[] { 0 };

            }
            else
                return new int[] { 0 };
        }

        public void UpdateGameInfo(string processName, uint totalCrashes, int[] allowedReturnedCodes)
        {
            if(processName != null && processName != String.Empty)
            {
                processName = processName.ToLower();
                if(rootNode[processName] != null)
                {
                    rootNode[processName].InnerText = totalCrashes.ToString();
                    if (rootNode[processName].Attributes["ReturnCodes"] != null)
                        rootNode[processName].Attributes["ReturnCodes"].Value = string.Join(",", allowedReturnedCodes);
                    else
                    {
                        var newAttribute = xmlDoc.CreateAttribute("ReturnCodes");
                        newAttribute.Value = string.Join(",", allowedReturnedCodes);
                        rootNode[processName].Attributes.Append(newAttribute);
                    }
                    
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
