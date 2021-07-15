using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemOne_LogicErrorBL
{
    public class Class1
    {
       
        private int i;
        private int result = 0;

        public Class1()
        { }

        public int Solution(int a)
        {
            int result = 0;
            try
            {
                for (int i = 1; i <= 1000; i++)
                {
                    if (((i % 3) == 0) || ((i % 5) == 0))
                    {
                        result = +i;
                    }
                }

            }

            catch(Exception ex)
            {

            }
            finally
            {

            }
            return result;
        }
 

    }
}
