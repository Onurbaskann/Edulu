using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Edulu3.Models.Entity
{
    public class Story
    {
        public int StoryId { get; set; }
        public string StoryName { get; set; }
        public string Context { get; set; }
        public string Theme { get; set; }
        public string Author { get; set; }
        public string Path { get; set; }
    }
}