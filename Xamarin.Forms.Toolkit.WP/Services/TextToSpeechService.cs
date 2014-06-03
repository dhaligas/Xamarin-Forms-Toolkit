using System;
using Windows.Phone.Speech.Synthesis;
using Xamarin.Forms;
using Xamarin.Forms.Toolkit.Services;
using Xamarin.Forms.Toolkit.WP.Services;


[assembly: Dependency(typeof(TextToSpeechService))]
namespace Xamarin.Forms.Toolkit.WP.Services
{
    public class TextToSpeechService : ITextToSpeechService
    {
        SpeechSynthesizer synth;

        public TextToSpeechService()
        {
            synth = new SpeechSynthesizer();
        }


        public async void Speak(string text)
        {
            await synth.SpeakTextAsync(text);
        }
    }
}