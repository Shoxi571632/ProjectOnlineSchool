using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class SubjectTeacher : BaseEntity , IAuditedEntity
{
    public int SubjectId { get; set; }
    public int TeacherId { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
