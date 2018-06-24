using FluentAssertions;

namespace TestProject.Extensions
{
    public static class Helper
    {
        public static void IsAllPropertiesInitialized<T>(T obj)
        {
            foreach(var property in obj.GetType().GetProperties())
            {
                property.GetValue(obj).Should().NotBeNull("Property {0} is null", property.Name);
            }
        }
    }
}
