using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExampleOOP
{
    /// <summary>
    /// Represents an individual die.
    /// </summary>
    class Die
    {
        #region Fields

        // static: set random once and share it between all the classes.
        static Random random;

        // for instance constructor that creates min and max
        byte minValue;
        byte maxValue;

        #endregion

        #region Constructors

        /// <summary>
        /// Static constructors are called once for all the die classes.
        /// </summary>
        static Die()
        {
            random = new Random();  // create it once and keep referencing it.
        }

        /// <summary>
        /// Generate a random number.
        /// </summary>
        public Die():this(1, 6)
        {
            // Original code is not needed because of chaining constructor

            //// set min and max value
            //minValue = 1;
            //maxValue = 6;

            //Roll(); // Roll die with a new instance of Die object; avoid 0 value.
        }

        /// <summary>
        /// Instance constructor that will take in Min and Max values.
        /// </summary>
        /// <param name="minValue">The inclusive lower bound</param>
        /// <param name="maxValue">The inclusive maximum bound</param>
        public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            Roll();
        }

        #endregion

        #region Properties

        /// <summary>
        /// The outcome value of the die.
        /// </summary>
        public byte Value { get; private set; } // cannot be set; only retrieved. 

        public bool IsHeld { get; set; } // public get and set access available for event driven programming.

        #endregion

        #region Methods

        /// <summary>
        /// Roll a new random value between 1 - 6
        /// and return the newly rolled value.
        /// If the die is held, the current value will be returned
        /// and no new value generated.
        /// </summary>
        public byte Roll() // public: anyone can roll a die/dice.
        {
            // create variable for exclusive number
            const int offSet = 1;

            // control statement
            if (!IsHeld) // if Die is NOT Held.
            {
                // create value, apply to value property and cast to match data type.
                //Value = (byte)random.Next(1, 7); // max exclusive: need to include 6.

                Value = (byte)random.Next(minValue, maxValue + offSet);
            }
            // return value
            return Value;
        }

        #endregion
    }
}
