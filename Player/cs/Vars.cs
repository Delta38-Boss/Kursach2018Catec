using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.cs
{
	public static class Vars
	{
		public static List<string> files = new List<string>();

		public static List<int> list = new List<int>();

		public static string GetFileName(string file)
		{
			string[] tmp = file.Split('\\');
			return tmp[tmp.Length-1];
		}
		public static string GetFileNameTo(string file)
		{
			string[] tmp = file.Split('/');
			return tmp[tmp.Length - 1];
		}

	}
}
