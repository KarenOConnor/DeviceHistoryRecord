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
    
    public partial class ProductStage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductStage()
        {
            this.StageSteps = new HashSet<StageStep>();
        }
    
        public int StageID { get; set; }
        public int ProductID { get; set; }
        public string StageName { get; set; }
        public int Sequence { get; set; }
    
        public virtual ProductConfig ProductConfig { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StageStep> StageSteps { get; set; }
    }
}
