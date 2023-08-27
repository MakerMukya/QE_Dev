using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace m_add
{
    internal interface IRead
    {
        string AtomId { get; set; } 
        string FilePath { get; set; }
        void ReadCifFile ();
        object[] CoordView { get; set; }
        void MoveCoordCalcul ();

    }
}
