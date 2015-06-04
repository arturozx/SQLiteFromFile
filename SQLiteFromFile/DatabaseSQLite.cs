using System;
using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SQLiteFromFile
{
	public class DatabaseSQLite 
	{
		static object locker = new object ();

		SQLiteConnection database;

		public DatabaseSQLite()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();
			// create the tables
			database.CreateTable<Users>();
		}

		public List<Users> GetItems ()
		{
			lock (locker) {
				return (from i in database.Table<Users>() select i).ToList();
			}
		}

		public List<Users> GetItems2 () 
		{
			lock (locker) {
				return database.Table<Users> ().Where (x => x.IdSubEvent == 1).ToList ();
			}
		}

		public int SaveItem (Users item)
		{
			lock (locker) {
				if (item.IdUser != 0) {
					database.Update (item);
					return item.IdUser;
				} else {
					return database.Insert (item);
				}
			}
		}

	}
}

