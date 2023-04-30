using System.ComponentModel;

namespace LibraryManagementStudio.Models.Enums;

public enum CategoryType
{
    [Description("Fantastyka")]
    Fantasy = 0,

    [Description("Historyczna")]
    History = 1,
    
    [Description("Thriller")]
    Thriller = 2,
    
    [Description("Bibliografia")]
    Bibliography = 3,
    
    [Description("Romans")]
    Romance = 4
}