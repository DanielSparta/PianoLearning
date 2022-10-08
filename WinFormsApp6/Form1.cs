using WMPLib;

namespace WinFormsApp6
{
    public partial class Form1 : Form
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
        //תווים רגילים:
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


        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //תווים רגילים:

            tileDo.URL = @"https://myproject054.000webhostapp.com/voice/do.mp4";
            tileRe.URL = @"https://myproject054.000webhostapp.com/voice/re.mp4";
            tileMi.URL = @"https://myproject054.000webhostapp.com/voice/mi.mp4";
            tileFa.URL = @"https://myproject054.000webhostapp.com/voice/fa.mp4";
            tileSol.URL = @"https://myproject054.000webhostapp.com/voice/sol.mp4";
            tileLa.URL = @"https://myproject054.000webhostapp.com/voice/la.mp4";
            tileSi.URL = @"https://myproject054.000webhostapp.com/voice/si.mp4";
            tileDo2.URL = @"https://myproject054.000webhostapp.com/voice/do2.mp4";
            tileRe2.URL = @"https://myproject054.000webhostapp.com/voice/re2.mp4";
            tileMi2.URL = @"https://myproject054.000webhostapp.com/voice/mi2.mp4";
            tileFa2.URL = @"https://myproject054.000webhostapp.com/voice/fa2.mp4";
            tileSol2.URL = @"https://myproject054.000webhostapp.com/voice/sol2.mp4";
            tileLa2.URL = @"https://myproject054.000webhostapp.com/voice/la2.mp4";
            tileSi2.URL = @"https://myproject054.000webhostapp.com/voice/si2.mp4";

            //תווים שחורים:

            tileDoS.URL = @"https://myproject054.000webhostapp.com/voice/DoS.mp4";
            tileReS.URL = @"https://myproject054.000webhostapp.com/voice/ReS.mp4";
            tileMiS.URL = @"https://myproject054.000webhostapp.com/voice/MiS.mp4";
            tileFaS.URL = @"https://myproject054.000webhostapp.com/voice/FaS.mp4";
            tileSolS.URL = @"https://myproject054.000webhostapp.com/voice/SolS.mp4";
            tileLaS.URL = @"https://myproject054.000webhostapp.com/voice/LaS.mp4";
            tileSiS.URL = @"https://myproject054.000webhostapp.com/voice/SiS.mp4";
            tileDo2S.URL = @"https://myproject054.000webhostapp.com/voice/Do2S.mp4";
            tileRe2S.URL = @"https://myproject054.000webhostapp.com/voice/Re2S.mp4";
            tileMi2S.URL = @"https://myproject054.000webhostapp.com/voice/Mi2S.mp4";
            tileFa2S.URL = @"https://myproject054.000webhostapp.com/voice/Fa2S.mp4";
            tileSol2S.URL = @"https://myproject054.000webhostapp.com/voice/Sol2S.mp4";
            tileLa2S.URL = @"https://myproject054.000webhostapp.com/voice/La2S.mp4";
            tileSi2S.URL = @"https://myproject054.000webhostapp.com/voice/Si2S.mp4";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            start: //area to generate a note
                letter = "";
            string[] list = { "do1", "re1", "mi1", "fa1", "sol1", "la1", "si1", "do2", "re2", "mi2", "fa2", "sol2" };
            int index = random.Next(list.Length);
            string note = list[index];

