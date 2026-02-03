using System.Data.Common;
using System.Runtime.CompilerServices;

namespace GenerateId
{
    public class GenerateID
    {
        private int ID;

        public int _newID()
        {
            return ID ++;
        }
        public int getNewID()
        {
            return _newID();
        }
    }
}