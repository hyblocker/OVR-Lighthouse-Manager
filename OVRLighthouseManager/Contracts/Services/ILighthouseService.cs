﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OVRLighthouseManager.Models;
using Windows.Devices.Enumeration;

namespace OVRLighthouseManager.Contracts.Services;
public interface ILighthouseService
{
    public event EventHandler<LighthouseDevice> OnFound;

    public IReadOnlyList<LighthouseDevice> KnownLighthouses
    {
        get;
    }

    public void StartScan();
    public void StopScan();

    public LighthouseDevice? GetLighthouse(ulong bluetoothAddress);
    public LighthouseDevice? GetLighthouse(string bluetoothAddress);
}
