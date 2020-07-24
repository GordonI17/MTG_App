using System;
using System.ComponentModel;
using Xamarin.Forms;
namespace MTGCounters
{
    public class SettingsPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public SettingsPageViewModel()
        {
            bool IsWhite1 = false;
            bool IsBlue1 = false;
            bool IsBlack1 = false;
            bool IsRed1 = false;
            bool IsGreen1 = false;
            WhiteButton1 = new Command(() =>
            {
                if (IsWhite1 == false)
                {
                    White1Box = "Color.LightGoldenrodYellow";
                    IsWhite1 = true;
                }
                else
                {
                    White1Box = "Color.Gray";
                    IsWhite1 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("White1Box"));
            });

            BlueButton1 = new Command(() =>
            {
                if (IsBlue1 == false)
                {
                    Blue1Box = "Color.DeepSkyBlue";
                    IsBlue1 = true;
                }
                else
                {
                    Blue1Box = "Color.Gray";
                    IsBlue1 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue1Box"));
            });

            BlackButton1 = new Command(() =>
            {
                if (IsBlack1 == false)
                {
                    Black1Box = "Color.MediumPurple";
                    IsBlack1 = true;
                }
                else
                {
                    Black1Box = "Color.Gray";
                    IsBlack1 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Black1Box"));
            });

            RedButton1 = new Command(() =>
            {
                if (IsRed1 == false)
                {
                    Red1Box = "Color.IndianRed";
                    IsRed1 = true;
                }
                else
                {
                    Red1Box = "Color.Gray";
                    IsRed1 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red1Box"));
            });

            GreenButton1 = new Command(() =>
            {
                if (IsGreen1 == false)
                {
                    Green1Box = "Color.LightGreen";
                    IsGreen1 = true;
                }
                else
                {
                    Green1Box = "Color.Gray";
                    IsGreen1 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green1Box"));
            });

            bool IsWhite2 = false;
            bool IsBlue2 = false;
            bool IsBlack2 = false;
            bool IsRed2 = false;
            bool IsGreen2 = false;
            WhiteButton2 = new Command(() =>
            {
                if (IsWhite2 == false)
                {
                    White2Box = "Color.LightGoldenrodYellow";
                    IsWhite2 = true;
                }
                else
                {
                    White2Box = "Color.Gray";
                    IsWhite2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("White2Box"));
            });

            BlueButton2 = new Command(() =>
            {
                if (IsBlue2 == false)
                {
                    Blue2Box = "Color.DeepSkyBlue";
                    IsBlue2 = true;
                }
                else
                {
                    Blue2Box = "Color.Gray";
                    IsBlue2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue2Box"));
            });

            BlackButton2 = new Command(() =>
            {
                if (IsBlack2 == false)
                {
                    Black2Box = "Color.MediumPurple";
                    IsBlack2 = true;
                }
                else
                {
                    Black2Box = "Color.Gray";
                    IsBlack2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Black2Box"));
            });

            RedButton2 = new Command(() =>
            {
                if (IsRed2 == false)
                {
                    Red2Box = "Color.IndianRed";
                    IsRed2 = true;
                }
                else
                {
                    Red2Box = "Color.Gray";
                    IsRed2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red2Box"));
            });

            GreenButton2 = new Command(() =>
            {
                if (IsGreen2 == false)
                {
                    Green2Box = "Color.LightGreen";
                    IsGreen2 = true;
                }
                else
                {
                    Green2Box = "Color.Gray";
                    IsGreen2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green2Box"));
            });

            SubmitSettings = new Command(() =>
            {

            });

            
        }


        public string Player1Name
        {
            get;
            set;
        }
        public string Player2Name
        {
            get;
            set;
        }

        public string White1Box { get; set; }
        public string Blue1Box { get; set; }
        public string Black1Box { get; set; }
        public string Red1Box { get; set; }
        public string Green1Box { get; set; }

        public string White2Box { get; set; }
        public string Blue2Box { get; set; }
        public string Black2Box { get; set; }
        public string Red2Box { get; set; }
        public string Green2Box { get; set; }

        public string SubmitButtonReadyBackground { get; set; }
        public string SubmitButtonReadyText { get; set; }
        public string SelectedItem { get; set; }

        public Command WhiteButton1 { get; set; }
        public Command BlueButton1 { get; set; }
        public Command BlackButton1 { get; set; }
        public Command RedButton1 { get; set; }
        public Command GreenButton1 { get; set; }

        public Command WhiteButton2 { get; set; }
        public Command BlueButton2 { get; set; }
        public Command BlackButton2 { get; set; }
        public Command RedButton2 { get; set; }
        public Command GreenButton2 { get; set; }

        public Command SubmitSettings { get; set; }
    }
}
