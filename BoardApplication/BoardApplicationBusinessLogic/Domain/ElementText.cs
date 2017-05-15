using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApplicationBusinessLogic
{
    public class ElementText : BoardElement
    {
        private string text;
        private Size fontSize;
        private Font font;

        public ElementText(string text, Size fontSize, Font font, int originPointX, int originPointY, int height, int width, List<Commentary> comentarysBoardElement) :
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

        public Size getFontSize()
        {
            return this.fontSize;
        }

        public void setFontSize(Size fontSize)
        {
            this.fontSize = fontSize;
        }

        public Font getFont()
        {
            return this.font;
        }

        public void setFont(Font font)
        {
            this.font = font;
        }

    }
}
