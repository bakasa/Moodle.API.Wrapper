using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class OptionInputModel : IModel 
	{

		public int includecontent {get;set;}
		public string sortby {get;set;}
		public string sortdirection {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("includecontent",prefix),includecontent.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortby",prefix),sortby));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sortdirection",prefix),sortdirection));
			return keyValuePairs;
		}

	}
}