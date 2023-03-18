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


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
           
            cboxSelectPort.DataSource = SerialPort.GetPortNames();
            cboxSelectPort.Text = "포트선택";
           
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!mySerial.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                mySerial.PortName = cboxSelectPort.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                mySerial.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                mySerial.DataBits = 8;
                mySerial.StopBits = StopBits.One;
                mySerial.Parity = Parity.None;
                mySerial.DataReceived += new SerialDataReceivedEventHandler(MySerial_DataReceived); //이것이 꼭 필요하다

                mySerial.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                cboxSelectPort.Enabled = false;  //COM포트설정 콤보박스 비활성화
            }
            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }



        //포트선택 로그인
        private void btnLoginCOM_Click(object sender, EventArgs e)
        {
            subForm_COM sform = new subForm_COM();
            sform.eventdelmySerialReadExisting += Sform_eventdelmySerialReadExisting;
            sform.Show();
        }

        private void Sform_eventdelmySerialReadExisting(string ReadText)
        {
            richTextBox_received.Text = ReadText;
        }


        #region 사용자 정의함수 new SerialDataReceivedEventHandler(MySerial_DataReceived);
        private void MySerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }


        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {

            //// 수신 데이터 문자수 확인
            //string strRecData = string.Empty;

            //// 수신 버퍼의 값을 모두 읽어 온다.
            //strRecData = mySerial.ReadExisting();


            //// UI Cross thread invoke
            //this.Invoke(new MethodInvoker(delegate
            //{
            //    // RichTextBox에 표시하기
            //    richTextBox_received.Text = strRecData;
            //}));


            string recievedtext = mySerial.ReadExisting();

            richTextBox_received.Text = recievedtext;
            //richTextBox_received.Text = richTextBox_received.Text + string.Format(recievedtext);

        }


        #endregion



        //테스트용으로 만든 버튼! 위에코드 안먹고 이게 먹더라... 
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            if (!mySerial.IsOpen)  //시리얼포트가 열려 있지 않으면
            {
                mySerial.PortName = cboxSelectPort.Text;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                mySerial.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                mySerial.DataBits = 8;
                mySerial.StopBits = StopBits.One;
                mySerial.Parity = Parity.None;
                mySerial.DataReceived += new SerialDataReceivedEventHandler(MySerial_DataReceived); //이것이 꼭 필요하다

                mySerial.Open();  //시리얼포트 열기

                label_status.Text = "포트가 열렸습니다.";
                cboxSelectPort.Enabled = false;  //COM포트설정 콤보박스 비활성화
            }
            else  //시리얼포트가 열려 있으면
            {
                label_status.Text = "포트가 이미 열려 있습니다.";
            }
        }


    }
}
