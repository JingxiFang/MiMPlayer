namespace MusicPlayer
{
    partial class MimMusicPlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MimMusicPlayer));
            this.MImoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlayOrNot = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.libMusicName = new System.Windows.Forms.ListBox();
            this.cmsLIbRight = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仅在列表中删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在文件夹删除文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件所在文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnVoiceUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lablyric = new System.Windows.Forms.Label();
            this.btnChoiceFile = new System.Windows.Forms.Button();
            this.labAllTime = new System.Windows.Forms.Label();
            this.labNowTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MImoPlayer)).BeginInit();
            this.cmsLIbRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // MImoPlayer
            // 
            this.MImoPlayer.Enabled = true;
            this.MImoPlayer.Location = new System.Drawing.Point(-1, -1);
            this.MImoPlayer.Name = "MImoPlayer";
            this.MImoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MImoPlayer.OcxState")));
            this.MImoPlayer.Size = new System.Drawing.Size(591, 378);
            this.MImoPlayer.TabIndex = 0;
            this.MImoPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.MImoPlayer_OpenStateChange);
            this.MImoPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnPlayOrNot
            // 
            this.btnPlayOrNot.Location = new System.Drawing.Point(12, 381);
            this.btnPlayOrNot.Name = "btnPlayOrNot";
            this.btnPlayOrNot.Size = new System.Drawing.Size(81, 29);
            this.btnPlayOrNot.TabIndex = 1;
            this.btnPlayOrNot.Text = "暂停";
            this.btnPlayOrNot.UseVisualStyleBackColor = true;
            this.btnPlayOrNot.Click += new System.EventHandler(this.btnPlayOrNot_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(110, 381);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(81, 29);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(804, 1);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(17, 195);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "上一首";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // libMusicName
            // 
            this.libMusicName.ContextMenuStrip = this.cmsLIbRight;
            this.libMusicName.FormattingEnabled = true;
            this.libMusicName.ItemHeight = 12;
            this.libMusicName.Location = new System.Drawing.Point(596, 1);
            this.libMusicName.Name = "libMusicName";
            this.libMusicName.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.libMusicName.Size = new System.Drawing.Size(202, 376);
            this.libMusicName.TabIndex = 2;
            this.libMusicName.SelectedIndexChanged += new System.EventHandler(this.libMusicName_SelectedIndexChanged);
            this.libMusicName.DoubleClick += new System.EventHandler(this.libMusicName_DoubleClick);
            // 
            // cmsLIbRight
            // 
            this.cmsLIbRight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.打开文件所在文件夹ToolStripMenuItem});
            this.cmsLIbRight.Name = "cmsLIbRight";
            this.cmsLIbRight.Size = new System.Drawing.Size(185, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仅在列表中删除ToolStripMenuItem,
            this.在文件夹删除文件ToolStripMenuItem});
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 仅在列表中删除ToolStripMenuItem
            // 
            this.仅在列表中删除ToolStripMenuItem.Name = "仅在列表中删除ToolStripMenuItem";
            this.仅在列表中删除ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.仅在列表中删除ToolStripMenuItem.Text = "仅在列表中删除";
            this.仅在列表中删除ToolStripMenuItem.Click += new System.EventHandler(this.仅在列表中删除ToolStripMenuItem_Click);
            // 
            // 在文件夹删除文件ToolStripMenuItem
            // 
            this.在文件夹删除文件ToolStripMenuItem.Name = "在文件夹删除文件ToolStripMenuItem";
            this.在文件夹删除文件ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.在文件夹删除文件ToolStripMenuItem.Text = "在文件夹删除文件";
            // 
            // 打开文件所在文件夹ToolStripMenuItem
            // 
            this.打开文件所在文件夹ToolStripMenuItem.Name = "打开文件所在文件夹ToolStripMenuItem";
            this.打开文件所在文件夹ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.打开文件所在文件夹ToolStripMenuItem.Text = "打开文件所在文件夹";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(804, 202);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(17, 173);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "下一首";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnVoiceUp
            // 
            this.btnVoiceUp.Location = new System.Drawing.Point(222, 381);
            this.btnVoiceUp.Name = "btnVoiceUp";
            this.btnVoiceUp.Size = new System.Drawing.Size(81, 29);
            this.btnVoiceUp.TabIndex = 1;
            this.btnVoiceUp.Text = "音量增加";
            this.btnVoiceUp.UseVisualStyleBackColor = true;
            this.btnVoiceUp.Click += new System.EventHandler(this.btnVoiceUp_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "音量减小";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lablyric
            // 
            this.lablyric.AutoSize = true;
            this.lablyric.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lablyric.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lablyric.Location = new System.Drawing.Point(207, 92);
            this.lablyric.Name = "lablyric";
            this.lablyric.Size = new System.Drawing.Size(83, 12);
            this.lablyric.TabIndex = 3;
            this.lablyric.Text = "··· ···";
            // 
            // btnChoiceFile
            // 
            this.btnChoiceFile.Location = new System.Drawing.Point(735, 383);
            this.btnChoiceFile.Name = "btnChoiceFile";
            this.btnChoiceFile.Size = new System.Drawing.Size(63, 27);
            this.btnChoiceFile.TabIndex = 4;
            this.btnChoiceFile.Text = "打开文件";
            this.btnChoiceFile.UseVisualStyleBackColor = true;
            this.btnChoiceFile.Click += new System.EventHandler(this.btnChoiceFile_Click);
            // 
            // labAllTime
            // 
            this.labAllTime.AutoSize = true;
            this.labAllTime.Location = new System.Drawing.Point(549, 344);
            this.labAllTime.Name = "labAllTime";
            this.labAllTime.Size = new System.Drawing.Size(11, 12);
            this.labAllTime.TabIndex = 6;
            this.labAllTime.Text = "#";
            // 
            // labNowTime
            // 
            this.labNowTime.AutoSize = true;
            this.labNowTime.Location = new System.Drawing.Point(543, 344);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(0, 12);
            this.labNowTime.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MimMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 418);
            this.Controls.Add(this.labNowTime);
            this.Controls.Add(this.labAllTime);
            this.Controls.Add(this.btnChoiceFile);
            this.Controls.Add(this.lablyric);
            this.Controls.Add(this.libMusicName);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVoiceUp);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayOrNot);
            this.Controls.Add(this.MImoPlayer);
            this.Name = "MimMusicPlayer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MImoPlayer)).EndInit();
            this.cmsLIbRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MImoPlayer;
        private System.Windows.Forms.Button btnPlayOrNot;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.ListBox libMusicName;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnVoiceUp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lablyric;
        private System.Windows.Forms.Button btnChoiceFile;
        private System.Windows.Forms.ContextMenuStrip cmsLIbRight;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仅在列表中删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在文件夹删除文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件所在文件夹ToolStripMenuItem;
        private System.Windows.Forms.Label labAllTime;
        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

