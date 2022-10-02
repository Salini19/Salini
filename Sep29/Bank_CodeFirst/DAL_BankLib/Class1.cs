using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BankLib
{
    public class Borrower
    { 
        [Key]
        [Required]
        public int Borrowerid { get; set; }
        public string BorrowerName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public string JobName { get; set; }
        
        public virtual ICollection<Loan> Loans { get; set; }
    }
    public class Loan
    {
        [Key]
        [Required]
        public int LoanID { get; set; }
        public string LoanType { get; set; }
        public int Amount { get; set; }
        public int Duration { get; set; }
        public int RateofInterest { get; set; }
        public int Borrowerid { get; set; }

        [ForeignKey("Borrowerid")]
        public virtual Borrower BorrowerDetails { get; set; }
    }
    public class MyBank : DbContext
    {
        public MyBank() : base("MyBank")
        {
            Database.SetInitializer<MyBank>(new DropCreateDatabaseIfModelChanges<MyBank>());
        }
        public virtual DbSet<Borrower> BorrowerTable { get; set; }
        public virtual DbSet<Loan> LoanTable { get; set; }
    }
}
