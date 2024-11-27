using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class ClassRoom : BaseEntity, IAuditedEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Capacity { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
