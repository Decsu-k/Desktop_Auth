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
    
    public partial class InstalledEquipment
    {
        public int ID { get; set; }
        public int CodeTypeEquipment { get; set; }
        public int CodeIdentificationData { get; set; }
        public int CodeTypePort { get; set; }
        public int CodeInformationlocation { get; set; }
        public string NumbePorts { get; set; }
    
        public virtual IdentificationData IdentificationData { get; set; }
        public virtual Informationlocation Informationlocation { get; set; }
        public virtual TypeEquipment TypeEquipment { get; set; }
        public virtual TypePort TypePort { get; set; }
    }
}