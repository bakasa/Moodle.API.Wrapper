using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class TagsModel : IModel 
	{
		public List<Tag> tags {get;set;}
		public List<Warning> warnings {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var tagsIndex = 0; tagsIndex<tags.Count;tagsIndex++) 
			{
				var tagsItem = tags[tagsIndex];
				var tagsItems = tagsItem.ToKeyValuePairs("tags[" + tagsIndex + "]");
				keyValuePairs.AddRange(tagsItems);
			}


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