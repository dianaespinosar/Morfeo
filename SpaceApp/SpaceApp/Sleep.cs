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
    
    public partial class Sleep
    {
        public int idSleep { get; set; }
        public Nullable<int> idAstr { get; set; }
        public Nullable<System.DateTime> bedTime { get; set; }
        public Nullable<System.DateTime> wakeupTime { get; set; }
        public Nullable<int> interruptions { get; set; }
        public string reasns { get; set; }
        public bool deepSleep { get; set; }
        public string light { get; set; }
        public string circadianCycle { get; set; }
    
        public virtual Astronaut Astronaut { get; set; }

        public Sleep()
        {
        }
        public Sleep(int idAstr, DateTime bedTime, DateTime wakeupTime, int interruptions, string reasns, bool deepSleep, string light, string circadianCycle)
        {
            this.idAstr = idAstr;
            this.bedTime = bedTime;
            this.wakeupTime = wakeupTime;
            this.interruptions = interruptions;
            this.reasns = reasns;
            this.deepSleep = deepSleep;
            this.light = light;
            this.circadianCycle = circadianCycle;
        }
    }
}
