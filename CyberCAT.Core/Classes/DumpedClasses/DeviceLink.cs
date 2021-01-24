using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("DeviceLink")]
    public class DeviceLink : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("PSID")]
        public GamePersistentID PSID { get; set; }
        
        [RealName("className")]
        public CName ClassName { get; set; }
    }
}
