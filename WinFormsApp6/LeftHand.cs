using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WinFormsApp6
{
    public partial class LeftHand : Form
    {
        int letsgo = 0;
        bool timer = false;
        Random random = new Random();
        int timeing = 5;
        int myscore = 0;
        bool click = false;
        bool hint = false;
        string anote;
        bool startMode = false;
        string typing;
        bool generateimage = false;
        string letter;
        string visblefalse;

        WindowsMediaPlayer tileDo = new WindowsMediaPlayer();
        WindowsMediaPlayer tileRe = new WindowsMediaPlayer();
        WindowsMediaPlayer tileMi = new WindowsMediaPlayer();
        WindowsMediaPlayer tileFa = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSol = new WindowsMediaPlayer();
        WindowsMediaPlayer tileLa = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSi = new WindowsMediaPlayer();
        WindowsMediaPlayer tileDo2 = new WindowsMediaPlayer();
        WindowsMediaPlayer tileRe2 = new WindowsMediaPlayer();
        WindowsMediaPlayer tileMi2 = new WindowsMediaPlayer();
        WindowsMediaPlayer tileFa2 = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSol2 = new WindowsMediaPlayer();
        WindowsMediaPlayer tileLa2 = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSi2 = new WindowsMediaPlayer();

        //תווים שחורים:
        WindowsMediaPlayer tileDoS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileReS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileMiS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileFaS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSolS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileLaS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSiS = new WindowsMediaPlayer();
        WindowsMediaPlayer tileDo2S = new WindowsMediaPlayer();
        WindowsMediaPlayer tileRe2S = new WindowsMediaPlayer();
        WindowsMediaPlayer tileMi2S = new WindowsMediaPlayer();
        WindowsMediaPlayer tileFa2S = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSol2S = new WindowsMediaPlayer();
        WindowsMediaPlayer tileLa2S = new WindowsMediaPlayer();
        WindowsMediaPlayer tileSi2S = new WindowsMediaPlayer();


        public LeftHand()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            thehint.Visible = true;
            pause.Visible = true;
            myhint.Visible = true;
            label2.Visible = true;
            //test.Visible = true;
            text1.Visible = true;
            time.Visible = true;
            score.Visible = true;
            name.Visible = true;
            result.Visible = true;
            letsgo = 1;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.RunWorkerAsync();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (timeing != 0)
                {
                    this.BeginInvoke((MethodInvoker)(() => time.Text = "הזמן שנותר: " + timeing.ToString()));
                    timeing--;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        start: //area to generate a note
            letter = "";
            string[] list = { "leftDo", "leftRe", "leftMi", "leftFa", "leftSol", "leftLa", "leftSi", "leftDo1", "leftFa1", "leftSol1", "leftLa1", "leftSi1" };
            int index = random.Next(list.Length);
            string note = list[index];

            if (generateimage == true)
            {
                if (visblefalse == leftFa.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftFa.Visible = false));
                }
                if (visblefalse == leftSol.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftSol.Visible = false));
                }
                if (visblefalse == leftLa.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftLa.Visible = false));
                }
                if (visblefalse == leftSi.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftSi.Visible = false));
                }
                if (visblefalse == leftDo.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftDo.Visible = false));
                }
                if (visblefalse == leftRe.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftRe.Visible = false));
                }
                if (visblefalse == leftMi.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftMi.Visible = false));
                }
                if (visblefalse == leftFa1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftFa1.Visible = false));
                }
                if (visblefalse == leftSol1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftSol1.Visible = false));
                }
                if (visblefalse == leftLa1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftLa1.Visible = false));
                }
                if (visblefalse == leftSi1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftSi1.Visible = false));
                }
                if (visblefalse == leftDo1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => leftDo1.Visible = false));
                }
                generateimage = false;
            }

            if (note == leftFa.Name)
            {
                letter = "פה";
                this.BeginInvoke((MethodInvoker)(() => leftFa.Visible = true));
                if (music.Checked)
                {
                    tileDo.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftSol.Name)
            {
                letter = "סול";
                this.BeginInvoke((MethodInvoker)(() => leftSol.Visible = true));
                if (music.Checked)
                {
                    tileRe.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftLa.Name)
            {
                letter = "לה";
                this.BeginInvoke((MethodInvoker)(() => leftLa.Visible = true));
                if (music.Checked)
                {
                    tileMi.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftSi.Name)
            {
                letter = "סי";
                this.BeginInvoke((MethodInvoker)(() => leftSi.Visible = true));
                if (music.Checked)
                {
                    tileFa.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftDo.Name)
            {
                letter = "דו";
                this.BeginInvoke((MethodInvoker)(() => leftDo.Visible = true));
                if (music.Checked)
                {
                    tileSol.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftRe.Name)
            {
                letter = "רה";
                this.BeginInvoke((MethodInvoker)(() => leftRe.Visible = true));
                if (music.Checked)
                {
                    tileLa.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftMi.Name)
            {
                letter = "מי";
                this.BeginInvoke((MethodInvoker)(() => leftMi.Visible = true));
                if (music.Checked)
                {
                    tileSi.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftFa1.Name)
            {
                letter = "פה";
                this.BeginInvoke((MethodInvoker)(() => leftFa1.Visible = true));
                if (music.Checked)
                {
                    tileDo2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftSol1.Name)
            {
                letter = "סול";
                this.BeginInvoke((MethodInvoker)(() => leftSol1.Visible = true));
                if (music.Checked)
                {
                    tileRe2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftLa1.Name)
            {
                letter = "לה";
                this.BeginInvoke((MethodInvoker)(() => leftLa1.Visible = true));
                if (music.Checked)
                {
                    tileMi2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftSi1.Name)
            {
                letter = "סי";
                this.BeginInvoke((MethodInvoker)(() => leftSi1.Visible = true));
                if (music.Checked)
                {
                    tileFa2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == leftDo1.Name)
            {
                letter = "דו";
                this.BeginInvoke((MethodInvoker)(() => leftDo1.Visible = true));
                if (music.Checked)
                {
                    tileSol2.controls.play();
                }
                //ניגון הצליל
            }
        loop:
            if (startMode == true)
            {
                if (startMode == true)
                {
                    if (thehint.Text != letter)
                        this.BeginInvoke((MethodInvoker)(() => thehint.Text = letter));
                }
            }
            if (timeing == 0)
            {
                if (myscore != 0)
                {
                    myscore--;
                    this.BeginInvoke((MethodInvoker)(() => score.Text = myscore.ToString()));
                }
                this.BeginInvoke((MethodInvoker)(() => result.BackColor = Color.Pink));
                this.BeginInvoke((MethodInvoker)(() => result.Text = "הזמן תם!"));
                Thread.Sleep(1000);
                timeing = 5;
                goto loop;
            }
            if (click != false)
            {
                click = false;
                this.BeginInvoke((MethodInvoker)(() => thehint.Text = ""));
                if (hint == true)
                {
                    hint = false;
                    this.BeginInvoke((MethodInvoker)(() => thehint.Text = "התו הוא " + letter));
                }
                typing = text1.Text;
                if (typing.StartsWith(letter))
                {
                    myscore++;
                    this.BeginInvoke((MethodInvoker)(() => result.BackColor = Color.Green));
                    this.BeginInvoke((MethodInvoker)(() => result.Text = "נכון!"));
                    this.BeginInvoke((MethodInvoker)(() => text1.Text = ""));
                    if(timeing !< 500)
                    timeing = 5;
                    if (myscore != 500)
                    {
                        this.BeginInvoke((MethodInvoker)(() => score.ForeColor = Color.Green));
                        this.BeginInvoke((MethodInvoker)(() => score.Text = myscore.ToString()));
                    }
                    generateimage = true;
                    visblefalse = note;
                    goto start;
                }
                if (myscore != 0 && myscore != 500)
                {
                    myscore--;
                    this.BeginInvoke((MethodInvoker)(() => score.ForeColor = Color.Red));
                    this.BeginInvoke((MethodInvoker)(() => score.Text = myscore.ToString()));
                }
                this.BeginInvoke((MethodInvoker)(() => result.BackColor = Color.Red));
                this.BeginInvoke((MethodInvoker)(() => result.Text = "טעות."));
                this.BeginInvoke((MethodInvoker)(() => text1.Text = ""));
                goto loop;
            }
            else
                goto loop;
        }

        private void text1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                click = true;
            }
        }

        private void myhint_Click(object sender, EventArgs e)
        {
            hint = true;
            click = true;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (pause.Text == "עצור")
            {
                timeing = 5000;
                text1.Enabled = false;
                pause.Text = "המשך";
            }
            else
            {
                pause.Text = "עצור";
                text1.Enabled = true;
                timeing = 5;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
                timeing = 5000;
            startMode = true;
            hints.Visible = true;
        }
    }
}
