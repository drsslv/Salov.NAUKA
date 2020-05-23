using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salov.NAUKA
{
    // класс наследованный от TextBox, добавляем возможность Placeholder 
   public  class TextBoxWithPlaceHolder: TextBox
    {
        public string Placeholder { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (!DesignMode)
            {
                Text = Placeholder;
            }
        }
        // отображает заполнитель при активном фокусе поля
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);

            if (Text.Equals(string.Empty))
            {
                Text = Placeholder;
            }
        }
        
        //Убирает заполнитель при фокусе поля 
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            if (Text.Equals(Placeholder))
            {
                Text = string.Empty;
            }
        }
    }
}
