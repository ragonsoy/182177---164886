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
        ManagerUserCollaborator managerUserCollaborator;
        ManagerTeam managerTeam;

        PersistenceUserCollaborator persistenceUserCollaborator;
        PersistenceUserAdministration persistenceUserAdministrator;
        PersistenceTeam persistenceTeam;

        public BoardAplication()
        {
            InitializeComponent();

            ShowLoginFuntions();

            persistenceUserCollaborator = new PersistenceUserCollaborator();
            persistenceUserAdministrator = new PersistenceUserAdministration();
            persistenceTeam = new PersistenceTeam();

            this.managerUserAdministrator = new ManagerUserAdministrator(persistenceUserAdministrator, persistenceUserCollaborator, persistenceTeam);
            this.managerUserCollaborator = new ManagerUserCollaborator(persistenceUserCollaborator);
            this.managerTeam = new ManagerTeam(persistenceTeam);

            dataTest();
           }

        private void dataTest()
        {
            dataTestUsers();
            dataTestTeams();
            dataTestAddUsersToTeams();
            dataTestAddBoardToTeams();
        }

        private void dataTestAddBoardToTeams()
        {
            managerTeam.SetActualTeam("team");
            managerTeam.AddBoard(managerUserCollaborator.GetUserCollaborator("collaborator"), "board", "description", 100, 100);
            managerTeam.AddBoard(managerUserCollaborator.GetUserCollaborator("c2"), "boardTest", "description", 100, 100);
        }

        private void dataTestUsers()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            managerUserAdministrator.CreateUserAdministrator("admim", "admin", "admin", birthDateUser, "admin");
            managerUserAdministrator.CreateUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            managerUserAdministrator.CreateUserCollaborator("c2", "c2", "c2", birthDateUser, "c2");
        }
        private void dataTestTeams()
        {
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            managerUserAdministrator.CreateTeam("team", birthDateUser, "description", 10);
            managerUserAdministrator.CreateTeam("team2", birthDateUser, "description", 10);
            managerUserAdministrator.CreateTeam("team3", birthDateUser, "description", 10);
            managerUserAdministrator.CreateTeam("team4", birthDateUser, "description", 10);
            managerUserAdministrator.CreateTeam("team5", birthDateUser, "description", 10);
        }

        private void dataTestAddUsersToTeams()
        {
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team2"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team3"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team4"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team5"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("c2"), managerTeam.GetTeam("team"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team3"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team5"));

        }

        private void ShowLoginFuntions()
        {
            radioButtonHome.Hide();
            radioButtonNewBoard.Hide();
            radioButtonUser.Hide();
            radioButtonTeam.Hide();
            radioButtonBoards.Hide();
            radioButtonInfor.Hide();
            radioButtonLogout.Hide();
            tabControlPrincipal.SelectedTab = tabPage1;
        }

        private void radioButtonHome_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage14;
            buttonEnterBoard.Hide();
            listBoxTeamBoards.Items.Clear();
        }

        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage2;
        }

        private void radioButtonTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage3;
            listAllUsersForNewTeam();
        }

        private void listAllUsersForNewTeam()
        {
            this.listBoxAllUsersForNewTeam.Items.Clear();
            this.listBoxAllUsersForNewTeam.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
        }

        private void radioButtonBoards_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage4;
            label28.Hide();
            listBoxSelectedTeamBoards.Hide();
            buttonDeleteSelectedBoardFromDeleteBoard.Hide();
            this.listBoxOfAllSystemTeams.Items.Clear();
            this.listBoxOfAllSystemTeams.Items.AddRange(managerUserAdministrator.GetAllTeam().ToArray());

        }

        private void radioButtonInfor_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage5;
        }
        
        private void radioButtonModifyUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage7;
            this.listBoxAllUserToModifyList.Items.Clear();
            this.listBoxAllUserToModifyList.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
        }

        private void radioButtonNewUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage6;
        }         
                
        private void radioButtonNewTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage9;
            listAllUsersForNewTeam();
        }

        private void radioButtonModifyTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlTeams.SelectedTab = tabPage10;
        }
                
        private void radioButtonNewBoard_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage11;
            this.listBoxTeamsNewBoard.Items.Clear();
            this.listBoxTeamsNewBoard.Items.AddRange(managerUserCollaborator.GetTeams().ToArray());
            HideNewBoardFormData();
        }

        private void HideNewBoardFormData()
        {
            label34.Hide();
            label33.Hide();
            label32.Hide();
            label31.Hide();
            textBoxNameNewBoard.Hide();
            textBoxDescriptionNewBoard.Hide();
            textBoxHeightNewBoard.Hide();
            textBoxWidthNewBoard.Hide();
            buttonCreateNewBoard.Hide();
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
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string email = textBoxLoginEmail.Text;
            if (managerUserAdministrator.ExistsUserAdministrator(email))
            {
                managerUserAdministrator.SetActualUserAdministrator(email);
                managerUserCollaborator.SetActualUser(email);
                if (managerUserAdministrator.PasswordCorrect(textBoxLoginPassword.Text))
                    ShowAdministratorFrontendFuntions();
                else
                    MessageBox.Show("La password es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (managerUserCollaborator.ExistsUserCollaborator(email))
                {
                    managerUserCollaborator.SetActualUser(email);
                    if (managerUserCollaborator.PasswordCorrect(textBoxLoginPassword.Text))
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
            radioButtonBoards.Show();
            ShowCollaboratorFrontendFuntions();
        }
        private void ShowCollaboratorFrontendFuntions()
        {
            radioButtonHome.Show();
            radioButtonNewBoard.Show();
            radioButtonLogout.Show();
            buttonDeleteSelectedBoard.Hide();
            buttonEnterBoard.Hide();
            tabControlPrincipal.SelectedTab = tabPage14;
            ShowTeamsActualUser();
        }

        private void ShowTeamsActualUser()
        {
            this.listBoxUserTeams.Items.Clear();
            this.listBoxUserTeams.Items.AddRange(managerUserCollaborator.GetTeams().ToArray());
        }

        private void buttonSelectTeam_Click(object sender, EventArgs e)
        {
            this.listBoxTeamBoards.Items.Clear();
            managerTeam.SetActualTeam(this.listBoxUserTeams.SelectedItem.ToString());
            this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
        }

        private void listBoxTeamBoards_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnterBoard.Show();
            if (managerUserAdministrator.ExistsUserAdministrator(managerUserCollaborator.GetIDActualUser()))
                this.buttonDeleteSelectedBoard.Show();
            else
            {
                if(managerTeam.UserIsCreatorBoard(managerUserCollaborator.GetActualUser(), listBoxTeamBoards.SelectedItem.ToString()))
                    this.buttonDeleteSelectedBoard.Show();
                else
                    this.buttonDeleteSelectedBoard.Hide();
            }
        }

        private void buttonDeleteSelectedBoard_Click(object sender, EventArgs e)
        {
            managerTeam.RemoveBoard(listBoxTeamBoards.SelectedItem.ToString());
            this.listBoxTeamBoards.Items.Clear();
            this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
            buttonDeleteSelectedBoard.Hide();
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {            
            if (ValidateFieldsNewUser())
            {
                string nameUser = textBoxNameNewUser.Text;
                string lastNameUser = textBoxLastNameNewUser.Text;
                DateTime birthDayUser = dateTimePickerNewUser.Value;
                string emailUser = textBoxEmailNewUser.Text;
                string passwordUser = textBoxPasswordNewUser.Text;
                if (radioButtonNewUserTypeAdministrator.Checked)
                    managerUserAdministrator.CreateUserCollaborator(nameUser, lastNameUser, emailUser, birthDayUser, passwordUser);
                else
                    managerUserAdministrator.CreateUserCollaborator(nameUser,lastNameUser,emailUser,birthDayUser,passwordUser);
                MessageBox.Show("Usuario agregado correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFieldsNewUser();
            }
        }

        private void ClearFieldsNewUser()
        {
            textBoxNameNewUser.Clear();
            textBoxLastNameNewUser.Clear();
            textBoxEmailNewUser.Clear();
            textBoxPasswordNewUser.Clear();
        }

        private bool ValidateFieldsNewUser()
        {
            if (textBoxNameNewUser.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxLastNameNewUser.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un apellido para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxEmailNewUser.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un e-mail para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxPasswordNewUser.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una password para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                
            return true;
        }

        private void buttonSelectUserToModify_Click(object sender, EventArgs e)
        {            
            textBoxNameUserToModify.Text = managerUserCollaborator.GetName(listBoxAllUserToModifyList.SelectedItem.ToString());
            textBoxLastNameUserToModify.Text = managerUserCollaborator.GetLastName(listBoxAllUserToModifyList.SelectedItem.ToString()); ;
            dateTimePickerModifyUser.Value = managerUserCollaborator.GetBirthDay(listBoxAllUserToModifyList.SelectedItem.ToString()); ;
            textBoxEmailUserToModify.Text = listBoxAllUserToModifyList.SelectedItem.ToString();
            textBoxPasswordUserToModify.Text = managerUserCollaborator.GetPassword(listBoxAllUserToModifyList.SelectedItem.ToString()); ;                      
        }

        private bool ValidateFieldsModifyUser()
        {
            if (textBoxNameUserToModify.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxLastNameUserToModify.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un apellido para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBoxEmailUserToModify.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un e-mail para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxPasswordUserToModify.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una password para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonModifyUser_Click(object sender, EventArgs e)
        {
            if (ValidateFieldsModifyUser())
            {
                string name = textBoxNameUserToModify.Text;
                string lastName = textBoxLastNameUserToModify.Text;
                DateTime birthDay = dateTimePickerModifyUser.Value;
                string email = textBoxEmailUserToModify.Text;
                string password = textBoxPasswordUserToModify.Text;
                managerUserAdministrator.ModifyUser(name, lastName,email,birthDay,password);
            }
        }       

        private void radioButtonLogout_CheckedChanged(object sender, EventArgs e)
        {
            ShowLoginFuntions();
        }

        private void buttonSelectTeamNewBoard_Click(object sender, EventArgs e)
        {
            ShowNewBoardFormData();
        }

        private void ShowNewBoardFormData()
        {
            label34.Show();
            label33.Show();
            label32.Show();
            label31.Show();
            textBoxNameNewBoard.Show();
            textBoxDescriptionNewBoard.Show();
            textBoxHeightNewBoard.Show();
            textBoxWidthNewBoard.Show();
            buttonCreateNewBoard.Show();
        }

        private void listBoxUserTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEnterBoard.Hide();
            buttonDeleteSelectedBoard.Hide();
            this.listBoxTeamBoards.Items.Clear();
            this.listBoxTeamBoards.Items.Clear();
            managerTeam.SetActualTeam(this.listBoxUserTeams.SelectedItem.ToString());
            this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
        }

        private void listBoxTeamsNewBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNewBoardFormData();
        }

        private void listBoxOfAllSystemTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            managerTeam.SetActualTeam(this.listBoxOfAllSystemTeams.SelectedItem.ToString());
            label28.Show();
            listBoxSelectedTeamBoards.Show();
            buttonDeleteSelectedBoardFromDeleteBoard.Hide();
            this.listBoxSelectedTeamBoards.Items.Clear();
            this.listBoxSelectedTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
        }

        private void listBoxSelectedTeamBoards_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteSelectedBoardFromDeleteBoard.Show();
        }

        private void buttonDeleteSelectedBoardFromDeleteBoard_Click(object sender, EventArgs e)
        {
            managerTeam.RemoveBoard(listBoxSelectedTeamBoards.SelectedItem.ToString());
            this.listBoxSelectedTeamBoards.Items.Clear();
            this.listBoxSelectedTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
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
            buttonRemoveUserOfModifyList.Hide();
            buttonAddUserOfModifyList.Hide();
            this.listBoxAllSystemUsers.Items.Clear();
            this.listBoxAllSystemUsers.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
        }

        private void listBoxAllSystemUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            label21.Show();
            listBoxSelectedUserTeams.Show();
            
            listBoxAllSystemTeams.Show();
            label20.Show();
            
            managerUserCollaborator.SetActualUser(this.listBoxAllSystemUsers.SelectedItem.ToString());
            RefreshListModifyUserToTeam();

        }

        private void buttonAddUserOfModifyList_Click(object sender, EventArgs e)
        {
            if (!managerTeam.TeamIsFull(listBoxAllSystemTeams.SelectedItem.ToString()))
            {
                managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator(listBoxAllSystemUsers.SelectedItem.ToString()), managerTeam.GetTeam(listBoxAllSystemTeams.SelectedItem.ToString()));
                RefreshListModifyUserToTeam();
            }
            else
                MessageBox.Show("El equipo esta completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRemoveUserOfModifyList_Click(object sender, EventArgs e)
        {
            if (!managerTeam.UniqueUser(listBoxAllSystemTeams.SelectedItem.ToString()))
            {
                managerUserAdministrator.RemoveUserToTeam(managerUserCollaborator.GetUserCollaborator(listBoxAllSystemUsers.SelectedItem.ToString()), managerTeam.GetTeam(listBoxAllSystemTeams.SelectedItem.ToString()));
                RefreshListModifyUserToTeam();
            }
            else
                MessageBox.Show("El equipo esta completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RefreshListModifyUserToTeam()
        {
            this.listBoxSelectedUserTeams.Items.Clear();
            this.listBoxSelectedUserTeams.Items.AddRange(managerUserCollaborator.GetTeams().ToArray());
            this.listBoxAllSystemTeams.Items.Clear();
            this.listBoxAllSystemTeams.Items.AddRange(managerUserAdministrator.GetAllTeamExceptTeamsUser(managerUserCollaborator.GetUserCollaborator(listBoxAllSystemUsers.SelectedItem.ToString())).ToArray());
        }

        private void listBoxSelectedUserTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Show();
            buttonRemoveUserOfModifyList.Show();
            label14.Hide();            
            buttonAddUserOfModifyList.Hide();
        }

        private void listBoxAllSystemTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            label13.Hide();
            buttonRemoveUserOfModifyList.Hide();
            label14.Show();
            buttonAddUserOfModifyList.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
