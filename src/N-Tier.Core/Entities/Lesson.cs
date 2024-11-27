﻿using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;
public class Lesson : BaseEntity , IAuditedEntity
{
    public int Id { get; set; }
    public int ClassNumberId { get; set; }
    public ClassNumber? ClassNumber { get; set; }
    public int TeacherId { get; set; }
    public Teacher? Teacher { get; set; }
    public int SubjectId { get; set; }
    public Subject? Subject { get; set; }
    public string? CreateBy { get; set; }
    public DateTime? CreateOn { get; set; }
    public string? UpdateBy { get; set; }
    public DateTime? UpdateOn { get; set; }
}
