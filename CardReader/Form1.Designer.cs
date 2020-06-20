using System;

namespace CardReader
{
    partial class Form1
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
            this.button_GetSerialPorts = new System.Windows.Forms.Button();
            this.comboBoxGetPorts = new System.Windows.Forms.ComboBox();
            this.button_PortState = new System.Windows.Forms.Button();
            this.comboBox_SetBaudRate = new System.Windows.Forms.ComboBox();
            this.button_GetBaudRate = new System.Windows.Forms.Button();
            this.textBox_GetID = new System.Windows.Forms.TextBox();
            this.poll = new System.Windows.Forms.Button();
            this.getData = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoId = new System.Windows.Forms.Button();
            this.button1_autoPoll = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.setParity = new System.Windows.Forms.Button();
            this.setDataBits = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button_GetSerialPorts
            // 
            this.button_GetSerialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_GetSerialPorts.Location = new System.Drawing.Point(26, 33);
            this.button_GetSerialPorts.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetSerialPorts.Name = "button_GetSerialPorts";
            this.button_GetSerialPorts.Size = new System.Drawing.Size(132, 40);
            this.button_GetSerialPorts.TabIndex = 1;
            this.button_GetSerialPorts.Text = "Get Ports";
            this.button_GetSerialPorts.UseVisualStyleBackColor = true;
            this.button_GetSerialPorts.Click += new System.EventHandler(this.button_GetSerialPorts_Click);
            // 
            // comboBoxGetPorts
            // 
            this.comboBoxGetPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxGetPorts.FormattingEnabled = true;
            this.comboBoxGetPorts.Location = new System.Drawing.Point(166, 40);
            this.comboBoxGetPorts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxGetPorts.Name = "comboBoxGetPorts";
            this.comboBoxGetPorts.Size = new System.Drawing.Size(120, 28);
            this.comboBoxGetPorts.TabIndex = 2;
            this.comboBoxGetPorts.Text = "COM5";
            this.comboBoxGetPorts.SelectedIndexChanged += new System.EventHandler(this.comboBoxGetPorts_SelectedIndexChanged);
            // 
            // button_PortState
            // 
            this.button_PortState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_PortState.Location = new System.Drawing.Point(602, 33);
            this.button_PortState.Margin = new System.Windows.Forms.Padding(4);
            this.button_PortState.Name = "button_PortState";
            this.button_PortState.Size = new System.Drawing.Size(138, 71);
            this.button_PortState.TabIndex = 0;
            this.button_PortState.Text = "Port Closed";
            this.button_PortState.Click += new System.EventHandler(this.button_PortState_Click);
            // 
            // comboBox_SetBaudRate
            // 
            this.comboBox_SetBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_SetBaudRate.FormattingEnabled = true;
            this.comboBox_SetBaudRate.Location = new System.Drawing.Point(456, 40);
            this.comboBox_SetBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SetBaudRate.Name = "comboBox_SetBaudRate";
            this.comboBox_SetBaudRate.Size = new System.Drawing.Size(120, 28);
            this.comboBox_SetBaudRate.TabIndex = 4;
            this.comboBox_SetBaudRate.Text = "9600";
            this.comboBox_SetBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_SetBaudRate_SelectedIndexChanged);
            // 
            // button_GetBaudRate
            // 
            this.button_GetBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_GetBaudRate.Location = new System.Drawing.Point(318, 33);
            this.button_GetBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.button_GetBaudRate.Name = "button_GetBaudRate";
            this.button_GetBaudRate.Size = new System.Drawing.Size(132, 40);
            this.button_GetBaudRate.TabIndex = 5;
            this.button_GetBaudRate.Text = "Get Baud Rates";
            this.button_GetBaudRate.UseVisualStyleBackColor = true;
            this.button_GetBaudRate.Click += new System.EventHandler(this.button_GetBaudRate_Click);
            // 
            // textBox_GetID
            // 
            this.textBox_GetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_GetID.Location = new System.Drawing.Point(261, 517);
            this.textBox_GetID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_GetID.Name = "textBox_GetID";
            this.textBox_GetID.Size = new System.Drawing.Size(317, 30);
            this.textBox_GetID.TabIndex = 16;
            // 
            // poll
            // 
            this.poll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.poll.Location = new System.Drawing.Point(26, 171);
            this.poll.Margin = new System.Windows.Forms.Padding(4);
            this.poll.Name = "poll";
            this.poll.Size = new System.Drawing.Size(76, 36);
            this.poll.TabIndex = 10;
            this.poll.Text = "Poll";
            this.poll.UseVisualStyleBackColor = true;
            this.poll.Click += new System.EventHandler(this.poll_Click);
            // 
            // getData
            // 
            this.getData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getData.Location = new System.Drawing.Point(107, 171);
            this.getData.Margin = new System.Windows.Forms.Padding(4);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(84, 36);
            this.getData.TabIndex = 11;
            this.getData.Text = "Get Data";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(26, 215);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(714, 282);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(161, 519);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "CARD ID";
            // 
            // autoId
            // 
            this.autoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autoId.Location = new System.Drawing.Point(196, 171);
            this.autoId.Margin = new System.Windows.Forms.Padding(4);
            this.autoId.Name = "autoId";
            this.autoId.Size = new System.Drawing.Size(103, 36);
            this.autoId.TabIndex = 14;
            this.autoId.Text = "Auto ID";
            this.autoId.UseVisualStyleBackColor = true;
            this.autoId.Click += new System.EventHandler(this.autoId_Click);
            // 
            // button1_autoPoll
            // 
            this.button1_autoPoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_autoPoll.Location = new System.Drawing.Point(306, 171);
            this.button1_autoPoll.Margin = new System.Windows.Forms.Padding(4);
            this.button1_autoPoll.Name = "button1_autoPoll";
            this.button1_autoPoll.Size = new System.Drawing.Size(103, 36);
            this.button1_autoPoll.TabIndex = 15;
            this.button1_autoPoll.Text = "Auto Poll";
            this.button1_autoPoll.UseVisualStyleBackColor = true;
            this.button1_autoPoll.Click += new System.EventHandler(this.button1_autoPoll_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Clear.Location = new System.Drawing.Point(415, 171);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(113, 36);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear Buffer";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // stop
            // 
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stop.Location = new System.Drawing.Point(653, 171);
            this.stop.Margin = new System.Windows.Forms.Padding(4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(86, 36);
            this.stop.TabIndex = 18;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // clearText
            // 
            this.clearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearText.Location = new System.Drawing.Point(533, 171);
            this.clearText.Margin = new System.Windows.Forms.Padding(4);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(114, 36);
            this.clearText.TabIndex = 19;
            this.clearText.Text = "Clear Text";
            this.clearText.UseVisualStyleBackColor = true;
            this.clearText.Click += new System.EventHandler(this.clearText_Click);
            // 
            // setParity
            // 
            this.setParity.Location = new System.Drawing.Point(27, 90);
            this.setParity.Name = "setParity";
            this.setParity.Size = new System.Drawing.Size(131, 40);
            this.setParity.TabIndex = 20;
            this.setParity.Text = "Parity";
            this.setParity.UseVisualStyleBackColor = true;
            // 
            // setDataBits
            // 
            this.setDataBits.Location = new System.Drawing.Point(319, 90);
            this.setDataBits.Name = "setDataBits";
            this.setDataBits.Size = new System.Drawing.Size(131, 40);
            this.setDataBits.TabIndex = 21;
            this.setDataBits.Text = "Data Bits";
            this.setDataBits.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 97);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "Odd";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(456, 97);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(120, 28);
            this.comboBox2.TabIndex = 23;
            this.comboBox2.Text = "8";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(603, 111);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(137, 18);
            this.progressBar1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.setDataBits);
            this.Controls.Add(this.setParity);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button1_autoPoll);
            this.Controls.Add(this.autoId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.poll);
            this.Controls.Add(this.textBox_GetID);
            this.Controls.Add(this.button_GetBaudRate);
            this.Controls.Add(this.comboBox_SetBaudRate);
            this.Controls.Add(this.button_PortState);
            this.Controls.Add(this.comboBoxGetPorts);
            this.Controls.Add(this.button_GetSerialPorts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_GetSerialPorts;
        private System.Windows.Forms.ComboBox comboBoxGetPorts;
        private System.Windows.Forms.Button button_PortState;
        private System.Windows.Forms.ComboBox comboBox_SetBaudRate;
        private System.Windows.Forms.Button button_GetBaudRate;
        private System.Windows.Forms.TextBox textBox_GetID;
        private System.Windows.Forms.Button poll;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button autoId;
        private System.Windows.Forms.Button button1_autoPoll;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.Button setParity;
        private System.Windows.Forms.Button setDataBits;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

