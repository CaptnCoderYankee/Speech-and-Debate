using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System.Timers;

namespace PORobo
{
    public partial class Form1 : Form
    {
        private static System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(textBox2.Text);
            item.SubItems.Add("0");
            item.SubItems.Add("0");
            //item.SubItems.Add(billCodeBox.Text);
            listView1.Items.Add(item);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Tab)
            {
                textBox2.Focus();
            }
        }

        private void selectSpeaker_Click(object sender, EventArgs e)
        {
            string repName = listView1.SelectedItems[0].SubItems[0].Text;
            string repCode = listView1.SelectedItems[0].SubItems[1].Text;
            string repSpeechNum = listView1.SelectedItems[0].SubItems[2].Text;
            string repQuestNum = listView1.SelectedItems[0].SubItems[3].Text;

            repsNameLabel.Text = repName;
            repsSchoolCodeLabel.Text = repCode;
            speechNumberLabel.Text = repSpeechNum;
            questionNumberLabel.Text = repQuestNum;
            
        }


        WaveStream waveStream = new Mp3FileReader("Beep.mp3");

        //Changes and edits number of speeches for both list view and label.//
        #region Number Of Speeches
        private void addNumberSpeechBtn_Click(object sender, EventArgs e)//Gets New Number of Speeches on each button click.
        {
            timer1.Enabled = true;
            timer1.Start();
            questioningLabel.Visible = false;
            speechTimeLabel.Visible = true;
            addNumberSpeechBtn.Enabled = false;
            button2.Enabled = false;
            mins = 0;
            secs = 0;
            try
            {
                int currentIndex = listView1.SelectedItems[0].Index;
                var itemCount = listView1.SelectedItems.Count;
                ListViewItem item = listView1.Items[currentIndex];
                item.SubItems.Add(billCodeBox.Text);
                if (currentIndex == itemCount)
                {
                    listView1.Items.RemoveAt(currentIndex);
                    listView1.Items.Insert(itemCount, item);
                }
                else if (currentIndex > 0)
                {
                    listView1.Items.RemoveAt(currentIndex);
                    listView1.Items.Insert(currentIndex - 1, item);
                }
                else
                {
                    /*If the item is the top item make it the last*/
                    listView1.Items.RemoveAt(currentIndex);
                    listView1.Items.Insert(listView1.Items.Count, item);
                }

                if (listView1.SelectedItems[0].SubItems[2].Text == "0") //Checks to see Value
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "1";// If Value is Greater, Increase and Change ListView
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;// Increase and Change Label
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "1")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "2";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "2")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "3";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "3")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "4";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "4")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "5";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "5")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "6";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "6")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "7";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "7")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "8";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "8")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "9";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[2].Text == "9")
                {
                    listView1.SelectedItems[0].SubItems[2].Text = "10";
                    speechNumberLabel.Text = listView1.SelectedItems[0].SubItems[2].Text;
                }
            }
            catch
            {
                // Do nothing
            }
        }
        #endregion

        #region Speech Time Button
        int mins = 0;
        int secs = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            secs++;
            speechTimerUpdate();
        }

        private void speechTimerUpdate()
        {
            var waveOut = new WaveOut();
            if (secs > 59)
            {
                mins++;
                secs = 0;
            }

            if (mins == 3 && secs == 15)
            {
                timer1.Stop();

                if (secs >= 0 && secs <= 9)
                {
                    speechTimeLabel.Text = "0" + mins + ":0" + secs;
                }
                else
                {
                    speechTimeLabel.Text = "0" + mins + ":" + secs;
                }

            }
            if (secs >= 0 && secs <= 9)
            {
                speechTimeLabel.Text = "0" + mins + ":0" + secs;
            }
            else
            {
                speechTimeLabel.Text = "0" + mins + ":" + secs;
            }
            Console.WriteLine(mins + " " + secs);
            if(mins == 2 && secs == 30)
            {

                waveOut.Init(waveStream);
                waveOut.Play();
            }

            if(mins == 3 && secs == 00)
            {
                WaveStream waveStream = new Mp3FileReader("Beep.mp3");
                waveOut.Init(waveStream);
                waveOut.Play();
            }


            if (mins == 3 && secs == 5)
            {
                WaveStream waveStream = new Mp3FileReader("Beep.mp3");
                waveOut.Init(waveStream);
                waveOut.Play();
            }

            if (mins == 0 && secs == 7)
            {
                aTimer = new System.Timers.Timer();
                aTimer.Interval = 1000;

                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                for(int i = 0; i < 10; i++)
                {
                    aTimer.Enabled = true;
                    for(int g = 0; g < 10; g++)
                    {
                        aTimer.Enabled = false;
                    }
                }
            }
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            var waveOut = new WaveOut();
            WaveStream waveStream = new Mp3FileReader("Beep.mp3");
            waveOut.Init(waveStream);
            waveOut.Play();
        }
        #endregion

        #region Timer Controls
        bool stopBtnClicked = false;
        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopBtnClicked = true;
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
            }

            if (timer2.Enabled == true)
            {
                timer2.Enabled = false;
            }
            addNumberSpeechBtn.Enabled = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            minsLeft = 2;
            secLeft = 0;
            mins = 3;
            secs = 5;
            questioningLabel.Text = "0" + minsLeft + ":0" + secLeft;
            speechTimeLabel.Text = "0" + mins + ":0" + secs;
            addNumberSpeechBtn.Enabled = true;
            button2.Enabled = true;
        }
        #endregion

        #region Questioning Add to List
        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0].SubItems[3].Text == "0") //Checks to see Value
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "1";// If Value is Greater, Increase and Change ListView
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;// Increase and Change Label
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "1")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "2";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "2")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "3";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "3")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "4";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "4")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "5";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "5")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "6";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "6")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "7";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "7")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "8";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "8")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "9";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }

                else if (listView1.SelectedItems[0].SubItems[3].Text == "9")
                {
                    listView1.SelectedItems[0].SubItems[3].Text = "10";
                    questionNumberLabel.Text = listView1.SelectedItems[0].SubItems[3].Text;
                }
            }
            catch
            {
                // Do Nothing
            }
        }
        #endregion

        #region Questioning Time Button

        int i = 0;
        public int minsLeft;
        public int secLeft;
        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
            button2.Enabled = false;
            addNumberSpeechBtn.Enabled = false;

            questioningLabel.Visible = true;
            speechTimeLabel.Visible = false;

            billQuestioner();
            
        }

        public void billQuestioner()
        {
            if (i< 2)
            {
                minsLeft = 2;
                secLeft = 0;
                i++;
                Console.WriteLine(i);
            }
            else
            {
                minsLeft = 1;
                secLeft = 0;
                Console.WriteLine(i);
            }
        }
 

        public void timer2_Tick(object sender, EventArgs e)
        {
            secLeft--;
            questionTimerUpdate();
        }

        private void questionTimerUpdate()
        {
            if (secLeft < 0)
            {
                minsLeft--;
                secLeft = 59;
            }
            
            if(minsLeft == 0 && secLeft == 0)
            {
                timer2.Stop();

                if (secLeft >= 0 && secLeft <= 9)
                {
                    questioningLabel.Text = "0" + minsLeft + ":0" + secLeft;
                }
                else
                {
                    questioningLabel.Text = "0" + minsLeft + ":" + secLeft;
                }

            }
            if (secLeft >= 0 && secLeft <= 9)
            {
                questioningLabel.Text = "0" + minsLeft + ":0" + secLeft;
            }
            else
            {
                questioningLabel.Text = "0" + minsLeft + ":" + secLeft;
            }
            Console.WriteLine(minsLeft + " " + secLeft);

        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            questioningLabel.Visible = false;
            questioningLabel.Text= "0"+minsLeft+":"+secLeft+"0";

            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void billCodeBox_TextChanged(object sender, EventArgs e)
        {
            i = 0;
            Console.WriteLine(i);
        }
    }
}