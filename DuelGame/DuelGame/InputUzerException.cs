using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class InputUzerException : Exception
    {
        public InputUzerException()
        {
            CreatedDate = DateTime.Now;
        }

        public InputUzerException(string message)
            : base(message)
        {
            CreatedDate = DateTime.Now;
        }

        public InputUzerException(string message, Exception innerException)
            : base(message, innerException)
        {
            CreatedDate = DateTime.Now;
        }

        // описание возникшей ситации
        public DateTime CreatedDate { get; private set; }
    }
}
