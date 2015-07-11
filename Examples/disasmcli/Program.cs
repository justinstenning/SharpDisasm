using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace disasmcli
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpDisasm.ArchitectureMode mode = SharpDisasm.ArchitectureMode.x86_32;
            if (args.Length > 0)
            {
                switch (args[0])
                {
                    case "16": { mode = SharpDisasm.ArchitectureMode.x86_16; break; }
                    case "32": { mode = SharpDisasm.ArchitectureMode.x86_32; break; }
                    case "64": { mode = SharpDisasm.ArchitectureMode.x86_64; break; }
                    default:
                        break;
                }
            }

            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192))); // This will allow input >256 chars

            SharpDisasm.Disassembler.Translator.IncludeAddress = true;
            SharpDisasm.Disassembler.Translator.IncludeBinary = true;

            StringBuilder input = new StringBuilder();
            while (Console.In.Peek() != -1)
            {
                input.Append(Console.In.ReadLine());

            }

            var disasm = new SharpDisasm.Disassembler(StringToByteArray(input.ToString().Replace(" ", "")), mode, 0, true);
            foreach (var insn in disasm.Disassemble())
                Console.Out.WriteLine(insn.ToString());
        }

        static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
    }
}
