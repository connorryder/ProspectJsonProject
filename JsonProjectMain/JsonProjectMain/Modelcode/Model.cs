using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProjectMain.Model
{
    partial class Course
    {
        public Course()
        {
            if (Courses == null)
            {
                Courses = new ObservableCollection<Course>();
            }
        }
        private ObservableCollection<Course> _courses;
        public ObservableCollection<Course> Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
        public Course(string title, string type, string board, string desc, string why, string requirements, string opportunities)
        {
            this.Title = title;
            this.Type = type;
            this.Board = board;
            this.Desc = desc;
            this.Why = why;
            this.Requirements = requirements;
            this.Opportunities = opportunities;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _board;
        public string Board
        {
            get { return _board; }
            set { _board = value; }
        }

        private string _desc;
        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        private string _why;

        public string Why
        {
            get { return _why; }
            set { _why = value; }
        }

        private string _requirements;

        public string Requirements
        {
            get { return _requirements; }
            set { _requirements = value; }
        }
        private string _opportunities;

        public string Opportunities
        {
            get { return _opportunities; }
            set { _opportunities = value; }
        }
    }
}