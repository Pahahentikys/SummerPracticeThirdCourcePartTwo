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
    
    public partial class jReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public jReceipt()
        {
            this.jReceiptPosition = new HashSet<jReceiptPosition>();
        }
    
        public int ReceiptId { get; set; }
        public decimal ReceiptSumAmount { get; set; }
        public int ReceiptCashBoxId { get; set; }
        public int PersonId { get; set; }
        public System.DateTime ReceiptDateTime { get; set; }
        public bool Exist { get; set; }
    
        public virtual hCashBox hCashBox { get; set; }
        public virtual hPersonal hPersonal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jReceiptPosition> jReceiptPosition { get; set; }
    }
}
