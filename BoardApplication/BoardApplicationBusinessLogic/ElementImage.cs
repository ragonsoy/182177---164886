using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class ElementImage : BoardElement
    {
        private List<Commentary> comentarysBoardElement;
        private int height;
        private int originPointX;
        private int originPointY;
        private int width;
        private string url;

        public ElementImage(string url, int originPointX, int originPointY, int height, int width, List<Commentary> comentarysBoardElement) :
            base (originPointX, originPointY, height, width, comentarysBoardElement)
        {
            this.url = url;
        }

        public string GetUrl()
        {
            return this.url;
        }

        public void SetUrl(string url)
        {
            this.url = url;
        }

    }
}
