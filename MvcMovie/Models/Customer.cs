using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(20, ErrorMessage = "Your forename can contain only 20 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Invalid entry, names must start with uppercase and contain letters only")]
        public string Forename { get; set; }
        [StringLength(20, ErrorMessage = "Your surname can contain only 20 characters")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Invalid entry, names must start with uppercase and contain letters only")]
        public string Surname { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Invalid date")]
        public DateTime DOB { get; set; }
    }
}
