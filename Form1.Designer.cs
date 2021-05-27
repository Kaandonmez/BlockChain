
namespace BlockChain
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.data_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.work2_rt_txt = new System.Windows.Forms.TextBox();
            this.work1_rt_txt = new System.Windows.Forms.TextBox();
            this.nonce_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hash_txt = new System.Windows.Forms.TextBox();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.total_rt_txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.main2_thread_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main2_thread_runtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.main2_thread_16 = new System.Windows.Forms.RadioButton();
            this.main2_thread_8 = new System.Windows.Forms.RadioButton();
            this.main2_thread_4 = new System.Windows.Forms.RadioButton();
            this.main2_thread_3 = new System.Windows.Forms.RadioButton();
            this.main2_thread_2 = new System.Windows.Forms.RadioButton();
            this.main2_status_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.main1_thread_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.main1_thread_runtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.main1_thread_16 = new System.Windows.Forms.RadioButton();
            this.main1_thread_8 = new System.Windows.Forms.RadioButton();
            this.main1_thread_4 = new System.Windows.Forms.RadioButton();
            this.main1_thread_3 = new System.Windows.Forms.RadioButton();
            this.main1_thread_2 = new System.Windows.Forms.RadioButton();
            this.main1_status_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.devamet = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.block_table = new System.Windows.Forms.ListView();
            this.blok_no = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nonce_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total_found_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_hash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.main1_thread_1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_txt
            // 
            this.data_txt.Location = new System.Drawing.Point(9, 25);
            this.data_txt.Name = "data_txt";
            this.data_txt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.data_txt.Size = new System.Drawing.Size(769, 20);
            this.data_txt.TabIndex = 0;
            this.data_txt.Text = "1Bize her yer Trabzon! Bölümün en yakışıklı hocası İbrahim Hoca’dır00000000000000" +
    "00000000000000000000000000000000000000000000000000";
            this.data_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start String";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // work2_rt_txt
            // 
            this.work2_rt_txt.Enabled = false;
            this.work2_rt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.work2_rt_txt.Location = new System.Drawing.Point(3, 141);
            this.work2_rt_txt.Name = "work2_rt_txt";
            this.work2_rt_txt.ReadOnly = true;
            this.work2_rt_txt.Size = new System.Drawing.Size(100, 26);
            this.work2_rt_txt.TabIndex = 2;
            this.work2_rt_txt.TextChanged += new System.EventHandler(this.work2_rt_txt_TextChanged);
            // 
            // work1_rt_txt
            // 
            this.work1_rt_txt.Enabled = false;
            this.work1_rt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.work1_rt_txt.Location = new System.Drawing.Point(3, 92);
            this.work1_rt_txt.Name = "work1_rt_txt";
            this.work1_rt_txt.ReadOnly = true;
            this.work1_rt_txt.Size = new System.Drawing.Size(100, 26);
            this.work1_rt_txt.TabIndex = 3;
            this.work1_rt_txt.TextChanged += new System.EventHandler(this.work1_rt_txt_TextChanged);
            // 
            // nonce_txt
            // 
            this.nonce_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nonce_txt.Location = new System.Drawing.Point(3, 43);
            this.nonce_txt.Name = "nonce_txt";
            this.nonce_txt.ReadOnly = true;
            this.nonce_txt.Size = new System.Drawing.Size(100, 26);
            this.nonce_txt.TabIndex = 4;
            this.nonce_txt.TextChanged += new System.EventHandler(this.nonce_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Main2 Runtime (ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Main1 Runtime (ms)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nonce Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hash Value";
            // 
            // hash_txt
            // 
            this.hash_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hash_txt.Location = new System.Drawing.Point(9, 64);
            this.hash_txt.Name = "hash_txt";
            this.hash_txt.ReadOnly = true;
            this.hash_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hash_txt.Size = new System.Drawing.Size(769, 21);
            this.hash_txt.TabIndex = 9;
            this.hash_txt.TextChanged += new System.EventHandler(this.hash_txt_TextChanged);
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calculate_btn.Enabled = false;
            this.calculate_btn.Location = new System.Drawing.Point(9, 91);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(95, 38);
            this.calculate_btn.TabIndex = 10;
            this.calculate_btn.Text = "Find Nonce Value";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Runtime (ms)";
            // 
            // total_rt_txt
            // 
            this.total_rt_txt.Enabled = false;
            this.total_rt_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_rt_txt.Location = new System.Drawing.Point(3, 190);
            this.total_rt_txt.Name = "total_rt_txt";
            this.total_rt_txt.ReadOnly = true;
            this.total_rt_txt.Size = new System.Drawing.Size(100, 26);
            this.total_rt_txt.TabIndex = 12;
            this.total_rt_txt.TextChanged += new System.EventHandler(this.total_rt_txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.total_rt_txt);
            this.groupBox1.Controls.Add(this.work2_rt_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.work1_rt_txt);
            this.groupBox1.Controls.Add(this.nonce_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "ms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "ms";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "ms";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(161, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 229);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread Control Panel";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView2);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.main2_status_txt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(325, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Main2";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.main2_thread_id,
            this.main2_thread_runtime});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(10, 65);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(172, 114);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // main2_thread_id
            // 
            this.main2_thread_id.Text = "Thread ID";
            // 
            // main2_thread_runtime
            // 
            this.main2_thread_runtime.Text = "Runtime (ms)";
            this.main2_thread_runtime.Width = 113;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.main2_thread_16);
            this.groupBox6.Controls.Add(this.main2_thread_8);
            this.groupBox6.Controls.Add(this.main2_thread_4);
            this.groupBox6.Controls.Add(this.main2_thread_3);
            this.groupBox6.Controls.Add(this.main2_thread_2);
            this.groupBox6.Location = new System.Drawing.Point(188, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(92, 153);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thread Count";
            // 
            // main2_thread_16
            // 
            this.main2_thread_16.AutoSize = true;
            this.main2_thread_16.ForeColor = System.Drawing.Color.Purple;
            this.main2_thread_16.Location = new System.Drawing.Point(7, 129);
            this.main2_thread_16.Name = "main2_thread_16";
            this.main2_thread_16.Size = new System.Drawing.Size(74, 17);
            this.main2_thread_16.TabIndex = 4;
            this.main2_thread_16.Text = "16 Thread";
            this.main2_thread_16.UseVisualStyleBackColor = true;
            this.main2_thread_16.CheckedChanged += new System.EventHandler(this.main3_thread_16_CheckedChanged);
            // 
            // main2_thread_8
            // 
            this.main2_thread_8.AutoSize = true;
            this.main2_thread_8.ForeColor = System.Drawing.Color.Red;
            this.main2_thread_8.Location = new System.Drawing.Point(7, 102);
            this.main2_thread_8.Name = "main2_thread_8";
            this.main2_thread_8.Size = new System.Drawing.Size(68, 17);
            this.main2_thread_8.TabIndex = 3;
            this.main2_thread_8.Text = "8 Thread";
            this.main2_thread_8.UseVisualStyleBackColor = true;
            this.main2_thread_8.CheckedChanged += new System.EventHandler(this.main3_thread_8_CheckedChanged);
            // 
            // main2_thread_4
            // 
            this.main2_thread_4.AutoSize = true;
            this.main2_thread_4.ForeColor = System.Drawing.Color.Yellow;
            this.main2_thread_4.Location = new System.Drawing.Point(7, 75);
            this.main2_thread_4.Name = "main2_thread_4";
            this.main2_thread_4.Size = new System.Drawing.Size(68, 17);
            this.main2_thread_4.TabIndex = 2;
            this.main2_thread_4.Text = "4 Thread";
            this.main2_thread_4.UseVisualStyleBackColor = true;
            this.main2_thread_4.CheckedChanged += new System.EventHandler(this.main3_thread_4_CheckedChanged);
            // 
            // main2_thread_3
            // 
            this.main2_thread_3.AutoSize = true;
            this.main2_thread_3.Location = new System.Drawing.Point(7, 48);
            this.main2_thread_3.Name = "main2_thread_3";
            this.main2_thread_3.Size = new System.Drawing.Size(68, 17);
            this.main2_thread_3.TabIndex = 1;
            this.main2_thread_3.Text = "3 Thread";
            this.main2_thread_3.UseVisualStyleBackColor = true;
            this.main2_thread_3.CheckedChanged += new System.EventHandler(this.main3_thread_3_CheckedChanged);
            // 
            // main2_thread_2
            // 
            this.main2_thread_2.AutoSize = true;
            this.main2_thread_2.ForeColor = System.Drawing.Color.ForestGreen;
            this.main2_thread_2.Location = new System.Drawing.Point(7, 21);
            this.main2_thread_2.Name = "main2_thread_2";
            this.main2_thread_2.Size = new System.Drawing.Size(68, 17);
            this.main2_thread_2.TabIndex = 0;
            this.main2_thread_2.Text = "2 Thread";
            this.main2_thread_2.UseVisualStyleBackColor = true;
            this.main2_thread_2.CheckedChanged += new System.EventHandler(this.main2_thread_2_CheckedChanged);
            // 
            // main2_status_txt
            // 
            this.main2_status_txt.Enabled = false;
            this.main2_status_txt.Location = new System.Drawing.Point(10, 39);
            this.main2_status_txt.Name = "main2_status_txt";
            this.main2_status_txt.ReadOnly = true;
            this.main2_status_txt.Size = new System.Drawing.Size(173, 20);
            this.main2_status_txt.TabIndex = 1;
            this.main2_status_txt.TextChanged += new System.EventHandler(this.main2_status_txt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.main1_status_txt);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 185);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.main1_thread_id,
            this.main1_thread_runtime});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 65);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(177, 114);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // main1_thread_id
            // 
            this.main1_thread_id.Text = "Thread ID";
            // 
            // main1_thread_runtime
            // 
            this.main1_thread_runtime.Text = "Runtime(ms)";
            this.main1_thread_runtime.Width = 75;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.main1_thread_1);
            this.groupBox5.Controls.Add(this.main1_thread_16);
            this.groupBox5.Controls.Add(this.main1_thread_8);
            this.groupBox5.Controls.Add(this.main1_thread_4);
            this.groupBox5.Controls.Add(this.main1_thread_3);
            this.groupBox5.Controls.Add(this.main1_thread_2);
            this.groupBox5.Location = new System.Drawing.Point(189, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(92, 174);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thread Count";
            // 
            // main1_thread_16
            // 
            this.main1_thread_16.AutoSize = true;
            this.main1_thread_16.ForeColor = System.Drawing.Color.Purple;
            this.main1_thread_16.Location = new System.Drawing.Point(6, 150);
            this.main1_thread_16.Name = "main1_thread_16";
            this.main1_thread_16.Size = new System.Drawing.Size(74, 17);
            this.main1_thread_16.TabIndex = 4;
            this.main1_thread_16.Text = "16 Thread";
            this.main1_thread_16.UseVisualStyleBackColor = true;
            this.main1_thread_16.CheckedChanged += new System.EventHandler(this.main1_thread_16_CheckedChanged);
            // 
            // main1_thread_8
            // 
            this.main1_thread_8.AutoSize = true;
            this.main1_thread_8.ForeColor = System.Drawing.Color.Red;
            this.main1_thread_8.Location = new System.Drawing.Point(6, 123);
            this.main1_thread_8.Name = "main1_thread_8";
            this.main1_thread_8.Size = new System.Drawing.Size(68, 17);
            this.main1_thread_8.TabIndex = 3;
            this.main1_thread_8.Text = "8 Thread";
            this.main1_thread_8.UseVisualStyleBackColor = true;
            this.main1_thread_8.CheckedChanged += new System.EventHandler(this.main1_thread_8_CheckedChanged);
            // 
            // main1_thread_4
            // 
            this.main1_thread_4.AutoSize = true;
            this.main1_thread_4.ForeColor = System.Drawing.Color.Yellow;
            this.main1_thread_4.Location = new System.Drawing.Point(6, 96);
            this.main1_thread_4.Name = "main1_thread_4";
            this.main1_thread_4.Size = new System.Drawing.Size(68, 17);
            this.main1_thread_4.TabIndex = 2;
            this.main1_thread_4.Text = "4 Thread";
            this.main1_thread_4.UseVisualStyleBackColor = true;
            this.main1_thread_4.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // main1_thread_3
            // 
            this.main1_thread_3.AutoSize = true;
            this.main1_thread_3.Location = new System.Drawing.Point(6, 69);
            this.main1_thread_3.Name = "main1_thread_3";
            this.main1_thread_3.Size = new System.Drawing.Size(68, 17);
            this.main1_thread_3.TabIndex = 1;
            this.main1_thread_3.Text = "3 Thread";
            this.main1_thread_3.UseVisualStyleBackColor = true;
            this.main1_thread_3.CheckedChanged += new System.EventHandler(this.main1_thread_3_CheckedChanged);
            // 
            // main1_thread_2
            // 
            this.main1_thread_2.AutoSize = true;
            this.main1_thread_2.ForeColor = System.Drawing.Color.ForestGreen;
            this.main1_thread_2.Location = new System.Drawing.Point(6, 42);
            this.main1_thread_2.Name = "main1_thread_2";
            this.main1_thread_2.Size = new System.Drawing.Size(68, 17);
            this.main1_thread_2.TabIndex = 0;
            this.main1_thread_2.Text = "2 Thread";
            this.main1_thread_2.UseVisualStyleBackColor = true;
            this.main1_thread_2.CheckedChanged += new System.EventHandler(this.main1_thread_2_CheckedChanged);
            // 
            // main1_status_txt
            // 
            this.main1_status_txt.Enabled = false;
            this.main1_status_txt.Location = new System.Drawing.Point(6, 39);
            this.main1_status_txt.Name = "main1_status_txt";
            this.main1_status_txt.ReadOnly = true;
            this.main1_status_txt.Size = new System.Drawing.Size(177, 20);
            this.main1_status_txt.TabIndex = 1;
            this.main1_status_txt.TextChanged += new System.EventHandler(this.main1_status_txt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Status";
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.DimGray;
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.reset_btn.Location = new System.Drawing.Point(107, 158);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(45, 41);
            this.reset_btn.TabIndex = 15;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.radioButton2);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Location = new System.Drawing.Point(161, 118);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 81);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Single Thread - Multi Thread";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Multi Thread( Main1&&Main2 )";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(154, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Single Thread( only Main1 )";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(334, 114);
            this.progressBar1.MarqueeAnimationSpeed = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(444, 23);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(523, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Progress";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(107, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = "Stop!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // devamet
            // 
            this.devamet.BackColor = System.Drawing.Color.MediumAquamarine;
            this.devamet.Location = new System.Drawing.Point(9, 158);
            this.devamet.Name = "devamet";
            this.devamet.Size = new System.Drawing.Size(92, 41);
            this.devamet.TabIndex = 22;
            this.devamet.Text = "Continue";
            this.devamet.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // block_table
            // 
            this.block_table.BackColor = System.Drawing.SystemColors.Window;
            this.block_table.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blok_no,
            this.nonce_value,
            this.total_found_time,
            this.list_hash});
            this.block_table.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_table.FullRowSelect = true;
            this.block_table.GridLines = true;
            this.block_table.HideSelection = false;
            this.block_table.Location = new System.Drawing.Point(788, 25);
            this.block_table.Name = "block_table";
            this.block_table.Size = new System.Drawing.Size(356, 174);
            this.block_table.TabIndex = 25;
            this.block_table.UseCompatibleStateImageBehavior = false;
            this.block_table.View = System.Windows.Forms.View.Details;
            // 
            // blok_no
            // 
            this.blok_no.Text = "Block No";
            this.blok_no.Width = 63;
            // 
            // nonce_value
            // 
            this.nonce_value.Text = "Nonce";
            this.nonce_value.Width = 49;
            // 
            // total_found_time
            // 
            this.total_found_time.Text = "Total Elapsed Time";
            this.total_found_time.Width = 86;
            // 
            // list_hash
            // 
            this.list_hash.Text = "Hash";
            this.list_hash.Width = 400;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(785, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Block Table";
            // 
            // main1_thread_1
            // 
            this.main1_thread_1.AutoSize = true;
            this.main1_thread_1.ForeColor = System.Drawing.Color.DarkOrange;
            this.main1_thread_1.Location = new System.Drawing.Point(6, 16);
            this.main1_thread_1.Name = "main1_thread_1";
            this.main1_thread_1.Size = new System.Drawing.Size(68, 17);
            this.main1_thread_1.TabIndex = 5;
            this.main1_thread_1.TabStop = true;
            this.main1_thread_1.Text = "1 Thread";
            this.main1_thread_1.UseVisualStyleBackColor = true;
            this.main1_thread_1.CheckedChanged += new System.EventHandler(this.main1_thread_1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 446);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.block_table);
            this.Controls.Add(this.devamet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.hash_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conditional Hash Finder(KTÜ)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox data_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox work2_rt_txt;
        private System.Windows.Forms.TextBox work1_rt_txt;
        private System.Windows.Forms.TextBox nonce_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hash_txt;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_rt_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox main2_status_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox main1_status_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton main2_thread_16;
        private System.Windows.Forms.RadioButton main2_thread_8;
        private System.Windows.Forms.RadioButton main2_thread_4;
        private System.Windows.Forms.RadioButton main2_thread_3;
        private System.Windows.Forms.RadioButton main2_thread_2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader main1_thread_id;
        private System.Windows.Forms.ColumnHeader main1_thread_runtime;
        public System.Windows.Forms.RadioButton main1_thread_16;
        public System.Windows.Forms.RadioButton main1_thread_8;
        public System.Windows.Forms.RadioButton main1_thread_4;
        public System.Windows.Forms.RadioButton main1_thread_3;
        public System.Windows.Forms.RadioButton main1_thread_2;
        private System.Windows.Forms.ColumnHeader main2_thread_id;
        private System.Windows.Forms.ColumnHeader main2_thread_runtime;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button devamet;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView block_table;
        private System.Windows.Forms.ColumnHeader blok_no;
        private System.Windows.Forms.ColumnHeader nonce_value;
        private System.Windows.Forms.ColumnHeader total_found_time;
        private System.Windows.Forms.ColumnHeader list_hash;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.RadioButton main1_thread_1;
    }
}

