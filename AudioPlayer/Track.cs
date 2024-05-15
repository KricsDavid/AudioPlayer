using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    public class Track
    {
        public Track(string fileName, string v1, string v2, string v3, TimeSpan zero)
        {
            FileName = fileName;
            V1 = v1;
            V2 = v2;
            V3 = v3;
            Zero = zero;
        }

        public string FileName { get; set; }
        public string FriendlyName { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public TimeSpan Length { get; set; }
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public TimeSpan Zero { get; }
    }
}
