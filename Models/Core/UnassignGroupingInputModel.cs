using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class UnassignGroupingInputModel : IModel 
	{
		public List<UnassignmentInputModel> unassignments {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var unassignmentsIndex = 0; unassignmentsIndex<unassignments.Count;unassignmentsIndex++) 
			{
				var unassignmentsItem = unassignments[unassignmentsIndex];
				var unassignmentsItems = unassignmentsItem.ToKeyValuePairs("unassignments[" + unassignmentsIndex + "]");
				keyValuePairs.AddRange(unassignmentsItems);
			}

			return keyValuePairs;
		}

	}
}