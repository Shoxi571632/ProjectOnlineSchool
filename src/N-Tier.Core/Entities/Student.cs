using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class Student : BaseEntity , IAuditedEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PersonId { get; set; }
    public int ClassNumberId { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}

