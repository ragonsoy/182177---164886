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
using BoardApplicationBusinessLogic.DomainPersistence;

namespace WindowsFormsApplication1
{
    public partial class BoardAplication : Form
    {
        ManagerUserAdministrator managerUserAdministrator;
        ManagerUserCollaborator managerUserCollabarator;
        ManagerTeam managerTeam;

        PersistenceUserCollaborator persistenceUserCollaborator;
        PersistenceUserAdministration persistenceUserAdministrator;
        PersistenceTeam persistenceTeam;

        public BoardAplication()
        {
            InitializeComponent();
            radioButtonHome.Hide();
            radioButtonNewBoard.Hide();
            radioButtonUser.Hide();
            radioButtonTeam.Hide();
            radioButtonBoards.Hide();
            radioButtonInfor.Hide();

            persistenceUserCollaborator = new PersistenceUserCollaborator();
            persistenceUserAdministrator = new PersistenceUserAdministration();
            persistenceTeam = new PersistenceTeam();

            this.managerUserAdministrator = new ManagerUserAdministrator(persistenceUserAdministrator, persistenceUserCollaborator, persistenceTeam);
            this.managerUserCollabarator = new ManagerUserCollaborator(persistenceUserCollaborator);
            this.managerTeam = new ManagerTeam(persistenceTeam);

            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            managerUserAdministrator.CreateUserAdministrator("admim","admin","admin", birthDateUser,"admin");
            managerUserAdministrator.CreateUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            managerUserAdministrator.CreateTeam("team", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("admin"),managerTeam.GetTeam("team"));
            managerUserAdministrator.CreateTeam("team2", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("admin"), managerTeam.GetTeam("team2"));
            managerUserAdministrator.CreateTeam("team3", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("admin"), managerTeam.GetTeam("team3"));
            managerUserAdministrator.CreateTeam("team4", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("admin"), managerTeam.GetTeam("team4"));
            managerUserAdministrator.CreateTeam("team5", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("admin"), managerTeam.GetTeam("team5"));
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team"));
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team3"));
            managerUserAdministrator.AddUserToTeam(managerUserCollabarator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team5"));
            managerTeam.SetActualTeam("team");
            managerTeam.AddBoard(managerUserCollabarator.GetUserCollaborator("collaborator"), "board", "description", 100, 100);
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
        
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage7;
        }

        private void radioButtonNewUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage6;
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
               
                
        private void radioButtonNewTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage9;
        }

        private void radioButtonModifyTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage10;
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxLoginEmail.Text;
            if (managerUserAdministrator.ExistsUserAdministrator(email))
            {
                managerUserAdministrator.SetActualUserAdministrator(email);
                managerUserCollabarator.SetActualUser(email);
                if (managerUserAdministrator.PasswordCorrect(textBoxLoginPassword.Text))
                    ShowAdministratorFrontendFuntions();
                else
                    MessageBox.Show("La password es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (managerUserCollabarator.ExistsUserCollaborator(email))
                {
                    managerUserCollabarator.SetActualUser(email);
                    if (managerUserCollabarator.PasswordCorrect(textBoxLoginPassword.Text))
                        ShowCollaboratorFrontendFuntions();
                    else
                        MessageBox.Show("La password es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                    MessageBox.Show("El usuario no existe en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAdministratorFrontendFuntions()
        {
            radioButtonNewBoard.Show();
            radioButtonUser.Show();
            radioButtonTeam.Show();
            radioButtonInfor.Show();
            ShowCollaboratorFrontendFuntions();
        }
        private void ShowCollaboratorFrontendFuntions()
        {
            radioButtonHome.Show();
            radioButtonNewBoard.Show();
            buttonDeleteSelectedBoard.Hide();

            tabControlPrincipal.SelectedTab = tabPage14;

            ShowTeamsActualUser();
        }

        private void ShowTeamsActualUser()
        {
            this.listBoxUserTeams.Items.AddRange(managerUserCollabarator.GetTeams().ToArray());
        }

        private void buttonSelectTeam_Click(object sender, EventArgs e)
        {
            managerTeam.SetActualTeam(this.listBoxUserTeams.SelectedItem.ToString());
            this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
        }

        private void listBoxTeamBoards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (managerUserAdministrator.ExistsUserAdministrator(managerUserCollabarator.GetIDActualUser()))
                this.buttonDeleteSelectedBoard.Show();
            else
            {
                if(managerTeam.UserIsCreatorBoard(managerUserCollabarator.GetActualUser(), listBoxTeamBoards.SelectedItem.ToString()))
                    this.buttonDeleteSelectedBoard.Show();
                else
                    this.buttonDeleteSelectedBoard.Hide();

            }
        }
    }
}
