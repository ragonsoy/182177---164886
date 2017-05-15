using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplicationBusinessLogic.DomainPersistence;
using BoardApplicationBusinessLogic;

namespace BoardApplicationFacade
{
    public class ManagerTeam
    {
        PersistenceTeam persistenceTeams;
        Team team;
        public ManagerTeam(PersistenceTeam persistanceTeams)
        {
            this.persistenceTeams = persistanceTeams;
        }

        public void SetActualTeam(string name)
        {
            this.team = GetTeam(name);
        }
        public bool ExistsTeam(string name)
        {
            Team team = new Team(name);
            return persistenceTeams.ElementExist(team);
        }
        public Team GetTeam(string name)
        {
            Team team = new Team(name);
            return persistenceTeams.Get(team);
        }

        public void AddBoard(UserCollaborator user, string name, string description, int height, int width)
        {
            Board board = new Board(name, description, height, width, user);
            if (!team.ExistBoard(board))
            {
                team.AddBoard(board);
                persistenceTeams.Remove(team);
                persistenceTeams.Add(team);
            }
        }

        public List<Board> GetBoards()
        {
            return this.team.getBoards();
        }

        public bool UserIsCreatorBoard(UserCollaborator user, string nameBoard)
        {
            Board board = this.team.GetBoard(nameBoard);
            return board.IsUserCreator(user);
        }

        public void RemoveBoard(string nameBoard)
        {
            Board board = this.team.GetBoard(nameBoard);
            this.team.RemoveBoard(board);
            persistenceTeams.Remove(team);
            persistenceTeams.Add(team);
        }

        public bool TeamIsFull(string name)
        {
            Team team = this.GetTeam(name);
            return team.TeamFull();
        }

        public bool UniqueUser(string name)
        {
            Team team = this.GetTeam(name);
            return team.UniqueUser();
        }

        //public void ModifyTeam(string name, DateTime creationDate, string description, int maxUserCount)
        //{
        //    Team team = new Team(name, creationDate, description, maxUserCount);
        //    persistence.Remove(team);
        //    persistence.Add(team);
        //}

        //public void RemoveTeam(string name, DateTime creationDate, string description, int maxUserCount)
        //{
        //    Team team = new Team(name, creationDate, description, maxUserCount);
        //    persistence.Remove(persistence.Get(team));
        //}
    }
}
