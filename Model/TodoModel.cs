using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList.Model
{
    public class TodoModel
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsStar { get; set; }

        public bool IsFinish { get; set; }
    }
}
