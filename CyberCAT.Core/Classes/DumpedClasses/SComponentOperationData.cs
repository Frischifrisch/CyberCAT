using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SComponentOperationData")]
    public class SComponentOperationData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("componentName")]
        public CName ComponentName { get; set; }
        
        [RealName("operationType")]
        public DumpedEnums.EComponentOperation? OperationType { get; set; }
    }
}
