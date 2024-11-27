using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class Attendance : BaseEntity, IAuditedEntity
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int TeachereId { get; set; }
    public DateTime Date { get; set; }
    public bool IsPresent { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
