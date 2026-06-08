using System;

namespace ITSupport.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int AuthorId { get; set; }
        public string CommentText { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsInternal { get; set; }
        public string AuthorName { get; set; }
        public string AuthorRole { get; set; }

        public string AttachmentPath { get; set; }
    }
}