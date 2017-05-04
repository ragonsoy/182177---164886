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

        public string GetText()
        {
            return this.text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public int GetFontSize()
        {
            return this.fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

        public string GetFont()
        {
            return this.font;
        }

        public void SetFont(string font)
        {
            this.font = font;
        }

    }
}
