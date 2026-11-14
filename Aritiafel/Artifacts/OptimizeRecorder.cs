using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritiafel.Artifacts
{
    //處理檔案插入項目讀寫等問題

    //開時鎖定檔案，不用再透過StreamWriter
    
    public class OptimizeRecorder : IDisposable
    {
        long _constantDataLength;
        Dictionary<long, long> _spaceLocation;
        FileStream _fs;

        public OptimizeRecorder(string filePath, long constantDataLength, Dictionary<long, long> spaceLocation)
        {   
            try
            {
                Path.GetFullPath(filePath);
            }
            catch (Exception ex)
            {   
                throw new ArgumentException("filePath is not valid", ex);
            }

            try
            {
                _fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Can't open or create file", ex);
            }

            _constantDataLength = constantDataLength;
            _spaceLocation = spaceLocation;
            if(_spaceLocation == null)
                _spaceLocation = new Dictionary<long, long>();
        }

        public OptimizeRecorder(string filePath)
            : this(filePath, 0, null)
        { }

        public void ScanSpaceLocation()
        {

        }

        public bool Insert()
        {
            return false;
        }

        public bool Replace()
        {
            return false;
        }
        public string Read()
        {
            return "";
        }
        public bool Delete()
        {
            return false;
        }

        public List<(long, long)> Normalize()
        {
            return null;
        }

        public void Dispose()
        {
            _fs.Close();
        }

        ~OptimizeRecorder()
        {
            Dispose();
        }
    }
}
