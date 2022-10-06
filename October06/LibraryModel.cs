using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace oct4_MVCapp.Models
{
    public class BookModel
    {
        [Required]
        public int BookId { get; set; }
        [MaxLength(30,ErrorMessage = "Book Name cannot be greater than 30 characters")]
        [MinLength(2,ErrorMessage ="Book Name cannot be less than 2 characters")]
        public string BookName { get; set; }
        public string Author { get; set; }
        [Range(100,10000,ErrorMessage ="Price is not in a Range")]
        public int Price { get; set; }

    }
    public class MemberModel
    {
        [Required]
        public int MemberId { get; set; }
        [MaxLength(20, ErrorMessage = "Name cannot be greater than 20 characters")]
        [MinLength(2, ErrorMessage = "Name cannot be less than 2 characters")]
        public string MemberName { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime AccountOpenDate { get; set; }
        [Range(1,10,ErrorMessage ="Books number not in a range")]
        public int MaxBooksAllowed { get; set; }
        public int Penalty { get; set; }
    }
    public class IssuedBookModel
    {
        [Required]
        public int Lib_IssueId { get; set; }
        [Required]
        public int BookId { get; set; }
        [Required]
        public int MemberId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReturnDate { get; set; }
    }
}