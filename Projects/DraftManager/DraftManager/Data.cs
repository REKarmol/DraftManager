using System;
using System.Collections.Generic;

namespace DraftManager
{

	//**********************************************************
	public class Average : IComparable<Average> // base 0
	//**********************************************************
	{
		public int Rank { get; set; }
		public int Position { get; set; }
		public float Value { get; set; }

		public Average (int rank, int pos, float average)
		{
			Rank = rank;
			Position = pos;
			Value = average;
		}

		public Average (Average average)
		{
			Rank = average.Rank;
			Position = average.Position;
			Value = average.Value;
		}

		public int CompareTo (Average other)
		{
			if (Position != other.Position)
				return Position.CompareTo(other.Position);
			return Rank.CompareTo(other.Rank);
		}
	}


	//**********************************************************
	public class Comment : IComparable<Comment> // base 0
	//**********************************************************
	{
		public int Ffl { get; set; }
		public int Round { get; set; }
		public string Text { get; set; }

		public Comment (int ffl, int round, string comment)
		{
			Ffl = ffl;
			Round = round;
			Text = comment;
		}

		public Comment (Comment comment)
		{
			Ffl = comment.Ffl;
			Round = comment.Round;
			Text = comment.Text;
		}

		public int CompareTo (Comment other)
		{
			if (Ffl != other.Ffl)
				return Ffl.CompareTo(other.Ffl);
			return Round.CompareTo(other.Round);
		}
	}


	//**********************************************************
	public class Confidence : IComparable<Confidence> // base 0
	//**********************************************************
	{
		public int Ffl { get; set; }
		public int Position { get; set; }
		public float Value { get; set; }

		public Confidence (int ffl, int pos, float confidence)
		{
			Ffl = ffl;
			Position = pos;
			Value = confidence;
		}

		public Confidence (Confidence confidence)
		{
			Ffl = confidence.Ffl;
			Position = confidence.Position;
			Value = confidence.Value;
		}

		public int CompareTo (Confidence other)
		{
			if (Ffl != other.Ffl)
				return Ffl.CompareTo(other.Ffl);
			return Position.CompareTo(other.Position);
		}
	}


	//**********************************************************
	public class Ffl
	//**********************************************************
	{
		public string Name { get; set; }
		public string Owner { get; set; }
		public string Email { get; set; }

		public Ffl (string name, string owner, string email)
		{
			Name = name;
			Owner = owner;
			Email = email;
		}
		public Ffl (Ffl ffl)
		{
			Name = ffl.Name;
			Owner = ffl.Owner;
			Email = ffl.Email;
		}
		public Ffl Set (string name, string owner, string email)
		{
			Name = name;
			Owner = owner;
			Email = email;
			return this;
		}
		public void Clear ()
		{
			Name = "";
			Owner = "";
			Email = "";
		}
	}


	//**********************************************************
	public class Limit : IComparable<Limit> // base 0
	//**********************************************************
	{
		public int Ffl { get; set; }
		public int Position { get; set; }
		public int Round { get; set; }
		public int Value { get; set; }

		public Limit (int ffl, int pos, int round, int limit)
		{
			Ffl = ffl;
			Position = pos;
			Round = round;
			Value = limit;
		}

		public Limit (Limit limit)
		{
			Ffl = limit.Ffl;
			Position = limit.Position;
			Round = limit.Round;
			Value = limit.Value;
		}

		public int CompareTo (Limit other)
		{
			if (Ffl != other.Ffl)
				return Ffl.CompareTo(other.Ffl);
			if (Position != other.Position)
				return Position.CompareTo(other.Position);
			return Round.CompareTo(other.Round);
		}
	}


