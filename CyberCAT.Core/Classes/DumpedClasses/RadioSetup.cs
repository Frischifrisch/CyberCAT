using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("RadioSetup")]
    public class RadioSetup : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("startingStation")]
        public DumpedEnums.ERadioStationList? StartingStation { get; set; }
        
        [RealName("isInteractive")]
        public bool IsInteractive { get; set; }
        
        [RealName("glitchSFX")]
        public CName GlitchSFX { get; set; }
    }
}
