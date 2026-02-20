using QuorumAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayWare
{
    public partial class Form1 : Form
    {
        private QuorumModule quorum;
        public Form1()
        {
            QuorumAPI.QuorumModule.SetAttachNotify("RayWare", "Attached successfully!");
            bool isAttached = quorum.IsAttached();
            InitializeComponent();
            //velocity api
            quorum = new QuorumModule();
            quorum.StartCommunication();
        }
        private async void attachbtn_Click(object sender, EventArgs e)
        {
            await quorum.AttachAPI();
        }

        private void executebtn_Click(object sender, EventArgs e)
        {
            quorum.ExecuteScript(scriptbox.Text);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            quorum.StartCommunication();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            quorum.StopCommunication();
            Application.Exit();
        }
        private void killrbxbtn_Click(object sender, EventArgs e)
        {
            QuorumAPI.QuorumModule.KillRoblox();
        }
    }
}
