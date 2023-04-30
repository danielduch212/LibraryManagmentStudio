using System.ComponentModel;
using System.Reflection;

namespace LibraryManagementStudio.Views;

public static class EnumDescriptor
{
    public static string GetEnumDescription(Enum value)
    {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute));
        
        return attribute != null ? attribute.Description : value.ToString();
    }
}