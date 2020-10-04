//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpaceApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exercise
    {
        public int idExer { get; set; }
        public Nullable<int> idAstr { get; set; }
        public Nullable<short> idEquip { get; set; }
        public Nullable<System.DateTime> starT { get; set; }
        public Nullable<System.DateTime> endT { get; set; }
        public Nullable<int> forceAmount { get; set; }
        public string typeExe { get; set; }
    
        public virtual Astronaut Astronaut { get; set; }
        public virtual Equipment Equipment { get; set; }


        public Exercise()
        {
        }
        public Exercise(int idAstr, short idEquip, DateTime starT, DateTime endT, int forceAmount, string typeExe)
        {
            this.idAstr = idAstr;
            this.idEquip = idEquip;
            this.starT = starT;
            this.endT = endT;
            this.forceAmount = forceAmount;
            this.typeExe = typeExe;
        }
    }
}
