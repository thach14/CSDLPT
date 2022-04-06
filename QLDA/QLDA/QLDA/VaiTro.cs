namespace QLDA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VaiTro")]
    public partial class VaiTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VaiTro()
        {
            PhanCong = new HashSet<PhanCong>();
        }

        public int ID { get; set; }

        [Column("VaiTro")]
        [Required]
        [StringLength(50)]
        public string VaiTro1 { get; set; }

        public decimal Luong { get; set; }

        public Guid rowguid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCong { get; set; }
    }
}
