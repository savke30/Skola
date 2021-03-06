//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Skola.DbModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ucenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ucenik()
        {
            this.Ocjenes = new HashSet<Ocjene>();
        }
    
        public int UcenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Pol { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public System.DateTime DatumRodjenja { get; set; }
        public string ImeRoditelja { get; set; }
        public int BrojUDnevniku { get; set; }
        public string Drzavljanstvo { get; set; }
        public int OdjeljenjeId { get; set; }
        public Nullable<int> GradID { get; set; }
    
        public virtual Grad Grad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocjene> Ocjenes { get; set; }
        public virtual Odjeljenje Odjeljenje { get; set; }
    }
}
