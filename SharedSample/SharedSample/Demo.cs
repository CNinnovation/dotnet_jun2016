using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace SharedSample
{
    public class Demo
    {
        public void ShoWMessage(string message)
        {
#if WPF
            MessageBox.Show(message);
#else
            Console.WriteLine(message);
#endif
        }

    }
}
