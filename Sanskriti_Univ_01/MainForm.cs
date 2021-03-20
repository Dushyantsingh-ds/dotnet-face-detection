using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;


namespace Sanskriti_Univ_01
{
    public partial class MainForm : Form
    {
        //Image<Bgr, Byte> currentFrame;
        //Capture grabber;
        //HaarCascade face;
        //HaarCascade eye;
        //MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        //Image<Gray, byte> result, TrainedFace = null;
        //Image<Gray, byte> gray = null;
        //List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        //List<string> labels = new List<string>();
        //List<string> NamePersons = new List<string>();
        //int ContTrain, NumLabels, t;
        //string name, names = null;
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> result_usercits;
        Image<Gray, byte> result_bookingdatettime;
        Image<Gray, byte> result_Mobile;
        Image<Gray, byte> result_Role;
        Image<Gray, byte> result_Status;
        Image<Gray, byte> result_AttendDateTime;

        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();

        List<string> labels = new List<string>();
        List<string> userCity = new List<string>();
        List<string> bookingDateTime = new List<string>();
        List<string> Label_Mobile = new List<string>();
        List<string> Label_Role = new List<string>();
        List<string> Label_Status = new List<string>();
        List<string> Label_AttendDateTime = new List<string>();

        List<string> NamePersons = new List<string>();
        List<string> NameuserCity = new List<string>();
        List<string> NamebookingDateTime = new List<string>();
        List<string> Name_Mobile = new List<string>();
        List<string> Name_Role = new List<string>();
        List<string> Name_Status = new List<string>();
        List<string> Name_AttendDateTime = new List<string>();

        int ContTrain, NumLabels, t;
        string name, names = null;
        string usercity, usercits = null;
        string bookingdatettime, bookingdatettims = null;
        string mobile, Mobiles = null;
        string role, Roles = null;
        string status, Statuss = null;
        string attendDateTime, AttendDateTimes = null;

        string UserName;
        private void AddNew_btn_Click(object sender, EventArgs e)
        {

            addNew_UC1.Show();
            addNew_UC1.BringToFront();

        }

        public MainForm()
        {

            InitializeComponent();
            ////Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                //Load of previus trainned faces and labels for each image
                string UserCity = File.ReadAllText(Application.StartupPath + "/TrainedFaces/UserCity.txt");
                string[] UserCits = UserCity.Split('%');
                //Load of previus trainned faces and labels for each image
                string BookingDateTime = File.ReadAllText(Application.StartupPath + "/TrainedFaces/BookingDateTime.txt");
                string[] BookingDateTims = BookingDateTime.Split('%');
                //Load of previus trainned faces and labels for each image
                string Mobile = File.ReadAllText(Application.StartupPath + "/TrainedFaces/UserMobile.txt");
                string[] Mobiless = Mobile.Split('%');
                //Load of previus trainned faces and labels for each image
                string Role = File.ReadAllText(Application.StartupPath + "/TrainedFaces/UserRole.txt");
                string[] Roless = Role.Split('%');
                //Load of previus trainned faces and labels for each image
                string Status = File.ReadAllText(Application.StartupPath + "/TrainedFaces/EventAttend.txt");
                string[] Statusss = Status.Split('%');
                //Load of previus trainned faces and labels for each image
                string AttendDateTime = File.ReadAllText(Application.StartupPath + "/TrainedFaces/EventAttendDateTime.txt");
                string[] AttendDateTimess = AttendDateTime.Split('%');

                NumLabels = Convert.ToInt16(Labels[0]);

                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));

                    labels.Add(Labels[tf]);
                   
