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
    
    public partial class MedAstr
    {
        public int idMedAstr { get; set; }
        public Nullable<int> idMed { get; set; }
        public Nullable<int> idAstr { get; set; }
    
        public virtual Astronaut Astronaut { get; set; }
        public virtual Medicines Medicines { get; set; }

        public MedAstr()
        { }
        public MedAstr(int idMed, int idAstr)
        {
            this.idMed = idMed;
            this.idAstr = idAstr;
        }
    }
}
