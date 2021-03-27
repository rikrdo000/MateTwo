using System;
using System.Collections.Generic;
using System.Text;

namespace MateTwo.DependencyServices
{
    public interface ITextToSpeech
    {
        void Speak(string Text);
    }
}
