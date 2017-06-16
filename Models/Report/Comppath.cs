using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Report
{
	public sealed class Comppath : IModel 
	{

		public List<Ancestor> ancestors {get;set;}
		public Framework framework {get;set;}
		public int pagecontextid {get;set;}
		public string pluginbaseurl {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var ancestorsIndex = 0; ancestorsIndex<ancestors.Count;ancestorsIndex++) 
			{
				var ancestorsItem = ancestors[ancestorsIndex];
				var ancestorsItems = ancestorsItem.ToKeyValuePairs("ancestors[" + ancestorsIndex + "]");
				keyValuePairs.AddRange(ancestorsItems);
			}

			var frameworkItems = framework.ToKeyValuePairs("framework");
			keyValuePairs.AddRange(frameworkItems);
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pagecontextid",prefix),pagecontextid.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("pluginbaseurl",prefix),pluginbaseurl));
			return keyValuePairs;
		}

	}
}