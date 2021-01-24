﻿using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GameSessionConfigParser : INodeParser
    {
        public string ParsableNodeName { get; }

        public string DisplayName { get; }

        public Guid Guid { get; }

        public GameSessionConfigParser()
        {
            ParsableNodeName = Constants.NodeNames.GAME_SESSION_CONFIG_NODE;
            DisplayName = "Game Session Config Parser";
            Guid = Guid.Parse("{886579BC-1423-4509-9977-9967C31B114E}");
        }
        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            node.Parser = this;

            var result = new GameSessionConfig();
            reader.BaseStream.Position = node.Offset;
            reader.Skip(4);//Skip the ID
            result.Hash1 = reader.ReadUInt64();
            result.Hash2 = reader.ReadUInt64();
            result.TextValue = reader.ReadPackedString();
            result.Hash3 = reader.ReadUInt64();
            var trailing = node.Size - (reader.BaseStream.Position - node.Offset);
            result.TrailingBytes = reader.ReadBytes((int)trailing);

            result.Node = node;
            return result;
        }

        public void Write(NodeWriter writer, NodeEntry node)
        {
            var data = (GameSessionConfig)node.Value;

            writer.Write(data.Hash1);
            writer.Write(data.Hash2);
            writer.WritePackedString(data.TextValue);
            writer.Write(data.Hash3);
            writer.Write(data.TrailingBytes);
        }
    }
}
