using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class BoardElement
    {
        private List<Commentary> comentarysBoardElement;
        private int height;
        private int originPointX;
        private int originPointY;
        private int width;

        public BoardElement(int originPointX, int originPointY, int height, int width, List<Commentary> comentarysBoardElement)
        {
            this.originPointX = originPointX;
            this.originPointY = originPointY;
            this.height = height;
            this.width = width;
            this.comentarysBoardElement = comentarysBoardElement;
        }

        public int GetOriginPointX()
        {
            return this.originPointX;
        }

        public void SetOriginPointX(int originPointX)
        {
            this.originPointX = originPointX;
        }

        public int GetOriginPointY()
        {
            return this.originPointY;
        }

        public void SetOriginPointY(int originPointY)
        {
            this.originPointY = originPointY;
        }

        public int GetHeigh()
        {
            return this.height;
        }

        public void SetHeigh(int height)
        {
            this.height = height;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void AddCommentary(Commentary commentary)
        {
            this.comentarysBoardElement.Add(commentary);
        }

        public List<Commentary> GetComentarys()
        {
            return this.comentarysBoardElement;
        }

        
    }
}
