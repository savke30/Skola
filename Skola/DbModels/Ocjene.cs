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
    
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int UcenikId { get; set; }
        public System.DateTime Datum { get; set; }
        public int VrijednostOcjene { get; set; }
        public int TipOcjene { get; set; }
        public int Predmet { get; set; }
        public int Nastavnik { get; set; }
    
        public virtual Nastavnik Nastavnik1 { get; set; }
        public virtual Predmet Predmet1 { get; set; }
        public virtual Ucenik Ucenik { get; set; }
    }
}
