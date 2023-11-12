using NAudio.CoreAudioApi;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VoiceCont_FlapBird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            ;
        }

        public int voice;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var selected = (MMDevice)comboBox1.SelectedItem;
                voice = (int)(selected.AudioMeterInformation.MasterPeakValue * 100 + 0.5);
                progressBar1.Value = voice;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (voice > 25 && bird.Top > 30)
            {
                bird.Top += -3;

            }
            else
            {
                if (bird.Top < 430)
                    bird.Top += 3;
            }
        }
    }
}