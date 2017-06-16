using System.Collections.Generic;

namespace Moodle.API.Wrapper.Models.Core
{
	public sealed class DeleteCategoriesInputModel : IModel 
	{
		public List<CategoryInputModel> categories {get;set;}


		public List<KeyValuePair<string,string>> ToKeyValuePairs(string prefix="")
		{
			var keyValuePairs = new List<KeyValuePair<string,string>>();


			for(var categoriesIndex = 0; categoriesIndex<categories.Count;categoriesIndex++) 
			{
				var categoriesItem = categories[categoriesIndex];
				var categoriesItems = categoriesItem.ToKeyValuePairs("categories[" + categoriesIndex + "]");
				keyValuePairs.AddRange(categoriesItems);
			}

			return keyValuePairs;
		}

	}
}