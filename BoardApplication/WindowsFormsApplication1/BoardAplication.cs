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
        private ManagerUserAdministrator managerUserAdministrator;
        private ManagerUserCollaborator managerUserCollaborator;
        private ManagerTeam managerTeam;

        private PersistenceUserCollaborator persistenceUserCollaborator;
        private PersistenceUserAdministration persistenceUserAdministrator;
        private PersistenceTeam persistenceTeam;

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
            try { 
                managerTeam.SetActualTeam("team");
                managerTeam.CreationBoard(managerUserCollaborator.GetUserCollaborator("collaborator"), "board", "description", 100, 100);
                managerTeam.CreationBoard(managerUserCollaborator.GetUserCollaborator("c2"), "boardTest", "description", 100, 100);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dataTestUsers()
        {
            try { 
            DateTime birthDateUser = new DateTime();
            DateTime.TryParse("1/1/2000", out birthDateUser);
            managerUserAdministrator.CreateUserAdministrator("admim", "admin", "admin", birthDateUser, "admin");
            managerUserAdministrator.CreateUserCollaborator("collaborator", "collaborator", "collaborator", birthDateUser, "collaborator");
            managerUserAdministrator.CreateUserCollaborator("c2", "c2", "c2", birthDateUser, "c2");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void dataTestTeams()
        {
            try { 
                DateTime birthDateUser = new DateTime();
                DateTime.TryParse("1/1/2000", out birthDateUser);
                managerUserAdministrator.CreateTeam("team", birthDateUser, "description", 10);
                managerUserAdministrator.CreateTeam("team2", birthDateUser, "description", 10);
                managerUserAdministrator.CreateTeam("team3", birthDateUser, "description", 10);
                managerUserAdministrator.CreateTeam("team4", birthDateUser, "description", 10);
                managerUserAdministrator.CreateTeam("team5", birthDateUser, "description", 10);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dataTestAddUsersToTeams()
        {
            try { 
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

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
            try {
                this.listBoxAllUsersForNewTeam.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void radioButtonBoards_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage4;
            label28.Hide();
            listBoxSelectedTeamBoards.Hide();
            buttonDeleteSelectedBoardFromDeleteBoard.Hide();
            this.listBoxOfAllSystemTeams.Items.Clear();
            try { 
                this.listBoxOfAllSystemTeams.Items.AddRange(managerUserAdministrator.GetAllTeam().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void radioButtonInfor_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage5;
            label37.Hide();
            listBoxInformAllBoardsByTeam.Hide();
            this.listBoxInformAllTeams.Items.Clear();
            try { 
                this.listBoxInformAllTeams.Items.AddRange(managerUserAdministrator.GetAllTeam().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        
        private void radioButtonModifyUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlUsers.SelectedTab = tabPage7;
            this.listBoxAllUserToModifyList.Items.Clear();
            try { 
                this.listBoxAllUserToModifyList.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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
            ListBoxAllTeamsModify();
        }

        private void ListBoxAllTeamsModify()
        {
            this.listBoxAllTeams.Items.Clear();
            try { 
                this.listBoxAllTeams.Items.AddRange(managerUserAdministrator.GetAllTeam().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void radioButtonNewBoard_CheckedChanged(object sender, EventArgs e)
        {
            tabControlPrincipal.SelectedTab = tabPage11;
            this.listBoxTeamsNewBoard.Items.Clear();
            try { 
                this.listBoxTeamsNewBoard.Items.AddRange(managerUserCollaborator.GetTeams().ToArray());
                HideNewBoardFormData();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }            
        }

        private void HideNewBoardFormData()
        {
            label34.Hide();
            label33.Hide();
            label32.Hide();
            label31.Hide();
            textBoxNameNewBoard.Hide();
            textBoxDescriptionNewBoard.Hide();
            numericBoxHeightNewBoard.Hide();
            numericBoxWidthNewBoard.Hide();
            buttonCreateNewBoard.Hide();
        }     
        
        private void radioButtonBoardCreatedByTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabControlInforms.SelectedTab = tabPage12;
            label54.Hide();
            listBoxInformAllBoardsByTeam.Hide();
            this.listBoxInformAllTeams.Items.Clear();
            try
            {
                this.listBoxInformAllTeams.Items.AddRange(managerUserAdministrator.GetAllTeam().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void radioButtonCommentartResovedByUser_CheckedChanged(object sender, EventArgs e)
        {
            tabControlInforms.SelectedTab = tabPage13;
            label38.Hide();
            listBoxInformCommentaryResolvedByUser.Hide();
            this.listBoxInformAllUsers.Items.Clear();
            try
            {
                this.listBoxInformAllUsers.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
                

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try {
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
            try
            {
                this.listBoxUserTeams.Items.Clear();
                this.listBoxUserTeams.Items.AddRange(managerUserCollaborator.GetTeams().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonSelectTeam_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBoxTeamBoards.Items.Clear();
                managerTeam.SetActualTeam(this.listBoxUserTeams.SelectedItem.ToString());
                this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void listBoxTeamBoards_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonDeleteSelectedBoard_Click(object sender, EventArgs e)
        {
            try { 
                managerTeam.RemoveBoard(listBoxTeamBoards.SelectedItem.ToString());
                this.listBoxTeamBoards.Items.Clear();
                this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
                buttonDeleteSelectedBoard.Hide();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            try {    
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
            try
            {
                textBoxNameUserToModify.Text = managerUserCollaborator.GetName(listBoxAllUserToModifyList.SelectedItem.ToString());
                textBoxLastNameUserToModify.Text = managerUserCollaborator.GetLastName(listBoxAllUserToModifyList.SelectedItem.ToString());
                dateTimePickerModifyUser.Value = managerUserCollaborator.GetBirthDay(listBoxAllUserToModifyList.SelectedItem.ToString());
                textBoxEmailUserToModify.Text = listBoxAllUserToModifyList.SelectedItem.ToString();
                textBoxPasswordUserToModify.Text = managerUserCollaborator.GetPassword(listBoxAllUserToModifyList.SelectedItem.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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
            try { 
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
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }       

        private void radioButtonLogout_CheckedChanged(object sender, EventArgs e)
        {
            ShowLoginFuntions();
        }        

        private void listBoxUserTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                buttonEnterBoard.Hide();
                buttonDeleteSelectedBoard.Hide();
                this.listBoxTeamBoards.Items.Clear();
                this.listBoxTeamBoards.Items.Clear();
                managerTeam.SetActualTeam(this.listBoxUserTeams.SelectedItem.ToString());
                this.listBoxTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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
            numericBoxHeightNewBoard.Show();
            numericBoxWidthNewBoard.Show();
            buttonCreateNewBoard.Show();
        }

        private void listBoxTeamsNewBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowNewBoardFormData();
        }

        private void listBoxOfAllSystemTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                label28.Show();
                listBoxSelectedTeamBoards.Show();
                buttonDeleteSelectedBoardFromDeleteBoard.Hide();
                managerTeam.SetActualTeam(this.listBoxOfAllSystemTeams.SelectedItem.ToString());
                this.listBoxSelectedTeamBoards.Items.Clear();
                this.listBoxSelectedTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void listBoxSelectedTeamBoards_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDeleteSelectedBoardFromDeleteBoard.Show();
        }

        private void buttonDeleteSelectedBoardFromDeleteBoard_Click(object sender, EventArgs e)
        {
            try
            {
                managerTeam.RemoveBoard(listBoxSelectedTeamBoards.SelectedItem.ToString());
                this.listBoxSelectedTeamBoards.Items.Clear();
                this.listBoxSelectedTeamBoards.Items.AddRange(managerTeam.GetBoards().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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
            try
            {
                this.listBoxAllSystemUsers.Items.Clear();
                this.listBoxAllSystemUsers.Items.AddRange(managerUserAdministrator.GetAllUser().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void listBoxAllSystemUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label21.Show();
                listBoxSelectedUserTeams.Show();

                listBoxAllSystemTeams.Show();
                label20.Show();

                managerUserCollaborator.SetActualUser(this.listBoxAllSystemUsers.SelectedItem.ToString());
                RefreshListModifyUserToTeam();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonAddUserOfModifyList_Click(object sender, EventArgs e)
        {
            try
            {
                if (!managerTeam.TeamIsFull(listBoxAllSystemTeams.SelectedItem.ToString()))
                {
                    managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator(listBoxAllSystemUsers.SelectedItem.ToString()), managerTeam.GetTeam(listBoxAllSystemTeams.SelectedItem.ToString()));
                    RefreshListModifyUserToTeam();
                }
                else
                    MessageBox.Show("El equipo esta completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
}

        private void buttonRemoveUserOfModifyList_Click(object sender, EventArgs e)
        {
            try
            {
                if (!managerTeam.UniqueUser(listBoxSelectedUserTeams.SelectedItem.ToString()))
                {
                    managerUserAdministrator.RemoveUserToTeam(managerUserCollaborator.GetUserCollaborator(listBoxAllSystemUsers.SelectedItem.ToString()), managerTeam.GetTeam(listBoxSelectedUserTeams.SelectedItem.ToString()));
                    RefreshListModifyUserToTeam();
                }
                else
                    MessageBox.Show("El equipo esta completo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
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

        private void buttonCreateNewBoard_Click(object sender, EventArgs e)
        {
            try
            { 
                managerTeam.SetActualTeam(listBoxTeamsNewBoard.SelectedItem.ToString());
                if (ValidateFieldsNewBoard())
                {
                    string nameBoard = textBoxNameNewBoard.Text;
                    string descriptionBoard = textBoxDescriptionNewBoard.Text;
                    int heightBoard = (int)numericBoxHeightNewBoard.Value;
                    int widthBoard = (int)numericBoxWidthNewBoard.Value;                
                    managerTeam.CreationBoard(managerUserCollaborator.GetActualUser(),nameBoard, descriptionBoard, heightBoard, widthBoard);
                    MessageBox.Show("Pizarron agregado correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFieldsNewBoard();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ClearFieldsNewBoard()
        {
            textBoxNameNewBoard.Clear();
            textBoxDescriptionNewBoard.Clear();
            numericBoxHeightNewBoard.Value = 1;
            numericBoxWidthNewBoard.Value = 1;
        }

        private bool ValidateFieldsNewBoard()
        {
            if (ExistOtherBoardWithTheSameNameInTheTeam())
            {
                MessageBox.Show("Este equipo ya tiene un pizarron con este nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxNameNewBoard.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el pizarron", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxDescriptionNewBoard.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para el pizarron", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numericBoxHeightNewBoard.Value == 0)
            {
                MessageBox.Show("Debe ingresar una altura para el pizarron", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numericBoxWidthNewBoard.Value == 0)
            {
                MessageBox.Show("Debe ingresar un ancho para el pizarron", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ExistOtherBoardWithTheSameNameInTheTeam()
        {
            try
            {
                return managerTeam.ExistOtherBoardWithTheSameNameInTheTeam(textBoxNameNewBoard.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
}

        private void listBoxInformAllTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            { 
                label37.Show();
                listBoxInformAllBoardsByTeam.Show();
                managerTeam.SetActualTeam(this.listBoxInformAllTeams.SelectedItem.ToString());
                this.listBoxInformAllBoardsByTeam.Items.Clear();
                this.listBoxInformAllBoardsByTeam.Items.AddRange(managerTeam.GetBoards().ToArray());
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void listBoxInformAllUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            label54.Show();
            listBoxInformCommentaryResolvedByUser.Show();
            string usuarioSeleccionado = this.listBoxInformAllUsers.SelectedItem.ToString();
            this.listBoxInformCommentaryResolvedByUser.Items.Clear();
            // cargar info de comentarios resuletos por este usuario, pasando el email del usuario seleccionado.
        }

        private void buttonEnterBoard_Click(object sender, EventArgs e)
        {
            string nameBoard = this.listBoxTeamBoards.SelectedItem.ToString();
            string nameTeam = this.listBoxUserTeams.SelectedItem.ToString();
            BoardAplication_Board board = new BoardAplication_Board(nameTeam, nameBoard, persistenceTeam);
            board.Show();
        }

        private void buttonAddNewTeam_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFieldsNewTeam())
                {
                    if (!managerTeam.ExistsTeam(textBoxNameNewTeam.Text))
                    {
                        string name = textBoxNameNewTeam.Text;
                        string description = textBoxDescriptionNewTeam.Text;
                        int maxUsersTeam = (int)numericBoxMaxUsersNewTeam.Value;
                        managerUserAdministrator.CreateTeam(name, DateTime.Now.Date, description, maxUsersTeam);
                        AddListUsersNewTeam();
                        MessageBox.Show("El equipo ha sido creado correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFieldsNewTeam();
                    }
                    else
                        MessageBox.Show("El nombre del equipo ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void AddListUsersNewTeam()
        {
            try
            {
                for (int i = 0; i < listBoxUsersForNewTeam.Items.Count; i++)
                    managerUserAdministrator.AddUserToTeam(managerUserCollaborator.GetUserCollaborator(listBoxUsersForNewTeam.Items[i].ToString()), managerTeam.GetTeam(textBoxNameNewTeam.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void ClearFieldsNewTeam()
        {
            textBoxNameNewTeam.Clear();
            textBoxDescriptionNewTeam.Clear();
            numericBoxMaxUsersNewTeam.Value = 1;
        }

        private bool ValidateFieldsNewTeam()
        {
            if (ListUserNewTeamEmpty())
            {
                MessageBox.Show("Debe ingresar al menos un usuario al equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (ListUserNewTeamOverflow())
            {
                MessageBox.Show("El equipo tiene un maximo de usuarios menor a los usuarios seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxNameNewTeam.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBoxDescriptionNewTeam.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numericBoxMaxUsersNewTeam.Value == 0)
            {
                MessageBox.Show("Debe ingresar un maximo de usuarios mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool ListUserNewTeamEmpty()
        {
            try
            {
                return listBoxUsersForNewTeam.Items.Count == 0;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
        }

        private bool ListUserNewTeamOverflow()
        {
            try
            {
                return listBoxUsersForNewTeam.Items.Count > numericBoxMaxUsersNewTeam.Value;
            }            
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }            
        }

        private void buttonRemoveUserToNewTeam_Click(object sender, EventArgs e)
        {
            try
            {
                this.listBoxUsersForNewTeam.Items.Remove(listBoxUsersForNewTeam.SelectedItem);
            }            
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonAddUserToNewTeam_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.listBoxUsersForNewTeam.Items.Contains(listBoxAllUsersForNewTeam.SelectedItem))
                    this.listBoxUsersForNewTeam.Items.Add(listBoxAllUsersForNewTeam.SelectedItem);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void listBoxAllTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTeamNameToModify.Text = listBoxAllTeams.SelectedItem.ToString();
                textBoxDescriptionOfTeamToModify.Text = managerTeam.GetDescription(listBoxAllTeams.SelectedItem.ToString());
                numericBoxMaxUserTeamToModify.Value = managerTeam.GetMaxUserTeam(listBoxAllTeams.SelectedItem.ToString());
            }         
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
        }

        private void buttonModifySelectedTeam_Click(object sender, EventArgs e)
        {
            try { 
                if (ValidateFieldsModifyTeam())
                {
                    string nameTeam = textBoxTeamNameToModify.Text;
                    string descriptionTeam = textBoxDescriptionOfTeamToModify.Text;
                    int maxUserTeam = (int)numericBoxMaxUserTeamToModify.Value;
                    managerUserAdministrator.ModifyTeam(nameTeam, descriptionTeam, maxUserTeam);
                    MessageBox.Show("El equipo ha sido modificado correctamente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFieldsModifyTeam();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
        }

        private void ClearFieldsModifyTeam()
        {
            textBoxTeamNameToModify.Clear();
            textBoxDescriptionOfTeamToModify.Clear();
            numericBoxMaxUserTeamToModify.Value = 1;
        }

        private bool ValidateFieldsModifyTeam()
        {
            if (textBoxDescriptionOfTeamToModify.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una descripcion para el equipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numericBoxMaxUserTeamToModify.Value == 0)
            {
                MessageBox.Show("Debe ingresar un maximo de usuarios mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numericBoxMaxUserTeamToModify.Value == managerTeam.GetMaxUserTeam(listBoxAllTeams.SelectedItem.ToString()))
            {
                MessageBox.Show("El equipo esta integrado por mas usuario que el numero maximo especificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
