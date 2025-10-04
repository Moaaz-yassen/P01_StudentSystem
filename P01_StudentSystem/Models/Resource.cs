using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace P01_StudentSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        [MaxLength(50)]
        [Unicode(true)]
        public string Name { get; set; }

        [Unicode(false)]
        public string Url { get; set; }

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }

    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}