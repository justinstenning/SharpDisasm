using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SharpDisasm.Factory
{
    /// <summary>
    /// interface for instruction factory
    /// </summary>
    public interface IInstructionFactory
    {
        /// <summary>
        /// The create method of the factory
        /// </summary>
        /// <param name="u">the internal instruction parser</param>
        /// <param name="keepBinary">To copy the binary bytes to instruction</param>
        /// <returns>Instructuion instance</returns>
        IInstruction Create(ref Udis86.ud u, bool keepBinary);
    }
}
