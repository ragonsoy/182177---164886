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
            ShowPanel();        
        }

        public void ShowPanel()
        {
            Board board = managerTeam.GetBoard(nameBoard);
            this.panelBoard.Height = board.getHeight();
            this.panelBoard.Width = board.getWidth();
        }       

    }
}
