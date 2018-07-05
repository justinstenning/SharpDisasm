using SharpDisasm.Udis86;

namespace SharpDisasm
{
    /// <summary>
    /// instruction interface
    /// </summary>
    public interface IInstruction
    {
        /// <summary>
        /// Instruction Offset
        /// </summary>
        byte[] Bytes { get; }

        /// <summary>
        /// Indicates whether the instruction was successfully decoded.
        /// </summary>
        bool Error { get; }

        /// <summary>
        /// The reason an instruction was not successfully decoded.
        /// </summary>
        string ErrorMessage { get; }

        /// <summary>
        /// The length of the instruction in bytes
        /// </summary>
        int Length { get; }

        /// <summary>
        /// Mnemonic
        /// </summary>
        ud_mnemonic_code Mnemonic { get; }

        /// <summary>
        /// Instruction offset
        /// </summary>
        ulong Offset { get; }

        /// <summary>
        /// Instruction Operends (maximum 3)
        /// </summary>
        Operand[] Operands { get; }

        /// <summary>
        /// Program counter
        /// </summary>
        ulong PC { get; }

        


    }
}