using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class AssignRolesInputModel : IModel 
	{
		public List<AssignmentInputModel> assignments {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var assignmentsIndex = 0; assignmentsIndex<assignments.Count;assignmentsIndex++) 
			{
				var assignmentsItem = assignments[assignmentsIndex];
				var assignmentsItems = assignmentsItem.ToKeyValuePairs("assignments[" + assignmentsIndex + "]");
				keyValuePairs.AddRange(assignmentsItems);
			}

			return keyValuePairs;
		}

	}
}