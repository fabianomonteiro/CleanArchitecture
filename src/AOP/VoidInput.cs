using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Inputs
{
    public class VoidInput
    {
        public static VoidInput Instance { get; private set; }

        static VoidInput()
        {
            Instance = new VoidInput();
        }
    }
}
