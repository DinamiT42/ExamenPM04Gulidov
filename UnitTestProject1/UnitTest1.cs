using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Text10To50_Menshe_ReturnsFalse()
        {
            string name = "ab412";

            bool result = IsNameValid(name);

            
            Assert.IsFalse(result);
        }


        public void Text10To50_Bolshe_ReturnsFalse()
        {
            
            string name = "12345678901";

            
            bool result = IsNameValid(name);

            
            Assert.IsFalse(result);
        }


        public void Text10To50_ReturnsTrue()
        {
            
            string name1 = "abc";
            string name2 = "abcdefghijklmno";

     
            bool result1 = IsNameValid(name1);
            bool result2 = IsNameValid(name2);

            
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
        }

        private bool IsNameValid(string name)
        {
            if (name.Length < 10 || name.Length > 50)
            {
                return false;
            }

         
            return true;
        }

        public void PreviewTextInput_ValidInput_NoError()
        {
            TextBox textBox = new TextBox();
            TextCompositionEventArgs args = new TextCompositionEventArgs(null, new TextComposition(InputManager.Current, textBox, "1"));

            textBoxminus_PreviewTextInput(textBox, args);

            Assert.IsFalse(args.Handled);
        }

        private void textBoxminus_PreviewTextInput(TextBox textBox, TextCompositionEventArgs args)
        {
            throw new NotImplementedException();
        }

        public void PreviewTextInput_InvalidInput_Error()
        {
            TextBox textBox = new TextBox();
            TextCompositionEventArgs args = new TextCompositionEventArgs(null, new TextComposition(InputManager.Current, textBox, "-"));
            textBoxminus_PreviewTextInput(textBox, args);
            Assert.IsTrue(args.Handled);
        }
    }
}