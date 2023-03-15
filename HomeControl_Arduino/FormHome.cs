using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeControl_Arduino
{
    public partial class FormHome : Form
    {
        public delegate void delSerialText(string data); // string 을 반환값으로 같은 대리자를 선언
        public event delSerialText eventdelSerialText;


        public FormHome()
        {
            InitializeComponent();
        }


        string ReceivedData;

        public FormHome(string Data)
        {
            InitializeComponent();

            // 부모폼에서 데이터를 받아 전역변수에 넣는다.
            ReceivedData = Data;
            foreach (var item in Data)
            {
                richTextBox1.Text = ReceivedData;
            }
        }



        private void FormHome_Load(object sender, EventArgs e)
        {

            //richTextBox1.Text = ReceivedData;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
