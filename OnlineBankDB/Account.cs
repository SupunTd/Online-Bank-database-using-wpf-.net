//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineBankDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public Account()
        {
            this.Banks = new HashSet<Bank>();
        }
    
        public int Account_Id { get; set; }
        public int Balance { get; set; }
        public string Account_Type { get; set; }
    
        public virtual ICollection<Bank> Banks { get; set; }
    }
}
