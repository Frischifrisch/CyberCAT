﻿using CyberCAT.Core.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GodModeSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }

        public GodModeSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.GOD_MODE_SYSTEM;
            DisplayName = "Godmode System Parser";
            Guid = Guid.Parse("{F3108C87-6AE2-43E6-95FF-22611EDF25DF}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = base.ReadWithMapping(node, reader, parsers);

            return result;
        }
    }
}
