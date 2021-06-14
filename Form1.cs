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

        public static List<Stopwatch> t = new List<Stopwatch>();
        public static List<Thread> core = new List<Thread>(32);
        public static int main1_thread_no;
        public static int main2_thread_no;
        public static bool isSingle; // true = Single thread --- false = Multi thread
        public static string last_hash;

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
            //devamet.Enabled = false;
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
            main1_thread_1.Enabled = false;
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
            main1_thread_1.Enabled = true;
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
                            start_pos_1 += (uint.MaxValue/2) / (uint)main1_thread_no;
                            
                            Thread worker11 = new Thread(thread1);
                            worker11.Start(rawData);
                            worker1.Join();
                            worker11.Join();
                            break;
                        case 4:
                            Thread worker14 = new Thread(thread1);
                            worker14.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;
                            
                            Thread worker15 = new Thread(thread1);
                            worker15.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker16 = new Thread(thread1);
                            worker16.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker17 = new Thread(thread1);
                            worker17.Start(rawData);



                            worker14.Join();
                            worker15.Join();
                            worker16.Join();
                            worker17.Join();
                            break;

                        case 8:
                            Thread worker80 = new Thread(thread1);
                            worker80.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker81 = new Thread(thread1);
                            worker81.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker82 = new Thread(thread1);
                            worker82.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker83 = new Thread(thread1);
                            worker83.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker84 = new Thread(thread1);
                            worker84.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker85 = new Thread(thread1);
                            worker85.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker86 = new Thread(thread1);
                            worker86.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker87 = new Thread(thread1);
                            worker87.Start(rawData);


                            worker80.Join();
                            worker81.Join();
                            worker81.Join();
                            worker82.Join();
                            worker83.Join();
                            worker84.Join();
                            worker85.Join();
                            worker86.Join();
                            worker87.Join();
                            




                            break;

                        case 16:
                            Thread worker160 = new Thread(thread1);
                            worker160.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker161 = new Thread(thread1);
                            worker161.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker162 = new Thread(thread1);
                            worker162.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker163 = new Thread(thread1);
                            worker163.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker164 = new Thread(thread1);
                            worker164.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker165 = new Thread(thread1);
                            worker165.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker166 = new Thread(thread1);
                            worker166.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker167 = new Thread(thread1);
                            worker167.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker168 = new Thread(thread1);
                            worker168.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker169 = new Thread(thread1);
                            worker169.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker170 = new Thread(thread1);
                            worker170.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker172 = new Thread(thread1);
                            worker172.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker173 = new Thread(thread1);
                            worker173.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker174 = new Thread(thread1);
                            worker174.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker171 = new Thread(thread1);
                            worker171.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_1 += (uint.MaxValue / 2) / (uint)main1_thread_no;

                            Thread worker175 = new Thread(thread1);
                            worker175.Start(rawData);

                            worker160.Join();
                            worker161.Join();
                            worker162.Join();
                            worker163.Join();
                            worker164.Join();
                            worker165.Join();
                            worker166.Join();
                            worker167.Join();
                            worker168.Join();
                            worker169.Join();
                            worker170.Join();
                            worker171.Join();
                            worker172.Join();
                            worker173.Join();
                            worker174.Join();
                            worker175.Join();





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
                            
                            Thread worker222 = new Thread(thread2);
                            worker222.Start(rawData);
                            worker2.Join();
                            worker222.Join();
                            break;
                        case 4:
                            Thread worker20 = new Thread(thread2);
                            worker20.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker21 = new Thread(thread2);
                            worker21.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker22 = new Thread(thread2);
                            worker22.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker23 = new Thread(thread2);
                            worker23.Start(rawData);



                            worker20.Join();
                            worker21.Join();
                            worker22.Join();
                            worker23.Join();
                            break;

                        case 8:
                            Thread worker90 = new Thread(thread2);
                            worker90.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker91 = new Thread(thread2);
                            worker91.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker92 = new Thread(thread2);
                            worker92.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker93 = new Thread(thread2);
                            worker93.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker94 = new Thread(thread2);
                            worker94.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker95 = new Thread(thread2);
                            worker95.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker96 = new Thread(thread2);
                            worker96.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker97 = new Thread(thread2);
                            worker97.Start(rawData);


                            worker90.Join();
                            worker91.Join();
                            worker91.Join();
                            worker92.Join();
                            worker93.Join();
                            worker94.Join();
                            worker95.Join();
                            worker96.Join();
                            worker97.Join();





                            break;

                        case 16:
                            Thread worker260 = new Thread(thread2);
                            worker260.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker261 = new Thread(thread2);
                            worker261.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker262 = new Thread(thread2);
                            worker262.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker263 = new Thread(thread2);
                            worker263.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker264 = new Thread(thread2);
                            worker264.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker265 = new Thread(thread2);
                            worker265.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker266 = new Thread(thread2);
                            worker266.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker267 = new Thread(thread2);
                            worker267.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker268 = new Thread(thread2);
                            worker268.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker269 = new Thread(thread2);
                            worker269.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker270 = new Thread(thread2);
                            worker270.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker272 = new Thread(thread2);
                            worker272.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker273 = new Thread(thread2);
                            worker273.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker274 = new Thread(thread2);
                            worker274.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker271 = new Thread(thread2);
                            worker271.Start(rawData);
                            Thread.Sleep(50);
                            start_pos_2 += (uint.MaxValue / 2) / (uint)main2_thread_no;

                            Thread worker275 = new Thread(thread2);
                            worker275.Start(rawData);

                            worker260.Join();
                            worker261.Join();
                            worker262.Join();
                            worker263.Join();
                            worker264.Join();
                            worker265.Join();
                            worker266.Join();
                            worker267.Join();
                            worker268.Join();
                            worker269.Join();
                            worker270.Join();
                            worker271.Join();
                            worker272.Join();
                            worker273.Join();
                            worker274.Join();
                            worker275.Join();





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
            if (main1_thread_4.Checked)
            {
                main1_thread_no = 4;
            }
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
            //devamet.Enabled = true;
        }
    }
}
