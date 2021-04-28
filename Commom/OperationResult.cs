using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commom
{
    public class OperationResult<T>
    {
        public OperationResult()
        {
            Messages = new List<string>();
        }
        public T Model { get; set; }
        public bool Success { get; set; }
        public List<string> Messages { get; set; }

    }
}