                    userCity.Add(UserCits[tf]);
                    bookingDateTime.Add(BookingDateTims[tf]);
                    Label_Mobile.Add(Mobiless[tf]);
                    Label_Role.Add(Roless[tf]);
                    Label_Status.Add(Statusss[tf]);
                    Label_AttendDateTime.Add(AttendDateTimess[tf]);
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            //No_Face_dect.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");
            NameuserCity.Add("");
            NamebookingDateTime.Add("");
            Name_Mobile.Add("");
            Name_Role.Add("");
            Name_Status.Add("");
            Name_AttendDateTime.Add("");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(470, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                result_usercits = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                result_bookingdatettime = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                result_Mobile = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                result_Role = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                result_Status = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                result_AttendDateTime = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);
                    EigenObjectRecognizer recognizer_City = new EigenObjectRecognizer(
                      trainingImages.ToArray(),
                      userCity.ToArray(),
                      3000,
                      ref termCrit);
                    EigenObjectRecognizer recognizer_DateTime = new EigenObjectRecognizer(
                     trainingImages.ToArray(),
                     bookingDateTime.ToArray(),
                     3000,
                     ref termCrit);
                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer_Mobile = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       Label_Mobile.ToArray(),
                       3000,
                       ref termCrit);
                    EigenObjectRecognizer recognizer_Role = new EigenObjectRecognizer(
                      trainingImages.ToArray(),
                      Label_Role.ToArray(),
                      3000,
                      ref termCrit);
                    EigenObjectRecognizer recognizer_Status = new EigenObjectRecognizer(
                     trainingImages.ToArray(),
                     Label_Status.ToArray(),
                     3000,
                     ref termCrit);
                    EigenObjectRecognizer recognizer_AttendDateTime = new EigenObjectRecognizer(
                     trainingImages.ToArray(),
                     Label_AttendDateTime.ToArray(),
                     3000,
                     ref termCrit);

                    name = recognizer.Recognize(result);
                    bookingdatettime = recognizer_DateTime.Recognize(result_bookingdatettime);
                    usercity = recognizer_City.Recognize(result_usercits);
                    mobile = recognizer_Mobile.Recognize(result_Mobile);
                    role = recognizer_Role.Recognize(result_Role);
                    status = recognizer_Status.Recognize(result_Status);
                    attendDateTime = recognizer_AttendDateTime.Recognize(result_AttendDateTime);

                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");

                NameuserCity[t - 1] = usercits;
                NameuserCity.Add("");

                NamebookingDateTime[t - 1] = bookingdatettims;
                NamebookingDateTime.Add("");

                Name_Mobile[t - 1] = Mobiles;
                Name_Mobile.Add("");

                Name_Role[t - 1] = Roles;
                Name_Role.Add("");

                Name_Status[t - 1] = Statuss;
                Name_Status.Add("");

                Name_AttendDateTime[t - 1] = AttendDateTimes;
                Name_AttendDateTime.Add("");


                //Set the number of faces detected on the scene
                UserCity_.Text = facesDetected[0].Length.ToString();
            }
            t = 0;


            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;

            UserName_.Text = names;
            UserName = names;
            UserCity_.Text = usercity;
            BookingDateTime_.Text = bookingdatettime;
            Mobile_.Text = mobile;
            Role_.Text = role;
            Status_.Text = status;
            EventAttendTime_.Text = attendDateTime;

            if (names == "")
            {
                UserCity_.Text = "Null";
                BookingDateTime_.Text = "Null";
                Mobile_.Text = "Null";
                Role_.Text = "Null";
                Status_.Text = "Null";
                EventAttendTime_.Text = "Null";
            }
            names = "";
            usercits = "";
            bookingdatettims = "";
            Mobiles = "";
            Roles = "";
            Statuss = "";
            AttendDateTimes = "";
            //Clear the list(vector) of names

            NamePersons.Clear();
            NameuserCity.Clear();
            NamebookingDateTime.Clear();
        }


   


        private void Detect_btn_Click(object sender, EventArgs e)
        {
            grabber = new Capture();
            grabber.QueryFrame();
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            Detect_btn.Enabled = false;
            DisableDetection_btn.Enabled = true;

        }
        private void Dev_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void DisableDetection_btn_Click(object sender, EventArgs e)
        {
            SqlData.CreateConnection();
            SqlData.UpdateDG(UserName);
        }

        private void Home_btn_click(object sender, EventArgs e)
        {

            addNew_UC1.Hide();
            addNew_UC1.SendToBack();
        }
    }
}
