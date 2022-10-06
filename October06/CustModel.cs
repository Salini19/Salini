using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace oct4_MVCapp.Models
{
    public class CustModel
    {

        [Required()]
        public int Custid { get; set; }
        [MaxLength(10, ErrorMessage = "Name cannot be greater than 10 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 character")]
        public string Custname { get; set; }
        public string City { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [DataType(DataType.Date)]
        public DateTime RegistrationTime { get; set; }
    }
}
