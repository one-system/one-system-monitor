using System;
using System.Net.NetworkInformation;
using System.Threading;
using OneSystemMonitor.PingModule.PingAggregate;

namespace OneSystemMonitor.Cmd.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PingReply pingReply = PingOperation.PingResource("svrwww05");
                if (pingReply.Status != IPStatus.Success)
                {
                    Console.WriteLine($"{DateTimeOffset.Now} {pingReply.Status} {pingReply.Address.ToString()} {pingReply.Buffer.Length} {pingReply.RoundtripTime}");
                    Console.WriteLine();
                }
                else
                {
                    //Console.WriteLine($"{DateTimeOffset.Now} {pingReply.Status} {pingReply.Address.ToString()} {pingReply.Buffer.Length} {pingReply.RoundtripTime} {pingReply.Options.Ttl}");
                    Console.Write(".");
                }

                //Console.WriteLine("Address: {0}", reply.Address.ToString());
                //Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                //Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                //Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                //Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);

                Thread.Sleep(1000);
            }
        }
    }
}
