using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatic_door_lock_face_recognition.Classess
{
    public static class TextBoxExtensions
    {
        public static void EnableAutoCapitalize(this TextBox textBox)
        {
            if (textBox == null) return;

            textBox.TextChanged += (s, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text)) return;

                int cursor = textBox.SelectionStart;
                string original = textBox.Text;

                StringBuilder sb = new StringBuilder(original.Length);

                bool capitalizeNext = true;

                foreach (char c in original)
                {
                    if (char.IsLetter(c))
                    {
                        if (capitalizeNext)
                        {
                            sb.Append(char.ToUpper(c));
                            capitalizeNext = false;
                        }
                        else
                        {
                            sb.Append(c);
                        }
                    }
                    else
                    {
                        sb.Append(c);
                        capitalizeNext = true; // next letter should be capitalized
                    }
                }

                string updatedText = sb.ToString();

                if (original != updatedText)
                {
                    textBox.Text = updatedText;
                    textBox.SelectionStart = cursor;
                }
            };
        }
    }

}
