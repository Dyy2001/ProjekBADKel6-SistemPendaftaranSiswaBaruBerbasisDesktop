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
    
    public partial class wali
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wali()
        {
            this.Siswas = new HashSet<Siswa>();
        }
    
        public int Id_wali { get; set; }
        public string nik_wali { get; set; }
        public string nama_wali { get; set; }
        public Nullable<System.DateTime> tanggal_lahir_wali { get; set; }
        public string pekerjaan_wali { get; set; }
        public string alamat_wali { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siswa> Siswas { get; set; }
    }
}
