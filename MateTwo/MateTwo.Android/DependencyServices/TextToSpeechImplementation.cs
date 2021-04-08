using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Speech.Tts;
using Xamarin.Forms;
using MateTwo.DependencyServices;
using MateTwo.Droid.DependencyServices;

[assembly: Dependency(typeof(TextToSpeechImplementation))]
namespace MateTwo.Droid.DependencyServices
{

    public class TextToSpeechImplementation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {

        private TextToSpeech speaker;
        private string toSpeak;

        
        public void Speak(string Text)
        {
            toSpeak = Text;


            if (speaker == null)
            {
                //speaker.SetLanguage(Locale.Default);
                speaker = new TextToSpeech(context: Forms.Context, listener: this);
                speaker.SetSpeechRate(0.8f);
            }
            else
            {
                speaker.SetSpeechRate(0.8f);
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
            //throw new NotImplementedException();
        }

        public void OnInit(OperationResult status)
        {
            speaker.SetSpeechRate(0.8f);
            speaker.Speak(toSpeak, QueueMode.Flush, null, null);
        }
    }
    
}