using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using System.Text.RegularExpressions;
//using System.Range;




namespace BlockChain
{


    public partial class Form1 : Form
    {

        //public static string data = "uuuu12332123321dgdfgdfg";
        public static string diff = "0";
        public static int diffi = 0;
        public static string[] sonuc_hash = new string[100];
        //public static List<string> sonuc_hash = new List<string>();
        public static string pattern = "^"+(String.Concat(Enumerable.Repeat("0", diffi+1)));
        public static bool flag = false;
        public static byte[] bytes = new byte[32];
        public static uint found_nonce;
        public static int[] times = new int[10];
        //public static Stopwatch t1 = new Stopwatch();
        //public static Stopwatch t2 = new Stopwatch();
        //public static Stopwatch t3 = new Stopwatch();
        //public static Stopwatch t4 = new Stopwatch();
        //public static Stopwatch t5 = new Stopwatch();
        //public static Stopwatch t6 = new Stopwatch();
        //public static Stopwatch t7 = new Stopwatch();
        //public static Stopwatch t8 = new Stopwatch();
        //public static Stopwatch t9 = new Stopwatch();
        //public static Stopwatch t10 = new Stopwatch();
        //public static Stopwatch t11 = new Stopwatch();
        //public static Stopwatch t12 = new Stopwatch();
        //public static Stopwatch t13 = new Stopwatch();
        //public static Stopwatch t14 = new Stopwatch();
        //public static Stopwatch t15 = new Stopwatch();
        //public static Stopwatch t16 = new Stopwatch();
        public static List<Stopwatch> t = new List<Stopwatch>();
        public static List<Thread> core = new List<Thread>(32);
        public static int main1_thread_no;
        public static int main2_thread_no;
        public static bool isSingle; // true = Single thread --- false = Multi thread
        public static string last_hash;
        //public static uint total_posible = (uint) Math.Pow(2,32);
        public static Regex regex = new Regex(pattern);
        public static uint start_pos_1 = 0;
        public static uint start_pos_2 = (uint)uint.MaxValue/2;
        public static uint iki_16 = (uint)Math.Pow(2, 16);
        public static uint iki_32 = (uint)Math.Pow(2, 32);
        public static string sha256;
        public static object rawData;
        public static string deneme;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.Columns.Add("Thread ID");
            //listView1.Columns.Add("Thread Runtime (ms)");
            
        }
        private void Form1_Shown(Object sender, EventArgs e)
        {

            //MessageBox.Show("You are in the Form.Shown event.");
            for (int i = 0; i < 32; i++)
            {
                t.Add(new Stopwatch());
            }

            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Style = ProgressBarStyle.Marquee;
            devamet.Enabled = false;
            //Düğmeye basıldığı zaman eski verileri silmek gerekiyor!!!
            nonce_txt.Clear();              //
            hash_txt.Clear();               //
            found_nonce = 0;                //
            flag = false;                   //
            //sonuc_hash.Clear();             //
            Array.Clear(bytes, 0,32);       //
            //Array.Clear(times, 0, 16);    //
            listView1.Items.Clear();        //
            listView2.Items.Clear();        //
            reset_all_timers();             //
            start_pos_1 = 0;
            //Düğmeye basıldığı zaman eski verileri silmek gerekiyor!!!
            //sonuc_hash.Add("12");
            buttons_disabled();
            
            main1_status_txt.Text = main1_thread_no.ToString();
            main2_status_txt.Text = main2_thread_no.ToString();

            rawData = data_txt.Text;
            //main1_status_txt.Text = deneme.ToString();


            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //sha256 = ComputeSha256Hash(data_txt.Text);
            //last_hash = (diffi + 2).ToString() + data_txt.Text + sha256 + found_nonce.ToString();
            ////Console.WriteLine("Data : " + nonce);

            ////Console.WriteLine("Using SHA 256 : " + sha256);
            deneme = data_txt.Text;
            Thread core1 = new Thread(Hesapla);
            core1.Start();
            last_hash = (diffi + 2).ToString() + data_txt.Text + sha256 + found_nonce.ToString();
            //core1.Join();

            stopwatch.Stop();

            //nonce_txt.Text = found_nonce.ToString();
            //hash_txt.Text = sha256;

            //data_txt.Text = last_hash;
            ////Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            ////work1_rt_txt.Text = times[0].ToString();
            ////work2_rt_txt.Text = times[1].ToString();
            //work1_rt_txt.Text = t[0].ElapsedMilliseconds.ToString();
            //work2_rt_txt.Text = t[1].ElapsedMilliseconds.ToString();
            //for (int a = 1; a < main1_thread_no + 1; a++)
            //{
            //    listView1.Items.Add(a.ToString());
            //    listView1.Items[a - 1].SubItems.Add(t[a - 1].ElapsedMilliseconds.ToString());
            //}
            //for (int a = 1; a < main2_thread_no + 1; a++)
            //{
            //    listView2.Items.Add(a.ToString());
            //    listView2.Items[a - 1].SubItems.Add(t[a - 1].ElapsedMilliseconds.ToString());
            //}
            //total_rt_txt.Text = stopwatch.ElapsedMilliseconds.ToString();
            //diffi++;
            ////listView1.Items.Add("deneme");

            ////main1_status_txt.Text = deneme;
        }


