//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientForKOMK
{
    using System;
    using System.Collections.Generic;
    
    public partial class hCashBox
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hCashBox()
        {
            this.jReceipt = new HashSet<jReceipt>();
        }
    
        public int CashBoxId { get; set; }
        public string CashBoxModel { get; set; }
        public bool Exist { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jReceipt> jReceipt { get; set; }
    }
}
