﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


interface IEventConnection
{
    int Priority { get; }
    void Disconnect();
}