//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeviceHistoryRecord.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class WorkItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkItem()
        {
            this.WorkItemComponents = new HashSet<WorkItemComponent>();
        }
    
        public int WorkItemID { get; set; }
        public int ProductID { get; set; }
        public int Status { get; set; }
    
        public virtual ProductConfig ProductConfig { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkItemComponent> WorkItemComponents { get; set; }
    }
}