	//**********************************************************
	public class Nfl : IComparable<Nfl>
	//**********************************************************
	{
		public string Name { get; set; }
		public string City { get; set; }
		public string Team { get; set; }
		public string Bye { get; set; }
		public string Conversion { get; set; }

		public Nfl (string name, string city, string team, string byew, string conv)
		{
			Name = name;
			City = city;
			Team = team;
			Bye = byew;
			Conversion = conv;
		}
		public Nfl (Nfl n)
		{
			Name = n.Name;
			City = n.City;
			Team = n.Team;
			Bye = n.Bye;
			Conversion = n.Conversion;
		}
		public Nfl Set (string name, string city, string team, string byew, string conv)
		{
			Name = name;
			City = city;
			Team = team;
			Bye = byew;
			Conversion = conv;
			return this;
		}
		public void Clear ()
		{
			Name = "";
			City = "";
			Team = "";
			Bye = "";
			Conversion = "";
		}
		public int CompareTo (Nfl other)
		{
			return Name.CompareTo(other.Name);
		}
	}


	//**********************************************************
	public class Pick
	//**********************************************************
	{
		public int Ffl { get; set; }
		public int Player { get; set; }

		public Pick (int team, int player)
		{
			Ffl = team;
			Player = player;
		}
		public Pick (Pick pick)
		{
			Ffl = pick.Ffl;
			Player = pick.Player;
		}
		public Pick Set (int team, int player)
		{
			Ffl = team;
			Player = player;
			return this;
		}
		public Pick Clear ()
		{
			Ffl = 0;
			Player = 0;
			return this;
		}
	}


	//**********************************************************
	public class Player : IComparable<Player>
	//**********************************************************
	{
		public string Last { get; set; }
		public string First { get; set; }
		public int Position { get; set; }
		public int Nfl { get; set; }
		public int Ffl { get; set; }
		public float Adp { get; set; }

		public Player (string last, string first, int pos, int nfl, int ffl, float adp)
		{
			Last = last;
			First = first;
			Position = pos;
			Nfl = nfl;
			Ffl = ffl;
			Adp = adp;
		}

		public Player (Player p)
		{
			Last = p.Last;
			First = p.First;
			Position = p.Position;
			Nfl = p.Nfl;
			Ffl = p.Ffl;
			Adp = p.Adp;
		}

		public Player Set (string last, string first, int pos, int nfl, int ffl, float adp)
		{
			Last = last;
			First = first;
			Position = pos;
			Nfl = nfl;
			Ffl = ffl;
			Adp = adp;
			return this;
		}

		public void Clear ()
		{
			Last = "";
			First = "";
			Position = 0;
			Nfl = 0;
			Ffl = 0;
			Adp = 0.0F;
		}

		public int CompareTo (Player other)
		{
			if (Position != other.Position)
				return Position.CompareTo(other.Position);
			if (Last != other.Last)
				return Last.CompareTo(other.Last);
			if (First != other.First)
				return First.CompareTo(other.First);
			return Nfl.CompareTo(other.Nfl);
		}
	}


	//**********************************************************
	public class Position
	//**********************************************************
	{
		public string Name { get; set; }
		public string Group { get; set; }
		public int Num { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }
		public string Conversion { get; set; }

		public Position (string name, string group, int groupmax, int posmin, int posmax, string conv)
		{
			Name = name;
			Group = group;
			Num = groupmax;
			Min = posmin;
			Max = posmax;
			Conversion = conv;
		}
		public Position (Position p)
		{
			Name = p.Name;
			Group = p.Group;
			Num = p.Num;
			Min = p.Min;
			Max = p.Max;
			Conversion = p.Conversion;
		}
		public Position Set (string name, string group, int groupmax, int posmin, int posmax, string conv)
		{
			Name = name;
			Group = group;
			Num = groupmax;
			Min = posmin;
			Max = posmax;
			Conversion = conv;
			return this;
		}
		public void Clear ()
		{
			Name = "";
			Group = "";
			Num = 0;
			Min = 0;
			Max = 0;
			Conversion = "";
		}
	}


