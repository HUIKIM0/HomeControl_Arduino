
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
            this.tableLP_MAIN = new System.Windows.Forms.TableLayoutPanel();
            this.tableLP_TOP = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnConditioner = new System.Windows.Forms.Button();
            this.btnHumidifier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLP_COM = new System.Windows.Forms.TableLayoutPanel();
            this.btnLoginCOM = new System.Windows.Forms.Button();
            this.labelHI = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cboxSelectPort = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.tableLP_MAIN.SuspendLayout();
            this.tableLP_TOP.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLP_COM.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLP_MAIN
            // 
            this.tableLP_MAIN.ColumnCount = 2;
            this.tableLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_MAIN.Controls.Add(this.tableLP_TOP, 1, 0);
            this.tableLP_MAIN.Controls.Add(this.tableLP_COM, 0, 0);
            this.tableLP_MAIN.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLP_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_MAIN.Location = new System.Drawing.Point(0, 0);
            this.tableLP_MAIN.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP_MAIN.Name = "tableLP_MAIN";
            this.tableLP_MAIN.RowCount = 2;
            this.tableLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_MAIN.Size = new System.Drawing.Size(1162, 517);
            this.tableLP_MAIN.TabIndex = 13;
            // 
            // tableLP_TOP
            // 
            this.tableLP_TOP.ColumnCount = 3;
            this.tableLP_TOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLP_TOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLP_TOP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLP_TOP.Controls.Add(this.panel4, 2, 1);
            this.tableLP_TOP.Controls.Add(this.panel3, 1, 1);
            this.tableLP_TOP.Controls.Add(this.btnLight, 2, 0);
            this.tableLP_TOP.Controls.Add(this.btnConditioner, 1, 0);
            this.tableLP_TOP.Controls.Add(this.btnHumidifier, 0, 0);
            this.tableLP_TOP.Controls.Add(this.panel1, 0, 1);
            this.tableLP_TOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_TOP.Location = new System.Drawing.Point(161, 1);
            this.tableLP_TOP.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP_TOP.Name = "tableLP_TOP";
            this.tableLP_TOP.RowCount = 2;
            this.tableLP_TOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.75343F));
            this.tableLP_TOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.24658F));
            this.tableLP_TOP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLP_TOP.Size = new System.Drawing.Size(1000, 117);
            this.tableLP_TOP.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(669, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(328, 35);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "조명 FOFF";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(336, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 35);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "에어컨 OFF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLight
            // 
            this.btnLight.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLight.FlatAppearance.BorderSize = 0;
            this.btnLight.Font = new System.Drawing.Font("한컴 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLight.Location = new System.Drawing.Point(669, 3);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(328, 70);
            this.btnLight.TabIndex = 2;
            this.btnLight.Text = "조명";
            this.btnLight.UseVisualStyleBackColor = false;
            // 
            // btnConditioner
            // 
            this.btnConditioner.BackColor = System.Drawing.Color.SkyBlue;
            this.btnConditioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConditioner.FlatAppearance.BorderSize = 0;
            this.btnConditioner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConditioner.Font = new System.Drawing.Font("한컴 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConditioner.Location = new System.Drawing.Point(336, 3);
            this.btnConditioner.Name = "btnConditioner";
            this.btnConditioner.Size = new System.Drawing.Size(327, 70);
            this.btnConditioner.TabIndex = 1;
            this.btnConditioner.Text = "에어컨";
            this.btnConditioner.UseVisualStyleBackColor = false;
            // 
            // btnHumidifier
            // 
            this.btnHumidifier.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHumidifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHumidifier.FlatAppearance.BorderSize = 0;
            this.btnHumidifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHumidifier.Font = new System.Drawing.Font("한컴 고딕", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHumidifier.Location = new System.Drawing.Point(3, 3);
            this.btnHumidifier.Name = "btnHumidifier";
            this.btnHumidifier.Size = new System.Drawing.Size(327, 70);
            this.btnHumidifier.TabIndex = 0;
            this.btnHumidifier.Text = "가습기";
            this.btnHumidifier.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 35);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 35);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "가습기 OFF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLP_COM
            // 
            this.tableLP_COM.ColumnCount = 1;
            this.tableLP_COM.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_COM.Controls.Add(this.btnLoginCOM, 0, 0);
            this.tableLP_COM.Controls.Add(this.labelHI, 0, 1);
            this.tableLP_COM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLP_COM.Location = new System.Drawing.Point(1, 1);
            this.tableLP_COM.Margin = new System.Windows.Forms.Padding(1);
            this.tableLP_COM.Name = "tableLP_COM";
            this.tableLP_COM.RowCount = 2;
            this.tableLP_COM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLP_COM.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLP_COM.Size = new System.Drawing.Size(158, 117);
            this.tableLP_COM.TabIndex = 1;
            // 
            // btnLoginCOM
            // 
            this.btnLoginCOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginCOM.Location = new System.Drawing.Point(3, 3);
            this.btnLoginCOM.Name = "btnLoginCOM";
            this.btnLoginCOM.Size = new System.Drawing.Size(152, 74);
            this.btnLoginCOM.TabIndex = 0;
            this.btnLoginCOM.Text = "포트선택 로그인";
            this.btnLoginCOM.UseVisualStyleBackColor = true;
            this.btnLoginCOM.Click += new System.EventHandler(this.btnLoginCOM_Click);
            // 
            // labelHI
            // 
            this.labelHI.AutoSize = true;
            this.labelHI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHI.Location = new System.Drawing.Point(3, 80);
            this.labelHI.Name = "labelHI";
            this.labelHI.Size = new System.Drawing.Size(152, 37);
            this.labelHI.TabIndex = 1;
            this.labelHI.Text = "안녕하세요";
            this.labelHI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxSelectPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_status, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox_received, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(163, 122);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(532, 309);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(269, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // cboxSelectPort
            // 
            this.cboxSelectPort.FormattingEnabled = true;
            this.cboxSelectPort.Location = new System.Drawing.Point(3, 3);
            this.cboxSelectPort.Name = "cboxSelectPort";
            this.cboxSelectPort.Size = new System.Drawing.Size(121, 23);
            this.cboxSelectPort.TabIndex = 1;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(3, 154);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(242, 15);
            this.label_status.TabIndex = 2;
            this.label_status.Text = "이거 신경쓰지마삼!!!!테스트용이삼";
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(269, 157);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(260, 149);
            this.richTextBox_received.TabIndex = 3;
            this.richTextBox_received.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 517);
            this.Controls.Add(this.tableLP_MAIN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLP_MAIN.ResumeLayout(false);
            this.tableLP_TOP.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLP_COM.ResumeLayout(false);
            this.tableLP_COM.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLP_MAIN;
        private System.Windows.Forms.TableLayoutPanel tableLP_TOP;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnConditioner;
        private System.Windows.Forms.Button btnHumidifier;
        private System.Windows.Forms.TableLayoutPanel tableLP_COM;
        private System.Windows.Forms.Button btnLoginCOM;
        private System.Windows.Forms.Label labelHI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cboxSelectPort;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

