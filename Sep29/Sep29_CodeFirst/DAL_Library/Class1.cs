using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library
{

    public class Book
    {
        [Key]
        [Required]
        public int BookID { get; set; }
        [MaxLength(20,ErrorMessage ="Not Allow above 20 charecters")]
        public string BookName { get; set; }
        public string Author { get; set; }
        [Range(10,5000,ErrorMessage ="Not in a Range")]
        public int Cost { get; set; }
        public string Category { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
    }
    public class Member
    {
        [Key]
        [Required]
        public int MemberId { get; set; }
        public string memberName { get; set; }
        [DataType(DataType.Date,ErrorMessage ="Not valid date")]
        public DateTime Acc_openDate { get; set; }
        [Range(1,5,ErrorMessage ="Not in range")]
        public int MaxAllowedBooks { get; set; }

        public virtual ICollection<Issue> Issues { get; set; }
    }
    public class Issue
    {
        [Key]
        [Required]
        public int Lib_IssueID { get; set; }
        public int BookID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int MemberId { get; set; }

        [ForeignKey("BookID")]
        public virtual Book BookDetails { get; set; }
        [ForeignKey("MemberId")]
        public virtual Member Memberdetails { get; set; }

    }


    public class MyBooks : DbContext
    {
        public MyBooks() : base("MyBooks")
        {
            Database.SetInitializer<MyBooks>(new CreateDatabaseIfNotExists<MyBooks>());
        }
        public virtual DbSet<Book> Booktable { get; set; }
        public virtual DbSet<Member> MemberTable { get; set; }
        public virtual DbSet<Issue> IssueTable { get; set; }
    }
    
}
