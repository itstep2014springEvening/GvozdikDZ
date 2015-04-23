using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day7
{
    public static class Forms
    {
        private static Form1 form1Forms = new Form1();
        private static Form2 form2Forms = new Form2();
        private static Form3 form3Forms = new Form3();
        private static Form4 form4Forms = new Form4();

        public static Form1 form1
        {
            get
            {
                return form1Forms;
            }
        }
        public static Form2 form2
        {
            get
            {
                return form2Forms;
            }
        }
        public static Form3 form3
        {
            get
            {
                return form3Forms;
            }
        }
        public static Form4 form4
        {
            get
            {
                return form4Forms;
            }
        }
    }
}
