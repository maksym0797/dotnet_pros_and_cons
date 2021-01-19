using System;
namespace ProsAndCons.Models
{
    public class Argument
    {
        public Argument()
        {
        }
        public Argument(int id, string text, bool isPros, int topicId)
        {
            Id = id;
            Text = text;
            IsPros = isPros;
            TopicId = topicId;
        }
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsPros { get; set; }
        public int TopicId { get; set; }
    }
}
