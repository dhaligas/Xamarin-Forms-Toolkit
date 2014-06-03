
using MonoTouch.AVFoundation;
using Xamarin.Forms;
using Xamarin.Forms.Toolkit.iOS.Services;
using Xamarin.Forms.Toolkit.Services;

[assembly: Dependency(typeof(TextToSpeechService))]
namespace Xamarin.Forms.Toolkit.iOS.Services
{
    public class TextToSpeechService : ITextToSpeechService
    {
        public TextToSpeechService() { }

        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}