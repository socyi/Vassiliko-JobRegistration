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
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Job_Register
    {
        [Key]
        [DisplayName("Serial Number")]
        public int Serial_No { get; set; }
        [DisplayName("Description")]
        public string Job_Description { get; set; }

        [DisplayName("Department")]
        public Nullable <int> Dep_Code { get; set; }

        [DisplayName("      Date     ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Job_Date { get; set; }

        [DisplayName("Status")]
        public string Job_Status { get; set; }

        [DisplayName("Completion Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> Job_Compl_Date { get; set; }
        [DisplayName("Remarks")]
        public string Job_Remarks { get; set; }
        public Nullable<int> Cat_Code { get; set; }

        [DisplayName("Next Shutdown Job")]
        public string Job_Employee { get; set; }

        [DisplayName("Next Shutdown Job")]
        public Nullable<bool> Job_Shutdown { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Assignment Date")]
        public Nullable<System.DateTime> Job_Assign_Date { get; set; }

        [DisplayName("Employee Assigned 2")]
        public string Job_Employee2 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Deadline Date")]
        public Nullable<System.DateTime> Job_Deadline { get; set; }

        [DisplayName("Email List")]
        public Nullable<bool> Job_Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Reminder Date")]
        public Nullable<System.DateTime> Job_Reminder_Date { get; set; }
        public Nullable<int> Manager_Code { get; set; }

        [DisplayName("Department")]
        public virtual Departments Departments { get; set; }

        [DisplayName("Employee Assigned 1")]
        public virtual Employees Employees { get; set; }

        [DisplayName("Employee Assigned 2")]
        public virtual Employees Employees1 { get; set; }

        [DisplayName("Category")]
        public virtual Job_Category Job_Category { get; set; }

        [DisplayName("Status")]
        public virtual Job_Status Job_Status1 { get; set; }
    }
}