        public void buttons_disabled()
        {
            data_txt.Enabled = false;
            calculate_btn.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            main1_thread_2.Enabled = false;
            main1_thread_3.Enabled = false;
            main1_thread_4.Enabled = false;
            main1_thread_8.Enabled = false;
            main1_thread_16.Enabled = false;
            main2_thread_2.Enabled = false;
            main2_thread_3.Enabled = false;
            main2_thread_4.Enabled = false;
            main2_thread_8.Enabled = false;
            main2_thread_16.Enabled = false;
        }

        public void buttons_enabled()
        {
            data_txt.Enabled = true;
            calculate_btn.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            main1_thread_2.Enabled = true;
            main1_thread_3.Enabled = true;
            main1_thread_4.Enabled = true;
            main1_thread_8.Enabled = true;
            main1_thread_16.Enabled = true;
            main2_thread_2.Enabled = true;
            main2_thread_3.Enabled = true;
            main2_thread_4.Enabled = true;
            main2_thread_8.Enabled = true;
            main2_thread_16.Enabled = true;
        }
        public void Hesapla()
        {
            //sha256 = ComputeSha256Hash(deneme);


            sha256 = ComputeSha256Hash(data_txt.Text);
            last_hash = (diffi + 2).ToString() + data_txt.Text + sha256 + found_nonce.ToString();

            nonce_txt.Text = found_nonce.ToString();
            hash_txt.Text = sha256;

            data_txt.Text = last_hash;
            
            work1_rt_txt.Text = t[0].ElapsedMilliseconds.ToString();
            work2_rt_txt.Text = t[1].ElapsedMilliseconds.ToString();
            total_rt_txt.Text = Math.Max(t[0].ElapsedMilliseconds, t[1].ElapsedMilliseconds).ToString();
            for (int a = 1; a < main1_thread_no + 1; a++)
            {
                listView1.Items.Add(a.ToString());
                listView1.Items[a - 1].SubItems.Add(t[a - 1].ElapsedMilliseconds.ToString());
            }
            for (int a = 1; a < main2_thread_no + 1; a++)
            {
                listView2.Items.Add(a.ToString());
                listView2.Items[a - 1].SubItems.Add(t[a - 1].ElapsedMilliseconds.ToString());
            }

            if (diffi !=0)
            {
                

                block_table.Items.Add(new ListViewItem(new string[] { 
                    (diffi).ToString(), 
                    found_nonce.ToString(),
                    Math.Max(t[0].ElapsedMilliseconds, t[1].ElapsedMilliseconds).ToString(), 
                    sha256.ToString() }));

            }
            else
            {

                block_table.Items.Add(new ListViewItem(new string[] { 
                    "Genesis Block", 
                    found_nonce.ToString(),
                    Math.Max(t[0].ElapsedMilliseconds, t[1].ElapsedMilliseconds).ToString(),
                    sha256.ToString() }));
            }
            buttons_enabled();

            //Math.Max(t[0].ElapsedMilliseconds, t[1].ElapsedMilliseconds);

            diffi++;

            progressBar1.Style = ProgressBarStyle.Continuous;

        }
        public static void reset_all_timers()
        {
            for (int i = 0; i < 32; i++)
            {
                t[i].Reset();
            }
        }





       
        // Static method for thread 1
        public static void thread1(object str)
        {
            

            t[0].Start();

            string temp;

            byte[] t1byte;

            


            using (SHA256 sha256Hash = SHA256.Create())
            {


                string returnStr = "";


                //switch (main1_thread_no)
                //{
                //    case 2:
                //        //Thread worker3 = new Thread(calculate);
                //        //Thread worker4 = new Thread(calculate);
                //        //worker3.Start(0);
                //        //worker4.Start(Math.Pow(2, 16));
                //        //worker3.Join();
                //        //worker4.Join();
                //        Thread worker3 = new Thread(thread3);
                //        worker3.Start(str);
                //        start_pos_1 = start_pos_1 + (uint)Math.Pow(iki_16, 1 / main1_thread_no);
                //        worker3.Join();
                //        break;
                //    //case 3:
                //    //    break;
                //    //case 4:
                //    //    break;
                //    //case 8:
                //    //    break;
                //    //case 16:
                //    //    break;
                //    default:
                //        break;
                //}


                uint multi;


                string search = String.Concat(Enumerable.Repeat("0", diffi + 1));
                uint index1 = start_pos_1;

                if (isSingle)
                {
                    multi = (uint)(uint.MaxValue);
                }
                else
                {
                    multi = (uint)(uint.MaxValue) / 2;
                }


                //for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(uint.MaxValue/*/2*/,1/main1_thread_no));i++)   
                for (uint i = start_pos_1; i < index1 + multi/main1_thread_no; i++)
                {
                    
                    temp = str.ToString() + i.ToString();
                    t1byte = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(temp));
                    StringBuilder builder1 = new StringBuilder();
                    for (int z = 0; z < bytes.Length; z++)
                    {
                        builder1.Append(t1byte[z].ToString("x2"));
                    }
                    

                    if (flag)
                    {
                        
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker1)");
                        //found_nonce = 88;
                        break;
                    }

                    //else if (regex.IsMatch(t1byte[0].ToString()))
                    //else if (Char.IsDigit(t1byte[0].ToString()))
                    //else if(t1byte[0] < 15)
                    //else if(t1byte[diffi] < Math.Pow(15,(diffi+1))) //Önemli!

                    //else if (BitConverter.ToString(t1byte).StartsWith(search))
                    else if (builder1.ToString().StartsWith(search))
                    {

                       

                     
                        found_nonce = i;
                        //Console.WriteLine("Worker1 found the nonce.. Nonce Value Found! =>> {0}", found_nonce);

                        flag = true;
                        bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //last_hash = diffi==0 ? (diffi+1).ToString() + str.ToString() + sha256 : (diffi).ToString()+str.ToString()+sha256  ;
                        //last_hash = (diffi+2).ToString()+str.ToString()+sha256  ;
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        //sonuc_hash[diffi] = diffi==0 ? "0000000000000000000000000000000000000000000000000000000000000000" : builder.ToString();
                        sonuc_hash[diffi] = builder.ToString();
                        
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                


            }


            t[0].Stop();
            //Console.WriteLine("Worker1 finish in {0} ms", t1.ElapsedMilliseconds);
            //times[0] = t1.ElapsedMilliseconds;


        }

