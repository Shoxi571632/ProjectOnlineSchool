using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class Exam : BaseEntity , IAuditedEntity
{
    public int Id { get; set; }
    public int ClassNumberId { get; set; }
    public ClassNumber? ClassNumber { get; set; }
    public int ClassRoomId { get; set; }
    public ClassRoom? ClassRoom { get; set; }
    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
