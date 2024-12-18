namespace Lab04.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SINH_VIEN
    {
        [StringLength(5)]
        public string Id { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        public double? AverageScore { get; set; }

        [StringLength(5)]
        public string FacultyId { get; set; }

        public virtual KHOA KHOA { get; set; }
    }
}
