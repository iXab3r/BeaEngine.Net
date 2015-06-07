# BeaEngine.Net
Managed wrapper for BeaEngine http://beaengine.org/
Wrapper uses Fody.Costura for embedding both x86 and x64 versions of BeaEngine

BeaEngine is a library coded in C respecting ISO C99 norm since 4.0.0 version (originally written with the IDE Code::Blocks and the compiler Pelles C). 
It has been developed to decode instructions from 16 bits, 32 bits and 64 bits intel architectures.
Actually, the main function available is called Disasm. 
It includes standard instruction set and instruction set from FPU, MMX, SSE, SSE2, SSE3, SSSE3, SSE4.1, SSE4.2, VMX, CLMUL, AES technologies. 
For those who like analyzing malicious codes and more generally obfuscated codes, BeaEngine decodes undocumented instructions called "alias" on the web site sandpile. 
In all scenarios, it sends back a complex structure that describes precisely the analyzed instructions.
