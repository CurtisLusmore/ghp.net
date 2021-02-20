using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.FileProviders;

namespace ghp
{
    public class DirectoryExistsContents : IDirectoryContents
    {
        public bool Exists => true;
        public IEnumerator<IFileInfo> GetEnumerator() => throw new System.NotImplementedException();
        IEnumerator IEnumerable.GetEnumerator() => throw new System.NotImplementedException();
    }
}
