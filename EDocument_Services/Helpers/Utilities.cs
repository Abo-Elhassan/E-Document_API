namespace EDocument_Services.Helpers
{
    public static class Utilities
    {
        public static Dictionary<string, string> ConvertKeysToPascalCase(Dictionary<string, string> filters)
        {
            var newFilters = new Dictionary<string, string>();

            foreach (var key in filters.Keys)
            {
                var newKey = $"{char.ToUpper(key[0])}{key[1..]}";

                newFilters[newKey] = filters[key];
            }

            return newFilters;
        }

        public static string ConvertColumnNameToPascalCase(string columnName)
        {
            columnName = $"{char.ToUpper(columnName[0])}{columnName[1..]}";

            return columnName;
        }
    }
}