        // static method for thread 2
        public static void thread2(object str)
        {


            t[1].Start();

            string temp;

            byte[] t1byte;




            using (SHA256 sha256Hash = SHA256.Create())
            {


                string returnStr = "";


                //switch (main1_thread_no)
                //{
                //    case 2:
                //        //Thread worker3 = new Thread(calculate);
                //        //Thread worker4 = new Thread(calculate);
                //        //worker3.Start(0);
                //        //worker4.Start(Math.Pow(2, 16));
                //        //worker3.Join();
                //        //worker4.Join();
                //        Thread worker3 = new Thread(thread3);
                //        worker3.Start(str);
                //        start_pos_1 = start_pos_1 + (uint)Math.Pow(iki_16, 1 / main1_thread_no);
                //        worker3.Join();
                //        break;
                //    //case 3:
                //    //    break;
                //    //case 4:
                //    //    break;
                //    //case 8:
                //    //    break;
                //    //case 16:
                //    //    break;
                //    default:
                //        break;
                //}





                string search = String.Concat(Enumerable.Repeat("0", diffi + 1));
                uint index1 = start_pos_2;
                if (!flag)
              {

                

                //for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(uint.MaxValue/*/2*/,1/main1_thread_no));i++)   
                for (uint i = start_pos_2; i < index1 + ((uint)(uint.MaxValue) / 2) / main2_thread_no; i++)
                {

                    temp = str.ToString() + i.ToString();
                    t1byte = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(temp));
                    StringBuilder builder1 = new StringBuilder();
                    for (int z = 0; z < bytes.Length; z++)
                    {
                        builder1.Append(t1byte[z].ToString("x2"));
                    }

                    
                    if (flag)
                    {

                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker1)");
                        //found_nonce = 99;
                        break;
                    }

                    //else if (regex.IsMatch(t1byte[0].ToString()))
                    //else if (Char.IsDigit(t1byte[0].ToString()))
                    //else if(t1byte[0] < 15)
                    //else if(t1byte[diffi] < Math.Pow(15,(diffi+1))) //Önemli!

                    //else if (BitConverter.ToString(t1byte).StartsWith(search))
                    else if (builder1.ToString().StartsWith(search))
                    {




                        found_nonce = i;
                        //Console.WriteLine("Worker1 found the nonce.. Nonce Value Found! =>> {0}", found_nonce);

                        flag = true;
                        bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //last_hash = diffi==0 ? (diffi+1).ToString() + str.ToString() + sha256 : (diffi).ToString()+str.ToString()+sha256  ;
                        //last_hash = (diffi+2).ToString()+str.ToString()+sha256  ;
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        //sonuc_hash[diffi] = diffi==0 ? "0000000000000000000000000000000000000000000000000000000000000000" : builder.ToString();
                        sonuc_hash[diffi] = builder.ToString();

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

            }



            }


            t[1].Stop();
            //Console.WriteLine("Worker1 finish in {0} ms", t1.ElapsedMilliseconds);
            //times[0] = t1.ElapsedMilliseconds;


        }

