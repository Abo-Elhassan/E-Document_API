

namespace EDocument_Data.Models.Shared
{
    public static  class Utilities
    {
        public static Dictionary<string,string>? ConvertKeysToPascalCase(Dictionary<string, string>? filters)
        {
            var newFilters = new Dictionary<string, string>();
            if (filters is not null)
            {
                foreach (var key in filters.Keys)
                {
                    var newKey = $"{char.ToUpper(key[0])}{key[1..]}";

                    newFilters[newKey] = filters[key];

                }
                
            }

            return newFilters;
        }
    }
}
