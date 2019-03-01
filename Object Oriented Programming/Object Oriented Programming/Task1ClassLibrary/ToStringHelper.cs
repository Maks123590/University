namespace StudentBookClassLibrary
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public static class ToStringHelper<T>
    {
        public static string ToString(T entity)
        {
            var entityType = entity.GetType();

            var properties = entityType.GetProperties();
            
            var strBuilder = new StringBuilder();

            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute(typeof(ToStringNameAttribute));

                var name = (attribute as ToStringNameAttribute)?.DisplayedName;

                var propertyValue = property.GetValue(entity);

                if (propertyValue is IEnumerable<string> values)
                {
                    strBuilder.Append($"{name ?? property.Name}: {string.Join(", ", values)}\n");
                }
                else
                {
                    strBuilder.Append($"{name ?? property.Name}: {property.GetValue(entity)}\n");
                }
            }

            return strBuilder.ToString();
        }
    }
}