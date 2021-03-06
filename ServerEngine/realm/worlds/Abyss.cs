﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ServerEngine.realm.worlds
{
    public class Abyss : World
    {
        public Abyss()
        {
            Name = "Abyss of Demons";
            Background = 0;
            AllowTeleport = true;
            base.FromWorldMap(typeof(RealmManager).Assembly.GetManifestResourceStream("ServerEngine.realm.worlds.abyss.wmap"));            
        }

        public override World GetInstance(ClientProcessor psr)
        {
            return RealmManager.AddWorld(new Abyss());
        }
    }
}
