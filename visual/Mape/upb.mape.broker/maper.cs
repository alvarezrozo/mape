//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace upb.mape.broker
{
    using System;
    using System.Collections.Generic;
    
    public partial class maper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public maper()
        {
            this.comments_mapers = new HashSet<comments_mapers>();
            this.dates = new HashSet<date>();
        }
    
        public decimal id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public string cell { get; set; }
        public string mail { get; set; }
        public string implements { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<decimal> cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comments_mapers> comments_mapers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<date> dates { get; set; }
    }
}
