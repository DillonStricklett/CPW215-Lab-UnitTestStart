using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private byte numberOfCredits;
        private string courseName;
        private string instructorName = "STAFF";

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName 
        {
            get => instructorName;
            set => instructorName = value;
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get => courseName;
            set =>
                courseName = value ?? throw new ArgumentNullException($"{nameof(courseName)} cannot be null");
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits
        {
            get => numberOfCredits;
            set
            {
                if (value != (byte)5)
                    throw new ArgumentException("Number of credits cannot be more than 30 or less than 1");
                numberOfCredits = value;
            }
        }

    }
}
