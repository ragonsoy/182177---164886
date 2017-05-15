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
            this.managerUserCollaborator = new ManagerUserCollaborator(persistenceUserCollaborator);
            this.managerTeam = new ManagerTeam(persistenceTeam);

            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            managerUserAdministrator.CreateUserAdministrator("admim","admin","admin", birthDateUser,"admin");
            managerUserAdministrator.CreateUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            managerUserAdministrator.CreateTeam("team", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"),managerTeam.GetTeam("team"));
            managerUserAdministrator.CreateTeam("team2", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team2"));
            managerUserAdministrator.CreateTeam("team3", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team3"));
            managerUserAdministrator.CreateTeam("team4", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team4"));
            managerUserAdministrator.CreateTeam("team5", birthDateUser, "description", 10);
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("admin"), managerTeam.GetTeam("team5"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team3"));
            managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator("collaborator"), managerTeam.GetTeam("team5"));
            managerTeam.SetActualTeam("team");
            managerTeam.AddBoard(managerUserCollaborator.GetUserCollaborator("collaborator"), "board", "description", 100, 100);
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
            buttonRemoveUserOfModifyList.Show();
            buttonAddUserOfModifyList.Show();

            RefreshListModifyUserToTeam();
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
            this.listBoxSelectedUserTeams.Items.AddRange(managerUserCollaborator.GetTeams(listBoxAllSystemUsers.SelectedItem.ToString()).ToArray());

            this.listBoxAllSystemTeams.Items.Clear();
            this.listBoxAllSystemTeams.Items.AddRange(managerUserAdministrator.GetAllTeamExceptTeamsUser(managerUserCollaborator.GetUserCollaborator(listBoxAllSystemUsers.SelectedItem.ToString())).ToArray());
            
        }
    }
}
