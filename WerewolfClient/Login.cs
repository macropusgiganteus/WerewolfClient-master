using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WerewolfClient
{
    public partial class Login : Form, View
    {
        private WerewolfController controller;
        private Form _mainForm;
        public Login(Form MainForm)
        {
            InitializeComponent();
            _mainForm = MainForm;
        }

        public void Notify(Model m)
        {
            if (m is WerewolfModel)
            {
                WerewolfModel wm = (WerewolfModel)m;             
                switch (wm.Event)
                {
                    case WerewolfModel.EventEnum.SignIn:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            _mainForm.Visible = true;
                            this.Visible = false;
                        }  
                        else
                        {
                            MessageBox.Show("Login or password incorrect, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);           
                        }
                        break;
                    case WerewolfModel.EventEnum.SignUp:
                        if (wm.EventPayloads["Success"] == "True")
                        {
                            MessageBox.Show("Sign up successfuly, please login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MessageBox.Show("Username or password unavailable, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                }
            }
        }

        public void setController(Controller c)
        {
            controller = (WerewolfController)c;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if(Players.Text == "0")
            {
                MessageBox.Show("Please select server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                WerewolfCommand wcmd = new WerewolfCommand();
                wcmd.Action = WerewolfCommand.CommandEnum.SignIn;
                wcmd.Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", TBServer.Text } };
                if (TbLogin.Text == "" || TbPassword.Text == "")
                {
                    MessageBox.Show("Login or password incorrect, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    controller.ActionPerformed(wcmd);
                }
            }      
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            WerewolfCommand wcmd = new WerewolfCommand();
    
            if (TbLogin.Text == "" || TbPassword.Text == "")
            {
                MessageBox.Show("Login or password incorrect, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                    wcmd.Action = WerewolfCommand.CommandEnum.SignUp;
                    wcmd.Payloads = new Dictionary<string, string>() { { "Login", TbLogin.Text }, { "Password", TbPassword.Text }, { "Server", TBServer.Text } };
                    controller.ActionPerformed(wcmd);
            }

        }

        private void Btn2P_Click(object sender, EventArgs e)
        {
            TBServer.Text = "http://project-ile.net:2342/werewolf/";
            Players.Text = "2";
        }

        private void Btn4P_Click(object sender, EventArgs e)
        {
            TBServer.Text = "http://project-ile.net:2344/werewolf/";
            Players.Text = "4";
        }

        private void Btn16P_Click(object sender, EventArgs e)
        {
            TBServer.Text = "http://project-ile.net:23416/werewolf/";
            Players.Text = "16";
        }
        private void BtnLocalP_Click(object sender, EventArgs e)
        {
            TBServer.Text = "http://localhost:2343/werewolf/";
            Players.Text = "2";
        }

        
    }
}
