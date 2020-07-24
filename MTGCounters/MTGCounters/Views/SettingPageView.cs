using System;
using System.Collections.Generic;
using System.Globalization;
using MTGCounters;
using Xamarin.Forms;


namespace MTGCounters
{
    public class SettingPageView : ContentPage
    {


        public SettingPageView()
        {

            BackgroundColor = Color.LightGray;
            //NavigationPage.SetHasNavigationBar(this, false);

            int CornerRadius = 100;
            int marginRadius = 5;
            int Radius = 55;

            Grid grid = new Grid
            {
                Margin = new Thickness(5),
                RowDefinitions =
                {
                   //Player names and text boxes
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   new RowDefinition { Height = Radius},
                   //prompt and starting health total
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   //Deck Color selection and prompt
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   new RowDefinition { Height = Radius},
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star)},
                   //get starting health totals
                   
                },
                ColumnDefinitions =
                {
                    //seperation for colors when sellecting for deck color
                    
                    new ColumnDefinition {Width = Radius},
                    new ColumnDefinition {Width = Radius},
                    new ColumnDefinition {Width = Radius},
                    new ColumnDefinition {Width = Radius},
                    new ColumnDefinition {Width = Radius},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)},

                }
            };

            var Plains = new Image
            {
                Source = "Plains.png",
                Margin = 8,
            };
            var Plains2 = new Image
            {
                Source = "Plains.png",
                Margin = 8,
            };
            var Island = new Image
            {
                Source = "Island.png",
                Margin = 8,
            };
            var Island2 = new Image
            {
                Source = "Island.png",
                Margin = 8,
            };
            var Swamp = new Image
            {
                Source = "Swamp.png",
                Margin = 8,
            };
            var Swamp2 = new Image
            {
                Source = "Swamp.png",
                Margin = 8,
            };
            var Mountain = new Image
            {
                Source = "Mountain.png",
                Margin = 8,
            };
            var Mountain2 = new Image
            {
                Source = "Mountain.png",
                Margin = 8,
            };
            var Forest = new Image
            {
                Source = "Forest.png",
                Margin = 8,
            };
            var Forest2 = new Image
            {
                Source = "Forest.png",
                Margin = 8,
            };

            Label Player1NameLabel = new Label
            {
                Text = "Player 1",
                TextColor = Color.Black,
                FontSize = 20,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.End,
            };

            grid.Children.Add(Player1NameLabel);
            Grid.SetColumnSpan(Player1NameLabel, 5);

            Editor Player1Name = new Editor
            {
                Placeholder = "Enter Name For Player 1",
                TextColor = Color.Black,
            };

            Player1Name.SetBinding(Editor.TextProperty, nameof(MainPageViewModel.Player1.name));

            grid.Children.Add(Player1Name, 0, 1);
            Grid.SetColumnSpan(Player1Name, 5);

            Label ColorSelection = new Label
            {
                Text = "Select the colors you are playing with",
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.End,
            };
            Label ColorSelection2 = new Label
            {
                Text = "Select the colors you are playing with",
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.End,
            };

            grid.Children.Add(ColorSelection, 0, 2);
            Grid.SetColumnSpan(ColorSelection, 6);

            grid.Children.Add(ColorSelection2, 0, 6);
            Grid.SetColumnSpan(ColorSelection2, 6);

            Button WhiteColorButton1 = new Button { };
            WhiteColorButton1.SetBinding(Button.CommandProperty, "WhiteButton1");

            BoxView White1Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
                BindingContext = MainPageViewModel.Player1,
            };

            var whiteConverter = new WhiteConverter();

            White1Box.SetBinding(BoxView.ColorProperty, nameof(MainPageViewModel.Player1.WhiteColor));

            grid.Children.Add(White1Box, 0, 3);

            grid.Children.Add(Plains, 0, 3);

            grid.Children.Add(WhiteColorButton1, 0, 3);
            WhiteColorButton1.BackgroundColor = Color.Transparent;

            Button BlueColorButton1 = new Button { };
            BlueColorButton1.SetBinding(Button.CommandProperty, "BlueButton1");

            BoxView Blue1Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
                BindingContext = MainPageViewModel.Player1,
            };
            var BlueConverter = new BlueConveter();

            Blue1Box.SetBinding(BoxView.ColorProperty, new Binding("MainPageViewModel.Player1.Blue") { Converter = BlueConverter });

            grid.Children.Add(Blue1Box, 1, 3);

            grid.Children.Add(Island, 1, 3);

            grid.Children.Add(BlueColorButton1, 1, 3);
            BlueColorButton1.BackgroundColor = Color.Transparent;

            Button BlackColorButton1 = new Button { };
            BlackColorButton1.SetBinding(Button.CommandProperty, "BlackButton1");

            BoxView Black1Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
                BindingContext = MainPageViewModel.Player1,
            };
            Black1Box.SetBinding(BoxView.ColorProperty, new Binding("MainPageViewModel.Player1.Black") { Converter = BlueConverter });

            grid.Children.Add(Black1Box, 2, 3);

            grid.Children.Add(Swamp, 2, 3);

            grid.Children.Add(BlackColorButton1, 2, 3);
            BlackColorButton1.BackgroundColor = Color.Transparent;

            Button RedColorButton1 = new Button { };
            RedColorButton1.SetBinding(Button.CommandProperty, "RedButton1");

            BoxView Red1Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
            };
            Red1Box.SetBinding(BoxView.ColorProperty, nameof(MainPageViewModel.Player1.RedColor));

            grid.Children.Add(Red1Box, 3, 3);

            grid.Children.Add(Mountain, 3, 3);

            grid.Children.Add(RedColorButton1, 3, 3);
            RedColorButton1.BackgroundColor = Color.Transparent;

            Button GreenColorButton1 = new Button { };
            GreenColorButton1.SetBinding(Button.CommandProperty, "GreenButton1");

            BoxView Green1Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
                BindingContext = MainPageViewModel.Player1,
            };
            Green1Box.SetBinding(BoxView.ColorProperty, "GreenColor");

            grid.Children.Add(Green1Box, 4, 3);

            grid.Children.Add(Forest, 4, 3);

            grid.Children.Add(GreenColorButton1, 4, 3);
            GreenColorButton1.BackgroundColor = Color.Transparent;



            Button WhiteColorButton2 = new Button { };
            WhiteColorButton2.SetBinding(Button.CommandProperty, "WhiteButton2");

            BoxView White2Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
            };
            White2Box.SetBinding(BoxView.ColorProperty, "White2Box");
            grid.Children.Add(White2Box, 0, 7);

            grid.Children.Add(Plains2, 0, 7);

            grid.Children.Add(WhiteColorButton2, 0, 7);
            WhiteColorButton2.BackgroundColor = Color.Transparent;

            Button BlueColorButton2 = new Button { };
            BlueColorButton2.SetBinding(Button.CommandProperty, "BlueButton2");

            BoxView Blue2Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
            };
            Blue2Box.SetBinding(BoxView.ColorProperty, "Blue2Box");
            grid.Children.Add(Blue2Box, 1, 7);

            grid.Children.Add(Island2, 1, 7);

            grid.Children.Add(BlueColorButton2, 1, 7);
            BlueColorButton2.BackgroundColor = Color.Transparent;

            Button BlackColorButton2 = new Button { };
            BlackColorButton2.SetBinding(Button.CommandProperty, "BlackButton2");

            BoxView Black2Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
            };
            Black2Box.SetBinding(BoxView.ColorProperty, "Black2Box");

            grid.Children.Add(Black2Box, 2, 7);

            grid.Children.Add(Swamp2, 2, 7);

            grid.Children.Add(BlackColorButton2, 2, 7);
            BlackColorButton2.BackgroundColor = Color.Transparent;

            Button RedColorButton2 = new Button { };
            RedColorButton2.SetBinding(Button.CommandProperty, "RedButton2");

            BoxView Red2Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
            };
            Red2Box.SetBinding(BoxView.ColorProperty, "Red2Box");

            grid.Children.Add(Red2Box, 3, 7);

            grid.Children.Add(Mountain2, 3, 7);

            grid.Children.Add(RedColorButton2, 3, 7);
            RedColorButton2.BackgroundColor = Color.Transparent;

            Button GreenColorButton2 = new Button { };
            GreenColorButton2.SetBinding(Button.CommandProperty, "GreenButton2");

            BoxView Green2Box = new BoxView
            {
                Margin = marginRadius,
                BackgroundColor = Color.Gray,
                CornerRadius = CornerRadius,
                HeightRequest = Radius,
                WidthRequest = Radius,
            };
            Green2Box.SetBinding(BoxView.ColorProperty, "Green2Box");

            grid.Children.Add(Green2Box, 4, 7);

            grid.Children.Add(Forest2, 4, 7);

            grid.Children.Add(GreenColorButton2, 4, 7);
            GreenColorButton2.BackgroundColor = Color.Transparent;

            Label Player2NameLabel = new Label
            {
                Text = "Player 2",
                FontSize = 20,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Start,
                VerticalTextAlignment = TextAlignment.End,
            };

            grid.Children.Add(Player2NameLabel, 0, 4);
            Grid.SetColumnSpan(Player2NameLabel, 5);

            Editor Player2Name = new Editor
            {
                Placeholder = "Enter Name For Player 2",
                TextColor = Color.Black,
            };
            Player2Name.SetBinding(Editor.TextProperty, "Player2Name");

            grid.Children.Add(Player2Name, 0, 5);
            Grid.SetColumnSpan(Player2Name, 5);

            List<string> Startinghealth = new List<string>();
            Startinghealth.Add("20");
            Startinghealth.Add("30");
            Startinghealth.Add("40");
            Picker StartingHealth = new Picker
            {
                Title = "Choose the amount of starting health",
                FontSize = 20,
                ItemsSource = Startinghealth,
                SelectedIndex = 0,
                SelectedItem = "20",
            };
            StartingHealth.SetBinding(Picker.SelectedItemProperty, "Player1.SelectedHealthValue");
            StartingHealth.SetBinding(Picker.SelectedItemProperty, nameof(MainPageViewModel.Player2.SelectedHealthValue));

            grid.Children.Add(StartingHealth, 0, 8);
            Grid.SetColumnSpan(StartingHealth, 7);

            Button SubmitButton = new Button
            {
                Text = "Submit Settings",
                TextColor = Color.DarkGray,
                FontSize = 20,
                BackgroundColor = Color.PowderBlue,
            };
            SubmitButton.SetBinding(Button.CommandProperty, "SubmitButton");
            SubmitButton.SetBinding(Button.TextColorProperty, "SubmitButtonText");
            SubmitButton.SetBinding(Button.BackgroundColorProperty, "SubmitButtonReadyBackground");

            grid.Children.Add(SubmitButton, 0, 9);
            Grid.SetColumnSpan(SubmitButton, 7);

            BindingContext = Application.Current.BindingContext;
            Content = grid;

        }

    }

    public class WhiteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                return value.ToString() == "true" ? "Color.LightGoldenrodYellow" : "Color.Gray";
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class BlueConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                if (value.ToString() == "true")
                    return Color.LightSkyBlue;

                return Color.Gray;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}