namespace P01_StudentSystem.Data.Models
{
    using P01_StudentSystem.Data.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Course
    {

        public Course()
        {
            this.StudentsEnrolled = new HashSet<Student>();
            this.Resources = new HashSet<Resource>();
            this.HomeworkSubmissions = new HashSet<Homework>();
            this.StudentCourses = new HashSet<StudentCourse>();
        }

        
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(GlobalConstants.CourseNameMaxLength)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }


        public virtual ICollection<Student> StudentsEnrolled { get; set; }

        public virtual ICollection<Resource> Resources { get; set; }

        public virtual ICollection<Homework> HomeworkSubmissions { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }




    }
}
