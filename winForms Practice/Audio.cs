using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;


namespace winForms_Practice
{
    class Audio
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern Boolean PlaySound(string lpszName, int hModule, int dwFlags);
        private static WMPLib.WindowsMediaPlayer wmp;
        static Audio()
        { 
            wmp = new WMPLib.WindowsMediaPlayer();
        }
        public static void Play(string sound)
        {
            wmp.URL = sound;
            wmp.controls.play();
        }
        public static void Stop()
        {
            wmp.controls.stop();
        }
    }
}
