using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		//針對 string 寫一個擴充方法 ToInt(this string value, int
		//defaultValue), 可以將 string 轉換成 int 型別, 如果無法轉型成
		//功, 傳回 defaultValue
		static void Main(string[] args)
		{
		}
	}
	public static class StringExtenstions
	{
		public static int ToInt(this string value,int defaultValue)
		{
			bool isInt = int.TryParse(value, out int number);
			return isInt ? number : defaultValue;
		}
	}
}
