using System;
using SQLite.Net;

namespace MboutiqueVisualElement
{
	public interface ISQLite {
		SQLiteConnection GetConnection();
	}
}

