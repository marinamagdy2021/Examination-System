//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examination_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam_Q
    {
        public int Exam_Id { get; set; }
        public int Q_Id { get; set; }
        public Nullable<int> Q_Number { get; set; }
        public string Checked_Ans { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
    }
}
