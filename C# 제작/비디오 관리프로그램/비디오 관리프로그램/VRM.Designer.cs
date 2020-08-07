namespace 비디오_관리프로그램
{
    partial class VRM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Card = new System.Windows.Forms.Button();
            this.textBox_VRMClientPhone = new System.Windows.Forms.TextBox();
            this.textBox_VRMClientNum = new System.Windows.Forms.TextBox();
            this.textBox_VRMClientCode = new System.Windows.Forms.TextBox();
            this.textBox_VRMClientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_ClientJob = new System.Windows.Forms.TextBox();
            this.textBox_ClientName = new System.Windows.Forms.TextBox();
            this.textBox_ClientAddress = new System.Windows.Forms.TextBox();
            this.textBox_ClientPost = new System.Windows.Forms.TextBox();
            this.textBox_ClientPhone = new System.Windows.Forms.TextBox();
            this.textBox_ClientNum = new System.Windows.Forms.TextBox();
            this.textBox_ClientPeopleNum = new System.Windows.Forms.TextBox();
            this.textBox_ClientCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Return = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Rent = new System.Windows.Forms.DateTimePicker();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_RollBack = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.textBox_VideoName = new System.Windows.Forms.TextBox();
            this.textBox_Arrears = new System.Windows.Forms.TextBox();
            this.textBox_RentRate = new System.Windows.Forms.TextBox();
            this.textBox_VideoCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_SumRent = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_SumReturn = new System.Windows.Forms.TextBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.dataGridView_Rent = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(261, 221);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Search);
            this.tabPage1.Controls.Add(this.button_Card);
            this.tabPage1.Controls.Add(this.textBox_VRMClientPhone);
            this.tabPage1.Controls.Add(this.textBox_VRMClientNum);
            this.tabPage1.Controls.Add(this.textBox_VRMClientCode);
            this.tabPage1.Controls.Add(this.textBox_VRMClientName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(253, 195);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "고객 입력";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(135, 150);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(101, 26);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "찾기";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Card
            // 
            this.button_Card.Location = new System.Drawing.Point(16, 150);
            this.button_Card.Name = "button_Card";
            this.button_Card.Size = new System.Drawing.Size(101, 26);
            this.button_Card.TabIndex = 2;
            this.button_Card.Text = "카드 읽기";
            this.button_Card.UseVisualStyleBackColor = true;
            // 
            // textBox_VRMClientPhone
            // 
            this.textBox_VRMClientPhone.Location = new System.Drawing.Point(82, 110);
            this.textBox_VRMClientPhone.Name = "textBox_VRMClientPhone";
            this.textBox_VRMClientPhone.Size = new System.Drawing.Size(154, 21);
            this.textBox_VRMClientPhone.TabIndex = 3;
            // 
            // textBox_VRMClientNum
            // 
            this.textBox_VRMClientNum.Location = new System.Drawing.Point(82, 77);
            this.textBox_VRMClientNum.Name = "textBox_VRMClientNum";
            this.textBox_VRMClientNum.Size = new System.Drawing.Size(154, 21);
            this.textBox_VRMClientNum.TabIndex = 2;
            // 
            // textBox_VRMClientCode
            // 
            this.textBox_VRMClientCode.Location = new System.Drawing.Point(82, 44);
            this.textBox_VRMClientCode.Name = "textBox_VRMClientCode";
            this.textBox_VRMClientCode.Size = new System.Drawing.Size(154, 21);
            this.textBox_VRMClientCode.TabIndex = 1;
            // 
            // textBox_VRMClientName
            // 
            this.textBox_VRMClientName.Location = new System.Drawing.Point(82, 11);
            this.textBox_VRMClientName.Name = "textBox_VRMClientName";
            this.textBox_VRMClientName.Size = new System.Drawing.Size(154, 21);
            this.textBox_VRMClientName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "휴대폰 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "전화번호 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "고객코드 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "고객명 :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView_Client);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(253, 195);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "고객 선택";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.ReadOnly = true;
            this.dataGridView_Client.RowTemplate.Height = 23;
            this.dataGridView_Client.Size = new System.Drawing.Size(253, 195);
            this.dataGridView_Client.TabIndex = 8;
            this.dataGridView_Client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Client_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_ClientJob);
            this.groupBox1.Controls.Add(this.textBox_ClientName);
            this.groupBox1.Controls.Add(this.textBox_ClientAddress);
            this.groupBox1.Controls.Add(this.textBox_ClientPost);
            this.groupBox1.Controls.Add(this.textBox_ClientPhone);
            this.groupBox1.Controls.Add(this.textBox_ClientNum);
            this.groupBox1.Controls.Add(this.textBox_ClientPeopleNum);
            this.groupBox1.Controls.Add(this.textBox_ClientCode);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(279, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "고객 정보";
            // 
            // textBox_ClientJob
            // 
            this.textBox_ClientJob.Location = new System.Drawing.Point(325, 53);
            this.textBox_ClientJob.Name = "textBox_ClientJob";
            this.textBox_ClientJob.ReadOnly = true;
            this.textBox_ClientJob.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientJob.TabIndex = 3;
            // 
            // textBox_ClientName
            // 
            this.textBox_ClientName.Location = new System.Drawing.Point(325, 20);
            this.textBox_ClientName.Name = "textBox_ClientName";
            this.textBox_ClientName.ReadOnly = true;
            this.textBox_ClientName.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientName.TabIndex = 1;
            // 
            // textBox_ClientAddress
            // 
            this.textBox_ClientAddress.Location = new System.Drawing.Point(73, 160);
            this.textBox_ClientAddress.Name = "textBox_ClientAddress";
            this.textBox_ClientAddress.ReadOnly = true;
            this.textBox_ClientAddress.Size = new System.Drawing.Size(406, 21);
            this.textBox_ClientAddress.TabIndex = 7;
            // 
            // textBox_ClientPost
            // 
            this.textBox_ClientPost.Location = new System.Drawing.Point(73, 134);
            this.textBox_ClientPost.Name = "textBox_ClientPost";
            this.textBox_ClientPost.ReadOnly = true;
            this.textBox_ClientPost.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientPost.TabIndex = 6;
            // 
            // textBox_ClientPhone
            // 
            this.textBox_ClientPhone.Location = new System.Drawing.Point(325, 94);
            this.textBox_ClientPhone.Name = "textBox_ClientPhone";
            this.textBox_ClientPhone.ReadOnly = true;
            this.textBox_ClientPhone.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientPhone.TabIndex = 5;
            // 
            // textBox_ClientNum
            // 
            this.textBox_ClientNum.Location = new System.Drawing.Point(73, 91);
            this.textBox_ClientNum.Name = "textBox_ClientNum";
            this.textBox_ClientNum.ReadOnly = true;
            this.textBox_ClientNum.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientNum.TabIndex = 4;
            // 
            // textBox_ClientPeopleNum
            // 
            this.textBox_ClientPeopleNum.Location = new System.Drawing.Point(73, 49);
            this.textBox_ClientPeopleNum.Name = "textBox_ClientPeopleNum";
            this.textBox_ClientPeopleNum.ReadOnly = true;
            this.textBox_ClientPeopleNum.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientPeopleNum.TabIndex = 2;
            // 
            // textBox_ClientCode
            // 
            this.textBox_ClientCode.Location = new System.Drawing.Point(73, 20);
            this.textBox_ClientCode.Name = "textBox_ClientCode";
            this.textBox_ClientCode.ReadOnly = true;
            this.textBox_ClientCode.Size = new System.Drawing.Size(154, 21);
            this.textBox_ClientCode.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "신분 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(270, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "고객명 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "주소 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "우편번호 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "핸드폰 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "전화번호 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "주민번호 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "고객코드 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker_Return);
            this.groupBox2.Controls.Add(this.dateTimePicker_Rent);
            this.groupBox2.Controls.Add(this.button_Save);
            this.groupBox2.Controls.Add(this.button_RollBack);
            this.groupBox2.Controls.Add(this.button_Insert);
            this.groupBox2.Controls.Add(this.textBox_VideoName);
            this.groupBox2.Controls.Add(this.textBox_Arrears);
            this.groupBox2.Controls.Add(this.textBox_RentRate);
            this.groupBox2.Controls.Add(this.textBox_VideoCode);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Location = new System.Drawing.Point(12, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여 비디오 입력";
            // 
            // dateTimePicker_Return
            // 
            this.dateTimePicker_Return.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Return.Location = new System.Drawing.Point(654, 57);
            this.dateTimePicker_Return.Name = "dateTimePicker_Return";
            this.dateTimePicker_Return.Size = new System.Drawing.Size(112, 21);
            this.dateTimePicker_Return.TabIndex = 5;
            // 
            // dateTimePicker_Rent
            // 
            this.dateTimePicker_Rent.CustomFormat = "yyyy-mm-dd";
            this.dateTimePicker_Rent.Enabled = false;
            this.dateTimePicker_Rent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Rent.Location = new System.Drawing.Point(453, 57);
            this.dateTimePicker_Rent.Name = "dateTimePicker_Rent";
            this.dateTimePicker_Rent.Size = new System.Drawing.Size(112, 21);
            this.dateTimePicker_Rent.TabIndex = 4;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(641, 17);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(57, 26);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "저장";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_RollBack
            // 
            this.button_RollBack.Location = new System.Drawing.Point(708, 17);
            this.button_RollBack.Name = "button_RollBack";
            this.button_RollBack.Size = new System.Drawing.Size(57, 26);
            this.button_RollBack.TabIndex = 3;
            this.button_RollBack.Text = "취소";
            this.button_RollBack.UseVisualStyleBackColor = true;
            this.button_RollBack.Click += new System.EventHandler(this.button_RollBack_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(574, 17);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(57, 26);
            this.button_Insert.TabIndex = 3;
            this.button_Insert.Text = "등록";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // textBox_VideoName
            // 
            this.textBox_VideoName.Location = new System.Drawing.Point(287, 20);
            this.textBox_VideoName.Name = "textBox_VideoName";
            this.textBox_VideoName.ReadOnly = true;
            this.textBox_VideoName.Size = new System.Drawing.Size(278, 21);
            this.textBox_VideoName.TabIndex = 1;
            // 
            // textBox_Arrears
            // 
            this.textBox_Arrears.Location = new System.Drawing.Point(259, 57);
            this.textBox_Arrears.Name = "textBox_Arrears";
            this.textBox_Arrears.ReadOnly = true;
            this.textBox_Arrears.Size = new System.Drawing.Size(106, 21);
            this.textBox_Arrears.TabIndex = 3;
            // 
            // textBox_RentRate
            // 
            this.textBox_RentRate.Location = new System.Drawing.Point(89, 57);
            this.textBox_RentRate.Name = "textBox_RentRate";
            this.textBox_RentRate.ReadOnly = true;
            this.textBox_RentRate.Size = new System.Drawing.Size(106, 21);
            this.textBox_RentRate.TabIndex = 2;
            // 
            // textBox_VideoCode
            // 
            this.textBox_VideoCode.Location = new System.Drawing.Point(89, 20);
            this.textBox_VideoCode.Name = "textBox_VideoCode";
            this.textBox_VideoCode.Size = new System.Drawing.Size(106, 21);
            this.textBox_VideoCode.TabIndex = 0;
            this.textBox_VideoCode.TextChanged += new System.EventHandler(this.textBox_VideoCode_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(571, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "반납 예정일 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 12);
            this.label15.TabIndex = 2;
            this.label15.Text = "대여일 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(204, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "연체료 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(204, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 2;
            this.label14.Text = "비디오 제목 :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(34, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "대여료 :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 2;
            this.label20.Text = "비디오 코드 :";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_Count.Location = new System.Drawing.Point(127, 345);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.ReadOnly = true;
            this.textBox_Count.Size = new System.Drawing.Size(106, 26);
            this.textBox_Count.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 12F);
            this.label17.Location = new System.Drawing.Point(13, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "총 대여 개수 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("굴림", 12F);
            this.label18.Location = new System.Drawing.Point(239, 350);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "총 대여료 :";
            // 
            // textBox_SumRent
            // 
            this.textBox_SumRent.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_SumRent.Location = new System.Drawing.Point(332, 345);
            this.textBox_SumRent.Name = "textBox_SumRent";
            this.textBox_SumRent.ReadOnly = true;
            this.textBox_SumRent.Size = new System.Drawing.Size(106, 26);
            this.textBox_SumRent.TabIndex = 1;
            this.textBox_SumRent.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 12F);
            this.label21.Location = new System.Drawing.Point(444, 350);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 16);
            this.label21.TabIndex = 5;
            this.label21.Text = "총 연체료 :";
            // 
            // textBox_SumReturn
            // 
            this.textBox_SumReturn.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox_SumReturn.Location = new System.Drawing.Point(537, 345);
            this.textBox_SumReturn.Name = "textBox_SumReturn";
            this.textBox_SumReturn.ReadOnly = true;
            this.textBox_SumReturn.Size = new System.Drawing.Size(106, 26);
            this.textBox_SumReturn.TabIndex = 2;
            this.textBox_SumReturn.Text = "0";
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(662, 345);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(116, 26);
            this.button_Return.TabIndex = 5;
            this.button_Return.Text = "비디오 반납";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // dataGridView_Rent
            // 
            this.dataGridView_Rent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Rent.Location = new System.Drawing.Point(12, 377);
            this.dataGridView_Rent.Name = "dataGridView_Rent";
            this.dataGridView_Rent.ReadOnly = true;
            this.dataGridView_Rent.RowTemplate.Height = 23;
            this.dataGridView_Rent.Size = new System.Drawing.Size(776, 200);
            this.dataGridView_Rent.TabIndex = 7;
            this.dataGridView_Rent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Rent_CellClick);
            // 
            // VRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 589);
            this.Controls.Add(this.dataGridView_Rent);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.textBox_SumReturn);
            this.Controls.Add(this.textBox_SumRent);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "VRM";
            this.Text = "대여/반납";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VRM_FormClosing);
            this.Load += new System.EventHandler(this.VRM_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Card;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button_RollBack;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button_Return;
        public System.Windows.Forms.DataGridView dataGridView_Rent;
        public System.Windows.Forms.DataGridView dataGridView_Client;
        public System.Windows.Forms.TextBox textBox_VRMClientPhone;
        public System.Windows.Forms.TextBox textBox_VRMClientNum;
        public System.Windows.Forms.TextBox textBox_VRMClientCode;
        public System.Windows.Forms.TextBox textBox_VRMClientName;
        public System.Windows.Forms.TextBox textBox_ClientCode;
        public System.Windows.Forms.TextBox textBox_VideoCode;
        public System.Windows.Forms.TextBox textBox_VideoName;
        public System.Windows.Forms.TextBox textBox_RentRate;
        public System.Windows.Forms.TextBox textBox_Arrears;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Return;
        public System.Windows.Forms.DateTimePicker dateTimePicker_Rent;
        private System.Windows.Forms.Button button_Save;
        public System.Windows.Forms.TextBox textBox_ClientJob;
        public System.Windows.Forms.TextBox textBox_ClientName;
        public System.Windows.Forms.TextBox textBox_ClientAddress;
        public System.Windows.Forms.TextBox textBox_ClientPost;
        public System.Windows.Forms.TextBox textBox_ClientNum;
        public System.Windows.Forms.TextBox textBox_ClientPeopleNum;
        public System.Windows.Forms.TextBox textBox_ClientPhone;
        public System.Windows.Forms.TextBox textBox_Count;
        public System.Windows.Forms.TextBox textBox_SumRent;
        public System.Windows.Forms.TextBox textBox_SumReturn;
    }
}