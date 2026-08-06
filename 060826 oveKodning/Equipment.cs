using System;
using System.Collections.Generic;
using System.Text;

namespace _060826_oveKodning
{
    public class Equipment
    {
        public string ThreadType { get; set; }
        public string NeedleType { get; set; }
        public string MachineType { get; set; }
        /// <summary>
        /// Constructor for Equipment class, which initializes all properties for a new instance of the class.
        /// </summary>
        /// <param name="threadType"></param>
        /// <param name="needleType"></param>
        /// <param name="machineType"></param>
        public Equipment(string threadType, string needleType, string machineType)
        {
            ThreadType = threadType;
            NeedleType = needleType;
            MachineType = machineType;
        })

    }
}