	//**********************************************************
	public class Ranking : IComparable<Ranking>
	//**********************************************************
	{
		public int Ffl { get; set; }
		public int Line { get; set; }
		public int Player { get; set; }
		public int Position { get; set; }
		public int Rank { get; set; }
		public int Rank2 { get; set; }
		public int Tier { get; set; }
		public float Points { get; set; }
		public float Ppg { get; set; }
		public string Name { get; set; }
		public string Risk { get; set; }

		public Ranking (string name, int ffl, int line, int position, int player, int rank, int rank2, int tier, float points, float ppg, string risk)
		{
			Name = name;
			Ffl = ffl;
			Line = line;
			Player = player;
			Position = position;
			Rank = rank;
			Rank2 = rank2;
			Tier = tier;
			Points = points;
			Ppg = ppg;
			Risk = risk;
		}

		public Ranking Set (string name, int ffl, int line, int position, int player, int rank, int rank2, int tier, float points, float ppg, string risk)
		{
			Name = name;
			Ffl = ffl;
			Line = line;
			Player = player;
			Position = position;
			Rank = rank;
			Rank2 = rank2;
			Tier = tier;
			Points = points;
			Ppg = ppg;
			Risk = risk;
			return this;
		}

		public Ranking (Ranking r)
		{
			Name = r.Name;
			Ffl = r.Ffl;
			Line = r.Line;
			Player = r.Player;
			Position = r.Position;
			Rank = r.Rank;
			Rank2 = r.Rank2;
			Tier = r.Tier;
			Points = r.Points;
			Ppg = r.Ppg;
			Risk = Risk;
		}

		public void Clear ()
		{
			Name = "";
			Ffl = 0;
			Line = 0;
			Player = 0;
			Position = 0;
			Rank = 0;
			Rank2 = 0;
			Tier = 0;
			Points = 0.0F;
			Ppg = 0.0F;
			Risk = "";
		}

		public int CompareTo (Ranking other)
		{
			if (Ffl != other.Ffl)
				return Ffl.CompareTo(other.Ffl);
			if (Line != other.Line)
				return Line.CompareTo(other.Line);
			if (Position != other.Position)
				return Position.CompareTo(other.Position);
			if (Tier != other.Tier)
				return Tier.CompareTo(other.Tier);
			if (Rank != other.Rank)
				return Rank.CompareTo(other.Rank);
			if (Ppg != other.Ppg)
				return -Ppg.CompareTo(other.Ppg);
			return Rank2.CompareTo(other.Rank2);
		}
	}


	//**********************************************************
	public class Score : IComparable<Score>
	//**********************************************************
	{
		public int Position { get; set; }
		public string Category { get; set; }
		public float Value { get; set; }

		public Score (int position, string category, float value)
		{
			Position = position;
			Category = category;
			Value = value;
		}
		public Score (Score s)
		{
			Position = s.Position;
			Category = s.Category;
			Value = s.Value;
		}
		public Score Set (int position, string category, float value)
		{
			Position = position;
			Category = category;
			Value = value;
			return this;
		}
		public void Clear ()
		{
			Position = 0;
			Category = "";
			Value = 0.0F;
		}
		public int CompareTo (Score other)
		{
			if (Position != other.Position)
				return Position.CompareTo(other.Position);
			return Category.CompareTo(other.Category);
		}
	}


	//**********************************************************
	public class Weight : IComparable<Weight>  // base 0
	//**********************************************************
	{
		public int Ffl { get; set; }
		public string Group { get; set; }
		public int Depth { get; set; }
		public float Value { get; set; }

		public Weight (int ffl, string group, int depth, float weight)
		{
			Ffl = ffl;
			Group = group;
			Depth = depth;
			Value = weight;
		}

		public Weight (Weight weight)
		{
			Ffl = weight.Ffl;
			Group = weight.Group;
			Depth = weight.Depth;
			Value = weight.Value;
		}

		public int CompareTo (Weight other)
		{
			if (Ffl != other.Ffl)
				return Ffl.CompareTo(other.Ffl);
			if (Group != other.Group)
				return Group.CompareTo(other.Group);
			return Depth.CompareTo(other.Depth);
		}
	}
}

