﻿using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class WorkspotInstancesSavedata : NodeRepresentation
    {
        public List<WorkspotInstancesSavedataEntry> Entries { get; set; }

        public WorkspotInstancesSavedata()
        {
            Entries = new List<WorkspotInstancesSavedataEntry>();
        }

        public class WorkspotInstancesSavedataEntry
        {
            public ulong Unk_Hash1 { get; set; }
            public ulong Unk_EntityHash { get; set; }
            public byte Unknown3 { get; set; }
        }
    }
}