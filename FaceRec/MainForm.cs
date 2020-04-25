
//Multiple face detection and recognition in real time
//Using EmguCV cross platform .Net wrapper to the Intel OpenCV image processing library for C#.Net
//Writed by Sergio Andrés Guitérrez Rojas
//"Serg3ant" for the delveloper comunity
// Sergiogut1805@hotmail.com    
//Regards from Bucaramanga-Colombia ;)

using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using Emgu.CV.UI;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Threading;
using System.Configuration;
using System.Runtime.Serialization.Formatters.Binary;

namespace MultiFaceRec
{
    public partial class FrmPrincipal : Form
    {
        //Declararation of all variables, vectors and haarcascades

        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> codes = new List<string>();
        
        List<string> NamePersons = new List<string>();
        List<string> CodePersons = new List<string>();
        int ContTrain, NumLabels, t, contTrainCode;
        string name, code, names, codevalue = null;
        DataTable dt = null;
        bool check = false;
        public bool statuscam = false;
        MemoryStream msImage;
        bool oneface = false;
        bool videorecord = false;
        
        int totalclick = 0;



        //----------------


        static string conStr = ConfigurationManager.ConnectionStrings["MultiFaceRec.Properties.Settings.Setting"].ConnectionString;
        SqlConnection connect = new SqlConnection(conStr);

        public void disPlayData()
        {
            for (int i = 0; i < 2; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < 2; j++)
                {
                    row.Cells.Add(new DataGridViewButtonCell());
                }
                dtgvEmployee.Rows.Add(row);
            }

            try
            {
                connect.Open();
                string query = "SELECT empcode, empname, checkin, checkout, imagee FROM Employee ORDER BY id DESC";
                SqlCommand sqlcmd = new SqlCommand(query, connect);
                sqlcmd.CommandType = CommandType.Text;

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                //DataTable dt = new DataTable();
                //sqlda.Fill(dt);
                //connect.Close();
                //dtgvEmployee.DataSource = dt;
                if (dt == null)
                {
                    dt = new DataTable();
                    sqlda.Fill(dt);
                    
                    dtgvEmployee.DataSource = dt;
                }
                check = true;
                connect.Close();
            }
            catch
            {}
        }

