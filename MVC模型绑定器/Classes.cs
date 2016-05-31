using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC模型绑定器
{
    public class Classes
    {
        public string ClassesName { get; set; }

        public string StudentCount { get; set; }

        public Student[] Students { get; set; }

        public HeadTeacher Teacher { get; set; }
    }
}