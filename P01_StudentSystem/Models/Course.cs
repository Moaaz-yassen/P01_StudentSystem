using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [MaxLength(80)]
        [Unicode(true)]
        public string Name { get; set; }

        [Unicode(true)]
        public string? Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<Resource> Resources { get; set; } = new HashSet<Resource>();
        public ICollection<Homework> Homeworks { get; set; } = new HashSet<Homework>();
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
    }
}