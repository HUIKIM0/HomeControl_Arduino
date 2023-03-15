using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HomeControl_Arduino
{
    public partial class Form1 : Form
    {
        SerialPort mySerial = new SerialPort();

        string recievedtext;

        public delegate void delSerialText(string strdelSerialText);
        public event delSerialText eventdelSerialText;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySerial = new SerialPort();
            cboxSelectPort.DataSource = SerialPort.GetPortNames();
            cboxSelectPort.Text = "포트선택";
        }

        private void cboxSelectPort_Click(object sender, EventArgs e)
        {
           // cboxSelectPort.Items.Clear();
           // foreach (var item in SerialPort.GetPortNames())
           // {
            //    cboxSelectPort.Items.Add(item);
           // }


        }


        //통신 연결하기 버튼 Button_connect_Click 선생님버전
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!mySerial.IsOpen)
                {
                    mySerial.PortName = cboxSelectPort.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                    mySerial.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                    mySerial.DataBits = 8;
                    mySerial.StopBits = StopBits.One;
                    mySerial.Parity = Parity.None;

                    mySerial.DataReceived += new SerialDataReceivedEventHandler(MySerial_DataReceived);

                    mySerial.Open();

                    label_status.Text = "포트가 열렸습니다";
                    cboxSelectPort.Enabled = false;
                }

                else
                {
                    label_status.Text = "포트가 이미 열려있습니다";
                }
            }
            catch (Exception)  //에스파는 둘이 될 수 없는데 Com8이 맞는데.. Com4도 연결되긴했다고 뜸 이거 해결하삼 주희
            {
                MessageBox.Show("연결에러", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void MySerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }


        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        { 

            recievedtext = mySerial.ReadExisting();
            richTextBox_received.Text = richTextBox_received.Text + string.Format(recievedtext);

        }


        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (mySerial.IsOpen)  //시리얼포트가 열려 있으면
            {
                mySerial.Close();  //시리얼포트 닫기

                label_status.Text = "포트가 닫혔습니다.";
                cboxSelectPort.Enabled = true;  //COM포트설정 콤보박스 활성화
            }
            else  //시리얼포트가 닫혀 있으면
            {
                label_status.Text = "포트가 이미 닫혀 있습니다.";
            }
        }



        //폼 연결 테스트용 삭제예정 ★
        private void button1_Click(object sender, EventArgs e)
        {


            FormHome childForm = new FormHome();
            childForm.ShowDialog();

        }

        /* 삭제용.. 시리얼통신한 Text결과를 List에 넣고 뿌려주고 싶었는데.. 
         * 시리얼 통신은 A출력 (끝) B출력(끝) 이런느낌으로 1초마다 돌아가는지라 몰루?*/
        public static List<string> SendChildFormMySerialText(string str)
        {

            List<string> Liststr = new List<string>();
            foreach (var item in Liststr)
            {
                Liststr.Add(item);
            }

            return Liststr;

        }

    }
}
