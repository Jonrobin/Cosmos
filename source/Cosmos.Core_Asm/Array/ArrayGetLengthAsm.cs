using Cosmos.Assembler;
using XSharp.Common;

namespace Cosmos.Core.Plugs_Asm
{
    public class ArrayGetLengthAsm : AssemblerMethod
    {
        public override void AssembleNew(Assembler.Assembler aAssembler, object aMethodInfo)
        {
            // $this   ebp+8
            XS.Set(XSRegisters.EAX, XSRegisters.EBP, sourceDisplacement: 8);
            XS.Set(XSRegisters.EAX, XSRegisters.EAX, sourceDisplacement: 8, sourceIsIndirect: true); // element count
            XS.Push(XSRegisters.EAX);
        }
    }
}
