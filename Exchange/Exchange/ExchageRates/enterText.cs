namespace Exchange
{
    using System;
    using System.Windows.Forms;
    public class Key
    {
        public static void EnterText(KeyPressEventArgs key)
        {
            char validate = key.KeyChar;
            if (!Char.IsDigit(validate) && validate != 44 && validate != 08)
            {
                key.Handled = true;
            }
        }
    }
}
