using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace winForms_Practice
{
    class ProductivityManager
    {
        public Settings AppSettings;
        public List<Note> _noteCollection;
        Timer _timer;
        public ProductivityManager()
        {
            _load();
            AppSettings = new Settings();
            _timer = new Timer(_timerCallback);
            _timer.Change(1000, 1000);
        }
        private void _timerCallback(Object obj)
        {
            foreach (Note item in _noteCollection)
            {
                if (TimeUtil.IsSameMinute(DateTime.Now, item.Time) && item.AlreadyShown == false)
                {
                    _timer.Change(0, 0);
                    item.AlreadyShown = true;
                    new MessageForm(item).ShowDialog();                    
                    _timer.Change(1000, 1000);
                }
            }
        }
        private void _load()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("notes.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                _noteCollection = (List<Note>)formatter.Deserialize(fs);
            }
            catch
            {
                _noteCollection = new List<Note>();
            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
        public List<Note> GetDateNotes(DateTime date)
        {
            List<Note> result = new List<Note>();

            for (var i = 0; i < _noteCollection.Count; i++)
            {
                if (TimeUtil.IsSameDay(_noteCollection[i].Time, date))
                {
                    result.Add(_noteCollection[i]);
                }
            }
            return result;
        }
        public Note GetNote(int id, DateTime day)
        {
            int pos = 0;
            foreach (Note item in _noteCollection)
            {
                if (TimeUtil.IsSameDay(item.Time, day))
                {
                    if (pos == id)
                    {
                        return item;
                    }
                    pos++;
                }
            }
            return null;
        }
        public Note Remove(int id, DateTime day)
        {
            int pos = 0;
            foreach (Note item in _noteCollection)
            {
                if (TimeUtil.IsSameDay(item.Time, day))
                {
                    if (pos == id)
                    {
                        _noteCollection.Remove(item);
                        return item;
                    }
                    pos++;
                }
            }
            return null;
        }
        public DateTime[] GetNotesDates()
        {
            DateTime[] dt = new DateTime[_noteCollection.Count];
            for (int i = 0; i < _noteCollection.Count; i++)
            {
                dt[i] = _noteCollection[i].Time;
            }
            return dt;
        }
        public void Add(Note note)
        {
            _noteCollection.Add(note);
            Update();
        }
        public void Update()
        {
            FileStream fs = new FileStream("notes.dat", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, _noteCollection);
        }
    }
}
