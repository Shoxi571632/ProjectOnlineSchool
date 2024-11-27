using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class StudentParent : BaseEntity , IAuditedEntity
{
    public int StudentId { get; set; }
    public int ParentId { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