        // static method for thread 3
        public static void thread3(object str)
        {

            t[2].Start();

            byte[] t3byte;
            string temp3;



            using (SHA256 sha256Hash3 = SHA256.Create())
            {

                string returnStr3 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp3 = str.ToString() + i;
                    t3byte = sha256Hash3.ComputeHash(Encoding.UTF8.GetBytes(temp3));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t3byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash3.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr3 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                       
                        sonuc_hash[diffi] = builder.ToString();


                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[2].Stop();
            

        }

        // static method for thread 5
        public static void thread5(object str)
        {

            t[3].Start();

            byte[] t5byte;
            string temp5;



            using (SHA256 sha256Hash5 = SHA256.Create())
            {

                string returnStr5 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp5 = str.ToString() + i;
                    t5byte = sha256Hash5.ComputeHash(Encoding.UTF8.GetBytes(temp5));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t5byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash5.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr5 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[3].Stop();
            

        }

        // static method for thread 7
        public static void thread7(object str)
        {

            t[4].Start();

            byte[] t7byte;
            string temp7;



            using (SHA256 sha256Hash7 = SHA256.Create())
            {

                string returnStr7 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp7 = str.ToString() + i;
                    t7byte = sha256Hash7.ComputeHash(Encoding.UTF8.GetBytes(temp7));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t7byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash7.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr7 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[4].Stop();


        }

        // static method for thread 9
        public static void thread9(object str)
        {

            t[5].Start();

            byte[] t9byte;
            string temp9;



            using (SHA256 sha256Hash9 = SHA256.Create())
            {

                string returnStr9 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp9 = str.ToString() + i;
                    t9byte = sha256Hash9.ComputeHash(Encoding.UTF8.GetBytes(temp9));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t9byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash9.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr9 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[5].Stop();


        }

        // static method for thread 11
        public static void thread11(object str)
        {

            t[6].Start();

            byte[] t11byte;
            string temp11;



            using (SHA256 sha256Hash11 = SHA256.Create())
            {

                string returnStr11 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp11 = str.ToString() + i;
                    t11byte = sha256Hash11.ComputeHash(Encoding.UTF8.GetBytes(temp11));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t11byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash11.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr11 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[6].Stop();


        }

        // static method for thread 13
        public static void thread13(object str)
        {

            t[7].Start();

            byte[] t13byte;
            string temp13;



            using (SHA256 sha256Hash13 = SHA256.Create())
            {

                string returnStr11 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp13 = str.ToString() + i;
                    t13byte = sha256Hash13.ComputeHash(Encoding.UTF8.GetBytes(temp13));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t13byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash13.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr11 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[7].Stop();


        }

        // static method for thread 15
        public static void thread15(object str)
        {

            t[8].Start();

            byte[] t15byte;
            string temp15;



            using (SHA256 sha256Hash11 = SHA256.Create())
            {

                string returnStr11 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp15 = str.ToString() + i;
                    t15byte = sha256Hash11.ComputeHash(Encoding.UTF8.GetBytes(temp15));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t15byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash11.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr11 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[8].Stop();


        }

        // static method for thread 17
        public static void thread17(object str)
        {

            t[9].Start();

            byte[] t17byte;
            string temp17;



            using (SHA256 sha256Hash17 = SHA256.Create())
            {

                string returnStr17 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp17 = str.ToString() + i;
                    t17byte = sha256Hash17.ComputeHash(Encoding.UTF8.GetBytes(temp17));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t17byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash17.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr17 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[9].Stop();


        }

        // static method for thread 19
        public static void thread19(object str)
        {

            t[10].Start();

            byte[] t19byte;
            string temp19;



            using (SHA256 sha256Hash19 = SHA256.Create())
            {

                string returnStr19 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp19 = str.ToString() + i;
                    t19byte = sha256Hash19.ComputeHash(Encoding.UTF8.GetBytes(temp19));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t19byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash19.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr19 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[10].Stop();


        }

        // static method for thread 21
        public static void thread21(object str)
        {

            t[11].Start();

            byte[] t21byte;
            string temp21;



            using (SHA256 sha256Hash21 = SHA256.Create())
            {

                string returnStr21 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp21 = str.ToString() + i;
                    t21byte = sha256Hash21.ComputeHash(Encoding.UTF8.GetBytes(temp21));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t21byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash21.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr21 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[11].Stop();


        }

        // static method for thread 23
        public static void thread23(object str)
        {

            t[12].Start();

            byte[] t23byte;
            string temp23;



            using (SHA256 sha256Hash23 = SHA256.Create())
            {

                string returnStr23 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp23 = str.ToString() + i;
                    t23byte = sha256Hash23.ComputeHash(Encoding.UTF8.GetBytes(temp23));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t23byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash23.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr23 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[12].Stop();


        }

        // static method for thread 25
        public static void thread25(object str)
        {

            t[13].Start();

            byte[] t25byte;
            string temp25;



            using (SHA256 sha256Hash25 = SHA256.Create())
            {

                string returnStr25 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp25 = str.ToString() + i;
                    t25byte = sha256Hash25.ComputeHash(Encoding.UTF8.GetBytes(temp25));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t25byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash25.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr25 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[13].Stop();


        }

        // static method for thread 27
        public static void thread27(object str)
        {

            t[14].Start();

            byte[] t27byte;
            string temp27;



            using (SHA256 sha256Hash27 = SHA256.Create())
            {

                string returnStr27 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp27 = str.ToString() + i;
                    t27byte = sha256Hash27.ComputeHash(Encoding.UTF8.GetBytes(temp27));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t27byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash27.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr27 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[14].Stop();


        }

        // static method for thread 29
        public static void thread29(object str)
        {

            t[15].Start();

            byte[] t29byte;
            string temp29;



            using (SHA256 sha256Hash29 = SHA256.Create())
            {

                string returnStr29 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp29 = str.ToString() + i;
                    t29byte = sha256Hash29.ComputeHash(Encoding.UTF8.GetBytes(temp29));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t29byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash29.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr29 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[15].Stop();


        }

        // static method for thread 31
        public static void thread31(object str)
        {

            t[16].Start();

            byte[] t31byte;
            string temp31;



            using (SHA256 sha256Hash31 = SHA256.Create())
            {

                string returnStr31 = "";
                for (uint i = start_pos_1; i< (start_pos_1 + Math.Pow(iki_16,1/main1_thread_no));i++)
                {
                    temp31 = str.ToString() + i;
                    t31byte = sha256Hash31.ComputeHash(Encoding.UTF8.GetBytes(temp31));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t31byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash31.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr31 = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[16].Stop();


        }

        //////////////////////////////////////////////////////////////////////////////////////////////////
        


        // static method for thread 4
        public static void thread4(object str)
        {

            t[17].Start();

            byte[] t4byte;
            string temp4;



            using (SHA256 sha256Hash4 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp4 = str.ToString() + i;
                    t4byte = sha256Hash4.ComputeHash(Encoding.UTF8.GetBytes(temp4));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t4byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash4.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[17].Stop();
            

        }

        // static method for thread 6
        public static void thread6(object str)
        {

            t[18].Start();

            byte[] t6byte;
            string temp6;



            using (SHA256 sha256Hash6 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp6 = str.ToString() + i;
                    t6byte = sha256Hash6.ComputeHash(Encoding.UTF8.GetBytes(temp6));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t6byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash6.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[18].Stop();


        }

        // static method for thread 8
        public static void thread8(object str)
        {

            t[19].Start();

            byte[] t8byte;
            string temp8;



            using (SHA256 sha256Hash8 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp8 = str.ToString() + i;
                    t8byte = sha256Hash8.ComputeHash(Encoding.UTF8.GetBytes(temp8));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t8byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash8.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[19].Stop();


        }

        // static method for thread 10
        public static void thread10(object str)
        {

            t[20].Start();

            byte[] t10byte;
            string temp10;



            using (SHA256 sha256Hash10 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp10 = str.ToString() + i;
                    t10byte = sha256Hash10.ComputeHash(Encoding.UTF8.GetBytes(temp10));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t10byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash10.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[20].Stop();


        }

        // static method for thread 12
        public static void thread12(object str)
        {

            t[21].Start();

            byte[] t12byte;
            string temp12;



            using (SHA256 sha256Hash12 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp12 = str.ToString() + i;
                    t12byte = sha256Hash12.ComputeHash(Encoding.UTF8.GetBytes(temp12));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t12byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash12.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[21].Stop();


        }

        // static method for thread 14
        public static void thread14(object str)
        {

            t[22].Start();

            byte[] t14byte;
            string temp14;



            using (SHA256 sha256Hash14 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp14 = str.ToString() + i;
                    t14byte = sha256Hash14.ComputeHash(Encoding.UTF8.GetBytes(temp14));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t14byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash14.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[22].Stop();


        }

        // static method for thread 16
        public static void thread16(object str)
        {

            t[23].Start();

            byte[] t16byte;
            string temp16;



            using (SHA256 sha256Hash16 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp16 = str.ToString() + i;
                    t16byte = sha256Hash16.ComputeHash(Encoding.UTF8.GetBytes(temp16));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t16byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash16.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[23].Stop();


        }

        // static method for thread 18
        public static void thread18(object str)
        {

            t[24].Start();

            byte[] t18byte;
            string temp18;



            using (SHA256 sha256Hash18 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp18 = str.ToString() + i;
                    t18byte = sha256Hash18.ComputeHash(Encoding.UTF8.GetBytes(temp18));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t18byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash18.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[24].Stop();


        }

        // static method for thread 20
        public static void thread20(object str)
        {

            t[25].Start();

            byte[] t20byte;
            string temp20;



            using (SHA256 sha256Hash20 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp20 = str.ToString() + i;
                    t20byte = sha256Hash20.ComputeHash(Encoding.UTF8.GetBytes(temp20));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t20byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash20.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[25].Stop();


        }

        // static method for thread 22
        public static void thread22(object str)
        {

            t[26].Start();

            byte[] t22byte;
            string temp22;



            using (SHA256 sha256Hash22 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp22 = str.ToString() + i;
                    t22byte = sha256Hash22.ComputeHash(Encoding.UTF8.GetBytes(temp22));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t22byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash22.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[26].Stop();


        }

        // static method for thread 24
        public static void thread24(object str)
        {

            t[27].Start();

            byte[] t24byte;
            string temp24;



            using (SHA256 sha256Hash24 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp24 = str.ToString() + i;
                    t24byte = sha256Hash24.ComputeHash(Encoding.UTF8.GetBytes(temp24));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t24byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash24.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[27].Stop();


        }

        // static method for thread 26
        public static void thread26(object str)
        {

            t[28].Start();

            byte[] t26byte;
            string temp26;



            using (SHA256 sha256Hash26 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp26 = str.ToString() + i;
                    t26byte = sha256Hash26.ComputeHash(Encoding.UTF8.GetBytes(temp26));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t26byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash26.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[28].Stop();


        }

        // static method for thread 28
        public static void thread28(object str)
        {

            t[29].Start();

            byte[] t28byte;
            string temp28;



            using (SHA256 sha256Hash28 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp28 = str.ToString() + i;
                    t28byte = sha256Hash28.ComputeHash(Encoding.UTF8.GetBytes(temp28));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t28byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash28.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[29].Stop();


        }

        // static method for thread 30
        public static void thread30(object str)
        {

            t[30].Start();

            byte[] t30byte;
            string temp30;



            using (SHA256 sha256Hash30 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp30 = str.ToString() + i;
                    t30byte = sha256Hash30.ComputeHash(Encoding.UTF8.GetBytes(temp30));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t30byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash30.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[30].Stop();


        }

        // static method for thread 32
        public static void thread32(object str)
        {

            t[31].Start();

            byte[] t32byte;
            string temp32;



            using (SHA256 sha256Hash32 = SHA256.Create())
            {

                string returnStr = "";
                for (uint i = start_pos_2; i < (start_pos_2 + Math.Pow(iki_32, 1 / main2_thread_no));i++)
                {
                    temp32 = str.ToString() + i;
                    t32byte = sha256Hash32.ComputeHash(Encoding.UTF8.GetBytes(temp32));
                    if (flag)
                    {
                        //Console.WriteLine("Some Workerx found solution. Ending Task.(Worker2)");
                        break;
                    }
                    else if (t32byte[0] < 15)
                    //else if (regex.IsMatch(t2byte[0].ToString()))
                    {


                        found_nonce = i;
                        //Console.WriteLine("Worker2 found the nonce... Nonce Value Found! =>> {0}", found_nonce);
                        flag = true;
                        bytes = sha256Hash32.ComputeHash(Encoding.UTF8.GetBytes(str.ToString() + found_nonce.ToString()));
                        returnStr = System.Convert.ToBase64String(bytes);
                        //Convert byte array to a string
                        StringBuilder builder = new StringBuilder();
                        for (int z = 0; z < bytes.Length; z++)
                        {
                            builder.Append(bytes[z].ToString("x2"));
                        }

                        sonuc_hash[diffi] = builder.ToString();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }




            }

            t[31].Stop();


        }






        static /*void*/ string ComputeSha256Hash(object rawData)
        {


            using (SHA256 sha256Hash = SHA256.Create())
            {



                if (isSingle)
                {
                    Thread worker1 = new Thread(thread1);
                    worker1.Start(rawData);
                    worker1.Join();
                }

                else
                {
                    switch (main1_thread_no)
                    {
                        case 2:
                            Thread worker1 = new Thread(thread1);
                            worker1.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 = start_pos_1 + (uint.MaxValue/2) / (uint)main1_thread_no;
                            Thread.Sleep(50);
                            Thread worker11 = new Thread(thread1);
                            worker11.Start(rawData);
                            worker1.Join();
                            worker11.Join();
                            break;
                        case 4:
                            Thread worker14 = new Thread(thread1);
                            worker14.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 = start_pos_1 + (uint.MaxValue / 2) / (uint)main1_thread_no;
                            Thread.Sleep(50);
                            Thread worker15 = new Thread(thread1);
                            worker15.Start(rawData);
                            //Thread worker 16 =  new Thread()
                            worker14.Join();
                            worker15.Join();
                            break;


                        default:
                            break;
                    }
                    Thread.Sleep(50);
                    switch (main2_thread_no)
                    {
                        case 2:
                            Thread worker2 = new Thread(thread2);
                            worker2.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 = start_pos_2 + (uint.MaxValue / 2) / (uint)main2_thread_no;
                            Thread.Sleep(50);
                            Thread worker22 = new Thread(thread2);
                            worker22.Start(rawData);
                            worker2.Join();
                            worker22.Join();
                            break;
                        default:
                            break;
                    }
                }


               
                //Thread worker2 = new Thread(thread2);
               
                //worker2.Start(rawData);
                
                //worker2.Join();




                






                // ComputeHash - returns byte array  

                //Convert byte array to a string



                return sonuc_hash[diffi];
            }


        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }



        private void main1_status_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void main2_status_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            //Düğmeye basıldığı zaman eski verileri silmek gerekiyor!!!
            nonce_txt.Clear();              //
            hash_txt.Clear();               //
            found_nonce = 0;                //
            flag = false;                   //
            //sonuc_hash = "";                //
            //sonuc_hash.Clear();
            Array.Clear(bytes, 0, 32);       //
            reset_all_timers();                 //
            //Düğmeye basıldığı zaman eski verileri silmek gerekiyor!!!

            data_txt.Text = "1Bize her yer Trabzon! Bölümün en yakışıklı hocası İbrahim Hoca’dır0000000000000000000000000000000000000000000000000000000000000000";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Columns.Add("Thread ID");
            listView1.Columns.Add("Thread Runtime (ms)");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void hash_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nonce_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void work1_rt_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void work2_rt_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_rt_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void main1_thread_2_CheckedChanged(object sender, EventArgs e)
        {
            if (main1_thread_2.Checked)
            {
                main1_thread_no = 2;
            }
        }

        private void main1_thread_8_CheckedChanged(object sender, EventArgs e)
        {
            if (main1_thread_8.Checked)
            {
                main1_thread_no = 8;
            }
        }

        private void main1_thread_3_CheckedChanged(object sender, EventArgs e)
        {
            if (main1_thread_3.Checked)
            {
                main1_thread_no = 3;
            }
        }

        private void main1_thread_16_CheckedChanged(object sender, EventArgs e)
        {
            if (main1_thread_16.Checked)
            {
                main1_thread_no = 16;
            }
        }

        private void main2_thread_2_CheckedChanged(object sender, EventArgs e)
        {
            if (main2_thread_2.Checked)
            {
                main2_thread_no = 2;
                calculate_btn.Enabled = true;
            }
        }

        private void main3_thread_8_CheckedChanged(object sender, EventArgs e)
        {
            if (main2_thread_8.Checked)
            {
                main2_thread_no = 8;
                calculate_btn.Enabled = true;
            }
        }

        private void main3_thread_4_CheckedChanged(object sender, EventArgs e)
        {
            if (main2_thread_4.Checked)
            {
                main2_thread_no = 4;
                calculate_btn.Enabled = true;
            }
        }

        private void main3_thread_3_CheckedChanged(object sender, EventArgs e)
        {
            if (main2_thread_3.Checked)
            {
                main2_thread_no = 3;
                calculate_btn.Enabled = true;
            }
        }

        private void main3_thread_16_CheckedChanged(object sender, EventArgs e)
        {
            if (main2_thread_16.Checked)
            {
                main2_thread_no = 16;
                calculate_btn.Enabled = true;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView2.Columns.Add("Thread ID");
            //listView2.Columns.Add("Thread Runtime (ms)");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                isSingle = true;
            }
            main1_thread_no = 1;
            calculate_btn.Enabled = false;

            main2_thread_2.Enabled = false;
            main2_thread_3.Enabled = false;
            main2_thread_4.Enabled = false;
            main2_thread_8.Enabled = false;
            main2_thread_16.Enabled = false;

            main2_thread_2.Checked = false;
            main2_thread_3.Checked = false;
            main2_thread_4.Checked = false;
            main2_thread_8.Checked = false;
            main2_thread_16.Checked = false;

            main1_thread_1.Checked = false;
            main1_thread_2.Checked = false;
            main1_thread_3.Checked = false;
            main1_thread_4.Checked = false;
            main1_thread_8.Checked = false;
            main1_thread_16.Checked = false;

            main1_thread_2.Enabled = false;
            main1_thread_3.Enabled = false;
            main1_thread_4.Enabled = false;
            main1_thread_8.Enabled = false;
            main1_thread_16.Enabled = false;

            //while (true)
            //{

            //    calculate_btn.Enabled = false;
            //    if ((radioButton1.Checked || radioButton2.Checked) &
            //        (main1_thread_2.Checked || main1_thread_3.Checked ||
            //        main1_thread_4.Checked || main1_thread_8.Checked || main1_thread_16.Checked) &
            //        (main2_thread_2.Checked || main2_thread_3.Checked ||
            //        main2_thread_4.Checked || main2_thread_8.Checked || main2_thread_16.Checked))
            //    {
            //        calculate_btn.Enabled = true;
            //        break;
            //    }
            //}



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calculate_btn.Enabled = false;
            if (radioButton2.Checked)
            {
                isSingle = false;
            }

            main1_thread_2.Enabled = true;
            main1_thread_3.Enabled = true;
            main1_thread_4.Enabled = true;
            main1_thread_8.Enabled = true;
            main1_thread_16.Enabled = true;

            main2_thread_2.Enabled = true;
            main2_thread_3.Enabled = true;
            main2_thread_4.Enabled = true;
            main2_thread_8.Enabled = true;
            main2_thread_16.Enabled = true;
            //if((main1_thread_2.Checked || main1_thread_3.Checked ||
            //         main1_thread_4.Checked || main1_thread_8.Checked || main1_thread_16.Checked) &
            //        (main2_thread_2.Checked || main2_thread_3.Checked ||
            //         main2_thread_4.Checked || main2_thread_8.Checked || main2_thread_16.Checked))
            //{
            //    calculate_btn.Enabled = true;
            //}
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void main1_thread_1_CheckedChanged(object sender, EventArgs e)
        {
            if (main1_thread_1.Checked)
            {
                calculate_btn.Enabled = true;
                main1_thread_no = 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            devamet.Enabled = true;
        }
    }
}
