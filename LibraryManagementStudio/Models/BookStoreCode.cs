using System.ComponentModel.DataAnnotations.Schema;
using LibraryManagementStudio.Models.Enums;

namespace LibraryManagementStudio.Models;
    
public class BookStoreCode
{
    public int BookStoreCodeId { get; set; }
    
    public string Code { get; set; }
    public CodeType CodeType { get; set; }
    
    //Relationships
    public int BookBorrowId { get; set; }
    public BookBorrow BookBorrow { get; set; }
}