using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Tool
{
	public sealed class CompletePlanInputModel : IModel 
	{
		public int planid {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("planid",prefix),planid.ToString()));
			return keyValuePairs;
		}

	}
}