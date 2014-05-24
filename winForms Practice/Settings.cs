using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winForms_Practice
{
    class Settings
    {
        private string _signal;
        public string Signal { get { return _signal; } set { _setSignal(value); } }
        private void _setSignal(string value)
        {
            _signal = value;
            System.IO.File.WriteAllText("config.dat", _signal);
        }
    }
}
