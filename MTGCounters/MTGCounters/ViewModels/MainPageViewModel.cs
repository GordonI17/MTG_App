using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MTGCounters
{
    
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        bool health1IsSelected = true;
        bool experience1IsMain = false;
        bool commander1IsMain = false;
        bool poison1IsMain = false;
        bool health2IsMain = true;
        bool experience2IsMain = false;
        bool commander2IsMain = false;
        bool poison2IsMain = false;
        int player1commander = 0;
        int player2commander = 0;
        int player1experience = 0;
        int player2experience = 0;
        int player1poison = 0;
        int player2poison = 0;

        public string Current1 = "Color.Black";
        public string Current2 = "Color.Black";

        public static PlayerModel Player1 { get; set; }
        public PlayerModel Player2 = new PlayerModel();

        public MainPageViewModel()
        {
            Player1 = new PlayerModel();
            ResetGame();
            
            ColorReset2();
            ColorProperties1();
            ColorProperties2();
            Player1AddButton = new Command(() =>
            {
                
            });

            Player1SubtractButton = new Command(() =>
            {
               
            });

            Player2AddButton = new Command(() =>
            {
                if (health2IsMain)
                {
                    player2health++;
                    Health2 = Convert.ToString(player2health);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
                else if (experience2IsMain)
                {
                    player2experience++;
                    Health2 = Convert.ToString(player2experience);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
                else if (commander2IsMain)
                {
                    player2commander++;
                    Health2 = Convert.ToString(player2commander);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
                else if (poison2IsMain)
                {
                    player2poison++;
                    Health2 = Convert.ToString(player2poison);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
            });

            Player2SubtractButton = new Command(() =>
            {
                if (health2IsMain)
                {
                    player2health--;
                    Health2 = Convert.ToString(player2health);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
                else if (experience2IsMain)
                {
                    player2experience--;
                    Health2 = Convert.ToString(player2experience);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
                else if (commander2IsMain)
                {
                    player2commander--;
                    Health2 = Convert.ToString(player2commander);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
                else if (poison2IsMain)
                {
                    player2poison--;
                    Health2 = Convert.ToString(player2poison);
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                }
            });
            
            StartGame = new Command(() =>
            {
                ResetGame();
            });

            CommanderDamage1 = new Command(() =>
            {
                Player1.SelectedHealth = HealthValue.Commander;
            });

            PoisonCounter1 = new Command(() =>
            {
                if (poison1IsMain == false)
                {
                    ResetMainPage1();
                    health1IsSelected = false;
                    poison1IsMain = true;
                    Health1 = Convert.ToString(player1poison);
                    Poison1 = Convert.ToString(player1health);
                    Player1Label1Color = "Color.Green";
                    Player1Label3Color = Current1;
                    Player1Label1off = "Color.White";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label1Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label1off"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label3Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1"));
                    Health1IsMain = "false";
                    Poison1IsMain = "true";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1IsMain"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1IsMain"));
                    Poison1Inverse = "false";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1Inverse"));
                }
                else
                {
                    ResetMainPage1();
                }
            });

            Player1Experience = new Command(() =>
            {
                if (experience1IsMain == false)
                {
                    ResetMainPage1();
                    experience1IsMain = true;
                    health1IsSelected = false;
                    Health1 = Convert.ToString(player1health);
                    Experience1 = Convert.ToString(player1experience);
                    Player1Label1Color = "Color.Blue";
                    Player1Label4Color = Current1;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label1Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label4Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1"));
                    Health1IsMain = "false";
                    Experience1IsMain = "true";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1IsMain"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1IsMain"));
                    Experience1Inverse = "false";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1Inverse"));
                }
                else
                {
                    ResetMainPage1();
                }
            });

            CommanderDamage2 = new Command(() =>
            {
                if (commander2IsMain == false)
                {
                    ResetMainPage2();
                    health2IsMain = false;
                    commander2IsMain = true;
                    Health2 = Convert.ToString(player2commander);
                    Commander2 = Convert.ToString(player2health);
                    Player2Label1Color = "Color.Gold";
                    Player2Label2Color = Current2;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label1Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label2Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2"));
                    Health2IsMain = "false";
                    Commander2IsMain = "true";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2IsMain"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2IsMain"));
                    Commander2Inverse = "false";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2Inverse"));

                }
                else
                {
                    ResetMainPage2();
                }
            });

            PoisonCounter2 = new Command(() =>
            {
                if (poison2IsMain == false)
                {
                    ResetMainPage2();
                    health2IsMain = false;
                    poison2IsMain = true;
                    Health2 = Convert.ToString(player2poison);
                    Poison2 = Convert.ToString(player2health);
                    Player2Label1Color = "Color.Green";
                    Player2Label3Color = Current2;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label1Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label3Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2"));
                    Health2IsMain = "false";
                    Poison2IsMain = "true";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2IsMain"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2IsMain"));
                    Poison2Inverse = "false";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2Inverse"));
                }
                else
                {
                    ResetMainPage2();
                }
            });

            Player2Experience = new Command(() =>
            {
                if (experience2IsMain == false)
                {
                    ResetMainPage2();
                    experience2IsMain = true;
                    health2IsMain = false;
                    Health2 = Convert.ToString(player2experience);
                    Experience2 = Convert.ToString(player2health);
                    Player2Label1Color = "Color.Blue";
                    Player2Label4Color = Current2;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label1Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label4Color"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2"));
                    Health2IsMain = "false";
                    Experience2IsMain = "true";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2IsMain"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2IsMain"));
                    Experience2Inverse = "false";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2Inverse"));
                }
                else
                {
                    ResetMainPage2();
                }
            });

            SettingPage = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PushAsync(new SettingPageView());
            });

            WhiteButton1 = new Command(() =>
            {
                if (Player1.White == false)
                {
                    Player1.WhiteColor = "Color.LightGoldenrodYellow";
                    Player1.White = true;
                }
                else
                {
                    Player1.WhiteColor = "Color.Gray";
                    Player1.White = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1"));
            });

            BlueButton1 = new Command(() =>
            {
                if (Player1.Blue == false)
                {
                    Blue1Box = "Color.DeepSkyBlue";
                    Player1.Blue = true;
                }
                else
                {
                    Blue1Box = "Color.Gray";
                    Player1.Blue = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1"));
            });

            BlackButton1 = new Command(() =>
            {
                if (Player1.Black == false)
                {
                    Black1Box = "Color.MediumPurple";
                    Player1.Black = true;
                }
                else
                {
                    Black1Box = "Color.Gray";
                    Player1.Black = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Black1Box"));
            });

            RedButton1 = new Command(() =>
            {
                if (Player1.Red == false)
                {
                    Player1.RedColor = Color.IndianRed;
                    Player1.Red = true;
                }
                else
                {
                    Player1.RedColor = Color.Gray;
                    Player1.Red = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red1Box"));
            });

            GreenButton1 = new Command(() =>
            {
                if (Player1.Green == "false")
                {
                    Player1.Green = "true";
                    Player1.GreenColor = "Color.LightGreen";
                }
                else
                {
                    Player1.Green = "false";
                    Player1.GreenColor = "Color.Gray";
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1"));
            });

            WhiteButton2 = new Command(() =>
            {
                if (White2 == false)
                {
                    White2Box = "Color.LightGoldenrodYellow";
                    White2 = true;
                }
                else
                {
                    White2Box = "Color.Gray";
                    White2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("White2Box"));
            });

            BlueButton2 = new Command(() =>
            {
                if (Blue2 == false)
                {
                    Blue2Box = "Color.DeepSkyBlue";
                    Blue2 = true;
                }
                else
                {
                    Blue2Box = "Color.Gray";
                    Blue2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue2Box"));
            });

            BlackButton2 = new Command(() =>
            {
                if (Black2 == false)
                {
                    Black2Box = "Color.MediumPurple";
                    Black2 = true;
                }
                else
                {
                    Black2Box = "Color.Gray";
                    Black2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Black2Box"));
            });

            RedButton2 = new Command(() =>
            {
                if (Red2 == false)
                {
                    Red2Box = "Color.IndianRed";
                    Red2 = true;
                }
                else
                {
                    Red2Box = "Color.Gray";
                    Red2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red2Box"));
            });

            GreenButton2 = new Command(() =>
            {
                if (Green2 == false)
                {
                    Green2Box = "Color.LightGreen";
                    Green2 = true;
                }
                else
                {
                    Green2Box = "Color.Gray";
                    Green2 = false;
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green2Box"));
            });

            SubmitButton = new Command(async() =>
            {
                ResetGame();
                await Application.Current.MainPage.Navigation.PopAsync();
                int i = 0;
                if(Player1.White == true)
                {
                    i++;
                }
                if (Player1.Blue == true)
                {
                    i++;
                }
                if (Player1.Black == true)
                {
                    i++;
                }
                if (Player1.Red == true)
                {
                    i++;
                }
                if (Player1.Green == "true")
                {
                    i++;
                }
                NumberOfColors1 = i;
                if(NumberOfColors1 == 1)
                {
                    if (Player1.White)
                    {
                        Current1 = "Color.White";
                    }
                    else if (Player1.Blue)
                    {
                        Current1 = "Color.White";
                    }
                    else if (Player1.Black)
                    {
                        Current1 = "Color.White";
                    }
                    else if (Player1.Red)
                    {
                        Current1 = "Color.White";
                    }
                    else if (Player1.Green == "true")
                    {
                        Current1 = "Color.White";
                    }
                    ColorProperties1();
                }
                else if(NumberOfColors1 == 2)
                {
                    if (Player1.Blue && Player1.Red)
                    {
                        Current1 = "Color.Black";
                    }                
                    if (Player1.Black && Player1.White)
                    {
                        Current1 = "Color.Black";
                    }
                    if (Player1.Blue && Player1.White)
                    {
                        Current1 = "Color.Black";
                    }
                    if (Player1.Red && Player1.White)
                    {
                        Current1 = "Color.Black";
                    }
                    if (Player1.Blue && Player1.Black)
                    {
                       Current1 = "Color.White";
                    }
                    if (Player1.Green == "true" && Player1.Black)
                    {
                        Current1 = "Color.White";
                    }
                    if (Player1.Red && Player1.Green == "true")
                    {
                        Current1 = "Color.White";
                    }
                    if (Player1.Red && Player1.Black)
                    {
                        Current1 = "Color.White";
                    }
                    if (Player1.Green == "true" && Player1.White)
                    {
                        Current1 = "Color.Black";
                    }
                    if (Player1.Blue && Player1.Green == "true")
                    {
                        Current1 = "Color.Black";
                    }
                }
                else if (NumberOfColors1 == 3)
                {

                }
                else if (NumberOfColors1 == 4)
                {

                }
                else
                {

                }

                int j = 0;
                if(White2 == true)
                {
                    j++;
                }
                if (Blue2 == true)
                {
                    j++;
                }
                if (Black2 == true)
                {
                    j++;
                }
                if (Red2 == true)
                {
                    j++;
                }
                if (Green2 == true)
                {
                    j++;
                }
                NumberOfColors2 = j;
                if (NumberOfColors2 == 1)
                {
                    if (White2)
                    {
                        ColorReset2();
                        White2text = "true";
                        Current2 = "Color.White";
                    }
                    if (Blue2)
                    {
                        ColorReset2();
                        Blue2text = "true";
                        Current2 = "Color.White";
                    }
                    if (Black2)
                    {
                        ColorReset2();
                        Black2text = "true";
                        Current2 = "Color.White";
                    }
                    if (Red2)
                    {
                        ColorReset2();
                        Red2text = "true";
                        Current2 = "Color.White";
                    }
                    if (Green2)
                    {
                        ColorReset2();
                        Green2text = "true";
                        Current2 = "Color.White";
                    }
                    ColorProperties2();

                }
                else if (NumberOfColors2 == 2)
                {
                    if (Blue2 == true && Red2 == true)
                    {
                        ColorReset2();
                        Izzet2 = "true";
                        Current2 = "Color.Black";
                    }
                    if (Black2 == true && White2 == true)
                    {
                        ColorReset2();
                        Orzhov2 = "true";
                        Current2 = "Color.Black";
                    }
                    if (Blue2 == true && White2 == true)
                    {
                        ColorReset2();
                        Azorius2 = "true";
                        Current2 = "Color.Black";
                    }
                    if (Red2 == true && White2 == true)
                    {
                        ColorReset2();
                        Boros2 = "true";
                        Current2 = "Color.Black";
                    }
                    if (Blue2 == true && Black2 == true)
                    {
                        ColorReset2();
                        Dimir2 = "true";
                        Current2 = "Color.White";
                    }
                    if (Green2 == true && Black2 == true)
                    {
                        ColorReset2();
                        Golgari2 = "true";
                        Current2 = "Color.White";
                    }
                    if (Red2 == true && Green2 == true)
                    {
                        ColorReset2();
                        Gruul2 = "true";
                        Current2 = "Color.White";
                    }
                    if (Red2 == true && Black2 == true)
                    {
                        ColorReset2();
                        Rakdos2 = "true";
                        Current2 = "Color.White";
                    }
                    if (Green2 == true && White2 == true)
                    {
                        ColorReset2();
                        Selesnya2 = "true";
                        Current2 = "Color.Black";
                    }
                    if (Blue2 == true && Green2 == true)
                    {
                        ColorReset2();
                        Simic2 = "true";
                        Current2 = "Color.Black";
                    }
                    ColorProperties2();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2")); 
                }
                Player1Label1Color = Current1;
                Player2Label1Color = Current2;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label1Color"));
            });
            
        }
        public int player1health = 20;
        public int player2health = 20;

        public string OneColor { get; set; }
        public string OneColor2 { get; set; }

        public bool White2 { get; set; } = false;
        public bool Blue2 { get; set; } = false;
        public bool Black2 { get; set; } = false;
       public bool Green2 { get; set; } = false;
        public bool Red2 { get; set; } = false;

        public string White2text { get; set; } = "false";
        public string Blue2text { get; set; } = "false";
        public string Black2text { get; set; } = "false";
        public string Red2text { get; set; } = "false";
        public string Green2text { get; set; } = "false";

        public int NumberOfColors1 { get; set; }
        public int NumberOfColors2 { get; set; }

        public string Player1Label1Color { get; set; } = "Color.Black";
        public string Player1Label2Color { get; set; } = "Color.Gold";
        public string Player1Label3Color { get; set; } = "Color.Green";
        public string Player1Label4Color { get; set; } = "Color.Blue";
        public string Player1Label1off { get; set; } = "Color.Black";

        public string Player2Label1Color { get; set; } = "Color.Black";
        public string Player2Label2Color { get; set; } = "Color.Gold";
        public string Player2Label3Color { get; set; } = "Color.Green";
        public string Player2Label4Color { get; set; } = "Color.Blue";

        public string Health1IsMain { get; set; } = "true";
        public string Experience1IsMain { get; set; }  = "false";
        public string Commander1IsMain { get; set; }  = "false";
        public string Poison1IsMain { get; set; }  = "false";
        public string Health2IsMain { get; set; }  = "true";
        public string Experience2IsMain { get; set; }  = "false";
        public string Commander2IsMain { get; set; }  = "false";
        public string Poison2IsMain { get; set; }  = "false";
        public string Experience1Inverse { get; set; } = "true";
        public string Poison1Inverse { get; set; } = "true";
        public string Commander1Inverse { get; set; } = "true";
        public string Experience2Inverse { get; set; } = "true";
        public string Poison2Inverse { get; set; } = "true";
        public string Commander2Inverse { get; set; } = "true";

        public string Health1 { get; set; } = "20";
        public string Health2 { get; set; } = "20";

        public string Commander1 { get; set; }
        public string Commander2 { get; set; }

        public string Experience1 { get; set; }
        public string Experience2 { get; set; }

        public string Poison1 { get; set; }
        public string Poison2 { get; set; }

        //2 colors
        public bool Izzet1 { get; set; } = false;
        public string Izzet2 { get; set; } = "false";

        public string Orzhov1 { get; set; } = "false";
        public string Orzhov2 { get; set; } = "false";

        public string Azorius1 { get; set; } = "false";
        public string Azorius2 { get; set; } = "false";

        public string Boros1 { get; set; } = "false";
        public string Boros2 { get; set; } = "false";

        public string Dimir1 { get; set; } = "false";
        public string Dimir2 { get; set; } = "false";

        public string Golgari1 { get; set; } = "false";
        public string Golgari2 { get; set; } = "false";

        public string Gruul1 { get; set; } = "false";
        public string Gruul2 { get; set; } = "false";

        public string Rakdos1 { get; set; } = "false";
        public string Rakdos2 { get; set; } = "false";

        public string Selesnya1 { get; set; } = "false";
        public string Selesnya2 { get; set; } = "false";

        public string Simic1 { get; set; } = "false";
        public string Simic2 { get; set; } = "false";

        //3 colors
        public string Jund1 { get; set; } = "false";
        public string Jund2 { get; set; } = "false";

        public string Bant1 { get; set; } = "false";
        public string Bant2 { get; set; } = "false";

        public string Grixis1 { get; set; } = "false";
        public string Grixis2 { get; set; } = "false";

        public string Naya1 { get; set; } = "false";
        public string Naya2 { get; set; } = "false";

        public string Esper1 { get; set; } = "false";
        public string Esper2 { get; set; } = "false";

        public string Jeskai1 { get; set; } = "false";
        public string Jeskai2 { get; set; } = "false";

        public string Mardu1 { get; set; } = "false";
        public string Mardu2 { get; set; } = "false";

        public string Sultai1 { get; set; } = "false";
        public string Sultai2 { get; set; } = "false";

        public string Temur1 { get; set; } = "false";
        public string Temur2 { get; set; } = "false";

        public string Abzan1 { get; set; } = "false";
        public string Abzan2 { get; set; } = "false";

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

        public Command StartGame { get; }

        public Command Player1AddButton { get; }
        public Command Player1SubtractButton { get; }
        public Command Player2AddButton { get; }
        public Command Player2SubtractButton { get; }
        public Command Player1Experience { get; }
        public Command Player2Experience { get; }
        public Command CommanderDamage1 { get; }
        public Command CommanderDamage2 { get; }
        public Command PoisonCounter1 { get; }
        public Command PoisonCounter2 { get; }

        public Command SettingPage { get; }

        public string SubmitButtonReadyBackground { get; set; }
        public string SubmitButtonReadyText { get; set; }
        public string StartingHealth { get; set; } = "20";

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

        public Command SubmitButton { get; set; }

        

        public void ClearSingleColors2()
        {
            White2text = "false";
            Blue2text = "false";
            Black2text = "false";
            Red2text = "false";
            Green2text = "false";
        }
        public void ClearTwoColors2()
        {
            Izzet2 = "false";
            Orzhov2 = "false";
            Azorius2 = "false";
            Boros2 = "false";
            Dimir2 = "false";
            Golgari2 = "false";
            Gruul2 = "false";
            Rakdos2 = "false";
            Selesnya2 = "false";
            Simic2 = "false";
        }
        public void ClearTripleColors2()
        {
            Jund2 = "false";
            Bant2 = "false";
            Grixis2 = "flase";
            Naya2 = "false";
            Esper2 = "false";
            Jeskai2 = "false";
            Mardu2 = "false";
            Sultai2 = "false";
            Temur2 = "false";
            Abzan2 = "false";
        }

        public void ColorProperties1()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("White1text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue1text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Black1text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red1text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green1text"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Orzhov1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Izzet1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Azorius1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Boros1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimir1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Golgari1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Gruul1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rakdos1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Selesnya1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Simic1"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jund1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bant1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Grixis1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Naya1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Esper1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jeskai1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mardu1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sultai1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Temur1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Abzan1"));
        }

        public void ColorProperties2()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("White2text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blue2text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Black2text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Red2text"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Green2text"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Orzhov2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Izzet2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Azorius2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Boros2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimir2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Golgari2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Gruul2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Rakdos2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Selesnya2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Simic2"));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jund2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bant2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Grixis2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Naya2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Esper2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Jeskai2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mardu2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sultai2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Temur2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Abzan2"));
        }

        public void OnPropertyChanged()
        {

        }

        public void ColorReset2()
        {
            ClearSingleColors2();
            ClearTwoColors2();
            ClearTripleColors2();
        }

        public void ResetGame()
        {
            
            try
            {
                player1health = Convert.ToInt32(StartingHealth);
                player2health = Convert.ToInt32(StartingHealth);
            }
            catch { return; }
            Health1 = Convert.ToString(player1health);
            Health2 = Convert.ToString(player2health);
            Commander1 = "0";
            Commander2 = "0";
            Poison1 = "0";
            Poison2 = "0";
            Experience1 = "0";
            Experience2 = "0";
            Health1IsMain = "true";
            Poison1IsMain = "false";
            Experience1IsMain = "false";
            Commander1IsMain = "false";
            Health2IsMain = "true";
            Poison2IsMain = "false";
            Experience2IsMain = "false";
            Commander2IsMain = "false";
            Player1Label1Color = Current1;
            Player1Label2Color = "Color.Gold";
            Player1Label3Color = "Color.Green";
            Player1Label4Color = "Color.Blue";
            Player2Label1Color = Current2;
            Player2Label2Color = "Color.Gold";
            Player2Label3Color = "Color.Green";
            Player2Label4Color = "Color.Blue";
            health1IsSelected = true;
            experience1IsMain = false;
            commander1IsMain = false;
            poison1IsMain = false;
            health2IsMain = true;
            experience2IsMain = false;
            commander2IsMain = false;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label1Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label2Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label3Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label4Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label1Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label2Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label3Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label4Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2IsMain"));

        }

        public void ResetMainPage1()
        {
            experience1IsMain = false;
            health1IsSelected = true;
            commander1IsMain = false;
            poison1IsMain = false;
            Health1 = Convert.ToString(player1health);
            Commander1 = Convert.ToString(player1commander);
            Poison1 = Convert.ToString(player1poison);
            Experience1 = Convert.ToString(player1experience);
            Player1Label1Color = Current1;
            Player1Label2Color = "Color.Gold";
            Player1Label3Color = "Color.Green";
            Player1Label4Color = "Color.Blue";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label1Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label2Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label3Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player1Label4Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1"));
            Health1IsMain = "true";
            Poison1IsMain = "false";
            Experience1IsMain = "false";
            Commander1IsMain = "false";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1IsMain"));
            Poison1Inverse = "true";
            Experience1Inverse = "true";
            Commander1Inverse = "true";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander1Inverse"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison1Inverse"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience1Inverse"));
        }

        public void ResetMainPage2()
        {
            experience2IsMain = false;
            health2IsMain = true;
            commander2IsMain = false;
            poison2IsMain = false;
            Health2 = Convert.ToString(player2health);
            Commander2 = Convert.ToString(player2commander);
            Poison2 = Convert.ToString(player2poison);
            Experience2 = Convert.ToString(player2experience);
            Player2Label1Color = Current1;
            Player2Label2Color = "Color.Gold";
            Player2Label3Color = "Color.Green";
            Player2Label4Color = "Color.Blue";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label1Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label2Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label3Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Player2Label4Color"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2"));
            Health2IsMain = "true";
            Poison2IsMain = "false";
            Experience2IsMain = "false";
            Commander2IsMain = "false";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Health2IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2IsMain"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2IsMain"));
            Poison2Inverse = "true";
            Experience2Inverse = "true";
            Commander2Inverse = "true";
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Commander2Inverse"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Poison2Inverse"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Experience2Inverse"));
        }
    }
}
