//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DontStarve.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class userinfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public userinfo()
        {
            this.cookcommentinfo = new HashSet<cookcommentinfo>();
            this.friendinfo = new HashSet<friendinfo>();
            this.r_user_actioninfo = new HashSet<r_user_actioninfo>();
            this.saysayinfo = new HashSet<saysayinfo>();
            this.roleinfo = new HashSet<roleinfo>();
            this.everydayrecommendinfo = new HashSet<everydayrecommendinfo>();
            this.leavenoteinfo = new HashSet<leavenoteinfo>();
        }
    
        public System.Guid Guid_id { get; set; }
        public string Name { get; set; }
        public string pwd { get; set; }
        public string Remark { get; set; }
        public byte[] Pic { get; set; }
        public long SubTime { get; set; }
        public string Signature { get; set; }
        public string QQ { get; set; }
        public string Phone { get; set; }
        public bool DelFlag { get; set; }
        public string IdCard { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cookcommentinfo> cookcommentinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<friendinfo> friendinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<r_user_actioninfo> r_user_actioninfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<saysayinfo> saysayinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roleinfo> roleinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<everydayrecommendinfo> everydayrecommendinfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<leavenoteinfo> leavenoteinfo { get; set; }
    }
}
