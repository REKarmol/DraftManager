using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace DraftManager
{

	//**********************************************************
	public class Model
	//**********************************************************
	{
		public const int maxPlayers = 2500;
		public const int maxRanks = 200;
		public const int maxPositions = 8;
		public const int maxFfls = 20;
		public const int maxNfls = 36;
		public const int maxRounds = 20;
		public const string importDirectory = @"C:\DraftManager"; //"C:\\Users\\edgikbq\\Documents\\Old Documents\\Documents";

		public int Nfls { get; set; }
		public int Ffls { get; set; }
		public int Players { get; set; }
		public int Scores { get; set; }
		public int Positions { get; set; }
		public int Timer { get; set; }
		public int Style { get; set; }
		public int Rounds { get; set; }
		public string Order { get; set; }
		public string DraftComment { get; set; }
		public int NextPick { get; set; }
		public int TotalPicks { get; set; }
		public int CurrentPick { get; set; }
		public int PlayerIndexes { get; set; }
		public int[] PlayerIndex { get; set; }
		public float[] PlayerValue { get; set; }
		public int[] PlayerRanking { get; set; }
		public string URI { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public float Salary { get; set; }
		public float MinBid { get; set; }
		public int[] Need { get; set; }
		public int[] Have { get; set; }
		public int[] BLin { get; set; }

		public List<Ffl>        Ffl;
		public List<Nfl>        Nfl;
		public List<Pick>       Pick;
		public List<Player>     Player;
		public List<Position>   Position;
		public List<Comment>    Comment;
		public List<Average>    Average;
		public List<Confidence> Confidence;
		public List<Limit>      Limit;
		public List<Weight>     Weight;
		public List<Ranking>    Ranking;
		public List<Score>      Score;

		private string[] ordervalues =
		{
			"FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF",
			"FLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFL",
			"FLLLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFL",
			"FLLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLFLF",
			"FLLFFLLFFLLFFLLFFLLFFLLFFLLFFLLFFLLFFLLFFLLFFLLF",
			"FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF"
		};
		public string[] orderchoices =
		{
			"Standard         (FFFFFFFFF...)",
			"Snake            (FLFLFLFLF...)",
			"3rd Rnd Reversal (FLLLFLFLF...)",
			"3rd Rnd Switch   (FLLFLFLFL...)",
			"Double Snake     (FLLFFLLFF...)",
			"Auction"
		};

		private float[] pconfidence;
		private float[] pweight;
		private int[] TempIndex;
		private int[] TempRanking;
		private float[] TempValue;
		//private float[] TempWeekly;
		private int tempindexes;
		private string leagueDirectory;
		private string picksfile;


		//***********************************************************************
		public Model ()
		//***********************************************************************
		{
			Nfl        = new List<Nfl>(36);
			Ffl        = new List<Ffl>(20);
			Pick       = new List<Pick>(20*16);
			Player     = new List<Player>(2500);
			Ranking    = new List<Ranking>(16*8*120);
			Position   = new List<Position>(16);
			Score      = new List<Score>(64);
			Average    = new List<Average>();
			Confidence = new List<Confidence>(16*8);
			Weight     = new List<Weight>(16*8*6);
			Limit      = new List<Limit>(16*8*20);
			Comment    = new List<Comment>(16*20);

			PlayerIndex = new int[maxPlayers];
			PlayerValue = new float[maxPlayers];
			PlayerRanking = new int[maxPlayers];

			TempIndex   = new int[maxRanks];
			TempRanking = new int[maxRanks];
			TempValue   = new float[maxRanks];
			//TempWeekly  = new float[maxRanks];

			Have        = new int[maxPositions];
			Need        = new int[maxPositions];
			BLin        = new int[maxPositions];
			pconfidence = new float[maxPositions];
			pweight     = new float[maxPositions];

			Style =   3;
			Timer = 120;
			Rounds = 16;
			Nfls = 0;
			Positions = 0;
			Players = 0;
			Ffls = 12;
			TotalPicks = 0;
			URI = "ftp://ftp.karmol.comlu.com";
			Username = "a3585714";
			Password = "Raptor23";
			leagueDirectory = "";
			picksfile = "";
		}


		//***********************************************************************
		public void SetLeagueDirectory (string d)
		//***********************************************************************
		{
			leagueDirectory = d;
			picksfile = leagueDirectory + @"\Default.picks";
		}


		//***********************************************************************
		public void DefaultPicks ()
		//***********************************************************************
		{
			Pick.Clear();
			TotalPicks = Ffls*Rounds;
			for (int i=0; i<TotalPicks; i++)
				Pick.Add(new Pick(0, 0));
		}


		//***********************************************************************
		public void DefaultNFL ()
		//***********************************************************************
		{
			Nfl.Clear();
			Nfl.Add(new Nfl("", "", "", "", ""));
			Nfl.Add(new Nfl("ARI", "Arizona", "Cardinals", "0", "ARI, ARZ, Arizona, Cardinals"));
			Nfl.Add(new Nfl("ATL", "Atlanta", "Falcons", "0", "ATL, Atlanta, Falcons"));
			Nfl.Add(new Nfl("BAL", "Baltimore", "Ravens", "0", "BAL, Baltimore, Ravens"));
			Nfl.Add(new Nfl("BUF", "Buffalo", "Bills", "0", "BUF, Buffalo, Bills"));
			Nfl.Add(new Nfl("CAR", "Carolina", "Panthers", "0", "CAR, Carolina, Panthers"));
			Nfl.Add(new Nfl("CHI", "Chicago", "Bears", "0", "CHI, Chicago, Bears"));
			Nfl.Add(new Nfl("CIN", "Cincinnati", "Bengals", "0", "CIN, Cincinnati, Bengals"));
			Nfl.Add(new Nfl("CLE", "Cleveland", "Browns", "0", "CLE, Cleveland, Browns"));
			Nfl.Add(new Nfl("DAL", "Dallas", "Cowboys", "0", "DAL, Dallas, Cowboys"));
			Nfl.Add(new Nfl("DEN", "Denver", "Broncos", "0", "DEN, Denver, Broncos"));
			Nfl.Add(new Nfl("DET", "Detroit", "Lions", "0", "DET, Detroit, Lions"));
			Nfl.Add(new Nfl("GB", "Green Bay", "Packers", "0", "GB, GBP, GNB, Green, Packers"));
			Nfl.Add(new Nfl("HOU", "Houston", "Texans", "0", "HOU, Houston, Texans"));
			Nfl.Add(new Nfl("IND", "Indianapolis", "Colts", "0", "IND, Indianapolis, Colts"));
			Nfl.Add(new Nfl("JAC", "Jacksonville", "Jaguars", "0", "JAC, JAX, Jacksonville, Jaguars"));
			Nfl.Add(new Nfl("KC", "Kansas City", "Chiefs", "0", "KC, KCC, KAN, Kansas, Chiefs"));
			Nfl.Add(new Nfl("MIA", "Miami", "Dolphins", "0", "MIA, Miami, Dolphins"));
			Nfl.Add(new Nfl("MIN", "Minnesota", "Vikings", "0", "MIN, Minnesota, Vikings"));
			Nfl.Add(new Nfl("NE", "New England", "Patriots", "0", "NE, NEP, NWE, England, Patriots"));
			Nfl.Add(new Nfl("NO", "New Orleans", "Saints", "0", "NO, NOS, NOR, Orleans, Saints"));
			Nfl.Add(new Nfl("NYG", "New York", "Giants", "0", "NYG, NYN, Giants"));
			Nfl.Add(new Nfl("NYJ", "New York", "Jets", "0", "NYJ, NYA, Jets"));
			Nfl.Add(new Nfl("OAK", "Oakland", "Raiders", "0", "OAK, Oakland, Raiders"));
			Nfl.Add(new Nfl("PHI", "Philadelphia", "Eagles", "0", "PHI, Philadelphia, Eagles"));
			Nfl.Add(new Nfl("PIT", "Pittsburgh", "Steelers", "0", "PIT, Pittsburgh, Steelers"));
			Nfl.Add(new Nfl("SD", "San Diego", "Chargers", "0", "SD, SDC, SDG, Diego, Chargers"));
			Nfl.Add(new Nfl("SEA", "Seattle", "Seahawks", "0", "SEA, Seattle, Seahawks"));
			Nfl.Add(new Nfl("SF", "San Francisco", "49ers", "0", "SF, SFO, Francisco, Forty, Niners, 49ers"));
			Nfl.Add(new Nfl("STL", "Saint Louis", "Rams", "0", "STL, Saint, Louis, Rams"));
			Nfl.Add(new Nfl("TB", "Tampa Bay", "Buccaneers", "0", "TB, TBB, TAM, Tampa, Buccaneers"));
			Nfl.Add(new Nfl("TEN", "Tennessee", "Titans", "0", "TEN, Tennessee, Titans"));
			Nfl.Add(new Nfl("WAS", "Washington", "Redskins", "0", "WAS, Washington, Redskins"));
			Nfls = Nfl.Count-1;
			Nfl.Sort();
		}


		//***********************************************************************
		public void DefaultPos ()
		//***********************************************************************
		{
			Position.Clear();
			Position.Add(new Position("", "", 0, 0, 0, ""));
			Position.Add(new Position("QB", "QB", 1, 1, 1, "QB, Q, Quarterback"));
			Position.Add(new Position("RB", "RB", 2, 2, 2, "RB, R, Running, FB"));
			Position.Add(new Position("WR", "WR", 2, 2, 2, "WR, W, Wide, Receiver"));
			Position.Add(new Position("TE", "TE", 1, 1, 1, "TE, T, Tight"));
			Position.Add(new Position("PK", "PK", 1, 1, 1, "PK, K, Place, Kicker"));
			Position.Add(new Position("DEF", "DEF", 1, 1, 1, "DT, D, DST, Def, Defense"));
			Positions = Position.Count - 1;

			//add scoring
			Score.Clear();
			Score.Add(new Score(0, "PPG", 1.0f));
			Score.Add(new Score(0, "PYDS", 0.05f));
			Score.Add(new Score(0, "PTDS", 4.00f));
			Score.Add(new Score(0, "INTS", -2.0f));
			Score.Add(new Score(0, "RYDS", 0.10f));
			Score.Add(new Score(0, "RTDS", 6.00f));
			Score.Add(new Score(0, "CYDS", 0.10f));
			Score.Add(new Score(0, "CTDS", 6.00f));
			Score.Add(new Score(0, "FUMS", -2.0f));
			Score.Add(new Score(0, "RECS", 1.00f));
			Score.Add(new Score(5, "PATS", 1.00f));
			Score.Add(new Score(5, "FG3S", 3.00f));
			Score.Add(new Score(5, "FG4S", 4.00f));
			Score.Add(new Score(5, "FG5S", 5.00f));
			Score.Add(new Score(6, "SAKS", 1.00f));
			Score.Add(new Score(6, "SAFS", 2.00f));
			Score.Add(new Score(6, "INTS", 2.00f));
			Score.Add(new Score(6, "FUMS", 2.00f));
			Score.Add(new Score(6, "DTDS", 6.00f));
			Score.Add(new Score(6, "STDS", 6.00f));
			Score.Add(new Score(6, "PA0", 10.0f));
			Score.Add(new Score(6, "PA6", 7.0f));
			Score.Add(new Score(6, "PA13", 4.0f));
			Score.Add(new Score(6, "PA17", 1.0f));
			Scores = Score.Count;
			Score.Sort();
		}


		//***********************************************************************
		public void DefaultPlayer ()
		//***********************************************************************
		{
			Player.Clear();
			Player.Add(new Player("", "", 0, 0, 0, 0));
			Player.Add(new Player("", "PASS", 0, 0, 0, 0));
			Players = Player.Count;
		}


		//***********************************************************************
		public void DefaultTeams ()
		//***********************************************************************
		{
			Ffl.Clear();
			Confidence.Clear();
			Comment.Clear();
			Limit.Clear();
			Weight.Clear();
			Ranking.Clear();

			Ffl.Add(new Ffl("", "", ""));
			for (int t=1; t<=Ffls; t++)
			{
				Ffl.Add(new Ffl("Team"+t.ToString(), "", ""));

				Confidence.Add(new Confidence(t, 1, 1.00F));
				Confidence.Add(new Confidence(t, 2, 1.00F));
				Confidence.Add(new Confidence(t, 3, 1.00F));
				Confidence.Add(new Confidence(t, 4, 0.75F));
				Confidence.Add(new Confidence(t, 5, 0.6F));
				Confidence.Add(new Confidence(t, 6, 0.4F));

				Weight.Add(new Weight(t, "QB", 1, 10.0F));
				Weight.Add(new Weight(t, "QB", 2, 10.0F));
				Weight.Add(new Weight(t, "RB", 1, 10.0F));
				Weight.Add(new Weight(t, "RB", 2, 10.0F));
				Weight.Add(new Weight(t, "RB", 3, 10.0F));
				Weight.Add(new Weight(t, "RB", 4, 10.0F));
				Weight.Add(new Weight(t, "WR", 1, 10.0F));
				Weight.Add(new Weight(t, "WR", 2, 10.0F));
				Weight.Add(new Weight(t, "WR", 3, 10.0F));
				Weight.Add(new Weight(t, "WR", 4, 10.0F));
				Weight.Add(new Weight(t, "TE", 1, 10.0F));
				Weight.Add(new Weight(t, "TE", 2, 10.0F));
				Weight.Add(new Weight(t, "PK", 1, 10.0F));
				Weight.Add(new Weight(t, "PK", 2, 10.0F));
				Weight.Add(new Weight(t, "DEF", 1, 10.0F));
				Weight.Add(new Weight(t, "DEF", 2, 10.0F));

				for (int r = 1; r <= Rounds; r++)
				{
					Comment.Add(new Comment(t, r, ""));
					for (int p=1; p<=Positions; p++)
					{
						Limit.Add(new Limit(t, p, r, 6));
					}
				}

				Confidence.Sort();
				Comment.Sort();
				Limit.Sort();
				Weight.Sort();
			}
		}


		//***********************************************************************
		public void New ()
		//***********************************************************************
		{
			Ffls = 12;
			Style = 3;
			Timer = 120;
			Rounds = 16;
			Positions = 6;

			DefaultNFL();
			DefaultPos();
			DefaultPlayer();
			DefaultTeams();
			DefaultPicks();
			RebuildPicks();
		}


		//***********************************************************************
		public void Open (string f)
		//***********************************************************************
		{
			// read League Draft file
			picksfile = f.Replace(".draft", ".picks");
			StreamWriter errors = new StreamWriter(leagueDirectory+@"\OpenErrors.lst", false);
			if (File.Exists(f)==true)
			{
				XmlReader rdr = XmlReader.Create(f);
				while (rdr.Read())
				{
					if (rdr.NodeType == XmlNodeType.Element)
					{

						//============================================================
						// <parameters>...
						//============================================================
						if (rdr.Name == "parameters")
						{
							int i;
							float d;
							Order = rdr.GetAttribute("order");
							Rounds = Order.Length;
							int.TryParse(rdr.GetAttribute("timer"), out i);
							Timer = i;
							int.TryParse(rdr.GetAttribute("style"), out i);
							Style = i;
							float.TryParse(rdr.GetAttribute("salary"), out d);
							Salary = d;
							float.TryParse(rdr.GetAttribute("minbid"), out d);
							MinBid = d;
							URI = rdr.GetAttribute("uri");
							Username = rdr.GetAttribute("username");
							Password = rdr.GetAttribute("password");
							continue;
						}

						//============================================================
						// <nfls><nfl>...</nfls>
						//============================================================
						if (rdr.Name == "nfls")
						{
							Nfl.Clear();
							Nfl.Add(new Nfl("", "", "", "", ""));
							continue;
						}
						if (rdr.Name == "nfl")
						{
							string name = rdr.GetAttribute("name");
							string city = rdr.GetAttribute("city");
							string team = rdr.GetAttribute("team");
							string byew = rdr.GetAttribute("byew");
							string conv = rdr.GetAttribute("conv");
							Nfl.Add(new Nfl(name, city, team, byew, conv));
							continue;
						}

						//============================================================
						// <players><player>...</players>
						//============================================================
						if (rdr.Name == "players")
						{
							Player.Clear();
							Player.Add(new Player("", "", 0, 0, 0, 0));
							Player.Add(new Player("", "PASS", 0, 0, 0, 0));
							continue;
						}
						if (rdr.Name == "player")
						{
							string last = rdr.GetAttribute("last");
							string first = rdr.GetAttribute("first");
							int pos; int.TryParse(rdr.GetAttribute("pos"), out pos);
							int nfl; int.TryParse(rdr.GetAttribute("nfl"), out nfl);
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							float adp; float.TryParse(rdr.GetAttribute("adp"), out adp);
							Player.Add(new Player(last, first, pos, nfl, ffl, adp));
							continue;
						}

						//============================================================
						// <ffls><ffl>...</ffls>
						//============================================================
						if (rdr.Name == "ffls")
						{
							Ffl.Clear();
							Ffl.Add(new Ffl("", "", ""));
							continue;
						}
						if (rdr.Name == "ffl")
						{
							string name = rdr.GetAttribute("name");
							string owner = rdr.GetAttribute("owner");
							string email = rdr.GetAttribute("email");
							Ffl.Add(new Ffl(name, owner, email));
							continue;
						}

						//============================================================
						// <positions><position>...</positions>
						//============================================================
						if (rdr.Name == "positions")
						{
							Position.Clear();
							Position.Add(new Position("", "", 0, 0, 0, ""));
							continue;
						}
						if (rdr.Name == "position")
						{
							string name = rdr.GetAttribute("name");
							string group = rdr.GetAttribute("group");
							int gn; int.TryParse(rdr.GetAttribute("num"), out gn);
							int pn; int.TryParse(rdr.GetAttribute("min"), out pn);
							int px; int.TryParse(rdr.GetAttribute("max"), out px);
							string conv = rdr.GetAttribute("conv");
							Position.Add(new Position(name, group, gn, pn, px, conv));
							continue;
						}

						//============================================================
						// <scores><score>...</scores>
						//============================================================
						if (rdr.Name == "scores")
						{
							Score.Clear();
							continue;
						}
						if (rdr.Name == "score")
						{
							int pos; int.TryParse(rdr.GetAttribute("position"), out pos);
							string category = rdr.GetAttribute("category");
							float val; float.TryParse(rdr.GetAttribute("value"), out val);
							Score.Add(new Score(pos, category, val));
							continue;
						}

						//============================================================
						// <averages><average>...</averages>
						//============================================================
						if (rdr.Name == "averages")
						{
							Average.Clear();
							continue;
						}
						if (rdr.Name == "average")
						{
							int rank; int.TryParse(rdr.GetAttribute("rank"), out rank);
							int pos; int.TryParse(rdr.GetAttribute("position"), out pos);
							float val; float.TryParse(rdr.GetAttribute("average"), out val);
							Average.Add(new Average(rank, pos, val));
							continue;
						}

						//============================================================
						// <confidences><confidence>...</confidences>
						//============================================================
						if (rdr.Name == "confidences")
						{
							Confidence.Clear();
							continue;
						}
						if (rdr.Name == "confidence")
						{
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							int pos; int.TryParse(rdr.GetAttribute("position"), out pos);
							float val; float.TryParse(rdr.GetAttribute("confidence"), out val);
							Confidence.Add(new Confidence(ffl, pos, val));
							continue;
						}

						//============================================================
						// <comments><comment>...</comments>
						//============================================================
						if (rdr.Name == "comments")
						{
							Comment.Clear();
							continue;
						}
						if (rdr.Name == "comment")
						{
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							int round; int.TryParse(rdr.GetAttribute("round"), out round);
							string comment = rdr.GetAttribute("comment");
							Comment.Add(new Comment(ffl, round, comment));
							continue;
						}

						//============================================================
						// <limits><limit>...</limits>
						//============================================================
						if (rdr.Name == "limits")
						{
							Limit.Clear();
							continue;
						}
						if (rdr.Name == "limit")
						{
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							int pos; int.TryParse(rdr.GetAttribute("position"), out pos);
							int round; int.TryParse(rdr.GetAttribute("round"), out round);
							int lim; int.TryParse(rdr.GetAttribute("limit"), out lim);
							Limit.Add(new Limit(ffl, pos, round, lim));
							continue;
						}

						//============================================================
						// <weights><weight>...</weights>
						//============================================================
						if (rdr.Name == "weights")
						{
							Weight.Clear();
							continue;
						}
						if (rdr.Name == "weight")
						{
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							string group = rdr.GetAttribute("group");
							int dep; int.TryParse(rdr.GetAttribute("depth"), out dep);
							float val; float.TryParse(rdr.GetAttribute("weight"), out val);
							Weight.Add(new Weight(ffl, group, dep, val));
							continue;
						}

						//============================================================
						// <rankings><ranking>...</rankings>
						//============================================================
						if (rdr.Name == "rankings")
						{
							Ranking.Clear();
							continue;
						}
						if (rdr.Name == "ranking")
						{
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							int line; int.TryParse(rdr.GetAttribute("line"), out line);
							int pos; int.TryParse(rdr.GetAttribute("position"), out pos);
							int player; int.TryParse(rdr.GetAttribute("player"), out player);
							int rank; int.TryParse(rdr.GetAttribute("rank"), out rank);
							int tier; int.TryParse(rdr.GetAttribute("tier"), out tier);
							float ppg; float.TryParse(rdr.GetAttribute("ppg"), out ppg);
							float points; float.TryParse(rdr.GetAttribute("points"), out points);
							Ranking.Add(new Ranking(rdr.GetAttribute("name"), ffl, line, pos, player, rank, 0, tier, points, ppg, rdr.GetAttribute("risk")));
							continue;
						}

						//============================================================
						// <picks><pick>...</picks>
						//============================================================
						if (rdr.Name == "picks")
						{
							Pick.Clear();
							continue;
						}
						if (rdr.Name == "pick")
						{
							int ffl; int.TryParse(rdr.GetAttribute("ffl"), out ffl);
							int player; int.TryParse(rdr.GetAttribute("player"), out player);
							Pick.Add(new Pick(ffl, player));
							continue;
						}

						errors.Write("Unknown Segment: ");
						errors.WriteLine(rdr.Name);
					}
					if (rdr.NodeType == XmlNodeType.EndElement)
					{
						//============================================================
						// <parameters>...
						//============================================================
						if (rdr.Name == "parameters")
						{
							continue;
						}

						//============================================================
						// <nfls><nfl>...</nfls>
						//============================================================
						if (rdr.Name == "nfls")
						{
							Nfl.Sort();
							Nfls = Nfl.Count - 1;
							continue;
						}

						//============================================================
						// <players><player>...</players>
						//============================================================
						if (rdr.Name == "players")
						{
							Player.Sort();
							Players = Player.Count;
							continue;
						}

						//============================================================
						// <ffls><ffl>...</ffls>
						//============================================================
						if (rdr.Name == "ffls")
						{
							Ffls = Ffl.Count - 1;
							continue;
						}

						//============================================================
						// <positions><position>...</positions>
						//============================================================
						if (rdr.Name == "positions")
						{
							Positions = Position.Count - 1;
							continue;
						}

						//============================================================
						// <scores><score>...</scores>
						//============================================================
						if (rdr.Name == "scores")
						{
							Scores = Score.Count;
							Score.Sort();
							continue;
						}

						//============================================================
						// <averages><average>...</averages>
						//============================================================
						if (rdr.Name == "averages")
						{
							Average.Sort();
							continue;
						}

						//============================================================
						// <confidences><confidence>...</confidences>
						//============================================================
						if (rdr.Name == "confidences")
						{
							Confidence.Sort();
							continue;
						}

						//============================================================
						// <comments><comment>...</comments>
						//============================================================
						if (rdr.Name == "comments")
						{
							Comment.Sort();
							continue;
						}

						//============================================================
						// <limits><limit>...</limits>
						//============================================================
						if (rdr.Name == "limits")
						{
							Limit.Sort();
							continue;
						}

						//============================================================
						// <weights><weight>...</weights>
						//============================================================
						if (rdr.Name == "weights")
						{
							Weight.Sort();
							continue;
						}

						//============================================================
						// <rankings><ranking>...</rankings>
						//============================================================
						if (rdr.Name == "rankings")
						{
							Ranking.Sort();
							continue;
						}

						//============================================================
						// <picks><pick>...</picks>
						//============================================================
						if (rdr.Name == "picks")
						{
							continue;
						}

						errors.Write("Unknown Segment: ");
						errors.WriteLine(rdr.Name);
					}
				}
				rdr.Close();
				errors.Close();
			}
			TotalPicks = Ffls * Rounds;
			ReadPicks();
			return;
		}

		//***********************************************************************
		public void Save (string f)
		//***********************************************************************
		{
			int i;
			picksfile = f.Replace(".draft", ".picks");

			XmlTextWriter wr = new XmlTextWriter(f, Encoding.UTF8);
			wr.Formatting = Formatting.Indented;
			wr.WriteStartDocument(true);
			wr.WriteStartElement("draft");

			//============================================================
			// <parameters...>
			//============================================================
			wr.WriteStartElement("parameters");
			{
				wr.WriteStartAttribute("timer");
				wr.WriteString(Timer.ToString());
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("order");
				wr.WriteString(Order);
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("style");
				wr.WriteString(Style.ToString());
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("salary");
				wr.WriteString(Salary.ToString());
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("minbid");
				wr.WriteString(MinBid.ToString());
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("uri");
				wr.WriteString(URI.ToString());
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("username");
				wr.WriteString(Username.ToString());
				wr.WriteEndAttribute();

				wr.WriteStartAttribute("password");
				wr.WriteString(Password.ToString());
				wr.WriteEndAttribute();
			}
			wr.WriteEndElement();


			//============================================================
			// <nfls><nfl>...</nfls>
			//============================================================
			wr.WriteStartElement("nfls");
			for (i = 1; i < Nfl.Count; i++)
			{
				wr.WriteStartElement("nfl");
				{
					wr.WriteStartAttribute("name");
					wr.WriteString(Nfl[i].Name);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("city");
					wr.WriteString(Nfl[i].City);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("team");
					wr.WriteString(Nfl[i].Team);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("byew");
					wr.WriteString(Nfl[i].Bye);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("conv");
					wr.WriteString(Nfl[i].Conversion);
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <players><player>...</players>
			//============================================================
			wr.WriteStartElement("players");
			for (i = 2; i < Player.Count; i++)
			{
				wr.WriteStartElement("player");
				{
					wr.WriteStartAttribute("last");
					wr.WriteString(Player[i].Last);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("first");
					wr.WriteString(Player[i].First);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("pos");
					wr.WriteString(Player[i].Position.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("nfl");
					wr.WriteString(Player[i].Nfl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("ffl");
					wr.WriteString(Player[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("adp");
					wr.WriteString(Player[i].Adp.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <ffls><ffl>...</ffls>
			//============================================================
			wr.WriteStartElement("ffls");
			for (i = 1; i < Ffl.Count; i++)
			{
				wr.WriteStartElement("ffl");
				{
					wr.WriteStartAttribute("name");
					wr.WriteString(Ffl[i].Name);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("owner");
					wr.WriteString(Ffl[i].Owner);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("email");
					wr.WriteString(Ffl[i].Email);
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <positions><position>...</positions>
			//============================================================
			wr.WriteStartElement("positions");
			for (i = 1; i < Position.Count; i++)
			{
				wr.WriteStartElement("position");
				{
					wr.WriteStartAttribute("name");
					wr.WriteString(Position[i].Name);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("group");
					wr.WriteString(Position[i].Group);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("num");
					wr.WriteString(Position[i].Num.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("min");
					wr.WriteString(Position[i].Min.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("max");
					wr.WriteString(Position[i].Max.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("conv");
					wr.WriteString(Position[i].Conversion);
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <scores><score>...</scores>
			//============================================================
			wr.WriteStartElement("scores");
			for (i = 0; i < Score.Count; i++)
			{
				wr.WriteStartElement("score");
				{
					wr.WriteStartAttribute("category");
					wr.WriteString(Score[i].Category);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("position");
					wr.WriteString(Score[i].Position.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("value");
					wr.WriteString(Score[i].Value.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <averages><average>...</averages>
			//============================================================
			wr.WriteStartElement("averages");
			for (i = 0; i < Average.Count; i++)
			{
				wr.WriteStartElement("average");
				{
					wr.WriteStartAttribute("position");
					wr.WriteString(Average[i].Position.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("rank");
					wr.WriteString(Average[i].Rank.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("average");
					wr.WriteString(Average[i].Value.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <confidences><confidence>...</confidences>
			//============================================================
			wr.WriteStartElement("confidences");
			for (i = 0; i < Confidence.Count; i++)
			{
				wr.WriteStartElement("confidence");
				{
					wr.WriteStartAttribute("ffl");
					wr.WriteString(Confidence[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("position");
					wr.WriteString(Confidence[i].Position.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("confidence");
					wr.WriteString(Confidence[i].Value.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();

			}
			wr.WriteEndElement();

			//============================================================
			// <comments><comment>...</comments>
			//============================================================
			wr.WriteStartElement("comments");
			for (i = 0; i < Comment.Count; i++)
			{
				wr.WriteStartElement("comment");
				{
					wr.WriteStartAttribute("ffl");
					wr.WriteString(Comment[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("round");
					wr.WriteString(Comment[i].Round.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("comment");
					wr.WriteString(Comment[i].Text);
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <limits><limit>...</limits>
			//============================================================
			wr.WriteStartElement("limits");
			for (i = 0; i < Limit.Count; i++)
			{
				wr.WriteStartElement("limit");
				{
					wr.WriteStartAttribute("ffl");
					wr.WriteString(Limit[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("position");
					wr.WriteString(Limit[i].Position.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("round");
					wr.WriteString(Limit[i].Round.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("limit");
					wr.WriteString(Limit[i].Value.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <weights><weight>...</weights>
			//============================================================
			wr.WriteStartElement("weights");
			for (i = 0; i < Weight.Count; i++)
			{
				wr.WriteStartElement("weight");
				{
					wr.WriteStartAttribute("ffl");
					wr.WriteString(Weight[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("group");
					wr.WriteString(Weight[i].Group);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("depth");
					wr.WriteString(Weight[i].Depth.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("weight");
					wr.WriteString(Weight[i].Value.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <rankings><ranking>...</rankings>
			//============================================================
			wr.WriteStartElement("rankings");
			for (i = 0; i < Ranking.Count; i++)
			{
				wr.WriteStartElement("ranking");
				{
					wr.WriteStartAttribute("name");
					wr.WriteString(Ranking[i].Name);
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("ffl");
					wr.WriteString(Ranking[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("line");
					wr.WriteString(Ranking[i].Line.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("position");
					wr.WriteString(Ranking[i].Position.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("player");
					wr.WriteString(Ranking[i].Player.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("rank");
					wr.WriteString(Ranking[i].Rank.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("tier");
					wr.WriteString(Ranking[i].Tier.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("ppg");
					wr.WriteString(Ranking[i].Ppg.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("points");
					wr.WriteString(Ranking[i].Points.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("risk");
					wr.WriteString(Ranking[i].Risk);
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();

			//============================================================
			// <picks><pick>...</picks>
			//============================================================
			wr.WriteStartElement("picks");
			for (i = 0; i < Pick.Count; i++)
			{
				wr.WriteStartElement("pick");
				{
					wr.WriteStartAttribute("ffl");
					wr.WriteString(Pick[i].Ffl.ToString());
					wr.WriteEndAttribute();

					wr.WriteStartAttribute("player");
					wr.WriteString(Pick[i].Player.ToString());
					wr.WriteEndAttribute();
				}
				wr.WriteEndElement();
			}
			wr.WriteEndElement();
			wr.WriteEndElement();
			wr.WriteEndDocument();
			wr.Flush();
			wr.Close();
			SavePicks();
			return;
		}


		//*****************************************************
		// Save Picks
		//*****************************************************
		public void SavePicks ()
		{
			string newpickfile = picksfile;
			string oldpickfile = picksfile.Replace(".picks", ".saved");

			// slide our previous picks as our new backup
			if (File.Exists(oldpickfile)==true)
				File.Delete(oldpickfile);

			if (File.Exists(newpickfile)==true)
				File.Move(newpickfile, oldpickfile);

			// write out the new one
			XmlTextWriter wr = new XmlTextWriter(newpickfile, Encoding.UTF8);
			wr.Formatting = Formatting.Indented;
			wr.WriteStartDocument(true);
			wr.WriteStartElement("picks");

			for (int i=0; i<Pick.Count; i++)
			{
				wr.WriteStartElement("pick");
				wr.WriteAttributeString("round", i.ToString());
				wr.WriteAttributeString("first", Player[Pick[i].Player].First);
				wr.WriteAttributeString("last", Player[Pick[i].Player].Last);
				wr.WriteAttributeString("nfl", Nfl[Player[Pick[i].Player].Nfl].Name);
				wr.WriteAttributeString("pos", Position[Player[Pick[i].Player].Position].Name);
				wr.WriteAttributeString("ffl", Ffl[Pick[i].Ffl].Name);
				wr.WriteAttributeString("fflid", Pick[i].Ffl.ToString());
				wr.WriteAttributeString("playerid", Pick[i].Player.ToString());
				wr.WriteEndElement();
			}
			wr.WriteEndElement();
			wr.WriteEndDocument();
			wr.Flush();
			wr.Close();
		}


		//*****************************************************
		// Read Picks
		//*****************************************************
		private void ReadPicks ()
		{
			string newpickfile = picksfile;

			// read Pick file
			StreamWriter errors = new StreamWriter(leagueDirectory+@"\PickErrors.lst", false);
			if (File.Exists(newpickfile)==true)
			{
				for (int i=0; i<Pick.Count; i++)
					Pick[i].Clear();
				XmlReader rdr = XmlReader.Create(newpickfile);
				while (rdr.Read())
				{
					if (rdr.NodeType==XmlNodeType.Element && rdr.Name=="pick")
					//============================================================
					{
						string first = rdr.GetAttribute("first");
						string last = rdr.GetAttribute("last");
						string nflnm = rdr.GetAttribute("nfl");
						string pos = rdr.GetAttribute("pos");
						string fflnm = rdr.GetAttribute("ffl");
						int rnd;
						int fidx;
						int pidx;
						int.TryParse(rdr.GetAttribute("round"), out rnd);
						int.TryParse(rdr.GetAttribute("fflid"), out fidx);
						int.TryParse(rdr.GetAttribute("playerid"), out pidx);

						if (first.Equals(Player[pidx].First) &&
                             last.Equals(Player[pidx].Last) &&
                             nflnm.Equals(Nfl[Player[pidx].Nfl].Name) &&
                             pos.Equals(Position[Player[pidx].Position].Name) &&
                             fflnm.Equals(Ffl[fidx].Name))
						{
							Pick[rnd].Set(fidx, pidx);
							Player[pidx].Ffl = fidx;
						}
						else
						{
							errors.Write("Unknown Pick: Round:{0} First:{1} Last:{2} NFL:{3}", rnd.ToString(), first, last, nflnm);
							errors.WriteLine(rdr.Name);
						}
						continue;
					}

					if (rdr.NodeType==XmlNodeType.Element)
					//============================================================
					{
						errors.Write("Unknown Segment: ");
						errors.WriteLine(rdr.Name);
					}
				}
			}
		}

		//***********************************************************************
		public void RebuildPicks ()
		//***********************************************************************
		{
			int i;

			Order = ordervalues[Style].Substring(0, Rounds);
			for (i=0; i<Pick.Count; i++)
				Pick[i].Clear();

			i=0;
			for (int r=0; r<Rounds; r++)
			{
				if (Order[r]=='F')
				{
					for (int t=0; t<Ffls; t++)
					{
						Pick[i++].Set(t+1, 0);
					}
				}
				else
				{
					for (int t=0; t<Ffls; t++)
					{
						Pick[i++].Set(Ffls-t, 0);
					}
				}
			}
			TotalPicks = i;
		}

		//***********************************************************************
		public void RebuildFfls ()
		//***********************************************************************
		{
		}

		//***********************************************************************
		public void RebuildPositions ()
		//***********************************************************************
		{
		}

		//***********************************************************************
		public void SetPickCountersComments ()
		//***********************************************************************
		{
			int i;

			CurrentPick = NextPick = TotalPicks;
			for (i = 0; i < TotalPicks; ++i)
			{
				if (CurrentPick == TotalPicks)
				{
					if (Pick[i].Player == 0)
						CurrentPick = i;
				}
				else
				{
					if (Pick[i].Ffl == Pick[CurrentPick].Ffl)
					{
						if (NextPick == TotalPicks && i!=CurrentPick + 1)
							NextPick = i;
					}
				}
			}

			if (CurrentPick < TotalPicks)
			{
				string c = "";
				int round = (CurrentPick / (Ffls)) + 1;

				for (int k = 0; k < Comment.Count; k++)
				{
					if (Comment[k].Round != round)
						continue;
					if (Comment[k].Ffl != Pick[CurrentPick].Ffl)
						continue;
					c = Comment[k].Text;
				}
				DraftComment = c;
			}
		}

		//***********************************************************************
		public void FillNeeds ()
		//***********************************************************************
		{
			int i,j;

			for (i = 1; i <= Positions; i++)
			{
				Have[i] = Need[i] = 0;
				pconfidence[i] = 0.0F;
				pweight[i] = 0.0F;
			}
			if (CurrentPick >= TotalPicks) return;

			// fill Have[], determines our depth, and targetround determines our round
			int targetround = 1;
			int targetteam = Pick[CurrentPick].Ffl;
			for (i = 0; i < CurrentPick; ++i)
			{
				if (Pick[i].Ffl == targetteam)
				{
					++Have[Player[Pick[i].Player].Position];
					++targetround;
				}
			}

			// fill need[] to targetround
			for (i = 1; i <= Positions; i++)
			{
				for (j = 0; j < Limit.Count; j++)
				{
					if (Limit[j].Ffl != targetteam)
						continue;
					if (Limit[j].Position != i)
						continue;
					if (Limit[j].Round != targetround)
						continue;
					Need[i] = Limit[j].Value;
					break;
				}
				for (j = 0; j < Confidence.Count; j++)
				{
					if (Confidence[j].Ffl != targetteam)
						continue;
					if (Confidence[j].Position != i)
						continue;
					pconfidence[i] = Confidence[j].Value;
					break;
				}

				// starter (1) if less than minimum
				int depth=0,depth2=0;
				if (Have[i]<Position[i].Min)
					depth = 1;
				else
				{
					// get group count
					int gcount = 0;
					for (j=1; j<=Positions; j++)
					{
						if (Position[i].Group==Position[j].Group)
							gcount += Have[j];
					}

					// maybe starter if group count higher than have count
					if (gcount<Position[i].Num)
						depth = 1;
					else
						depth = gcount - Position[i].Num + 2;

					// but also need to check max for position starters
					if (Have[i]>=Position[i].Max)
						depth2 = Have[i] - Position[i].Max + 2;

					// use bigger, depth or depth2
					if (depth2>depth)
						depth = depth2;
				}

				for (j = 0; j < Weight.Count; j++)
				{
					if (Weight[j].Ffl != targetteam)
						continue;
					if (Weight[j].Group != Position[i].Group)
						continue;
					if (Weight[j].Depth != depth)
						continue;
					pweight[i] = Weight[j].Value;
					break;
				}
			}
		}

		//***********************************************************************
		public void ABCDraft ()
		//***********************************************************************
		{
			int i, tot;

			FillNeeds();
			if (CurrentPick >= TotalPicks) return;

			tot = 0;
			for (i = 2; i < Player.Count; ++i)
			{
				if (Player[i].Ffl > 0)
					continue;
				if (Have[Player[i].Position] < Need[Player[i].Position])
				{
					PlayerIndex[tot] = i;
					PlayerRanking[tot] = Ranking.Count;
					PlayerValue[tot] = 0.0F;
					++tot;
				}
			}
			PlayerIndexes = tot;
		}

		//***********************************************************************
		public void ADPDraft ()
		//***********************************************************************
		{
			int i, j, k, tot;
			float f;

			FillNeeds();
			if (CurrentPick >= TotalPicks) return;

			tot = 0;
			for (i = 2; i < Player.Count; i++)
			{
				if (Player[i].Ffl > 0)
					continue;
				if (Have[Player[i].Position] < Need[Player[i].Position] && Player[i].Adp > 0.0F)
				{
					PlayerIndex[tot] = i;
					PlayerRanking[tot] = Ranking.Count;
					PlayerValue[tot] = Player[i].Adp;
					tot++;
				}
			}

			for (i = 0; i < tot; ++i)
			{
				for (j = i + 1; j < tot; ++j)
				{
					if (PlayerValue[i] > PlayerValue[j])
					{
						k = PlayerIndex[i];
						PlayerIndex[i] = PlayerIndex[j];
						PlayerIndex[j] = k;
						f = PlayerValue[i];
						PlayerValue[i] = PlayerValue[j];
						PlayerValue[j] = f;
					}
				}
			}
			PlayerIndexes = tot;
		}

		//***********************************************************************
		public void ADPDraftFull ()
		//***********************************************************************
		{
			int i, j, k, tot;
			float f;

			FillNeeds();
			if (CurrentPick >= TotalPicks) return;

			tot = 0;
			for (i = 2; i < Player.Count; i++)
			{
				if (Player[i].Ffl > 0)
					continue;
				if (Player[i].Adp > 0.0F)
				{
					PlayerIndex[tot] = i;
					PlayerRanking[tot] = Ranking.Count;
					PlayerValue[tot] = Player[i].Adp;
					tot++;
				}
			}

			for (i = 0; i < tot; ++i)
			{
				for (j = i + 1; j < tot; ++j)
				{
					if (PlayerValue[i] > PlayerValue[j])
					{
						k = PlayerIndex[i];
						PlayerIndex[i] = PlayerIndex[j];
						PlayerIndex[j] = k;
						f = PlayerValue[i];
						PlayerValue[i] = PlayerValue[j];
						PlayerValue[j] = f;
					}
				}
			}
			PlayerIndexes = tot;
		}

		//***********************************************************************
		public void ValDraft ()
		//***********************************************************************
		{
			float f;
			int i, j, k, tot, pos;

			FillNeeds();
			if (CurrentPick >= TotalPicks)
				return;

			int picker = Pick[CurrentPick].Ffl;
			for (i = 0; i < Player.Count; ++i)
			{
				PlayerValue[i] = 0.0F;
			}
			tot = 0;

			// for each position: try and find the baseline
			for (pos = 1; pos < Position.Count; ++pos)
			{
				// zero
				BLin[pos] = 0;

				// build temp lists with group and sort
				tempindexes = 0;
				for (i = 0; i < Ranking.Count; i++)
				{
					if (Ranking[i].Ffl != picker) continue;
					if (Position[Ranking[i].Position].Group != Position[pos].Group) continue;
					TempIndex[tempindexes] = Ranking[i].Player;
					TempValue[tempindexes] = Ranking[i].Ppg;
					tempindexes++;
				}
				for (i = 0; i < tempindexes; ++i)
				{
					for (j = i + 1; j < tempindexes; ++j)
					{
						if (TempValue[i] < TempValue[j])
						{
							k = TempIndex[i];
							TempIndex[i] = TempIndex[j];
							TempIndex[j] = k;
							f = TempValue[i];
							TempValue[i] = TempValue[j];
							TempValue[j] = f;
						}
					}
				}

				// count position matches to establish baseline (handles flex, I hope)
				j = 0;
				k = Ffls * Need[pos];	//Position[pos].Num;
				for (i=0; i<k && i<tempindexes; i++)
				{
					if (Player[TempIndex[i]].Position==pos)
						j++;
				}
				if (j<Position[pos].Min*Ffls)
					j = Position[pos].Min*Ffls;
				if (j>Position[pos].Max*Ffls)
					j = Position[pos].Max*Ffls;
				BLin[pos] = j;
			}

			// for each position, again, but now with positional baselines and biggest set
			for (pos = 1; pos < Position.Count; ++pos)
			{
				// make sure we need to do this one
				if (Have[pos] >= Need[pos])
					continue;

				// refill temp lists with just Position so I can access BLin[pos]
				tempindexes = 0;
				for (i = 0; i < Ranking.Count; i++)
				{
					if (Ranking[i].Ffl != picker) continue;
					if (Ranking[i].Position != pos) continue;
					TempIndex[tempindexes] = Ranking[i].Player;
					TempValue[tempindexes] = Ranking[i].Ppg;
					TempRanking[tempindexes] = i;
					tempindexes++;
				}
				
				// lay in the VBD values for available players
				for (i = 0; i < tempindexes; i++)
				{
					if (Player[TempIndex[i]].Ffl == 0)
					{
						PlayerIndex[tot] = TempIndex[i];
						PlayerRanking[tot] = TempRanking[i];
						PlayerValue[tot] = (TempValue[i]-TempValue[BLin[pos]]) * pconfidence[pos] * pweight[pos];
						tot++;
					}
				}
			}

			// sort everybody
			for (i = 0; i < tot; ++i)
			{
				for (j = i + 1; j < tot; ++j)
				{
					if (PlayerValue[i] < PlayerValue[j])
					{
						k = PlayerIndex[i];
						PlayerIndex[i] = PlayerIndex[j];
						PlayerIndex[j] = k;
						k = PlayerRanking[i];
						PlayerRanking[i] = PlayerRanking[j];
						PlayerRanking[j] = k;
						f = PlayerValue[i];
						PlayerValue[i] = PlayerValue[j];
						PlayerValue[j] = f;
					}
				}
			}
			PlayerIndexes = tot;
			if (tot == 0)
				ADPDraft();

			k = (Ffls * Rounds)-1;
			if (k>=tot)
				k=tot-1;
			for (i = 0; i < tot; ++i)
			{
				PlayerValue[i] -= PlayerValue[k];
				// could convert to $ here some day
			}
		}
	}
}
