using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class RatingModel : IModel 
	{
		public string aggregate {get;set;}
		public int count {get;set;}
		public int itemid {get;set;}
		public int success {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("aggregate",prefix),aggregate));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("count",prefix),count.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("itemid",prefix),itemid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("success",prefix),success.ToString()));

			for(var warningsIndex = 0; warningsIndex<warnings.Count;warningsIndex++) 
			{
				var warningsItem = warnings[warningsIndex];
				var warningsItems = warningsItem.ToKeyValuePairs("warnings[" + warningsIndex + "]");
				keyValuePairs.AddRange(warningsItems);
			}

			return keyValuePairs;
		}

	}
}