namespace StudentBookClassLibrary
{
    using System.Reflection;
    using System.Text;

    public class ToStringHelper<T>
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

                strBuilder.Append($"{name ?? property.Name}: {property.GetValue(entity)}\n");
            }

            return strBuilder.ToString();
        }
    }
}