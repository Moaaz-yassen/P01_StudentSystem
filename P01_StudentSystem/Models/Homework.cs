using System;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    public class Homework
    {
        public int HomeworkId { get; set; }

        [Unicode(false)]
        public string Content { get; set; }

        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
}