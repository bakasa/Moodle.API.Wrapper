using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class EditModuleInputModel : IModel 
	{
		public string action {get;set;}
		public int id {get;set;}
		public int sectionreturn {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();

			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("action",prefix),action));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("id",prefix),id.ToString()));
			keyValuePairs.Add(new KeyValuePair<string,string>(ModelHelper.GetPrefixedName("sectionreturn",prefix),sectionreturn.ToString()));
			return keyValuePairs;
		}

	}
}