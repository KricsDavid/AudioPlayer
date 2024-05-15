using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Track(string fileName, string v1, string v2, string v3, TimeSpan zero)
    {
        public string FileName { get; set; } = fileName;
        public string FriendlyName { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public string V1 { get; } = v1;
        public string V2 { get; } = v2;
        public string V3 { get; } = v3;
        public TimeSpan Zero { get; } = zero;
    }
}
