using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bea;
using NUnit.Framework;
namespace Bea.Tests
{
    [TestFixture()]
    public class BeaEngine32Tests
    {
        [Test()]
        public void DisasmTest()
        {
            var engine = BeaEngine32.Version;
        }
    }
}
