//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobsRegistration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Users
    {
        [Key]
        public string User_ID { get; set; }
        public string User_Password { get; set; }
        public string User_Name { get; set; }
        public Nullable<int> Manager_Code { get; set; }
        public string Emp_Code { get; set; }
        public string User_Role { get; set; }
    }
}