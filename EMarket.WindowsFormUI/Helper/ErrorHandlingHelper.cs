using System;
using System.Windows.Forms;

namespace EMarket.WindowsFormUI.Helper
{
    public static class ErrorHandlingHelper
    {
        public static void ErrorHandler(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(@"Please select the product");
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Please fill in the textboxes");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
