using BeaEngine.Net;

using NUnit.Framework;

namespace BeaTests64
{
    [TestFixture()]
    public class BeaEngine32Tests
    {
        [Test()]
        public void VersionTest()
        {
            var version = BeaEngine64.Version;
			Assert.NotNull(version);
        }

		[Test()]
		public void LibraryNameTest()
		{
			var libraryName = BeaEngine64.LibraryName;
			Assert.NotNull(libraryName);
		}

		[Test()]
		public void RevisionTest()
		{
			var revision = BeaEngine64.Revision;
			Assert.NotNull(revision);
		}

	}
}
