using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("VentilationAreaControllerPS")]
    public class VentilationAreaControllerPS : MasterControllerPS
    {
        [RealName("ventilationAreaSetup")]
        public VentilationAreaSetup VentilationAreaSetup { get; set; }
        
        [RealName("isActive")]
        public bool IsActive { get; set; }
    }
}
