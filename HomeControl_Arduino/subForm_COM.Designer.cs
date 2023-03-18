
namespace HomeControl_Arduino
{
    partial class subForm_COM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxSelectPort = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cboxSelectPort
            // 
            this.cboxSelectPort.FormattingEnabled = true;
            this.cboxSelectPort.Location = new System.Drawing.Point(13, 33);
            this.cboxSelectPort.Name = "cboxSelectPort";
            this.cboxSelectPort.Size = new System.Drawing.Size(121, 23);
            this.cboxSelectPort.TabIndex = 0;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(13, 73);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(45, 15);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "label1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(151, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "button1";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(151, 70);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.Size = new System.Drawing.Size(300, 156);
            this.richTextBox_received.TabIndex = 3;
            this.richTextBox_received.Text = "";
            // 
            // subForm_COM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 263);
            this.Controls.Add(this.richTextBox_received);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.cboxSelectPort);
            this.Name = "subForm_COM";
            this.Text = "subForm_COM";
            this.Load += new System.EventHandler(this.subForm_COM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxSelectPort;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox richTextBox_received;
    }
}