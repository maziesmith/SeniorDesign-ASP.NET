//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SeniorDesignWebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class judge
    {
        public judge()
        {
            this.casetables = new HashSet<casetable>();
        }
    
        public long JudgeId { get; set; }
        public string Name { get; set; }
        public int Race { get; set; }
        public bool Gender { get; set; }
        public int Tenure { get; set; }
        public int AppointedBy { get; set; }
    
        public virtual ICollection<casetable> casetables { get; set; }
    }
}
