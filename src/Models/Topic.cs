using System;
using System.Collections.Generic;

namespace ProsAndCons.Models
{
    public class Topic
    {
        public Topic()
        {
        }
        public Topic(int id, string title, List<Argument> arguments)
        {
            Id = id;
            Title = title;
            Arguments = arguments;
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Argument> Arguments { get; set; }
    }
}
