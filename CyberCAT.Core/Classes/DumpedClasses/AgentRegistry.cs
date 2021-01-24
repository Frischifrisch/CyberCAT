using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("AgentRegistry")]
    public class AgentRegistry : IScriptable
    {
        [RealName("isInitialized")]
        public bool IsInitialized { get; set; }
        
        [RealName("agents")]
        public Agent[] Agents { get; set; }
        
        [RealName("agentsLock")]
        public ScriptReentrantRWLock AgentsLock { get; set; }
        
        [RealName("maxReprimandsPerNPC")]
        public int MaxReprimandsPerNPC { get; set; }
        
        [RealName("maxReprimandsPerDEVICE")]
        public int MaxReprimandsPerDEVICE { get; set; }
    }
}
