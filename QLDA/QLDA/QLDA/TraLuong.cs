namespace QLDA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraLuong")]
    public partial class TraLuong
    {
        public int ID { get; set; }

        public int IDPC { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKetToan { get; set; }

        public int SoGioLamViec { get; set; }

        public Guid rowguid { get; set; }

        public virtual PhanCong PhanCong { get; set; }
    }
}
