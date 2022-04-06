namespace QLDA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanCong")]
    public partial class PhanCong
    {
        public int ID { get; set; }

        public int IDDA { get; set; }

        public int IDNV { get; set; }

        public int IDVT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThamGia { get; set; }

        public Guid rowguid { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual VaiTro VaiTro { get; set; }

        public virtual TraLuong TraLuong { get; set; }
    }
}
