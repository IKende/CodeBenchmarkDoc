﻿using CodeBenchmark;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Install-Package BeetleX -Version 1.3.7.2
[System.ComponentModel.Category("TCP")]
public class TcpTextLine : IExample
{
    public async Task Execute()
    {
        var data = $"henryfan@{DateTime.Now}";
        var stream = await mClient.ReceiveFrom(s => s.WriteLine(data));
        stream.ReadLine();

    }

    private BeetleX.Clients.AsyncTcpClient mClient;

    public void Initialize(Benchmark benchmark)
    {
        mClient = BeetleX.SocketFactory.CreateClient<BeetleX.Clients.AsyncTcpClient>("192.168.2.19", 9012);
    }

    public void Dispose()
    {
        mClient.Dispose();
    }
}

