using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winForms_Practice
{
    [Serializable]
    public class Note
    {
        public string Signal;
        public DateTime Time;
        public string Title;
        public string Text;
        public bool AlreadyShown;
    }
}