        void disPlayImage()
        {
            try
            {
                connect.Open();
                string query = "SELECT imagee, empcode, empname FROM train ORDER BY id DESC";
                SqlCommand sqlcmd = new SqlCommand(query, connect);
                //sqlcmd.CommandType = CommandType.Text;

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcmd);
                if (dt == null)
                {
                    dt = new DataTable();
                    sqlda.Fill(dt);
                    dtgvImage.DataSource = dt;
                }
                connect.Close();
            }
            catch
            { }
        }

        public void unDisplayData()
        {
            if(dt != null)
            {
                dtgvEmployee.DataSource = null;
                dtgvEmployee.Refresh();                
            }
            else { }
        }

        public void startCam()
        {
            grabber = new Capture();
            Application.Idle += new EventHandler(FrameGrabber);
            grabber.QueryFrame();
            
        }

        public void stopCam()
        {
            btnStartCam.Text = "Start Cam";
            offControl();
            Application.Idle -= FrameGrabber;
            grabber.Dispose();
        }        

        public void FrmPrincipal_Load(object sender, EventArgs e)
        {
            disPlayImage();
            //disPlayData();
            startCam();
            btnStartCam.Text = "Stop Cam";

            onControl();
            setNull();
            //btnStartCam.Enabled = true;
            statuscam = true;                    
        }
       
        public FrmPrincipal()
        {
            InitializeComponent();
            

            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                connect.Open();
                SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM train", connect);
                Int32 count = (Int32)countCmd.ExecuteScalar();
                NumLabels = count;
                ContTrain = NumLabels;
                

                SqlCommand labelsCmd = new SqlCommand("select empname from train", connect);
                SqlCommand codesCmd = new SqlCommand("select empcode from train", connect);
                SqlCommand imageCmd = new SqlCommand("select imagee from train", connect);

                List<string> Labels = new List<string>();
                List<string> Codes = new List<string>();
                List<Image<Gray, byte>> Images = new List<Image<Gray, byte>>();
                List<byte[]> imagebyte = new List<byte[]>();

                SqlDataReader labelsdr = labelsCmd.ExecuteReader();
                SqlDataReader codesdr = codesCmd.ExecuteReader();
                SqlDataReader imagedr = imageCmd.ExecuteReader();

                while (labelsdr.Read())
                {
                    Labels.Add(labelsdr.GetValue(0).ToString());
                }
                while (codesdr.Read())
                {
                    Codes.Add(codesdr.GetValue(0).ToString());
                }
                while (imagedr.Read())
                {
                    imagebyte.Add((byte[])imagedr["imagee"]);                    
                }
                connect.Close();
                for (int i = 0; i < imagebyte.Count; i++)
                {
                    MemoryStream ms = new MemoryStream(imagebyte[i]);
                    Image image = Image.FromStream(ms);
                    Bitmap bm = (Bitmap)image;
                    Image<Gray, byte> igray = new Image<Gray, byte>(bm);
                    Images.Add(igray);
                }
                
               
                for (int tf = 0; tf < NumLabels; tf++)
                {
                    trainingImages.Add(Images[tf]);
                    labels.Add(Labels[tf]);
                    codes.Add(Codes[tf]);
                }

            }
            catch (Exception)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        void setNull()
        {
            txbEmpCode.Text = "";
            txbEmpName.Text = "";
            txbCorrectCode.Text = "";
            txbCorrectName.Text = "";
        }

        void onControl()
        {
            txbEmpName.Enabled = true;
            txbEmpCode.Enabled = true;
            txbCorrectName.Enabled = false;
            txbCorrectCode.Enabled = false;
            btnStartCam.Enabled = true;
            btnOneFace.Enabled = true;
            btnVideoRecorder.Enabled = true;
            btnFileImage.Enabled = true;
            btnSave.Enabled = false;
            btnCorrection.Enabled = false;
            btnUpdate.Enabled = false;
            btnCheckin.Enabled = true;
            btnCheckout.Enabled = true;
        }

        void offControl()
        {
            txbEmpName.Enabled = false;
            txbEmpCode.Enabled = false;
            txbCorrectName.Enabled = false;
            txbCorrectCode.Enabled = false;
            btnStartCam.Enabled = true;
            btnOneFace.Enabled = false;
            btnVideoRecorder.Enabled = false;
            btnFileImage.Enabled = true;
            btnSave.Enabled = false;
            btnCorrection.Enabled = false;
            btnUpdate.Enabled = false;
            btnCheckin.Enabled = true;
            btnCheckout.Enabled = true;
        }

        void onCorrection()
        {
            txbCorrectName.Enabled = true;
            txbCorrectCode.Enabled = true;
            btnCorrection.Enabled = false;
            btnUpdate.Enabled = true;
        }

        void offCorrection()
        {
            txbCorrectName.Enabled = false;
            txbCorrectCode.Enabled = false;
            btnCorrection.Enabled = true;
            btnUpdate.Enabled = false;
        }   
        
        public void addEmp()
        {
            string query = "INSERT INTO train(empcode, empname, date, imagee) VALUES (@empcode, @empname, @date, @imagee)";
            SqlCommand cmd = new SqlCommand(query, connect);

            ImageConverter converter = new ImageConverter();
            byte[] imagepic = (byte[])converter.ConvertTo(TrainedFace.ToBitmap(), typeof(byte[]));

            cmd.Parameters.AddWithValue("@empcode", txbEmpCode.Text);
            cmd.Parameters.AddWithValue("@empname", txbEmpName.Text);
            cmd.Parameters.AddWithValue("@date", toolStripStatusLabel1.Text);
            cmd.Parameters.AddWithValue("@imagee", imagepic);

            cmd.ExecuteNonQuery();
        }

        public void faceRecProcess()
        {
            ContTrain = ContTrain + 1;

            //Get a gray frame from capture device
            gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                5,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                break;
            }

            //test image with cubic interpolation type method
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            trainingImages.Add(TrainedFace);
            labels.Add(txbEmpName.Text);
            codes.Add(txbEmpCode.Text);

            //Show face added in gray scale
            imageBox1.Image = TrainedFace;
        }
            
        private void btnOneFace_Click(object sender, System.EventArgs e)
        {           
            if(txbEmpCode.Text=="" || txbEmpName.Text == "")
            {
                MessageBox.Show("Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                    
            }
            else
            {
                try
                {

                    faceRecProcess();

                    connect.Open();
                    addEmp();
                    connect.Close();

                    lbNotification.Text = "Successfully! *Name: " + txbEmpName.Text + "  *Code: " + txbEmpCode.Text + " added!";
                    lbDailyCheck.Text = "";
                    
                    txbEmpName.Text = "";
                    txbEmpCode.Text = "";
                    btnCorrection.Enabled = true;
                    disPlayImage();
                }
                catch
                {
                    MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            onCorrection();
            txbCorrectCode.Text = "";
            txbCorrectName.Text = "";
        }

        private void dtgvEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txbEmpCode.Text = dtgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                txbCorrectCode.Text = dtgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();

                txbEmpName.Text = dtgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                txbCorrectName.Text = dtgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();

                displayCheckin.Text = dtgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                displayCheckout.Text = dtgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (displayCheckin.Text == "")
                {
                    displayCheckin.Text = "Null";
                }
                if (displayCheckout.Text == "")
                {
                    displayCheckout.Text = "Null";
                }

                string data = dtgvEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dtgvEmployee.CurrentRow.Cells[4].Value);
                Image img = Image.FromStream(ms);

                ImageBox ib = new ImageBox();
                Bitmap masterImage = (Bitmap)img;
                Image<Gray, Byte> displayimage = new Image<Gray, Byte>(masterImage);
                imageBox1.Image = displayimage;
                btnCorrection.Enabled = true;
            }
            catch { }
        }
        bool checkdetect = true;

        public bool checkDetect()
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          5,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);
                
            }
            return checkdetect;
            
        }

        private void btnVideoRecorder_Click(object sender, EventArgs e)
        {
            if(txbEmpCode.Text=="" || txbEmpName.Text == "")
            {
                MessageBox.Show("Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
            else
            {
                try
                {
                    faceRecProcess();
             
                    ImageConverter converter = new ImageConverter();
                    byte[] imagepic = (byte[])converter.ConvertTo(TrainedFace.ToBitmap(), typeof(byte[]));

                    connect.Open();

                    addEmp();

                    connect.Close();

                    totalclick++;
                    //btnVideoRecorder.Enabled = false;
                    txbEmpCode.Enabled = false;
                    txbEmpName.Enabled = false;
                    lbNotification.Text = "Successfully! *Name: " + txbEmpName.Text + "  *Code: " + txbEmpCode.Text + " added " + totalclick.ToString() + "/5.";


                    if (totalclick == 5)
                    {
                        btnVideoRecorder.Enabled = false;
                        btnSave.Enabled = true;
                        videorecord = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }          
        }

        
        public void btnStartCam_Click(object sender, EventArgs e)
        {

            if (statuscam == false)
            {
                startCam();
                btnStartCam.Text = "Stop Cam";

                onControl();
                setNull();
                
                statuscam = true;
            }
            else
            {
                btnStartCam.Text = "Start Cam";
                offControl();
                Application.Idle -= FrameGrabber;
                grabber.Dispose();
                txbEmpCode.Enabled = true;
                txbEmpName.Enabled = true;
                statuscam = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                SqlCommand idCmd = new SqlCommand("SELECT TOP 1 id FROM Employee ORDER BY ID DESC",connect);
                Int32 id = (Int32)idCmd.ExecuteScalar();
                string query = "UPDATE Employee SET empcode = '" + txbCorrectCode.Text + "', empname = '" + txbCorrectName.Text + "' WHERE id = '" + id.ToString() + "'";
                SqlCommand cmd = new SqlCommand(query, connect);
                
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                SqlCommand nameCmd = new SqlCommand("SELECT TOP 1 empname FROM Employee ORDER BY ID DESC", connect);
                string name = (string)nameCmd.ExecuteScalar();

                connect.Close();
                setNull();
                onControl();

                MessageBox.Show("Successfully, " + name + " is update!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
        }

        public void dtgvImage_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            displayEmpCode.Text = dtgvImage.Rows[e.RowIndex].Cells[1].Value.ToString();
            displayEmpName.Text = dtgvImage.Rows[e.RowIndex].Cells[2].Value.ToString();
            msImage = new MemoryStream((byte[])dtgvImage.CurrentRow.Cells[0].Value);
            Image img = Image.FromStream(msImage);
            ImageBox ib = new ImageBox();
            Bitmap masterImage = (Bitmap)img;
            Image<Gray, Byte> displayimage = new Image<Gray, Byte>(masterImage);
            imageBox1.Image = displayimage;
        }

        public void btnCheckin_Click(object sender, EventArgs e)
        {
            offCorrection();
            btnOneFace.Enabled = true;
            btnVideoRecorder.Enabled = true;
            btnFileImage.Enabled = true;
            btnSave.Enabled = false;
            txbEmpCode.Text = "";
            txbEmpName.Text = "";
            
            if (statuscam == true)
            {
                try
                {
                    faceRecProcess();

                    ImageConverter converter = new ImageConverter();
                    byte[] imagepic = (byte[])converter.ConvertTo(TrainedFace.ToBitmap(), typeof(byte[]));

                    connect.Open();
                    string query = "INSERT INTO Employee(empcode, empname, checkin, imagee) VALUES (@empcode, @empname, @checkin, @imagee)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@empcode", displayEmpCode.Text);
                    cmd.Parameters.AddWithValue("@empname", displayEmpName.Text);
                    cmd.Parameters.AddWithValue("@checkin", toolStripStatusLabel1.Text);
                    cmd.Parameters.AddWithValue("@imagee", imagepic);

                    cmd.ExecuteNonQuery();

                    SqlCommand nameCmd = new SqlCommand("SELECT TOP 1 empname FROM Employee ORDER BY ID DESC", connect);
                    SqlCommand codeCmd = new SqlCommand("SELECT TOP 1 empcode FROM Employee ORDER BY ID DESC", connect);

                    string empname = (string)nameCmd.ExecuteScalar();
                    string empcode = (string)codeCmd.ExecuteScalar();

                    connect.Close();

                    txbCorrectName.Text = empname.ToString();
                    txbCorrectCode.Text = empcode.ToString();

                    displayCheckin.Text = toolStripStatusLabel1.ToString();
                    displayCheckout.Text = "Null";
                    disPlayImage();
                    lbDailyCheck.Text = "Successfully! *Name: " + empname + "  *Code: " + empcode + " checked in!";
                    lbNotification.Text = "";

                }
                catch
                {
                    MessageBox.Show("Error for check in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    byte[] imagepic = msImage.ToArray();                    
                   
                    Image img = Image.FromStream(msImage);                    
                    Bitmap masterImage = (Bitmap)img;
                    Image<Gray, Byte> graypic = new Image<Gray, Byte>(masterImage);
                    trainingImages.Add(graypic);
                    labels.Add(displayEmpName.Text);
                    codes.Add(displayEmpCode.Text);
                  
                    connect.Open();
                    string query = "INSERT INTO Employee(empcode, empname, checkin, imagee) VALUES (@empcode, @empname, @checkin, @imagee)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@empcode", displayEmpCode.Text);
                    cmd.Parameters.AddWithValue("@empname", displayEmpName.Text);
                    cmd.Parameters.AddWithValue("@checkin", toolStripStatusLabel1.Text);
                    cmd.Parameters.AddWithValue("@imagee", imagepic);

                    cmd.ExecuteNonQuery();

                    SqlCommand nameCmd = new SqlCommand("SELECT TOP 1 empname FROM Employee ORDER BY ID DESC", connect);
                    SqlCommand codeCmd = new SqlCommand("SELECT TOP 1 empcode FROM Employee ORDER BY ID DESC", connect);

                    string empname = (string)nameCmd.ExecuteScalar();
                    string empcode = (string)codeCmd.ExecuteScalar();

                    connect.Close();

                    txbCorrectName.Text = empname.ToString();
                    txbCorrectCode.Text = empcode.ToString();

                    displayCheckin.Text = toolStripStatusLabel1.ToString();
                    displayCheckout.Text = "Null";
                    
                    disPlayImage();
                    lbDailyCheck.Text = "Successfully! *Name: " + empname + "  *Code: " + empcode + " checked in!";
                    lbNotification.Text = "";

                }
                catch
                {
                    MessageBox.Show("Error for check in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }



        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopCam();
            System.Windows.Forms.Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }


        private void btnLoadDatas_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                Login frm = new Login();
                frm.Activate();
                frm.Show();
                //disPlayData();

                check = true;
                this.Hide();
            }
            else
            {
                unDisplayData();
                check = false;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            offCorrection();
            btnOneFace.Enabled = true;
            btnVideoRecorder.Enabled = true;
            btnFileImage.Enabled = true;
            btnSave.Enabled = false;
            txbEmpCode.Text = "";
            txbEmpName.Text = "";


            if (statuscam == true)
            {
                try
                {
                    faceRecProcess();
                    ImageConverter converter = new ImageConverter();
                    byte[] imagepic = (byte[])converter.ConvertTo(TrainedFace.ToBitmap(), typeof(byte[]));

                    connect.Open();
                    string query = "INSERT INTO Employee(empcode, empname, checkout, imagee) VALUES (@empcode, @empname, @checkout, @imagee)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@empcode", displayEmpCode.Text);
                    cmd.Parameters.AddWithValue("@empname", displayEmpName.Text);
                    cmd.Parameters.AddWithValue("@checkout", toolStripStatusLabel1.Text);
                    cmd.Parameters.AddWithValue("@imagee", imagepic);

                    cmd.ExecuteNonQuery();

                    SqlCommand nameCmd = new SqlCommand("SELECT TOP 1 empname FROM Employee ORDER BY ID DESC", connect);
                    SqlCommand codeCmd = new SqlCommand("SELECT TOP 1 empcode FROM Employee ORDER BY ID DESC", connect);

                    string empname = (string)nameCmd.ExecuteScalar();
                    string empcode = (string)codeCmd.ExecuteScalar();

                    connect.Close();

                    txbCorrectName.Text = empname.ToString();
                    txbCorrectCode.Text = empcode.ToString();
                    displayCheckin.Text = "Null";
                    displayCheckout.Text = toolStripStatusLabel1.ToString();
                    disPlayImage();
                    lbDailyCheck.Text = "Successfully! *Name: " + empname + "  *Code: " + empcode + " checked out!";
                    lbNotification.Text = "";
                }
                catch
                {
                    MessageBox.Show("Error for check out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    byte[] imagepic = msImage.ToArray();

                    Image img = Image.FromStream(msImage);
                    Bitmap masterImage = (Bitmap)img;
                    Image<Gray, Byte> graypic = new Image<Gray, Byte>(masterImage);
                    trainingImages.Add(graypic);

                    labels.Add(displayEmpName.Text);
                    codes.Add(displayEmpCode.Text);

                    connect.Open();
                    string query = "INSERT INTO Employee(empcode, empname, checkout, imagee) VALUES (@empcode, @empname, @checkout, @imagee)";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.Parameters.AddWithValue("@empcode", displayEmpCode.Text);
                    cmd.Parameters.AddWithValue("@empname", displayEmpName.Text);
                    cmd.Parameters.AddWithValue("@checkout", toolStripStatusLabel1.Text);
                    cmd.Parameters.AddWithValue("@imagee", imagepic);

                    cmd.ExecuteNonQuery();

                    SqlCommand nameCmd = new SqlCommand("SELECT TOP 1 empname FROM Employee ORDER BY ID DESC", connect);
                    SqlCommand codeCmd = new SqlCommand("SELECT TOP 1 empcode FROM Employee ORDER BY ID DESC", connect);

                    string empname = (string)nameCmd.ExecuteScalar();
                    string empcode = (string)codeCmd.ExecuteScalar();

                    connect.Close();

                    txbCorrectName.Text = empname.ToString();
                    txbCorrectCode.Text = empcode.ToString();
                    displayCheckin.Text = "Null";
                    displayCheckout.Text = toolStripStatusLabel1.ToString();
                   
                    disPlayImage();
                    lbDailyCheck.Text = "Successfully! *Name: " + empname + "  *Code: " + empcode + " checked out!";
                    lbNotification.Text = "";
                }
                catch
                {
                    MessageBox.Show("Error for check out", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        

        private void btnFileImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            //DialogResult dialogResult = openFileDialog.ShowDialog();
            if (txbEmpName.Text == "" || txbEmpCode.Text == "" || statuscam == true)
            {
                MessageBox.Show("Null or Camera is running", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(openFileDialog.FileName, Directory.GetCurrentDirectory() + "\\image\\" + openFileDialog.SafeFileName);
                    Image img = Image.FromFile(openFileDialog.FileName);

                    ImageBox ib = new ImageBox();
                    Bitmap masterImage = (Bitmap)img;
                    Image<Bgr, Byte> currentImage = new Image<Bgr, byte>(masterImage);

                    faceRecProcess();

                    ImageConverter converter = new ImageConverter();
                    byte[] imagepic = (byte[])converter.ConvertTo(TrainedFace.ToBitmap(), typeof(byte[]));

                    connect.Open();
                    addEmp();
                    connect.Close();

                    lbNotification.Text = "Successfully! *Name: " + txbEmpName.Text + "  *Code: " + txbEmpCode.Text + " added!";
                    lbDailyCheck.Text = "";
                    txbEmpName.Text = "";
                    txbEmpCode.Text = "";
                    disPlayImage();
                    btnCorrection.Enabled = true;
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {      
            if (oneface)
            {
                
            }

            if (videorecord)
            {
                MessageBox.Show("Successfully! Your data added!", "Video Recorder", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbEmpName.Text = "";
                txbEmpCode.Text = "";
                lbNotification.Text = "";
                onControl();
            }
        }


        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");
            CodePersons.Add("");

            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,          
          5,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);
                    MCvTermCriteria termCrit2 = new MCvTermCriteria(contTrainCode, 0.001);

                    //Eigen face recognizer
                    //------------------------------------------------------------------------------------------------------
#pragma warning disable 0436
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);
                    EigenObjectRecognizer recognizer2 = new EigenObjectRecognizer(
                        trainingImages.ToArray(),
                        codes.ToArray(),
                        3000,
                        ref termCrit2);


                    name = recognizer.Recognize(result);
                    code = recognizer2.Recognize(result);

                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));
                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");

                CodePersons[t - 1] = code;
                CodePersons.Add("");


                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();           
            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn];
                codevalue = codevalue + CodePersons[nnn];
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            displayEmpName.Text = names;
            names = "";
            displayEmpCode.Text = codevalue;
            codevalue = "";

            //Clear the list(vector) of names
            NamePersons.Clear();
            CodePersons.Clear();
        }

    }
}