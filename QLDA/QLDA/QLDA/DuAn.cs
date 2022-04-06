namespace QLDA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DuAn")]
    public partial class DuAn
    {
        public int ID { get; set; }

        public int IDCN { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDuAn { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayBatDau { get; set; }

        public decimal KinhPhi { get; set; }

        public int ThoiHan { get; set; }

        public bool Status { get; set; }

        public Guid rowguid { get; set; }

        public virtual ChiNhanh ChiNhanh { get; set; }

        public virtual DuAn DuAn1 { get; set; }

        public virtual DuAn DuAn2 { get; set; }
    }
}
