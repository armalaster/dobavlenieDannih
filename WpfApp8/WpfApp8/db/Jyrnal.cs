//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp8.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jyrnal
    {
        public int IDJyrnala { get; set; }
        public int KodPridmeta { get; set; }
        public int NumTeacher { get; set; }
        public int KodYchenika { get; set; }
        public int Ocenka { get; set; }
    
        public virtual Pridmet Pridmet { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Ycheniki Ycheniki { get; set; }
    }
}