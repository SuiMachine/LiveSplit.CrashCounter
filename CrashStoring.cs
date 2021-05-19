using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LiveSplit.CrashCounter
{
	[Serializable]

	public class CrashStoring
	{
		[NonSerialized] private static CrashStoring _Instance;
		public static CrashStoring GetInstance()
		{
			if (_Instance != null)
				return _Instance;
			else
			{
				_Instance = Load();
				return _Instance;
			}
		}


		[NonSerialized]	const string XMLFILENAME = "Components/LiveSplit.CrashCounter.xml";

		[Serializable] 
		public class CrashCounterGame
		{
			[XmlAttribute] public string GameName { get; set; }
			[XmlAttribute] public string ProcessName { get; set; }
			[XmlAttribute] public uint Crashes { get; set; }
			[XmlAttribute] public int[] AllowedReturnCodes { get; set; }

			//Conversion String <-> Uint Array
			[XmlIgnore]
			public string AllowedReturnCodesString
			{
				get
				{
					return string.Join(", ", AllowedReturnCodes.Select(x => x.ToString()).ToArray());
				}
				set
				{
					AllowedReturnCodes = value.Split(',').Select(x => x.Trim()).Where(x => x != "").Select(x => int.Parse(x)).ToArray();
				}
			}

			public CrashCounterGame()
			{
				GameName = "";
				ProcessName = "";
				Crashes = 0;
				AllowedReturnCodes = new int[] { 0 };
			}
		}

		[XmlArrayItem] public List<CrashCounterGame> Games { get; set; }

		public CrashStoring()
		{
			Games = new List<CrashCounterGame>();
		}

		public static CrashStoring Load()
		{
			if (!File.Exists(XMLFILENAME))
			{
				var obj = new CrashStoring();
				XmlOperations.SaveObjectToXML(obj, XMLFILENAME);
				return obj;
			}
			else
				return XmlOperations.ReadFromXMLFile<CrashStoring>(XMLFILENAME);
		}

		public void Save()
		{
			XmlOperations.SaveObjectToXML(this, XMLFILENAME);
		}

		internal CrashCounterGame GetGame(string gameName)
		{
			var game = Games.FirstOrDefault(x => x.GameName == gameName.ToLower());
			if (game != null)
				return game;
			else
			{
				var newGame = new CrashCounterGame() { GameName = gameName.ToLower() };
				Games.Add(newGame);
				return newGame;
			}
		}
	}
}
