using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_ex4._3
{
    internal interface IStoreable
    {
        string Data { get; set; }
        void Write(string fileName);
        void Read(string fileName);
    }
}
