using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test
{
    [Table("employees")]
    public class Employees
    {

        [Key] 
        [Column("id_employee")]
        public int IdEmployee { get; set; }
        
        [Column("inn")]
        public string Inn { get; set; }
        
        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
        
        [Column("first_name")]
        public string FirstName { get; set; }
        
        [Column("middle_name")]
        public string MiddleName { get; set; }
        
        [Column("last_name")]
        public string LastName { get; set; }
        
        [Column("phone")]
        public string Phone { get; set; }
        
        [Column("email")]
        public string Email { get; set; }
        
        [Column("driver_license_category")]
        public string DriverLicenceCategory { get; set; }
    }
}