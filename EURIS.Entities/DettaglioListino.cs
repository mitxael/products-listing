//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EURIS.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class DettaglioListino
    {
        public int Id { get; set; }
        public Nullable<int> Id_listino { get; set; }
        public Nullable<int> Id_prodotto { get; set; }
        public Nullable<int> quantita { get; set; }
    
        public virtual Listino ListinoSet { get; set; }
        public virtual Prodotto ProdottoSet { get; set; }
    }
}