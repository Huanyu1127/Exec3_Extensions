using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Int32.IsOdd, IsEven IsOdd()傳回 bool , 表示是否為奇數

		}
	}
	public static class Extensions
	{
		public static bool IsOdd(this int source)
		{
			return (source % 2 == 0);
		}
		public static bool IsEven(this int source)
		{
			return (source % 2 == 1);
		}
	}
}
