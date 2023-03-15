
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
            this.label_status = new System.Windows.Forms.Label();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 26);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(107, 15);
            this.label_status.TabIndex = 9;
            this.label_status.Text = "포트 상태 확인";
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(137, 23);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(190, 138);
            this.richTextBox_received.TabIndex = 10;
            this.richTextBox_received.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 233);
            this.Controls.Add(this.richTextBox_received);
            this.Controls.Add(this.label_status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.RichTextBox richTextBox_received;
    }
}

