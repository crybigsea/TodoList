using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TodoList.Model;

namespace TodoList.ViewModel
{
    public class VMAdd : INotifyPropertyChanged
    {
        public string _title;
        public string _content;
        public DateTime _endTime;
        public bool _isStar;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
                OnPropertyChanged("Content");
            }
        }

        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
                OnPropertyChanged("EndTime");
            }
        }

        public bool IsStar
        {
            get
            {
                return _isStar;
            }
            set
            {
                _isStar = value;
                OnPropertyChanged("IsStar");
            }
        }

        public TodoModel ToModel()
        {
            return new TodoModel
            {
                Title = Title,
                Content = Content,
                EndTime = EndTime,
                IsStar = IsStar
            };
        }
    }
}
