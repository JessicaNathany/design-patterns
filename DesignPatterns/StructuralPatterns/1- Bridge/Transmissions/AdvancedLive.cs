using StructuralPatterns._1__Bridge.Plataforms.Interface;
using System;

namespace StructuralPatterns._1__Bridge.Transmissions
{
    public class AdvancedLive : Live
    {
        public AdvancedLive(IPlatform platform): base(platform)
        {
        }

        public void Subtitle()
        {
            Console.WriteLine("-- Active subtitles in the broadcast --");
        }

        public void Comments()
        {
            Console.WriteLine("-- Comments released on live --");
        }

        public void Record()
        {
            Console.WriteLine("-- Ready to record --");
        }
    }
}
