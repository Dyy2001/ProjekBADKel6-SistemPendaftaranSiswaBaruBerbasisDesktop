//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_BAD
{
    using System;
    using System.Collections.Generic;
    
    public partial class nik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nik()
        {
            this.Siswas = new HashSet<Siswa>();
        }
    
        public int id_nik { get; set; }
        public Nullable<int> nik1 { get; set; }
        public Nullable<System.DateTime> tanggal_lahir { get; set; }
        public Nullable<int> anak_ke { get; set; }
        public Nullable<int> jumlah_saudara { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siswa> Siswas { get; set; }
    }
}
