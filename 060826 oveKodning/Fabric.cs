using System;
using System.Collections.Generic;
using System.Text;

namespace _060826_oveKodning
{
    public class Fabric
    {
        public string FabricType;
        public string Color;
        public string Pattern;
        public string Material;
        public string PurposeTheme;
        /// <summary>
        /// Constructor for Fabric class, which initializes all properties for a new instance of the class.
        /// </summary>
        /// <param name="fabricType"></param>
        /// <param name="color"></param>
        /// <param name="pattern"></param>
        /// <param name="material"></param>
        /// <param name="purposeTheme"></param>
        public Fabric(string fabricType, string color, string pattern, string material, string purposeTheme)
        {
            FabricType = fabricType;
            Color = color;
            Pattern = pattern;
            Material = material;
            PurposeTheme = purposeTheme;
        })
    }
}
