﻿using System;
using JsonRpcNet.Docs;
using JsonRpcNet.WebSocketSharp.Extensions;
using WebSocketSharp.Server;

namespace JsonRpcNet.Net742.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new HttpServer(5000);

            server.AddJsonRpcService(() => new ChatJsonRpcWebSocketService());
            server.UseJsonRpcApi(new JsonRpcInfo
            {
                Description = "Api for JsonRpc chat",
                Title = "Chat API",
                Version = "v1",
                Contact = new JsonRpcContact
                {
                    Email = "test@test.com"
                }
            });

            server.Start();

            Console.WriteLine("Hello World!");
            Console.ReadLine();
            server.Stop();
        }
    }
}