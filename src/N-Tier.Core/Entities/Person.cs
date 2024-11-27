using N_Tier.Core.Common;
using N_Tier.Core.Enums;

namespace N_Tier.Core.Entities;
public class Person : BaseEntity, IAuditedEntity
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public Gender Gender { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
