using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class InputUserException : Exception
    {
        public InputUserException()
        {
            CreatedDate = DateTime.Now;
        }

        public InputUserException(string message)
            : base(message)
        {
            CreatedDate = DateTime.Now;
        }

        public InputUserException(string message, Exception innerException)
            : base(message, innerException)
        {
            CreatedDate = DateTime.Now;
        }

        // описание возникшей ситации
        public DateTime CreatedDate { get; private set; }
    }
}