            if(generateimage == true)
            {
                    if (visblefalse == do1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => do1.Visible = false));
                    }
                    if (visblefalse == re1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => re1.Visible = false));
                    }
                    if (visblefalse == mi1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => mi1.Visible = false));
                    }
                    if (visblefalse == fa1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => fa1.Visible = false));
                    }
                    if (visblefalse == sol1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => sol1.Visible = false));
                    }
                    if (visblefalse == la1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => la1.Visible = false));
                    }
                    if (visblefalse == si1.Name)
                    {
                        this.BeginInvoke((MethodInvoker)(() => si1.Visible = false));
                    }
                if (visblefalse == do2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => do2.Visible = false));
                }
                if (visblefalse == re2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => re2.Visible = false));
                }
                if (visblefalse == mi2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => mi2.Visible = false));
                }
                if (visblefalse == fa2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => fa2.Visible = false));
                }
                if (visblefalse == sol2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => sol2.Visible = false));
                }
                generateimage = false;
            }

            if (note == do1.Name)
            {
                letter = "דו";
                this.BeginInvoke((MethodInvoker)(() => do1.Visible = true));
                if (music.Checked)
                {
                    tileDo.controls.play();
                }
                //ניגון הצליל
            }
            if (note == re1.Name)
            {
                letter = "רה";
                this.BeginInvoke((MethodInvoker)(() => re1.Visible = true));
                if (music.Checked)
                {
                    tileRe.controls.play();
                }
                //ניגון הצליל
            }
            if (note == mi1.Name)
            { 
                letter = "מי";
                this.BeginInvoke((MethodInvoker)(() => mi1.Visible = true));
                if (music.Checked)
                {
                    tileMi.controls.play();
                }
                //ניגון הצליל
            }
            if (note == fa1.Name)
            { 
                letter = "פה";
                this.BeginInvoke((MethodInvoker)(() => fa1.Visible = true));
                if (music.Checked)
                {
                    tileFa.controls.play();
                }
                //ניגון הצליל
            }
            if (note == sol1.Name)
            { 
                letter = "סול";
                this.BeginInvoke((MethodInvoker)(() => sol1.Visible = true));
                if (music.Checked)
                {
                    tileSol.controls.play();
                }
                //ניגון הצליל
            }
            if (note == la1.Name)
            {
                letter = "לה";
                this.BeginInvoke((MethodInvoker)(() => la1.Visible = true));
                if (music.Checked)
                {
                    tileLa.controls.play();
                }
                //ניגון הצליל
            }
            if (note == si1.Name)
            {
                letter = "סי";
                this.BeginInvoke((MethodInvoker)(() => si1.Visible = true));
                if (music.Checked)
                {
                    tileSi.controls.play();
                }
                //ניגון הצליל
            }
            if (note == do2.Name)
            {
                letter = "דו";
                this.BeginInvoke((MethodInvoker)(() => do2.Visible = true));
                if (music.Checked)
                {
                    tileDo2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == re2.Name)
            {
                letter = "רה";
                this.BeginInvoke((MethodInvoker)(() => re2.Visible = true));
                if (music.Checked)
                {
                    tileRe2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == mi2.Name)
            {
                letter = "מי";
                this.BeginInvoke((MethodInvoker)(() => mi2.Visible = true));
                if (music.Checked)
                {
                    tileMi2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == fa2.Name)
            {
                letter = "פה";
                this.BeginInvoke((MethodInvoker)(() => fa2.Visible = true));
                if (music.Checked)
                {
                    tileFa2.controls.play();
                }
                //ניגון הצליל
            }
            if (note == sol2.Name)
            {
                letter = "סול";
                this.BeginInvoke((MethodInvoker)(() => sol2.Visible = true));
                if (music.Checked)
                {
                    tileSol2.controls.play();
                }
                //ניגון הצליל
            }
        loop:
            if (startMode == true)
            {
                if (thehint.Text != letter)
                    this.BeginInvoke((MethodInvoker)(() => thehint.Text = letter));
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
                if(myscore != 0 && myscore != 500)
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

        private void sol1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while(true)
            {
                Thread.Sleep(1000);
                if (timeing != 0)
                {
                    this.BeginInvoke((MethodInvoker)(() => time.Text = "הזמן שנותר: " + timeing.ToString()));
                    timeing--;
                }
            }
        }

        private void text_KeyPress(object sender, EventArgs e, KeyPressEventArgs v)
        {
            
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                click = true;
            }
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hint = true;
            click = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void makasStart_Click(object sender, EventArgs e)
        {
            makasStart.Visible = false;
            backgroundWorker3.RunWorkerAsync();

        }

        private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
        start: //area to generate a note
            letter = "";
            string[] list = { "do1", "re1", "mi1", "fa1", "sol1", "la1", "si1", "do2", "re2", "mi2", "fa2", "sol2" };
            int index = random.Next(list.Length);
            string note = list[index];

            if (generateimage == true)
            {
                if (visblefalse == do1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Ldo1.Visible = false));
                }
                if (visblefalse == re1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lre1.Visible = false));
                }
                if (visblefalse == mi1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lmi1.Visible = false));
                }
                if (visblefalse == fa1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lfa1.Visible = false));
                }
                if (visblefalse == sol1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lsol1.Visible = false));
                }
                if (visblefalse == la1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lla1.Visible = false));
                }
                if (visblefalse == si1.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lsi1.Visible = false));
                }
                if (visblefalse == do2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Ldo2.Visible = false));
                }
                if (visblefalse == re2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lre2.Visible = false));
                }
                if (visblefalse == mi2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lmi2.Visible = false));
                }
                if (visblefalse == fa2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lfa2.Visible = false));
                }
                if (visblefalse == sol2.Name)
                {
                    this.BeginInvoke((MethodInvoker)(() => Lsol2.Visible = false));
                }
                generateimage = false;
            }

            if (note == do1.Name)
            {
                letter = "דו";
                this.BeginInvoke((MethodInvoker)(() => Ldo1.Visible = true));
            }
            if (note == re1.Name)
            {
                letter = "רה";
                this.BeginInvoke((MethodInvoker)(() => Lre1.Visible = true));
            }
            if (note == mi1.Name)
            {
                letter = "מי";
                this.BeginInvoke((MethodInvoker)(() => Lmi1.Visible = true));
            }
            if (note == fa1.Name)
            {
                letter = "פה";
                this.BeginInvoke((MethodInvoker)(() => Lfa1.Visible = true));
            }
            if (note == sol1.Name)
            {
                letter = "סול";
                this.BeginInvoke((MethodInvoker)(() => Lsol1.Visible = true));
            }
            if (note == la1.Name)
            {
                letter = "לה";
                this.BeginInvoke((MethodInvoker)(() => Lla1.Visible = true));
            }
            if (note == si1.Name)
            {
                letter = "סי";
                this.BeginInvoke((MethodInvoker)(() => Lsi1.Visible = true));
            }
            if (note == do2.Name)
            {
                letter = "דו1";
                this.BeginInvoke((MethodInvoker)(() => Ldo2.Visible = true));
            }
            if (note == re2.Name)
            {
                letter = "רה1";
                this.BeginInvoke((MethodInvoker)(() => Lre2.Visible = true));
            }
            if (note == mi2.Name)
            {
                letter = "מי1";
                this.BeginInvoke((MethodInvoker)(() => Lmi2.Visible = true));
            }
            if (note == fa2.Name)
            {
                letter = "פה1";
                this.BeginInvoke((MethodInvoker)(() => Lfa2.Visible = true));
            }
            if (note == sol2.Name)
            {
                letter = "סול1";
                this.BeginInvoke((MethodInvoker)(() => Lsol2.Visible = true));
            }
        loop:
            if (click != false)
            {
                click = false;

                if (anote == letter)
                {
                    this.BeginInvoke((MethodInvoker)(() => feedback.BackColor = Color.Green));
                    this.BeginInvoke((MethodInvoker)(() => feedback.Text = "נכון!"));
                    generateimage = true;
                    visblefalse = note;
                    anote = "";
                    letter = "";
                    goto start;
                }

                this.BeginInvoke((MethodInvoker)(() => feedback.BackColor = Color.Red));
                this.BeginInvoke((MethodInvoker)(() => feedback.Text = "טעות."));
                anote = "";
                goto loop;
            }
            else
                goto loop;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            anote = "דו";
            Thread.Sleep(10);
            click = true;
        }

        void setting(WindowsMediaPlayer player, string chord)
        {
            anote = chord;
            player.controls.play();
            Thread.Sleep(10);
            click = true; //טריגר לבאקגראונד נפרד וורקר שאומר לו לעשות דברים

        }

        private void button24_Click(object sender, EventArgs e)
        {
            setting(tileDo, "דו");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            anote = "דו1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileDo2.controls.play();
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            anote = "דו";
            Thread.Sleep(10);
            click = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            anote = "רה";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileRe.controls.play();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anote = "רה1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileRe2.controls.play();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            anote = "מי1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileMi2.controls.play();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            anote = "מי";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileMi.controls.play();
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            anote = "מי";
            Thread.Sleep(10);
            click = true;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            anote = "פה";
            Thread.Sleep(10);
            click = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            anote = "פה";
            Thread.Sleep(10);
            click = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            anote = "פה";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileFa.controls.play();
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            anote = "פה1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileFa2.controls.play();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            anote = "לה1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileLa2.controls.play();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            anote = "לה";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileLa.controls.play();
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            anote = "סול";
            Thread.Sleep(10);
            click = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            anote = "סול";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileSol.controls.play();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            anote = "סול1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileSol2.controls.play();
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            anote = "סי1";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileSi2.controls.play();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            anote = "סי";
            Thread.Sleep(10);
            click = true;
            if (music.Checked)
            {
                tileSi.controls.play();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            anote = "סי";
            Thread.Sleep(10);
            click = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileDoS.controls.play();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileReS.controls.play();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileMiS.controls.play();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileFaS.controls.play();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileSolS.controls.play();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileLaS.controls.play();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileSiS.controls.play();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileDo2S.controls.play();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileRe2S.controls.play();
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (music.Checked)
            {
                tileMiS.controls.play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LeftHand left = new LeftHand();
            left.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            timeing = 5000;
            startMode = true;
        }
    }
}