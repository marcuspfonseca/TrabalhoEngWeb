//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Roda.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Processador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Processador()
        {
            this.ProcessadoresEquivalentes = new HashSet<Processador>();
            this.Jogos = new HashSet<Jogo>();
        }
    
        public int ID { get; set; }
        public string Descricao { get; set; }
        public Nullable<double> Clock { get; set; }
        public Nullable<int> IDProcessadorEquivalente { get; set; }
        public Nullable<int> Potencia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Processador> ProcessadoresEquivalentes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jogo> Jogos { get; set; }
    }
}
