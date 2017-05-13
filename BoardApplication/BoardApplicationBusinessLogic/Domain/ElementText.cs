using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class ElementText : BoardElement
    {
        private List<Commentary> comentarysBoardElement;
        private int height;
        private int originPointX;
        private int originPointY;
        private int width;

        private string text;
        private int fontSize;
        private string font;

        public ElementText(string text, int fontSize, string font, int originPointX, int originPointY, int height, int width, List<Commentary> comentarysBoardElement) :
            base (originPointX, originPointY, height, width, comentarysBoardElement)
        {
            this.text = text;
            this.fontSize = fontSize;
            this.font = font;
        }

        public string getText()
        {
            return this.text;
        }

        public void setText(string text)
        {
            this.text = text;
        }

        public int getFontSize()
        {
            return this.fontSize;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public string getFont()
        {
            return this.font;
        }

        public void setFont(string font)
        {
            this.font = font;
        }

    }
}
