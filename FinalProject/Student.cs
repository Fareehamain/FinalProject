//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Mentors = new HashSet<Mentor>();
        }
    
        public int StudentID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentJobTitle { get; set; }
        public string Organization { get; set; }
        public byte[] ProfileImage { get; set; }
        public Nullable<int> GraduationYear { get; set; }
        public string GraduationSemester { get; set; }
        public Nullable<bool> WantsToMentor { get; set; }
        public string GitHubLink { get; set; }
        public string LinkedInLink { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mentor> Mentors { get; set; }
        public virtual User User { get; set; }
    }
}
