using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardApplicationFacade;
using BoardApplicationBusinessLogic;

namespace WindowsFormsApplication1
{
    public partial class BoardAplication : Form
    {
        ManagerUserAdministrator managerUserAdministrator;
        public BoardAplication()
        {
            InitializeComponent();
            radioButtonHome.Hide();
            radioButtonNewBoard.Hide();
            radioButtonUser.Hide();
            radioButtonTeam.Hide();
            radioButtonBoards.Hide();
            radioButtonInfor.Hide();

            this.managerUserAdministrator = new ManagerUserAdministrator();
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            managerUserAdministrator.CreateUserAdministrator("admim","admin","admin", birthDateUser,"admin");
            managerUserAdministrator.CreateUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
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
            tabControlPrincipal.SelectedTab = tabPage14;
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
            label21.Hide();
            listBoxSelectedUserTeams.Hide();
            label13.Hide();
            label14.Hide();
            listBoxAllSystemTeams.Hide();
            label20.Hide();
            buttonAddUserToModifyTeam.Hide();
            buttonRemoveUserOfModifyList.Hide();
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

        private void radioButtonNewTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage9;
        }

        private void radioButtonModifyTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage10;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user;
            string email = textBoxLoginEmail.Text;
            if (managerUserAdministrator.ExistsUserAdministrator(email))
            {
                user = managerUserAdministrator.GetUserAdministrator(email);
                if (managerUserAdministrator.PasswordCorrect(user, textBoxLoginPassword.Text))
                {
                    radioButtonHome.Show();
                    radioButtonNewBoard.Show();
                    radioButtonUser.Show();
                    radioButtonTeam.Show();
                    radioButtonBoards.Show();
                    radioButtonInfor.Show();

                    tabControlPrincipal.SelectedTab = tabPage14;
                }
                else {
                    MessageBox.Show("La password es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (managerUserAdministrator.ExistsUserCollaborator(email))
                {
                    user = managerUserAdministrator.GetUserAdministrator(email);
                    if (managerUserAdministrator.PasswordCorrect(user, textBoxLoginPassword.Text))
                    {
                        radioButtonHome.Show();
                        radioButtonNewBoard.Show();

                        tabControlPrincipal.SelectedTab = tabPage14;
                    } else {
                        MessageBox.Show("La password es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void buttonUserToAddToATeam_Click(object sender, EventArgs e)
        {
            label21.Show();
            listBoxSelectedUserTeams.Show();
            label13.Show();
            label14.Show();
            listBoxAllSystemTeams.Show();
            label20.Show();
            buttonAddUserToModifyTeam.Show();
            buttonRemoveUserOfModifyList.Show();

        }
    }
}
