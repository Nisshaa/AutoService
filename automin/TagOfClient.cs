//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace automin
{
    using System;
    using System.Collections.Generic;
    
    public partial class TagOfClient
    {
        public int ClientID { get; set; }
        public int TagID { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
