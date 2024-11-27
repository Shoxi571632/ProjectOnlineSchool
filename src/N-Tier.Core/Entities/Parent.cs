using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class Parent : BaseEntity , IAuditedEntity
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public Person? Person { get; set; }
    public string? RelationToStudent { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
