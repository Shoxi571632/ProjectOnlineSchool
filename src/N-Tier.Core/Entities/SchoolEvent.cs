using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class SchoolEvent : BaseEntity, IAuditedEntity
{
    public int Id { get; set; }
    public string? EventName { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set ; }
    public DateTime? UpdateOn { get; set; }
}
