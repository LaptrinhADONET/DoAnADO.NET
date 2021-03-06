//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.NewFolder1
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BookRoom()
        {
            this.CTDichVus = new HashSet<CTDichVu>();
            this.CTHoaDons = new HashSet<CTHoaDon>();
            this.LichDonPhongs = new HashSet<LichDonPhong>();
            this.Menus = new HashSet<Menu>();
            this.KhachHangs = new HashSet<KhachHang>();
            this.Phongs = new HashSet<Phong>();
        }
    
        public int MaBookRoom { get; set; }
        public Nullable<int> MaPhong { get; set; }
        public Nullable<System.DateTime> BookRoomStart { get; set; }
        public Nullable<System.DateTime> BookRoomTill { get; set; }
        public Nullable<int> TrangThai { get; set; }
        public Nullable<int> SoLuongKhach { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDichVu> CTDichVus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichDonPhong> LichDonPhongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }
    }
}
