using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class MimMusicPlayer : Form
    {
        public MimMusicPlayer()
        {
            InitializeComponent();
        }
        //存储音乐文件的路径
        List<string> listMusicPath = new List<string>();
        //储存音乐文件的名字
        List<string> listMusicName = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }



        private void btnPlayOrNot_Click(object sender, EventArgs e)
        {

            if (btnPlayOrNot.Text == "暂停")
            {
                btnPlayOrNot.Text = "播放";
                //实现暂停功能
                MImoPlayer.Ctlcontrols.pause();
            }
            else if (btnPlayOrNot.Text == "播放")
            {
                btnPlayOrNot.Text = "暂停";
                //实现播放功能
                MImoPlayer.Ctlcontrols.play();
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //实现停止功能
            MImoPlayer.Ctlcontrols.stop();
        }



        private void btnChoiceFile_Click(object sender, EventArgs e)
        {
            //创建一个对话框
            OpenFileDialog open = new OpenFileDialog();
            //修改对话框的标题
            open.Title = "请选择音乐文件";
            //可以多选
            open.Multiselect = true;
            open.Filter = "音频文件|*MP3|视频文件|*MP4";
            open.ShowDialog();
            //获取选中文件的全路径
            string[] arrayNamePath = open.FileNames;
            //将文件路径添加到listMusicPath中
            listMusicPath.AddRange(arrayNamePath);
            //将音乐文件名添加到listbox中
            for (int i = 0; i < arrayNamePath.Length; i++)
            {
                //将音乐文件的名字放在libMusicName中
                libMusicName.Items.Add(Path.GetFileName(arrayNamePath[i]));
            }
        }

        private void libMusicName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void libMusicName_DoubleClick(object sender, EventArgs e)
        {
            //防止点击空白部分时报错
            if (libMusicName.SelectedIndex == -1)
            {
                return;
            }

            //获取点击的音乐路径 
            MImoPlayer.URL = listMusicPath[libMusicName.SelectedIndex];
            MImoPlayer.Ctlcontrols.play();
            SearchLyric(listMusicPath[libMusicName.SelectedIndex]);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            //防止在没有选中的情况下点击后报错
            if (libMusicName.SelectedIndex == -1)
            {
                return;
            }
            int index = libMusicName.SelectedIndex;
            //选择的项减1为上一首的索引
            index--;
            //使之循环
            if (index < 0)
            {
                index = listMusicPath.Count - 1;
            }
            //这样蓝条可以移动到改变后的索引上 
            libMusicName.SelectedItems.Clear();
            libMusicName.SelectedIndex = index;
            MImoPlayer.URL = listMusicPath[index];
            MImoPlayer.Ctlcontrols.play();
            SearchLyric(listMusicPath[libMusicName.SelectedIndex]);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            //防止在没有选中的情况下点击后报错
            if (libMusicName.SelectedIndex == -1)
            {
                return;
            }
            int index = libMusicName.SelectedIndex;
            //选择的项加1为上一首的索引
            index++;
            //使之循环
            if (index > listMusicPath.Count - 1)
            {
                index = 0;
            }
            //这样蓝条可以移动到改变后的索引上 
            libMusicName.SelectedItems.Clear();
            libMusicName.SelectedIndex = index;
            MImoPlayer.URL = listMusicPath[index];
            MImoPlayer.Ctlcontrols.play();
            SearchLyric(listMusicPath[libMusicName.SelectedIndex]);
        }

        private void 仅在列表中删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int indexs = libMusicName.SelectedItems.Count;

            for (int i = 0; i < indexs; i++)
            {
                listMusicPath.RemoveAt(libMusicName.SelectedIndex);
                //将选中项在listbox中删除
                libMusicName.Items.Remove(libMusicName.SelectedItem);
                //listMusicName.RemoveAt(libMusicName.SelectedIndex);
            }

        }

        private void btnVoiceUp_Click(object sender, EventArgs e)
        {
            //实现音量大的增加
            MImoPlayer.settings.volume += 5;
            if (MImoPlayer.settings.volume >= 100)
            {
                MImoPlayer.settings.volume = 100;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //实现音量的减小
            MImoPlayer.settings.volume -= 5;
            if (MImoPlayer.settings.volume <= 0)
            {
                MImoPlayer.settings.volume = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //当前音乐播放时间  单位是秒
            labNowTime.Text = MImoPlayer.Ctlcontrols.currentPosition.ToString();



            ////当前播放时间  单位是分
            //labNowTime.Text = MImoPlayer.Ctlcontrols.currentPositionString.ToString();

            ////当前音乐的全部时间 单位为秒
            //labAllTime.Text = MImoPlayer.currentMedia.duration.ToString();

            if (MImoPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //当前音乐的全部时间  单位为分
                labAllTime.Text = MImoPlayer.currentMedia.durationString.ToString();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (MImoPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if (MImoPlayer.currentMedia.duration - MImoPlayer.Ctlcontrols.currentPosition < 1)
                {
                    btnDown_Click(sender, e);
                }
            }

            for (int i = 1; i < listtime.Count; i++)
            {
                if (MImoPlayer.Ctlcontrols.currentPosition < listtime[i] && MImoPlayer.Ctlcontrols.currentPosition > listtime[i - 1])
                {
                    lablyric.Text = listlrc[i - 1];
                }

            }
        }

        private void MImoPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            ////MessageBox.Show(MImoPlayer.playState.ToString());
            //if (MImoPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            //{
            //    int index = libMusicName.SelectedIndex;
            //    //选择的项加1为上一首的索引
            //    index++;
            //    //使之循环
            //    if (index > listMusicPath.Count - 1)
            //    {
            //        index = 0;
            //    }
            //    //这样蓝条可以移动到改变后的索引上 
            //    libMusicName.SelectedItems.Clear();
            //    libMusicName.SelectedIndex = index;
            //    MImoPlayer.URL = listMusicPath[index];
            //}
            //if (MImoPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            //{
            //    try
            //    {
            //        MImoPlayer.Ctlcontrols.play();
            //    }
            //    catch { }
            //}
        }

        List<string> listlrc = new List<string>();
        List<double> listtime = new List<double>();

        private void SearchLyric(string lyricPath)
        {
            string[] lrc = lyricPath.Split('.');
            string pathLrc = lrc[0] + ".lrc";
            if (File.Exists(pathLrc))
            {
                lablyric.Text = "歌词加载中";
                //读取歌词文件
                string[] arrayLricy = File.ReadAllLines(pathLrc, Encoding.Default);
                Cut(arrayLricy);
            }
            else
            {
                lablyric.Text = "----歌词未找到-----";
            }
        }

        private void Cut(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                string[] arraylyc = a[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                if (arraylyc.Length  >1)
                {
                    listlrc.Add(arraylyc[1]);
                    string[] arrayTime = arraylyc[0].Split(new char[]{':'}, StringSplitOptions.RemoveEmptyEntries);
                    listtime.Add(Convert.ToDouble(arrayTime[0])*60+Convert.ToDouble(arrayTime[1]));

                }
              
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
        }
    }
}
