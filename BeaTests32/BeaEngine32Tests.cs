using BeaEngine.Net;

using NUnit.Framework;

namespace BeaTests32
{
    [TestFixture()]
    public class BeaEngine32Tests
    {
        [Test()]
        public void VersionTest()
        {
            var version = BeaEngine32.Version;
			Assert.NotNull(version);
        }

		[Test()]
		public void LibraryNameTest()
		{
			var libraryName = BeaEngine32.LibraryName;
			Assert.NotNull(libraryName);
		}

		[Test()]
		public void RevisionTest()
		{
			var revision = BeaEngine32.Revision;
			Assert.NotNull(revision);
		}

	}
}
