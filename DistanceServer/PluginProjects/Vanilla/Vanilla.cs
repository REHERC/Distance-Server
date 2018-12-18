﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class Vanilla : DistanceServerPlugin
    {
        public override string Author { get; } = "Corecii; Discord: Corecii#3019";
        public override string DisplayName { get; } = "Vanilla Functionality";
        public override int Priority { get; } = -10;

        public override void Start()
        {
            Log.Info("Vanilla Functionality Plugin started!");
            Server.OnPlayerValidatedEvent.Connect(player =>
            {
                Server.AddChatMessage($"[FFE999]{player.Name} has joined the server!");
            });
            Server.OnPlayerDisconnectedEvent.Connect(player =>
            {
                Server.AddChatMessage($"[FFE999]{player.Name} has left the game[-]");
                // TODO: implement timeout message
            });
        }
    }
}