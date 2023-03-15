
namespace HomeControl_Arduino
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboxSelectPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM 포트설정";
            // 
            // cboxSelectPort
            // 
            this.cboxSelectPort.FormattingEnabled = true;
            this.cboxSelectPort.Items.AddRange(new object[] {
            "포트를 선택"});
            this.cboxSelectPort.Location = new System.Drawing.Point(15, 51);
            this.cboxSelectPort.Name = "cboxSelectPort";
            this.cboxSelectPort.Size = new System.Drawing.Size(103, 23);
            this.cboxSelectPort.TabIndex = 1;
            this.cboxSelectPort.Click += new System.EventHandler(this.cboxSelectPort_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(125, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 35);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "연결하기";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(124, 97);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(101, 32);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "연결끄기";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(15, 159);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 15);
            this.label_status.TabIndex = 9;
            this.label_status.Text = "label2";
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(342, 46);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(190, 138);
            this.richTextBox_received.TabIndex = 10;
            this.richTextBox_received.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "form연결테스트용";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox_received);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboxSelectPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxSelectPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private System.Windows.Forms.Button button1;
    }
}

