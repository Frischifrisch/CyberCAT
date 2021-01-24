﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class ItemDropStorageParser :INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public ItemDropStorageParser()
        {
            ParsableNodeName = Constants.NodeNames.ITEM_DROP_STORAGE;
            DisplayName = "ItemDropStorage Parser";
            Guid = Guid.Parse("{417FE6C4-A916-4C9C-86B9-AD73C9D3B50D}");
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            node.Parser = this;
            node.WritesOwnTrailingSize = false;
            var result = new ItemDropStorage();

            reader.Skip(4); // Skip Id

            result.UnknownString = reader.ReadPackedString();
            result.HeaderBytes = reader.ReadBytes(25);
            result.Inventory = InventoryParser.ReadSubInventory(node, 0, reader, parsers);

            result.Node = node;
            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (ItemDropStorage)node.Value;

            writer.WritePackedString(data.UnknownString);
            writer.Write(data.HeaderBytes);
            InventoryParser.WriteSubInventory(writer, data.Inventory);
        }
    }
}
