//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cint
{
    using System;
    using System.Collections.Generic;
    
    public partial class Типы_траспорта
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Типы_траспорта()
        {
            this.Транспорт = new HashSet<Транспорт>();
        }
    
        public int ID_Типов_Транспорта { get; set; }
        public string Тип_транспорта { get; set; }
        public string Классификация { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Транспорт> Транспорт { get; set; }
    }
}
