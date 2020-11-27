using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;
using ClassLibrary2;

namespace ClassLibrary3
{
    public class Starter
    {
        public void Run()
        {
            Logger log = Logger.getInstance();
            Actions act = new Actions();
            for (int i = 1; i <= 100; i++)
            {
                try
                {
                    var r = new Random();
                    int x = r.Next(1, 6);
                    if (x % 5 == 0)
                    {
                        act.Make_Exception();

                    }
                    else if (x % 3 == 0)
                    {
                        act.Skipped_logic();
                        log.Warning();
                    }
                    else
                    {
                        act.Start_method();
                        log.Info();
                    }

                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }



            }



        }
    }
}
