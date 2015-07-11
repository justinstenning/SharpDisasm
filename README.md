SharpDisasm
===========

SharpDisam is a C# disassembler able to decode binary executable code for the x86 and x86-64 CPU architectures into disassembled instructions.

The disassembler is able to decode more than 4 million 64-bit instructions a second (with an average instruction length of 7-bytes). When also translating the instructions to Intel syntax the number of instructions per second is around 2 million instructions per second.

The library is a C# port of the Udis86 disassembler originally written in C. The ported portion of SharpDisam is a straight port of the C Udis86 library to C# with no attempt to change the logic and make the code base more C# friendly. This was done intentionally so that future updates to the Udis86 library can be ported across without too much hassle. The SharpDisam.Disassembler class wraps the original Udis86 API in order to present a C# friendly interface to the underlying API.

The opcode table "optable.xml" is used to generate the opcode lookup tables with a T4 template "OpTable.tt". This generates an output that is comparable to the output of the original Python scripts used with Udis86 (ud_itab.py and ud_opcode.py).

LICENSE
-------

SharpDisam is Copyright (c) 2015 Justin Stenning and is distributed under the 2-clause "Simplified BSD License". Portions of the project are ported from Udis86 Copyright (c) 2002-2012, Vivek Thampi <vivek.mt@gmail.com> https://github.com/vmt/udis86 distributed under the 2-clause "Simplified BSD License".