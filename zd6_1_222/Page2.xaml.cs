using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_1_222
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 :ContentPage
    {
        public Page2 (string selectedPickerItem, double sliderValue)
        {
            InitializeComponent();
        }
    }
}