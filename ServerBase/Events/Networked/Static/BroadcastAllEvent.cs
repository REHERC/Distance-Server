﻿extern alias Distance;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BroadcastAllEvent<T> : GenericNetworkEvent<T> where T : struct, Distance::IBitSerializable, Distance::INetworkGrouped
{
    public override void Fire(UnityEngine.NetworkPlayer target, Distance::IBitSerializable data)
    {
        DistanceServerMain.SendRPC("ReceiveBroadcastAllEvent", DistanceServerMain.ClientToClientEvents.IndexOf(this), target, data);
    }

    public override void Fire(UnityEngine.RPCMode target, Distance::IBitSerializable data)
    {
        DistanceServerMain.SendRPC("ReceiveBroadcastAllEvent", DistanceServerMain.ClientToClientEvents.IndexOf(this), target, data);
    }
}