using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Faceing
{
    
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);


       
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            


        }
       public static SpeechSynthesizer sSynth = new SpeechSynthesizer();

        PromptBuilder pBuilder = new PromptBuilder();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();


        public  void Debug_Helper(string str)
        {
            try
            {
                
                //debug_lable.Text = str;
            }
            catch(NullReferenceException)
            {
                
               // Debug.Info("Debug_Helper: " + ex.ToString());
            }
            return;
        }




        private void Load_Orpheius()
        {
           
            Load_Exe("Orpheius.exe");

        }

        

        private void Load_Power_On()
        {

            Load_Exe("startup_orpheius.vbs");
            
        }

        private void Install_Edge_Canrey()
        {
            Load_Exe("C:/xampp/browser/79.0.294.0/Installer/setup.exe");
        }

        


        private void Load_Exe(string file)
        {
            try
            {
                Process p = Process.Start(file);
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(this.Handle, p.MainWindowHandle);
            }
            catch(Exception ex)
            {
                Debug("Load_Exe: " + ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Task_Kill_Operations();

        }

       
        private void Task_Kill_Operations()
        {
            this.Close();


            Get_Processes("Orpheius");
            Get_Processes("httpd");
            Get_Processes("mysqld");
            Get_Processes("cmd");
            Get_Processes("command");



        }

        private void Get_Processes(string name)
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName(name))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                Debug("Get_Processes: " + ex.ToString());
            }
        }
        
        int count_time = 0;
        bool first_load = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            count_time++;
            label1.Text = count_time.ToString();
            //Debug(label1.Text);
            if (count_time > 121 && count_time < 140 && first_load == false)
            {
                Talk_Btn_Click(sender, e);
                speek_box.Text = "";
                Debug("(Ai):(Cleared):Thoughts");
                first_load = true;
                
            }
            if(count_time == 140)
            {
                count_time = 121;
                first_load = false;
            }
            // todo add mysql to know first load variable status
            /*if (count_time == 1 && first_load == true)
            {
                Debug("(System):(Install):(Ai):(Orpheius):(Server)");
                Install_Edge_Canrey();
            }*/
            if (count_time == 5)
            {
                Debug("(System):(Load):Server");
                Load_Power_On();
            }
            
            if (count_time == 120)
            {
                Debug("(System):(Load):Orpheius");
                Load_Orpheius();
            }

           WindowState = FormWindowState.Maximized;

        }

        private void Talk_Btn_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(speek_box.Text);
            Debug("(Ai):(Said):" + speek_box.Text);
            sSynth.Speak(pBuilder);
        }

        private void Record_BTN_Click(object sender, EventArgs e)
        {
            Record_BTN.Enabled = false;
            Record_BTN.Enabled = true;

            Choices sList = new Choices();
            sList.Add(new string[] {"a","b","c","d","e","f", "ERR_CONNECTION_REFUSED" });
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_Speech;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception ex)
            {
                Debug("Record_BTN_Click: " + ex.ToString());
                return;
            }
        }
        
        private void sRecognize_Speech(object sender, SpeechRecognizedEventArgs e)
        {
            // if(e.Result.Text == "a")
            //{
           
                speek_box.Text = textBox1.Text = e.Result.Text.ToString();
                Debug("(Ai):(Heard):"+speek_box.Text);
                pBuilder.ClearContent();
                pBuilder.AppendText(speek_box.Text);
                sSynth.Volume = 100;

                sSynth.Rate = 2;
                sSynth.Speak(pBuilder);
           
            //}
        }
        int count_items = -1;
        public void Debug (string sender)
        {

            try
            {
                count_items++;
                listBox1.Items.Add("(LOG):"+sender);
                listBox1.SelectedIndex = count_items;
                //PromptBuilder pBuilder = new PromptBuilder();
               // pBuilder.ClearContent();
                //pBuilder.AppendText(textBox2.Text);
               
                //debug_lable.Text = str;
            }
            catch (NullReferenceException)
            {

                // Debug.Info("Debug_Helper: " + ex.ToString());
            }
            return;
        }

       
    }
}
