using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace PingPerf
{
    public partial class Form1 : Form
    {
        PingReply ping_reply;
      
        Ping ping_send;
      
        IPAddress address;
   

        int timeout = 1800;
        int delay = 2500;
        string hostname = "8.8.8.8";
   
        int ping_max = 100;

        int[,] ping_data;

        string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

        int current_y_scale = 10;
        // 10
        // 100
        // 1000
        // 2000


        int ping_state = -1;



        int ping_success = 0;
        int ping_failed = 0;

        BackgroundWorker bg_worker1;
        BackgroundWorker bg_worker2;
        BackgroundWorker bg_worker3;
        BackgroundWorker bg_worker4;
        BackgroundWorker bg_worker5;
        BackgroundWorker bg_worker6;
        BackgroundWorker bg_worker7;
        BackgroundWorker bg_worker8;

        bool thread_1 = false;
        bool thread_2 = false;
        bool thread_3 = false;
        bool thread_4 = false;
        bool thread_5 = false;
        bool thread_6 = false;
        bool thread_7 = false;
        bool thread_8 = false;

        int thread_test = 0;


        debug_writer dw;

        public Form1()
        {

            try
            {




                dw = new debug_writer();
                dw.create_path();



                dw.write_to_file("Initialize components");


                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false;


                Thread.Sleep(500);

      



                System.Console.WriteLine("Backgroundworkers");
                dw.write_to_file("Backgroundworkers:");

                System.Console.WriteLine("BGW 1");
                dw.write_to_file("BGW 1");
                bg_worker1 = new BackgroundWorker();
                bg_worker1.WorkerReportsProgress = false;
                bg_worker1.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 2");
                dw.write_to_file("BGW 2");
                bg_worker2 = new BackgroundWorker();
                bg_worker2.WorkerReportsProgress = false;
                bg_worker2.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 3");
                dw.write_to_file("BGW 3");
                bg_worker3 = new BackgroundWorker();
                bg_worker3.WorkerReportsProgress = false;
                bg_worker3.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 4");
                dw.write_to_file("BGW 4");
                bg_worker4 = new BackgroundWorker();
                bg_worker4.WorkerReportsProgress = false;
                bg_worker4.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 5");
                dw.write_to_file("BGW 5");
                bg_worker5 = new BackgroundWorker();
                bg_worker5.WorkerReportsProgress = false;
                bg_worker5.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 6");
                dw.write_to_file("BGW 6");
                bg_worker6 = new BackgroundWorker();
                bg_worker6.WorkerReportsProgress = false;
                bg_worker6.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 7");
                dw.write_to_file("BGW 7");
                bg_worker7 = new BackgroundWorker();
                bg_worker7.WorkerReportsProgress = false;
                bg_worker7.WorkerSupportsCancellation = true;

                System.Console.WriteLine("BGW 8");
                dw.write_to_file("BGW 8");
                bg_worker8 = new BackgroundWorker();
                bg_worker8.WorkerReportsProgress = false;
                bg_worker8.WorkerSupportsCancellation = true;


                System.Console.WriteLine("BGW Handlers");
                dw.write_to_file("BGW Handlers");
                bg_worker1.DoWork += new DoWorkEventHandler(send_pings_thread);
                bg_worker2.DoWork += new DoWorkEventHandler(send_pings_thread);
                bg_worker3.DoWork += new DoWorkEventHandler(send_pings_thread);
                bg_worker4.DoWork += new DoWorkEventHandler(send_pings_thread);

                bg_worker5.DoWork += new DoWorkEventHandler(send_pings_thread);
                bg_worker6.DoWork += new DoWorkEventHandler(send_pings_thread);
                bg_worker7.DoWork += new DoWorkEventHandler(send_pings_thread);
                bg_worker8.DoWork += new DoWorkEventHandler(send_pings_thread);


                

                warm_up();


            }
            catch (Exception exp)
            {

                Console.WriteLine(exp.Message + "\n");
                dw.write_to_file("Error:" + exp.Message);
            }


        }


        public bool test_destination(string host_to_test)
        {

            dw.write_to_file("Test destination" );
            
            bool test = IPAddress.TryParse(host_to_test, out address);
       


            if (test)
            {

                address = IPAddress.Parse(host_to_test);

            }
            else
            {



                try
                {
                    text_debug.AppendText("Resolving address ... ");
                    dw.write_to_file("Resolving address ... ");
                    IPAddress[] address_table = Dns.GetHostAddresses(host_to_test);

                    address = address_table[0];

                    text_debug.AppendText("OK: " + address_table[0] + "\n");
                    dw.write_to_file("OK");
                    
                }
                catch (Exception exp)
                {

                    text_debug.AppendText("Failed: " + exp.Message + "\n");
                    dw.write_to_file("Failed: " + exp.Message + "\n");
                    return false;

                }


            }







            Ping ping_test = new Ping();
            PingOptions options = new PingOptions(64, true);
            PingReply reply_test = ping_test.Send(host_to_test);


            if (reply_test.Status == IPStatus.Success)
            {


                text_debug.AppendText("Host is responding: " + host_to_test + "\n");
                text_debug.AppendText("Starting... \n");
                dw.write_to_file("Host is responding: " + host_to_test );
                dw.write_to_file("Starting ...");
                return true;

            }


            text_debug.AppendText("No respond from: " + host_to_test + "\n");
            dw.write_to_file("No respond from: " + host_to_test);
            return false;
             
        }

        public int get_thread_id()
        {

            if (thread_1 == false)
            {

                thread_1 = true;
                return 1;
            }

            if (thread_2 == false)
            {

                thread_2 = true;
                return 2;

            }

            if (thread_3 == false)
            {

                thread_3 = true;
                return 3;
            }

            if (thread_4 == false)
            {


                thread_4 = true;
                return 4;
            }


            if (thread_5 == false)
            {


                thread_5 = true;
                return 5;
            }


            if (thread_6 == false)
            {


                thread_6 = true;
                return 6;
            }


            if (thread_7 == false)
            {


                thread_7 = true;
                return 7;
            }


            if (thread_8 == false)
            {


                thread_8 = true;
                return 8;
            }

            return -1;


        }

        public void send_pings_thread(object sender, DoWorkEventArgs e)
        {


            int id = get_thread_id();

           

            if (thread_test < 8)
            {

                dw.write_to_file(id + "New Thread Warming Up");

                text_debug.AppendText("New Thread Warming Up: " + id + "\n");
                text_debug.ScrollToCaret();

                if (id == 8)
                {

                    text_debug.AppendText("Ready. Change target and hit GO! \n\n");
                    text_debug.ScrollToCaret();
                    dw.write_to_file("Ready");

                }
                thread_test++;
                return;
            }


         //   text_debug.AppendText("New Thread: " +  id + "\n");

             Thread.Sleep(id * 250 ); //250);

        //    for (int t = 0; t < 5; t++)
            {

              //  Thread.Sleep(2000);
             //   text_debug.AppendText("T" + id + "\n");

                send_pings(id);

            }

           

        }


  
         public void send_pings(int id)
        //public void send_pings(object sender, DoWorkEventArgs e)
        {
            Ping ping_send = new Ping();
            ping_send.PingCompleted += p_PingCompleted;


            for (int ping_count = 0; ping_count < (ping_max / 8 ); ping_count++ )
            {
                ping_state++;

                try
                {

                  //  text_debug.AppendText("x");
                  
                    PingOptions options = new PingOptions(64, true);


                    

                    if (bg_worker1.CancellationPending == true)
                    {
                        dw.write_to_file("1 - Canceling");
                        break;

                    }
                    if (bg_worker2.CancellationPending == true)
                    {
                        dw.write_to_file("2 - Canceling");
                        break;

                    }
                    if (bg_worker3.CancellationPending == true)
                    {
                        dw.write_to_file("3 - Canceling");
                        break;

                    }
                    if (bg_worker4.CancellationPending == true)
                    {
                        dw.write_to_file("4 - Canceling");
                        break;

                    }




                    if (bg_worker5.CancellationPending == true)
                    {
                        dw.write_to_file("5 - Canceling");
                        break;

                    }
                    if (bg_worker6.CancellationPending == true)
                    {
                        dw.write_to_file("6 - Canceling");
                        break;

                    }
                    if (bg_worker7.CancellationPending == true)
                    {
                        dw.write_to_file("7 - Canceling");
                        break;

                    }
                    if (bg_worker8.CancellationPending == true)
                    {
                        dw.write_to_file("8 - Canceling");
                        break;

                    }



                    

                    ping_send.SendAsync(address, 1800 , Encoding.ASCII.GetBytes(data), options, ping_state);


                    Thread.Sleep(2000);
            
                }
                catch (Exception exp)
                {

                    dw.write_to_file(ping_state + ") " + "(debug) " + exp.Message + "\n");
                    text_debug.AppendText(ping_state + ") " + "(debug) " + exp.Message + "\n");
                    
                    //ping_state = ping_state - 1;
                    chart_reply_left.Series[0].Points.Add(0);
                    Thread.Sleep(2000);

                }


            }

           // text_debug.AppendText(id + " Finish");
            dw.write_to_file(id + " Finish");

           // chart_reply_left.Series[0].Points[2].SetValueY(40);
            chart_reply_left.Update();
           // report_ping();
            

        }


        int bbb = 0;

        void p_PingCompleted(object sender, PingCompletedEventArgs e)
        {

            bbb = (int)e.UserState;

            PingReply ping_reply = e.Reply;

            int state = (int) e.UserState;

            string msg = check_ping(ping_reply);

            if (ping_reply.Status == IPStatus.Success)
            {

                try
                {

                    text_debug.AppendText(e.UserState + ") Host: " + ping_reply.Address + "        Time: " + ping_reply.RoundtripTime + "        TTL: " + ping_reply.Options.Ttl + "\n");
                    text_debug.ScrollToCaret();


                    // chart_reply.Series[0].Points.Add(ping_reply.RoundtripTime);

                    ping_success++;

                    // barChart.Series(0).Points.Item(0).SetValueY(countInstSubs)
                    chart_reply_left.Series[0].Points[(int)e.UserState].SetValueY(ping_reply.RoundtripTime);
                    //chart_reply_loss.Series[0].Points[(int)e.UserState].SetValueY(0);
                    //  chart_reply_ttl.Series[0].Points[(int)e.UserState].SetValueY(ping_reply.Options.Ttl);

                    chart_reply_left.Refresh();
                    //chart_reply_left.Update();

                    //  chart_reply_loss.Refresh();
                    //  chart_reply_loss.Update();

                    // /  chart_reply_ttl.Refresh();
                    // chart_reply_ttl.Update();
                }
                catch (Exception exp)
                {

                    Console.WriteLine("Error: " + exp.Message);
                    dw.write_to_file("Error: " + exp.Message);
                    

                }

                try
                {


                    if (current_y_scale < ping_reply.RoundtripTime)
                    {

                        // 10
                        // 100
                        // 1000
                        // 2000

 




                        if ((ping_reply.RoundtripTime > 1000) && (ping_reply.RoundtripTime <= 2000))
                        {

                            current_y_scale = 2000;
                            

                        }

                        if ((ping_reply.RoundtripTime > 500) && (ping_reply.RoundtripTime <= 1000))
                        {
                            current_y_scale = 1000;
    
                        }

                        if ((ping_reply.RoundtripTime > 200) && (ping_reply.RoundtripTime <= 500))
                        {
                            current_y_scale = 500;
  
                        }


                        if ((ping_reply.RoundtripTime > 100) && (ping_reply.RoundtripTime <= 200))
                        {
                            current_y_scale = 200;

                        }


                        if ((ping_reply.RoundtripTime > 50) && (ping_reply.RoundtripTime <= 100))
                        {

                            current_y_scale = 100;
      
                        }


                        if ((ping_reply.RoundtripTime > 20) && (ping_reply.RoundtripTime <= 50))
                        {

                            current_y_scale = 50;
  

                        }

                        if ((ping_reply.RoundtripTime > 10) && (ping_reply.RoundtripTime <= 20))
                        {

                            current_y_scale = 20;



                        }


                        chart_reply_left.ChartAreas[0].AxisY.Maximum = current_y_scale;
                       // chart_reply_left.ChartAreas[0].AxisX.Maximum = ping_max;
                      //  chart_reply_left.ChartAreas[0].RecalculateAxesScale();

                      //  current_y_scale = (int) ping_reply.RoundtripTime +  10;

                      



                        //chart_reply.ChartAreas[0].AxisY.labe

                    //    chart_reply_left.Update();
                        //.chart_reply//.chart_replychart_reply.re
                       // chart_reply_left.ChartAreas[0].AxisX.Maximum = 200;
                      //  chart_reply.ChartAreas[0].AxisY.labe
                    }

                }
                catch (Exception exp)
                {

                    Console.WriteLine( bbb + " recalculate error" + exp.Message);
                    dw.write_to_file("Recalculate error" + exp.Message);
                    
                }
            }
            else
            {

                chart_reply_loss.Series[0].Points[(int)e.UserState].SetValueY(1);
               // chart_reply_ttl.Series[0].Points[(int)e.UserState].SetValueY(0);


                chart_reply_loss.Refresh();
               // chart_reply_loss.Update();



                text_debug.AppendText(e.UserState + ") "  +  msg + "\n");
                text_debug.ScrollToCaret();

                ping_failed++;

//                chart_reply.Series[0].Points.Add(ping_reply.RoundtripTime);

           //     chart_reply.Series[0].Points.AddXY(1, ping_reply.RoundtripTime);
                


           //     chart_reply_left.Series[0].Points[abc].SetValueY(1);
           //     abc++;

            }


        }



        public void report_ping()
        {

            text_debug.AppendText("-------------------Summary-------------------\n");
            text_debug.AppendText("Send:\t" + (ping_success + ping_failed) +"\n");
            text_debug.AppendText("Success:\t" + ping_success + "\n");
            text_debug.AppendText("Failed:\t" + ping_failed + "\n");
            text_debug.AppendText("-------------------Summary-------------------\n");
            text_debug.ScrollToCaret();


            button_STOP.Enabled = false;
            button_Go.Enabled = true;

           
        }
        

       


        public string check_ping(PingReply ping_reply)
        {

            if (ping_reply.Status == IPStatus.BadDestination)
            {

                return "Bad Destination";

            }

            if (ping_reply.Status == IPStatus.BadRoute)
            {

                return "No Route To Host";

            }

            if (ping_reply.Status == IPStatus.DestinationHostUnreachable)
            {

                return "Destination Host Unreachable";

            }


            if (ping_reply.Status == IPStatus.DestinationNetworkUnreachable)
            {

                return "Destination Network Unreachable";

            }

            if (ping_reply.Status == IPStatus.DestinationUnreachable)
            {

                return "Destination Unreachable";

            }

            if (ping_reply.Status == IPStatus.HardwareError)
            {

                return "Hardware Error";

            }

            if (ping_reply.Status == IPStatus.TimedOut)
            {

                return "Timed Out";

            }

            if (ping_reply.Status == IPStatus.TimeExceeded)
            {

                return "Time Exceeded";

            }

            if (ping_reply.Status == IPStatus.TtlExpired)
            {

                return "TTL Expired";

            }

            if (ping_reply.Status == IPStatus.TtlReassemblyTimeExceeded)
            {

                return "Ttl Reassembly Time Exceeded";

            }

            if (ping_reply.Status == IPStatus.NoResources)
            {

                return "No Resources";

            }

            if (ping_reply.Status == IPStatus.DestinationProhibited)
            {

                return "Destination Prohibited";

            }

            return "Other Error";
        }


        private void button_STOP_Click(object sender, EventArgs e)
        {

            stop_ping();

            button_switch();

        }

        private void button_Go_Click(object sender, EventArgs e)
        {



            button_switch();

            reset_test();

            //test_target();

            if (test_destination(text_hostname_l.Text) == false)
            {

                return;

            }



            run_ping();



        }

        public void reset_test()
        {

            Console.WriteLine("Resetting variables");
            dw.write_to_file("Reseting variables");
            text_debug.ResetText();
            ping_state = -1;


            Console.WriteLine("1");

           // delay = 500;// int.Parse(text_delay.Text);
            hostname = text_hostname_l.Text;
            ping_max = int.Parse(text_ping_count.Text);


            ping_max = int.Parse(text_ping_count.Text);


            Console.WriteLine("2");

            ping_data = new int[ping_max,2];
            chart_prepare();

            Console.WriteLine("3");

            ping_success = 0;
            ping_failed = 0;

            current_y_scale = 10;


            Console.WriteLine("4");
            thread_1 = false;
            thread_2 = false;
            thread_3 = false;
            thread_4 = false;
            thread_5 = false;
            thread_6 = false;
            thread_7 = false;
            thread_8 = false;


            Console.WriteLine("5");

        }


        public void stop_ping()
        {

            dw.write_to_file("Canceling");


        //    if (bg_worker.IsBusy == true)
            {


                bg_worker1.CancelAsync();
                bg_worker2.CancelAsync();
                bg_worker3.CancelAsync();
                bg_worker4.CancelAsync();
                bg_worker5.CancelAsync();
                bg_worker6.CancelAsync();
                bg_worker7.CancelAsync();
                bg_worker8.CancelAsync();

            }

    
        }

        public void run_ping()
        {


            dw.write_to_file("RunWorkerAsync");
           // Thread.Sleep(500);

            if (bg_worker1.IsBusy != true)
            {


                bg_worker1.RunWorkerAsync();


            }


          //  Thread.Sleep(500);

            if (bg_worker2.IsBusy != true)
            {


                bg_worker2.RunWorkerAsync();


            }

         //   Thread.Sleep(500);

            if (bg_worker3.IsBusy != true)
            {


                bg_worker3.RunWorkerAsync();


            }

         //   Thread.Sleep(500);

            if (bg_worker4.IsBusy != true)
            {


                bg_worker4.RunWorkerAsync();


            }

            if (bg_worker5.IsBusy != true)
            {


                bg_worker5.RunWorkerAsync();


            }


            if (bg_worker6.IsBusy != true)
            {


                bg_worker6.RunWorkerAsync();


            }


            if (bg_worker7.IsBusy != true)
            {


                bg_worker7.RunWorkerAsync();


            }


            if (bg_worker8.IsBusy != true)
            {


                bg_worker8.RunWorkerAsync();


            }


        }

        public void button_switch()
        {

            button_Go.Enabled = !button_Go.Enabled;
            button_STOP.Enabled = !button_STOP.Enabled;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            dw.write_to_file("Closing ... (wait 4 sec) ");
            text_debug.AppendText("Closing ... (wait 4 sec) ");
            MessageBox.Show("Will close in 4 seconds", "Closing");
            
            
            
            bg_worker1.CancelAsync();
            bg_worker2.CancelAsync();
            bg_worker3.CancelAsync();
            bg_worker4.CancelAsync();
            bg_worker5.CancelAsync();
            bg_worker6.CancelAsync();
            bg_worker7.CancelAsync();
            bg_worker8.CancelAsync();
            stop_ping();
            Thread.Sleep(3000);
            dw.close_file();
            


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int abc = 0;

        public void chart_prepare()
        {

            chart_reply_left.Series[0].Points.Clear();
            chart_reply_loss.Series[0].Points.Clear();
            //chart_reply_ttl.Series[0].Points.Clear();

            for (int i = 0; i < ping_max ; i++)
            {

                ping_data[i,0] = i;
                ping_data[i, 1] = 0;


                chart_reply_left.Series[0].Points.Add(0);
                chart_reply_loss.Series[0].Points.Add(0);
           //     chart_reply_ttl.Series[0].Points.Add(0);
               

            }
            chart_reply_left.Series[0].Points.Add(0);
            chart_reply_loss.Series[0].Points.Add(0);
            //chart_reply_ttl.Series[0].Points.Add(0);
               
            current_y_scale = 10;
            chart_reply_left.ChartAreas[0].AxisY.Maximum = current_y_scale;
            chart_reply_loss.ChartAreas[0].AxisY.Maximum = 1;
          //  chart_reply_ttl.ChartAreas[0].AxisY.Maximum = 200;

           // chart_reply_left.ChartAreas[0].RecalculateAxesScale();

            chart_reply_left.ChartAreas[0].AxisX.Maximum = ping_max;
            chart_reply_loss.ChartAreas[0].AxisX.Maximum = ping_max;
         //   chart_reply_ttl.ChartAreas[0].AxisX.Maximum = ping_max;


            chart_reply_left.ChartAreas[0].RecalculateAxesScale();
         //   chart_reply_ttl.ChartAreas[0].RecalculateAxesScale();
            chart_reply_loss.ChartAreas[0].RecalculateAxesScale();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {



          //  chart_reply_left.Series[0].Points[4].SetValueY(10);

        }


        public void warm_up()
        {

            System.Console.WriteLine("Warm up...");
            dw.write_to_file("Warmp up...");
            button_switch();

            reset_test();


            //if (test_destination(text_hostname_l.Text) == false)
            {

               // return;

            }



            run_ping();

            button_Go.Enabled = true;
            button_STOP.Enabled = false;
           //button_warmup.Enabled = false;




        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        //    chart_reply_left.Size = new Size( (tab_icmp.Size.Width - 50 )/ 2 ,170);
         

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //dw.write_to_file("Closing ... (wait 4 sec) ");
            //text_debug.AppendText("Closing ... (wait 4 sec) ");
            //stop_ping();
            //Thread.Sleep(3000);
            //dw.close_file();
            //bg_worker1.CancelAsync();

            this.Close();



        }

    }
}
