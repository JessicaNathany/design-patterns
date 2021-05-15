using StructuralPatterns._1__Bridge.Plataforms;
using StructuralPatterns._1__Bridge.Plataforms.Interface;
using StructuralPatterns._1__Bridge.Transmissions;
using System;

namespace StructuralPatterns._1__Bridge
{
    public class ExecuteBridge
    {
        public void TestBridgePlatform()
        {
            StartLive(new Youtube());
            StartLive(new Facebook());
            StartLiveAdvanced(new TwitchTV());
            StartLiveAdvanced(new DLive());
            Console.ReadLine();
        }

        private void StartLive(IPlatform platform)
        {
            Console.WriteLine("Please wait");
            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }
        private void StartLiveAdvanced(IPlatform platform)
        {
            Console.WriteLine("Please wait");
            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }
    }
}
