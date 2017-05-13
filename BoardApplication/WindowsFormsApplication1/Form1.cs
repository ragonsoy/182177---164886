using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //radioButtonInfor.Hide(); ejemplo de esconder boton (dependeria del usuario)
        }

        
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonHome_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage1;
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage2;
        }

        private void radioButtonTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage3;
        }

        private void radioButtonBoards_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage4;
        }

        private void radioButtonInfor_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage5;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void tabPage6_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage7;
        }

        private void radioButtonNewUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage6;
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonAddUserToTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage8;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void listBoxUsersToAddToTeam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonNewTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage9;
        }

        private void radioButtonModifyTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage10;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonNewBoard_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage11;
        }

        private void radioButtonBoardCreatedByTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlInforms.SelectedTab = tabPage12;
        }

        private void radioButtonCommentartResovedByUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlInforms.SelectedTab = tabPage13;
        }
    }
}
