using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuelGame
{
    class InputUserPersonageException : Exception
    {
        public InputUserPersonageException()
        {
            CreatedDate = DateTime.Now;
        }

        public InputUserPersonageException(string message)
            : base(message)
        {
            CreatedDate = DateTime.Now;
        }

        public InputUserPersonageException(string message, Exception innerException)
            : base(message, innerException)
        {
            CreatedDate = DateTime.Now;
        }

        public DateTime CreatedDate { get; private set; }
    }
}
