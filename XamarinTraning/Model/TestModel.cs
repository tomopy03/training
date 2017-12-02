using System;
using System.ComponentModel;

using PropertyChanged;

namespace XamarinTraning.Model
{
    public class TestModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public TestModel()
        {
            Message = "hello world!";
        }

        public string Message { get; set; }
    }
}
