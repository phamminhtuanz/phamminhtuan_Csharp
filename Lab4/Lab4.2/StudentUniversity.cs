﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class StudentUniversity:StudentCollege
    {
        protected double score4;
        //contructor
        public StudentUniversity(string name, int year, double score1, double score2, double score3, double score4)
            : base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }
        //phương thức tính trung bình điểm
        public override double Average()
        {
            return (score1 + score2 + score3 +score4) / 4;
        }
        //phương thức hiển thị thông tin
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score 4: {0:N}", score4);
        }
    }
}
