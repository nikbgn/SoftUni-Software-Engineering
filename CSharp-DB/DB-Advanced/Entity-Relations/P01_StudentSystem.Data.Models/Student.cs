namespace P01_StudentSystem.Data.Models
{
    using P01_StudentSystem.Data.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {

        public Student()
        {
            this.CourseEnrollments = new HashSet<StudentCourse>();
            this.HomeworkSubmissions = new HashSet<Homework>();
            this.StudentCourses = new HashSet<StudentCourse>();
        }

        
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.StudentNameMaxLength)]
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateTime? Birthday { get; set; }

        
        public virtual ICollection<StudentCourse> CourseEnrollments { get; set; }

        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

    }
}
