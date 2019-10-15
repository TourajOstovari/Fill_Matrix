using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Matrix_NoReptative_
{
    class Patterns_Alternative
    {
        public List<Array> Patterns_Alt = new List<Array>();
    }
    internal partial class Program
    {
        public class Rep_Matrix
        {
            public List<Array> arrays = new List<Array>();
            byte[] goal_rep1_ = new byte[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            byte[] goal_rep2 = new byte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            public bool Contains_(byte[] buffered_)
            {
                if (arrays.Contains(buffered_)) return true;
                else return false;
            }
            public bool Final_Goal_Contains_(byte[] buffered_)
            {
                if (goal_rep1_.SequenceEqual<byte>(buffered_) || goal_rep2.SequenceEqual<byte>(buffered_)) return true;
                else return false;
            }
            public void set_buffer(byte[] buffered_)
            {
                arrays.Add(buffered_);
            }
        }
    }
}
