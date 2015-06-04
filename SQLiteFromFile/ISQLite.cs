using System;
using SQLite.Net;

namespace SQLiteFromFile
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

