using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Track
    {
        public string FileName { get; set; }
        public string FriendlyName { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
    }
}
