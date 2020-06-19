using Open.Nat;
using System;

namespace upnp_portmapper
{
  class Program
    {
      static async System.Threading.Tasks.Task<int> Main(string[] args)
      {
        Console.WriteLine("UPnP Portmapper Pre-Release");
        Console.WriteLine("Warning: this may not work whatsoever. That's because it isn't done yet.");
        Console.WriteLine("--- --- --- --- ---\n");
        
        Console.WriteLine("Choose a function.");
        Console.WriteLine("\tip - Get your external IP (people use this to connect to whatever you're portforwarding");
        Console.WriteLine("\tadd - Add a port to be mapped");
        Console.WriteLine("\tdel - Remove a port from mapping");
        Console.WriteLine("\tlist - Shows all ports that are currently on your router");
        Console.Write("Please select an option: ");

        var discover = new NatDiscoverer();
        var device = await discover.DiscoverDeviceAsync();

        switch(Console.ReadLine())
        {
          case "ip":
          {
            Console.WriteLine(await device.GetExternalIPAsync());
            break;
          }
          case "add":
          {
            if (args.Length == 0)
            {
              Console.WriteLine("You need to provide a protocol (TCP/UDP/TCP_UDP), an external port (what people outside your network connect to), an internal port (what people on your network and what your router forwards traffic to), and, optionally, a description to replace what will be disclosed as the purpose of the port forward (this is \"Mono.Nat via UPnP-PortMapper\", by default).");
              return 1;
            } // If no args, reset
            int external;
            bool t = int.TryParse(args[1], out external);
            int internalS;
            bool q = int.TryParse(args[2], out internalS);
            Open.Nat.Protocol protocol;
            protocol = Protocol.Tcp;
            if (args[0] == "TCP")
            {
              protocol = Protocol.Tcp;
            }
            else if (args[0] == "UDP")
            {
              protocol = Protocol.Udp;
            } // TODO: add a both option (TCP_UDP)
            Mapping m;
            m = new Mapping(protocol, external, internalS, "Mono.Nat via UPnP-PortMapper");
            if (args[3] != "")
            {
              m = new Mapping(protocol, external, internalS, args[3]);
            } // If you provide a description, this will fire; otherwise, it'll default to something else
            break;
          }
      }
      }
    }
}
