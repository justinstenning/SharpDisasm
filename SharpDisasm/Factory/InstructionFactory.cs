using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SharpDisasm.Factory
{
    /// <summary>
    /// Instruction factory
    /// </summary>
    public class InstructionFactory : IInstructionFactory
    {
        /// <summary>
        /// The create method of the factory
        /// </summary>
        /// <param name="u">the internal instruction parser</param>
        /// <param name="keepBinary">To copy the binary bytes to instruction</param>
        /// <returns>Instructuion instance</returns>
        public IInstruction Create(ref Udis86.ud u, bool keepBinary)
        {
            return new Instruction( ref u, keepBinary);
        }
    }
}
