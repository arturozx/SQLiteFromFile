using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace SQLiteFromFile
{
	public class MyPage : ContentPage
	{
		public MyPage ()
		{
			DatabaseSQLite db = new DatabaseSQLite ();

			List<Users> lst = db.GetItems2 ();

			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


