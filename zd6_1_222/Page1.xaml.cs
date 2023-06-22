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

    public partial class Page1 :ContentPage
    {
        private Label date2;
        private Button myButton;
        private Button myButton2;
        private Button myButton3;
        private Button myButton4;
        private Button myButton5;
        private Button myButton6;
        private Button myButton7;
        private Button myButton8;
        private Button myButton9;
        private Button myButton10;
        private Button myButton11;
        private Button myButton12;
        private Button myButton13;
        private Button myButton14;
        private Button myButton15;
        private Button myButton16;
        private Button myButton17;
        private Button myButton18;
        private Button myButton19;
        private Button myButton20;
        private Picker myPicker;
        private Switch CheckBox;
        private Switch CheckBox2;
        private Switch CheckBox3;
        private Switch CheckBox4;
        private Switch CheckBox5;
        private Switch CheckBox6;
        private Slider interestRateSlider1;
        private Slider interestRateSlider2;
        private Slider interestRateSlider3;
        private Slider interestRateSlider4;
        private Slider interestRateSlider5;
        public Page1 ()
        {
            InitializeComponent();
            date2 = new Label
            {
                TextColor = Color.Black,
                Text = $"Вы выбрали {10}"
            };


            myButton = new Button
            {
                Text = "BUTTON",
                StyleId = "stylebut",
                
            };
            myButton.Clicked += MyButton_Clicked;

            myButton2 = new Button
            {
                Text = "BUTTON",
                
                StyleId = "stylebut2",
                
            };
            myButton2.Clicked += MyButton_Clicked;

            myButton3 = new Button
            {
                Text = "BUTTON",
                
                StyleId = "stylebut3",
                
            };
            myButton3.Clicked += MyButton_Clicked;

            myButton4 = new Button
            {
                Text = "BUTTON",
               
                StyleId = "stylebut4",
                
            };
            myButton4.Clicked += MyButton_Clicked;

            myButton5 = new Button
            {
                Text = ">",
               
                StyleId = "stylebut",
               
            };
            myButton5.Clicked += MyButton_Clicked;

            myButton6 = new Button
            {
                Text = ">",

                StyleId = "stylebut2",
             
            };
            myButton6.Clicked += MyButton_Clicked;
            myButton7 = new Button
            {
                Text = ">",
      
                StyleId = "stylebut3",
                
            };
            myButton7.Clicked += MyButton_Clicked;
            myButton8 = new Button
            {
                Text = ">",
                
                StyleId = "stylebut4",
               
            };
            myButton8.Clicked += MyButton_Clicked;
            CheckBox = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };
            myButton9 = new Button
            {
                Text = "+",
              
                StyleId = "stylebut",
                
            };
            myButton9.Clicked += MyButton_Clicked;
            myButton10 = new Button
            {
                Text = "+",
                
                StyleId = "stylebut2",
              
            };
            myButton10.Clicked += MyButton_Clicked;
            myButton11 = new Button
            {
                Text = "+",
               
                StyleId = "stylebut3",
                
            };
            myButton11.Clicked += MyButton_Clicked;
            myButton12 = new Button
            {
                Text = "+",
              
                StyleId = "stylebut4",
              
            };
            myButton12.Clicked += MyButton_Clicked;
            myButton13 = new Button
            {
                Text = "▶",
               
                StyleId = "stylebut",
             
            };
            myButton13.Clicked += MyButton_Clicked;
            myButton14 = new Button
            {
                Text = "▶",
                
                StyleId = "stylebut2",
        
            };
            myButton14.Clicked += MyButton_Clicked;
            myButton15 = new Button
            {
                Text = "+",
               
                StyleId = "stylebut3",
               
            };
            myButton15.Clicked += MyButton_Clicked;
            myButton16 = new Button
            {
                Text = "▶",
               
                StyleId = "stylebut4",
             
            };
            myButton16.Clicked += MyButton_Clicked;
            myButton17 = new Button
            {
                Text = "✓",
              
                StyleId = "stylebut",
               
            };
            myButton17.Clicked += MyButton_Clicked;
            myButton18 = new Button
            {
                Text = "✓",
           
                StyleId = "stylebut2",
              
            };
            myButton18.Clicked += MyButton_Clicked;
            myButton19 = new Button
            {
                Text = "✓",
           
                StyleId = "stylebut3",
                
            };
            myButton19.Clicked += MyButton_Clicked;
            myButton20 = new Button
            {
                Text = "✓",
                //Margin = new Thickness(25, 25, 25, 25),
                StyleId = "stylebut4",
                //WidthRequest = 120
            };
            myButton20.Clicked += MyButton_Clicked;
            CheckBox.Toggled += (sender, e) =>
            {
                if (CheckBox.IsToggled)
                {
                    CheckBox.BackgroundColor = Color.Red;
                    CheckBox.ThumbColor = Color.White;
                    CheckBox.OnColor = Color.Red;
                } else
                {
                    CheckBox.BackgroundColor = Color.Gray;
                    CheckBox.ThumbColor = Color.White;
                    CheckBox.OnColor = Color.White;
                }
            };
            CheckBox2 = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };
            CheckBox2.Toggled += (sender, e) =>
            {
                if (CheckBox2.IsToggled)
                {
                    CheckBox2.BackgroundColor = Color.Red;
                    CheckBox2.ThumbColor = Color.White;
                    CheckBox2.OnColor = Color.Red;
                } else
                {
                    CheckBox2.BackgroundColor = Color.Gray;
                    CheckBox2.ThumbColor = Color.White;
                    CheckBox2.OnColor = Color.White;
                }
            };
            CheckBox3 = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White

            };
            CheckBox3.Toggled += (sender, e) =>
            {
                if (CheckBox3.IsToggled)
                {
                    CheckBox3.BackgroundColor = Color.Red;
                    CheckBox3.ThumbColor = Color.White;
                    CheckBox3.OnColor = Color.Red;
                } else
                {
                    CheckBox3.BackgroundColor = Color.Gray;
                    CheckBox3.ThumbColor = Color.White;
                    CheckBox3.OnColor = Color.White;
                }
            };
            CheckBox4 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,
            };

            CheckBox4.Toggled += (sender, e) =>
            {
                if (CheckBox4.IsToggled)
                {
                    CheckBox4.ThumbColor = Color.Red;
                    CheckBox4.OnColor = Color.Black;
                } else
                {
                    CheckBox4.ThumbColor = Color.Gray;
                    CheckBox4.OnColor = Color.Black;
                }
            };
            CheckBox5 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,

            };

            CheckBox5.Toggled += (sender, e) =>
            {
                if (CheckBox5.IsToggled)
                {
                    CheckBox5.ThumbColor = Color.Red;
                    CheckBox5.OnColor = Color.Black;
                } else
                {
                    CheckBox5.ThumbColor = Color.Gray;

                }
            };
            CheckBox6 = new Switch
            {
                OnColor = Color.Red,
                ThumbColor = Color.Gray,
                HorizontalOptions = LayoutOptions.EndAndExpand,

            };

            CheckBox6.Toggled += (sender, e) =>
            {
                if (CheckBox6.IsToggled)
                {
                    CheckBox6.ThumbColor = Color.Red;
                    CheckBox6.OnColor = Color.Black;
                } else
                {
                    CheckBox6.ThumbColor = Color.Gray;

                }
            };






            myPicker = new Picker
            {
                Title = "DROPDOWN",
                Margin = new Thickness(5, 0, 200, 0)
            };
            myPicker.Items.Add("Select One");
            myPicker.Items.Add("Select Two");
            myPicker.Items.Add("Select Three");
            myPicker.Items.Add("Select Four");
            myPicker.SelectedIndexChanged += MyPicker_SelectedIndexChanged;

            interestRateSlider1 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.White,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };

            interestRateSlider1 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.White,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider2 = new Slider
            {
                Minimum = 0,
                Maximum = 60,
                Value = 5,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider3 = new Slider
            {
                Minimum = 0,
                Maximum = 60,
                Value = 5,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider4 = new Slider
            {
                Minimum = 0,
                Maximum = 100,

                Value = 60,
                ThumbColor = Color.Gray,
                MinimumTrackColor = Color.Green,
                Margin = new Thickness(30, 0, 30, 0)
            };
            interestRateSlider5 = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 5,
                ThumbColor = Color.Gray,
                HeightRequest = 20,
                MinimumTrackColor = Color.White,
                Margin = new Thickness(30, 0, 150, 0),
            };



            Content = new StackLayout
            {
                BackgroundColor = Color.White,
                Padding = new Thickness(10, 10, 10, 0),
                Children =
                    {
                    new Grid
                    {
                         Children =
                         {
                            
                           { myButton5,0,0},
                           { myButton6,0,1},
                           { myButton7,0,2},
                           { myButton8,0,3},
                           { myButton9,1,0},
                           { myButton10,1,1},
                           { myButton11,1,2},
                           { myButton12,1,3},
                           { myButton13,2,0},
                           { myButton14,2,1},
                           { myButton15,2,2},
                           { myButton16,2,3},
                           { myButton17,3,0},
                           { myButton18,3,1},
                           { myButton19,3,2},
                            { myButton20,3,3},
                         }
                     },

                        new Grid
                    {
                         Children =
                         {

                           { myButton,0,0},
                           { myButton2,0,1},
                           { myButton3,1,0},
                           { myButton4,1,1},
                           
                         }
                     },
        //                    new StackLayout
        //                    {
        //                        Orientation = StackOrientation.Horizontal,
        //                        Children =

        //                        {
        //                            myButton2,
        //                            myButton6,
        //                            myButton10,
        //                            myButton14,
        //                            myButton18,
        //                        }
        //                    },
        //                    new StackLayout
        //                    {
        //                        Orientation = StackOrientation.Horizontal,
        //                        Children =

        //                        {
        //                            myButton3,
        //                            myButton7,
        //                            myButton11,
        //                            myButton15,
        //                            myButton19,
        //                        }
        //                    },
        //new StackLayout
        //{
        //    Orientation = StackOrientation.Horizontal,
        //    Children =
        //    {

        //         myButton4,
        //         myButton8,
        //         myButton12,
        //         myButton16,
        //         myButton20,
        //    }
        //},
        myPicker,
        new StackLayout
        {
            Orientation = StackOrientation.Horizontal,
            Children =
            {

                new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children =
                    {
                        CheckBox,
                        CheckBox2,
                        CheckBox3,
                    }
                },
                new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children =
                    {
                        CheckBox4,
                        CheckBox5,
                        CheckBox6,
                    }
                }
            }
        },
        interestRateSlider1,
        interestRateSlider2,
        interestRateSlider3,
        new Grid
        {
            Children =
            {
                { interestRateSlider4, 0, 0 },
                { interestRateSlider5, 0, 0 }
            }
        },

        date2,


                }
            };
        }
        private void MyPicker_SelectedIndexChanged (object sender, EventArgs e)
        {
            var selectedPickerItem = myPicker.SelectedItem as string;


            interestRateSlider1.IsVisible = false;
            interestRateSlider2.IsVisible = false;
            interestRateSlider3.IsVisible = false;
            interestRateSlider4.IsVisible = false;
            interestRateSlider5.IsVisible = false;

            switch (selectedPickerItem)
            {
                case "Select One":
                    interestRateSlider1.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider1.Value}";
                    break;
                case "Select Two":
                    interestRateSlider2.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider2.Value}";
                    break;
                case "Select Three":
                    interestRateSlider3.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider3.Value}";
                    break;
                case "Select Four":
                    interestRateSlider4.IsVisible = true;
                    interestRateSlider5.IsVisible = true;
                    date2.Text = $"Вы выбрали {interestRateSlider4.Value}";
                    break;
                default:
                    break;
            }
        }




        private void MyButton_Clicked (object sender, EventArgs e)
        {
            string selectedPickerItem = myPicker.SelectedItem as string;
            double sliderValue = interestRateSlider1.Value;

            Page2 page2 = new Page2(selectedPickerItem, sliderValue);
            Navigation.PushAsync(page2);
        }
    }
}