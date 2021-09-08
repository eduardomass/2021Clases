using System;
using System.Collections.Generic;
using System.Text;

namespace MiConsola
{
    public static class IntExtension
    {
        public static bool EsPar(this int value) => value % 2 == 0;
    }
}
