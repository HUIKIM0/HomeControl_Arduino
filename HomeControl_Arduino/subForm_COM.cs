using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeControl_Arduino
{
    public partial class subForm_COM : Form
    {

        SerialPort mySerial = new SerialPort();

        public delegate void delmySerialReadExisting(string ReadText);
        public event delmySerialReadExisting eventdelmySerialReadExisting;

        public subForm_COM()
        {
            InitializeComponent();
        }


        private void subForm_COM_Load(object sender, EventArgs e)
        {
            cboxSelectPort.DataSource = SerialPort.GetPortNames();
            cboxSelectPort.Text = "포트선택";
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
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

          

                    // 폼 투명도 0. 폼은 살아있는데 안보이게만 하는거
                    WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;
                    Opacity = 0;

                }
                else  //시리얼포트가 열려 있으면
                {
                    label_status.Text = "포트가 이미 열려 있습니다.";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("해당 포트는 연결할 수 없습니다 다른 포트를 찾아주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnConnect.Text = mySerial.IsOpen ? "연결해제" : "연결하기";
            cboxSelectPort.Enabled = !mySerial.IsOpen;
            
        }

        #region 사용자 정의함수 new SerialDataReceivedEventHandler(MySerial_DataReceived);
        private void MySerial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
        }


        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {

   
            string recievedtext = mySerial.ReadExisting();
            richTextBox_received.Text = recievedtext;

            eventdelmySerialReadExisting(recievedtext);  //부모Form에 시리얼받아온텍스트 넘길 delegate event

            //richTextBox_received.Text = richTextBox_received.Text + string.Format(recievedtext);

        }
        #endregion


    }
}
