using System;
using SQLite.Net.Attributes;

namespace SQLiteFromFile
{
	public class Users
	{
		[PrimaryKey]
		public int IdUser {
			get;
			set;
		}
		public string Name {
			get;
			set;
		}
		public int IdSubEvent {
			get;
			set;
		}
	}
}

