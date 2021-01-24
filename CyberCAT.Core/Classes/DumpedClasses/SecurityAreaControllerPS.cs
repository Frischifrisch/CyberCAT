using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("SecurityAreaControllerPS")]
    public class SecurityAreaControllerPS : MasterControllerPS
    {
        [RealName("system")]
        public Handle<SecuritySystemControllerPS> System { get; set; }
        
        [RealName("usersInPerimeter")]
        public AreaEntry[] UsersInPerimeter { get; set; }
        
        [RealName("isPlayerInside")]
        public bool IsPlayerInside { get; set; }
        
        [RealName("securityAccessLevel")]
        public DumpedEnums.ESecurityAccessLevel? SecurityAccessLevel { get; set; }
        
        [RealName("securityAreaType")]
        public DumpedEnums.ESecurityAreaType? SecurityAreaType { get; set; }
        
        [RealName("eventsFilters")]
        public EventsFilters EventsFilters { get; set; }
        
        [RealName("areaTransitions")]
        public AreaTypeTransition[] AreaTransitions { get; set; }
        
        [RealName("pendingDisableRequest")]
        public bool PendingDisableRequest { get; set; }
        
        [RealName("lastOutput")]
        public OutputPersistentData LastOutput { get; set; }
        
        [RealName("questPlayerHasTriggeredCombat")]
        public bool QuestPlayerHasTriggeredCombat { get; set; }
        
        [RealName("hasThisAreaReceivedCombatNotification")]
        public bool HasThisAreaReceivedCombatNotification { get; set; }
        
        [RealName("pendingNotifyPlayerAboutTransition")]
        public bool PendingNotifyPlayerAboutTransition { get; set; }
    }
}
