using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExampleOOP
{
    /// <summary>
    /// Represents an individual dice.
    /// </summary>
    class Die
    {
        /// <summary>
        /// The outcome value of the die.
        /// </summary>
        public byte Value { get; private set; } // cannot be set; only retrieved. 

        public bool isHeld { get; set; }

        // Roll method
    }
}
