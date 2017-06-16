using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Mod
{
	public sealed class RubricInputModel : IModel 
	{

		public List<CriterionInputModel> criteria {get;set;}




		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var criteriaIndex = 0; criteriaIndex<criteria.Count;criteriaIndex++) 
			{
				var criteriaItem = criteria[criteriaIndex];
				var criteriaItems = criteriaItem.ToKeyValuePairs("criteria[" + criteriaIndex + "]");
				keyValuePairs.AddRange(criteriaItems);
			}

			return keyValuePairs;
		}

	}
}