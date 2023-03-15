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

        // 뭐 테스트한다고 퍼블릭으로 해놨는디 나중에 원래대로 하든가 말든가 해야함
        string recievedtext;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySerial = new SerialPort();


            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                try
                {
                    if (!mySerial.IsOpen)
                    {


                        mySerial.PortName = port;  //콤보박스의 선택된 COM포트명을 시리얼포트명으로 지정
                        mySerial.BaudRate = 9600;  //보레이트 변경이 필요하면 숫자 변경하기
                        mySerial.DataBits = 8;
                        mySerial.StopBits = StopBits.One;
                        mySerial.Parity = Parity.None;

                        mySerial.DataReceived += new SerialDataReceivedEventHandler(MySerial_DataReceived);

                        mySerial.Open();

                        int RecvSize = mySerial.BytesToRead;
                        if (RecvSize == 0)
                        {
                            mySerial.Close();
                        }
                        else
                        {
                            label_status.Text = "포트가 열렸습니다";
                        }
                    }
                    else
                    {
                        label_status.Text = "포트가 이미 열려있습니다";
                    }
                }


                catch (Exception)  //에스파는 둘이 될 수 없는데 Com8이 맞는데.. Com4도 연결되긴했다고 뜸 이거 해결하삼 주희
                {
                    continue;
                }

            }


            /*
            수정전 원본!!!! 깃에 올린 원본!!

            cboxSelectPort.DataSource = SerialPort.GetPortNames();
            cboxSelectPort.Text = "포트선택";
            */

        }



        #region 사용자 정의함수
        private void MySerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }


        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            recievedtext = mySerial.ReadExisting();

            richTextBox_received.Text = recievedtext;
            //richTextBox_received.Text = richTextBox_received.Text + string.Format(recievedtext);
        }
        #endregion
    }
}
