using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Palindrom_App
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        public void over(object sender, EventArgs e)
        {
            if (overeni(text.Text) == true)
            {
                vys.Text = "Jedná se o palindrom";
            }
            else
            {
                vys.Text = "Nejedná se o palindrom";
                
            }
        }
        public static bool overeni(string retezec)
        {
            char[] array = retezec.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);
            if (retezec == backwards)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
