﻿namespace SchoolScheduleManager.Entities
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return string.Format("{0}  {1}", Name, Surname);
        }
    }
}
