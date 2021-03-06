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
    
    public partial class Jogo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jogo()
        {
            this.PlacasCompativeis = new HashSet<PlacaVideo>();
            this.ProcessadoresCompativeis = new HashSet<Processador>();
        }
    
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UrlImagem { get; set; }
        public string NomeEmpresa { get; set; }
        public Nullable<int> MinimoMemoria { get; set; }
        public Nullable<int> MinimoHD { get; set; }
        public string DescricaoRequisitos { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlacaVideo> PlacasCompativeis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Processador> ProcessadoresCompativeis { get; set; }
    }
}
