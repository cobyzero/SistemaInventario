using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoVenta
{
    public static class ConfigGeneral
    {
        public enum TYPE_LANGUAGE
        {
            SPANISH = 0,
            ALEMAN = 1,
        }
        private static TYPE_LANGUAGE type_languaje = TYPE_LANGUAGE.SPANISH;

        public static TYPE_LANGUAGE getType()
        {
            return type_languaje;
        }

        public static string webDomain = "http://ealemana.somee.com/";
    }
}
