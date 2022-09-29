using System.IO;

namespace Kogane
{
    public sealed class EditorFirstBootChecker
    {
        private readonly string m_path;

        public EditorFirstBootChecker( string filename )
        {
            m_path = $"Library/{filename}";
        }

        public bool IsFirstBoot()
        {
            if ( File.Exists( m_path ) ) return false;

            File.Create( m_path );

            return true;
        }
    }
}