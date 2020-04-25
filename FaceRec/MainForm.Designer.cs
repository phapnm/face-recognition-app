namespace MultiFaceRec
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOneFace = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.txbEmpCode = new System.Windows.Forms.TextBox();
            this.txbEmpName = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDailyCheck = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbCorrectCode = new System.Windows.Forms.TextBox();
            this.txbCorrectName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCorrection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayCheckout = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.displayCheckin = new System.Windows.Forms.Label();
            this.displayEmpCode = new System.Windows.Forms.Label();
            this.displayEmpName = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbNotification = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFileImage = new System.Windows.Forms.Button();
            this.btnVideoRecorder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecord = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvImage = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.empcodee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnamee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.empcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagee = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLoadDatas = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImage)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOneFace
            // 
            this.btnOneFace.Enabled = false;
            this.btnOneFace.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOneFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneFace.Location = new System.Drawing.Point(47, 20);
            this.btnOneFace.Name = "btnOneFace";
            this.btnOneFace.Size = new System.Drawing.Size(73, 41);
            this.btnOneFace.TabIndex = 3;
            this.btnOneFace.Text = "One by one Face";
            this.btnOneFace.UseVisualStyleBackColor = true;
            this.btnOneFace.Click += new System.EventHandler(this.btnOneFace_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(351, 17);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(119, 119);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // txbEmpCode
            // 
            this.txbEmpCode.Location = new System.Drawing.Point(204, 101);
            this.txbEmpCode.Name = "txbEmpCode";
            this.txbEmpCode.Size = new System.Drawing.Size(120, 21);
            this.txbEmpCode.TabIndex = 18;
            // 
            // txbEmpName
            // 
            this.txbEmpName.Location = new System.Drawing.Point(204, 70);
            this.txbEmpName.Name = "txbEmpName";
            this.txbEmpName.Size = new System.Drawing.Size(120, 21);
            this.txbEmpName.TabIndex = 17;
            // 
            // btnCheckout
            // 
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(197, 32);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(72, 41);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Check out";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(108, 32);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(72, 41);
            this.btnCheckin.TabIndex = 6;
            this.btnCheckin.Text = "Check in";
            this.btnCheckin.UseVisualStyleBackColor = true;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnStartCam
            // 
            this.btnStartCam.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStartCam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCam.Location = new System.Drawing.Point(14, 32);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(72, 41);
            this.btnStartCam.TabIndex = 2;
            this.btnStartCam.Text = "Start Cam";
            this.btnStartCam.UseVisualStyleBackColor = false;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.lbDailyCheck);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1055, 329);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lbDailyCheck
            // 
            this.lbDailyCheck.AutoSize = true;
            this.lbDailyCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDailyCheck.ForeColor = System.Drawing.Color.Lime;
            this.lbDailyCheck.Location = new System.Drawing.Point(18, 145);
            this.lbDailyCheck.Name = "lbDailyCheck";
            this.lbDailyCheck.Size = new System.Drawing.Size(0, 15);
            this.lbDailyCheck.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCorrectCode);
            this.groupBox1.Controls.Add(this.txbCorrectName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnCorrection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.displayCheckout);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.displayCheckin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(316, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 146);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Correction";
            // 
            // txbCorrectCode
            // 
            this.txbCorrectCode.Location = new System.Drawing.Point(185, 56);
            this.txbCorrectCode.Name = "txbCorrectCode";
            this.txbCorrectCode.Size = new System.Drawing.Size(149, 21);
            this.txbCorrectCode.TabIndex = 35;
            // 
            // txbCorrectName
            // 
            this.txbCorrectName.Location = new System.Drawing.Point(185, 20);
            this.txbCorrectName.Name = "txbCorrectName";
            this.txbCorrectName.Size = new System.Drawing.Size(149, 21);
            this.txbCorrectName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Employee\'s code:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(27, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Employee\'s name:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(366, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 43);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCorrection
            // 
            this.btnCorrection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorrection.Location = new System.Drawing.Point(366, 30);
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.Size = new System.Drawing.Size(106, 40);
            this.btnCorrection.TabIndex = 28;
            this.btnCorrection.Text = "Correct";
            this.btnCorrection.UseVisualStyleBackColor = true;
            this.btnCorrection.Click += new System.EventHandler(this.btnCorrection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Date time check in:";
            // 
            // displayCheckout
            // 
            this.displayCheckout.AutoSize = true;
            this.displayCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCheckout.ForeColor = System.Drawing.Color.Red;
            this.displayCheckout.Location = new System.Drawing.Point(184, 125);
            this.displayCheckout.Name = "displayCheckout";
            this.displayCheckout.Size = new System.Drawing.Size(35, 16);
            this.displayCheckout.TabIndex = 21;
            this.displayCheckout.Text = "Null";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(28, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "Date time check out:";
            // 
            // displayCheckin
            // 
            this.displayCheckin.AutoSize = true;
            this.displayCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCheckin.ForeColor = System.Drawing.Color.Red;
            this.displayCheckin.Location = new System.Drawing.Point(182, 93);
            this.displayCheckin.Name = "displayCheckin";
            this.displayCheckin.Size = new System.Drawing.Size(35, 16);
            this.displayCheckin.TabIndex = 20;
            this.displayCheckin.Text = "Null";
            // 
            // displayEmpCode
            // 
            this.displayEmpCode.AutoSize = true;
            this.displayEmpCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmpCode.ForeColor = System.Drawing.Color.Blue;
            this.displayEmpCode.Location = new System.Drawing.Point(154, 70);
            this.displayEmpCode.Name = "displayEmpCode";
            this.displayEmpCode.Size = new System.Drawing.Size(69, 16);
            this.displayEmpCode.TabIndex = 31;
            this.displayEmpCode.Text = "No Code";
            // 
            // displayEmpName
            // 
            this.displayEmpName.AutoSize = true;
            this.displayEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmpName.ForeColor = System.Drawing.Color.Blue;
            this.displayEmpName.Location = new System.Drawing.Point(154, 35);
            this.displayEmpName.Name = "displayEmpName";
            this.displayEmpName.Size = new System.Drawing.Size(102, 16);
            this.displayEmpName.TabIndex = 30;
            this.displayEmpName.Text = "No Employee";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnStartCam);
            this.groupBox7.Controls.Add(this.btnCheckin);
            this.groupBox7.Controls.Add(this.btnCheckout);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(6, 172);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(290, 96);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Daily Check";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.lbNotification);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.btnSave);
            this.groupBox6.Controls.Add(this.txbEmpCode);
            this.groupBox6.Controls.Add(this.btnFileImage);
            this.groupBox6.Controls.Add(this.btnVideoRecorder);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txbEmpName);
            this.groupBox6.Controls.Add(this.btnOneFace);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(501, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(548, 153);
            this.groupBox6.TabIndex = 26;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "New Employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(330, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "(*)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(330, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "(*)";
            // 
            // lbNotification
            // 
            this.lbNotification.AutoSize = true;
            this.lbNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotification.ForeColor = System.Drawing.Color.Lime;
            this.lbNotification.Location = new System.Drawing.Point(44, 132);
            this.lbNotification.Name = "lbNotification";
            this.lbNotification.Size = new System.Drawing.Size(0, 15);
            this.lbNotification.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(73, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Employee\'s code:";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(361, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 41);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Done";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFileImage
            // 
            this.btnFileImage.Enabled = false;
            this.btnFileImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFileImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileImage.Location = new System.Drawing.Point(259, 20);
            this.btnFileImage.Name = "btnFileImage";
            this.btnFileImage.Size = new System.Drawing.Size(73, 41);
            this.btnFileImage.TabIndex = 26;
            this.btnFileImage.Text = "Image File";
            this.btnFileImage.UseVisualStyleBackColor = true;
            this.btnFileImage.Click += new System.EventHandler(this.btnFileImage_Click);
            // 
            // btnVideoRecorder
            // 
            this.btnVideoRecorder.Enabled = false;
            this.btnVideoRecorder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVideoRecorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoRecorder.Location = new System.Drawing.Point(151, 20);
            this.btnVideoRecorder.Name = "btnVideoRecorder";
            this.btnVideoRecorder.Size = new System.Drawing.Size(73, 41);
            this.btnVideoRecorder.TabIndex = 25;
            this.btnVideoRecorder.Text = "Video Recorder";
            this.btnVideoRecorder.UseVisualStyleBackColor = true;
            this.btnVideoRecorder.Click += new System.EventHandler(this.btnVideoRecorder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(73, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "Employee\'s name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(18, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 15);
            this.label17.TabIndex = 22;
            this.label17.Text = "Employee\'s code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Employee\'s name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(211, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of faces detected: ";
            // 
            // btnRecord
            // 
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.Location = new System.Drawing.Point(174, 126);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(68, 41);
            this.btnRecord.TabIndex = 24;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(6, 30);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(322, 240);
            this.imageBoxFrameGrabber.TabIndex = 4;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvImage);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1073, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(175, 662);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image List";
            // 
            // dtgvImage
            // 
            this.dtgvImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvImage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.empcodee,
            this.empnamee});
            this.dtgvImage.Location = new System.Drawing.Point(6, 21);
            this.dtgvImage.Name = "dtgvImage";
            this.dtgvImage.RowTemplate.Height = 100;
            this.dtgvImage.Size = new System.Drawing.Size(164, 635);
            this.dtgvImage.TabIndex = 4;
            this.dtgvImage.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvImage_RowHeaderMouseClick);
            // 
            // image
            // 
            this.image.DataPropertyName = "imagee";
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // empcodee
            // 
            this.empcodee.DataPropertyName = "empcode";
            this.empcodee.HeaderText = "Code";
            this.empcodee.Name = "empcodee";
            this.empcodee.Visible = false;
            // 
            // empnamee
            // 
            this.empnamee.DataPropertyName = "empname";
            this.empnamee.HeaderText = "Name";
            this.empnamee.Name = "empnamee";
            this.empnamee.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imageBoxFrameGrabber);
            this.groupBox4.Controls.Add(this.btnRecord);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 333);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camera";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.displayEmpCode);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.displayEmpName);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.imageBox1);
            this.groupBox8.Location = new System.Drawing.Point(6, 13);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(489, 153);
            this.groupBox8.TabIndex = 34;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Result";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empcode,
            this.empname,
            this.checkin,
            this.checkout,
            this.imagee});
            this.dtgvEmployee.Location = new System.Drawing.Point(6, 21);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowTemplate.Height = 100;
            this.dtgvEmployee.Size = new System.Drawing.Size(651, 306);
            this.dtgvEmployee.TabIndex = 23;
            this.dtgvEmployee.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvEmployee_RowHeaderMouseClick);
            // 
            // empcode
            // 
            this.empcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empcode.DataPropertyName = "empcode";
            this.empcode.FillWeight = 65.17767F;
            this.empcode.HeaderText = "Employee\'s code";
            this.empcode.Name = "empcode";
            // 
            // empname
            // 
            this.empname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empname.DataPropertyName = "empname";
            this.empname.FillWeight = 65.17767F;
            this.empname.HeaderText = "Employee\'s name";
            this.empname.Name = "empname";
            // 
            // checkin
            // 
            this.checkin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkin.DataPropertyName = "checkin";
            this.checkin.FillWeight = 65.17767F;
            this.checkin.HeaderText = "Check in";
            this.checkin.Name = "checkin";
            // 
            // checkout
            // 
            this.checkout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkout.DataPropertyName = "checkout";
            this.checkout.FillWeight = 65.17767F;
            this.checkout.HeaderText = "Check out";
            this.checkout.Name = "checkout";
            // 
            // imagee
            // 
            this.imagee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imagee.DataPropertyName = "imagee";
            this.imagee.FillWeight = 65.17767F;
            this.imagee.HeaderText = "Image";
            this.imagee.Name = "imagee";
            this.imagee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imagee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLoadDatas);
            this.groupBox5.Controls.Add(this.dtgvEmployee);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(357, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(710, 333);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Management";
            // 
            // btnLoadDatas
            // 
            this.btnLoadDatas.BackColor = System.Drawing.Color.Maroon;
            this.btnLoadDatas.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLoadDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDatas.ForeColor = System.Drawing.Color.Turquoise;
            this.btnLoadDatas.Location = new System.Drawing.Point(663, 30);
            this.btnLoadDatas.Name = "btnLoadDatas";
            this.btnLoadDatas.Size = new System.Drawing.Size(41, 119);
            this.btnLoadDatas.TabIndex = 24;
            this.btnLoadDatas.Text = "Load Data";
            this.btnLoadDatas.UseVisualStyleBackColor = false;
            this.btnLoadDatas.Click += new System.EventHandler(this.btnLoadDatas_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1280, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 705);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Face Recognition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImage)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneFace;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbEmpCode;
        private System.Windows.Forms.TextBox txbEmpName;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayCheckout;
        private System.Windows.Forms.Label displayCheckin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnVideoRecorder;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnFileImage;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCorrection;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label displayEmpCode;
        private System.Windows.Forms.Label displayEmpName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCorrectCode;
        private System.Windows.Forms.TextBox txbCorrectName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLoadDatas;
        private System.Windows.Forms.DataGridView dtgvImage;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcodee;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnamee;
        private System.Windows.Forms.Label lbNotification;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDailyCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn empcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkout;
        private System.Windows.Forms.DataGridViewImageColumn imagee;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

