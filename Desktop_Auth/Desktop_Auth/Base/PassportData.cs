//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desktop_Auth.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassportData
    {
        public int Code { get; set; }
        public int CodeResidenceAddress { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string IssuedByWhom { get; set; }
        public Nullable<System.DateTime> DateOfIssue { get; set; }
    
        public virtual CodeResidenceAddress CodeResidenceAddress1 { get; set; }
        public virtual InformationSubscriber InformationSubscriber { get; set; }
    }
}