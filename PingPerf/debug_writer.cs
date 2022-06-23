using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PingPerf
{
    class debug_writer
    {

        string path;
        System.IO.StreamWriter file;

        public void create_path()
        {

            try
            {
                //    
                path = DateTime.Now.ToShortDateString() + ".txt";

                file = new System.IO.StreamWriter(path, true);

                file.WriteLine("\n");
                file.WriteLine("---------------------------------------------");
                file.WriteLine("Start ... \n");
                file.Flush();

            }
            catch (Exception exp)
            {

                System.Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt") + " Create log file error" + exp.Message);

            }
            
        }


        public void write_to_file( string msg)
        {
            try
            {
                file.WriteLine(DateTime.Now.ToString("HH:mm:ss tt") + msg);
                file.Flush();
            }
            catch (Exception exp)
            {

                System.Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt") + " Write to file error " + exp.Message);

            }

        }


        public void close_file()
        {
            try
            {
                //   file.Flush();
                file.Close();
            }
            catch (Exception exp)
            {

                System.Console.WriteLine(DateTime.Now.ToString("HH:mm:ss tt") + " Close file error" + exp.Message);

            }
        }
    
    
    }


}
