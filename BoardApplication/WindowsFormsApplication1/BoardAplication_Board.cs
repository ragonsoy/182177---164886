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
    public partial class BoardAplication_Board : Form
    {
        ManagerTeam managerTeam;
        PersistenceTeam persistenceTeam;
        string nameBoard;
        public BoardAplication_Board(string nameTeam, string nameBoard, PersistenceTeam persistenceTeam)
        {
            InitializeComponent();
            this.persistenceTeam = persistenceTeam;
            this.Text = nameBoard;
            this.nameBoard = nameBoard;
            this.managerTeam = new ManagerTeam(persistenceTeam);
            managerTeam.SetActualTeam(nameTeam);
            ShowElementsBoard();
        }

        public void ShowElementsBoard()
        {
            Label newLabel = new Label();
            newLabel.Text = "Elemento";
            newLabel.Visible = true;
            newLabel.Show();
            this.panelBoard.Controls.Add(newLabel);
        }

        public void ShowCommentariesBoard()
        {
            this.listBoxComentaryOfSelectedElement.Items.Clear();
            
            //this.listBoxComentaryOfSelectedElement.Items.AddRange(managerTeam.GetCommentaries(nameBoard));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
