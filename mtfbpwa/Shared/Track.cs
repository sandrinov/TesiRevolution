using System;
using System.Collections.Generic;
using System.Text;

namespace mtfbpwa.Shared
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string TimeLeft { get; set; } = "";
        public string FileName { get; set; } = "";
        public string Description { get; set; } = "";
        public string PublishDate { get; set; } = "";
        public bool Playing { get; set; } = false;
        public bool Cached { get; set; } = false;
        public string PlayErrorMessage { get; set; } = "";
    }
}
