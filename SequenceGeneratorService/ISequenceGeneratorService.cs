using System;
using System.Collections.Generic;
using System.Text;

namespace SequenceGeneratorService
{
    public interface ISequenceGeneratorService
    {
        public string ProcessInput(string inputString);
    }
}
