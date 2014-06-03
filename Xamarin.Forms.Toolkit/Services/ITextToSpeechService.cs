using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.Toolkit.Services
{
    //http://developer.xamarin.com/guides/cross-platform/xamarin-forms/dependency-service/
    public interface ITextToSpeechService
    {
        void Speak(string text);
    }
}
