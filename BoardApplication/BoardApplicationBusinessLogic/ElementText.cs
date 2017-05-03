using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    class ElementText : BoardElement
    {
        private List<Commentary> comentarysBoardElement;
        private int height;
        private int originPointX;
        private int originPointY;
        private int width;

        private string text { get; set; }
        private int fontSize { get; set; }
        private string font { get; set; }

        public ElementText(string text, int fontSize, string font, int originPointX, int originPointY, int height, int width, List<Commentary> comentarysBoardElement) :
            base (originPointX, originPointY, height, width, comentarysBoardElement)
        {
            this.text = text;
            this.fontSize = fontSize;
            this.font = font;
        }

    }
}
