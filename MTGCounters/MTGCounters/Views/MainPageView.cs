using System;
using System.ComponentModel;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace MTGCounters
{
    public partial class MainPageView : ContentPage
    {
        
        Image Player1Plains = new Image { Source = "Plains.png" , BindingContext = MainPageViewModel.Player1, };
        Image Player1Island = new Image { Source = "Island.png" };
        Image Player1Swamp = new Image { Source = "Swamp.png" };
        Image Player1Mountain = new Image { Source = "Mountain.png" };
        Image Player1Forest = new Image { Source = "Forest.png" };
        Image Player1Izzet = new Image { Source = "Izzet.png" };
        Image Player1Orzhov = new Image { Source = "Orzhov.png" };
        Image Player1Azorius = new Image { Source = "Azorius.png" };
        Image Player1Boros = new Image { Source = "Boros.png" };
        Image Player1Dimir = new Image { Source = "Dimir.png" };
        Image Player1Golgari = new Image { Source = "Golgari.png" };
        Image Player1Gruul = new Image { Source = "Gruul.png" };
        Image Player1Rakdos = new Image { Source = "Rakdos.png" };
        Image Player1Selesnya = new Image { Source = "Selesnya.png" };
        Image Player1Simic = new Image { Source = "Simic.png" };
        Image Player1Jund = new Image { };
        Image Player1Bant = new Image { };
        Image Player1Grixis = new Image { };
        Image Player1Naya = new Image { };
        Image Player1Esper = new Image { };
        Image Player1Jeskai = new Image { };
        Image Player1Mardu = new Image { };
        Image Player1Sultai = new Image { };
        Image Player1Temur = new Image { };
        Image Player1Abzan = new Image { };

        Image Player2Plains = new Image { Source = "Plains.png", Rotation = 180 };
        Image Player2Island = new Image { Source = "Island.png", Rotation = 180 };
        Image Player2Swamp = new Image { Source = "Swamp.png", Rotation = 180 };
        Image Player2Mountain = new Image { Source = "Mountain.png", Rotation = 180 };
        Image Player2Forest = new Image { Source = "Forest.png", Rotation = 180 };
        Image Player2Izzet = new Image { Source = "Izzet.png", Rotation = 180 };
        Image Player2Orzhov = new Image { Source = "Orzhov.png", Rotation = 180 };
        Image Player2Azorius = new Image { Source = "Azorius.png", Rotation = 180 };
        Image Player2Boros = new Image { Source = "Boros.png", Rotation = 180 };
        Image Player2Dimir = new Image { Source = "Dimir.png", Rotation = 180 };
        Image Player2Golgari = new Image { Source = "Golgari.png", Rotation = 180 };
        Image Player2Gruul = new Image { Source = "Gruul.png", Rotation = 180 };
        Image Player2Rakdos = new Image { Source = "Rakdos.png", Rotation = 180 };
        Image Player2Selesnya = new Image { Source = "Selesnya.png", Rotation = 180 };
        Image Player2Simic = new Image { Source = "Simic.png", Rotation = 180 };
        Image Player2Jund = new Image { };
        Image Player2Bant = new Image { };
        Image Player2Grixis = new Image { };
        Image Player2Naya = new Image { };
        Image Player2Esper = new Image { };
        Image Player2Jeskai = new Image { };
        Image Player2Mardu = new Image { };
        Image Player2Sultai = new Image { };
        Image Player2Temur = new Image { };
        Image Player2Abzan = new Image { };

        ContentView Player1 = new PlayerView();

        public MainPageView()
        {
            BackgroundColor = Color.LightGray;
            
            Grid grid = new Grid
            {
                Margin = new Thickness(0),
                ColumnDefinitions =
                {
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition {Width = new GridLength(1, GridUnitType.Star)}
                },
                RowDefinitions =
                {
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(.5, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                    new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
                },

            };
            NavigationPage.SetHasNavigationBar(this, false);

            grid.Children.Add(Player1, 0, 4);
            Grid.SetColumnSpan(Player1, 4);
            Grid.SetRowSpan(Player1, 3);

            //background colors, sets a blank canvas
            /*
            SKCanvasView Player1Background = new SKCanvasView() { };
            Player1Background.PaintSurface += Player1Background_paintsurface;

            grid.Children.Add(Player1Background, 0, 4);
            Grid.SetColumnSpan(Player1Background, 4);
            Grid.SetRowSpan(Player1Background, 3);
            */
            var Player2Background = new SKCanvasView { };
            Player2Background.PaintSurface += Player2Background_paintsurface;

            grid.Children.Add(Player2Background);
            Grid.SetColumnSpan(Player2Background, 4);
            Grid.SetRowSpan(Player2Background, 3);
            /*
            Player1Plains.SetBinding(Image.IsVisibleProperty, "White");
            Player1Island.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Blue));
            Player1Swamp.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Black));
            Player1Mountain.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Red));
            Player1Forest.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Green));
            Player1Izzet.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Izzet));
            Player1Orzhov.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Orzhov));
            Player1Azorius.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Azorius));
            Player1Boros.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Boros));
            Player1Dimir.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Dimir));
            Player1Golgari.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Golgari));
            Player1Gruul.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Gruul));
            Player1Rakdos.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Rakdos));
            Player1Selesnya.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Selesnya));
            Player1Gruul.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Simic));
            Player1Abzan.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Abzan));
            Player1Jund.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Jund));
            Player1Bant.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Bant));
            Player1Grixis.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Grixis));
            Player1Naya.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Naya));
            Player1Esper.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Esper));
            Player1Jeskai.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Jeskai));
            Player1Mardu.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Mardu));
            Player1Sultai.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Sultai));
            Player1Temur.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Temur));
            */

            Player1.PlainsImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.White));
            Player1.IslandImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Blue));
            Player1.SwampImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Black));
            Player1.MountainImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Red));
            Player1.ForestImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Green));
            Player1.IzzetImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Izzet));
            Player1.OrzhovImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Orzhov));
            Player1.AzoriusImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Azorius));
            Player1.BorosImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Boros));
            Player1.DimirImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Dimir));
            Player1.GolgariImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Golgari));
            Player1.GruulImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Gruul));
            Player1.RakdosImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Rakdos));
            Player1.SelesnyaImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Selesnya));
            Player1.AbzanImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Abzan));
            Player1.JundImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Jund));
            Player1.BantImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Bant));
            Player1.GrixisImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Grixis));
            Player1.NayaImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Naya));
            Player1.EsperImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Esper));
            Player1.JeskaiImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Jeskai));
            Player1.MarduImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Mardu));
            Player1.SultaiImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Sultai));
            Player1.TemurImage.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.Temur));


            // Create Images for background of health for player 1
            /*
            {

                grid.Children.Add(Player1Plains, 0, 4);
                Grid.SetColumnSpan(Player1Plains, 2);
                Grid.SetRowSpan(Player1Plains, 3);

                grid.Children.Add(Player1Island, 0, 4);
                Grid.SetColumnSpan(Player1Island, 2);
                Grid.SetRowSpan(Player1Island, 3);

                grid.Children.Add(Player1Swamp, 0, 4);
                Grid.SetColumnSpan(Player1Swamp, 2);
                Grid.SetRowSpan(Player1Swamp, 3);

                grid.Children.Add(Player1Mountain, 0, 4);
                Grid.SetColumnSpan(Player1Mountain, 2);
                Grid.SetRowSpan(Player1Mountain, 3);
                
                grid.Children.Add(Player1Forest, 0, 4);
                Grid.SetColumnSpan(Player1Forest, 2);
                Grid.SetRowSpan(Player1Forest, 3);

                grid.Children.Add(Player1Izzet, 0, 4);
                Grid.SetColumnSpan(Player1Izzet, 2);
                Grid.SetRowSpan(Player1Izzet, 3);
         
                grid.Children.Add(Player1Orzhov, 0, 4);
                Grid.SetColumnSpan(Player1Orzhov, 2);
                Grid.SetRowSpan(Player1Orzhov, 3);
           
                grid.Children.Add(Player1Azorius, 0, 4);
                Grid.SetColumnSpan(Player1Azorius, 2);
                Grid.SetRowSpan(Player1Azorius, 3);
            
                grid.Children.Add(Player1Boros, 0, 4);
                Grid.SetColumnSpan(Player1Boros, 2);
                Grid.SetRowSpan(Player1Boros, 3);
            
                grid.Children.Add(Player1Dimir, 0, 4);
                Grid.SetColumnSpan(Player1Dimir, 2);
                Grid.SetRowSpan(Player1Dimir, 3);
               
                grid.Children.Add(Player1Golgari, 0, 4);
                Grid.SetColumnSpan(Player1Golgari, 2);
                Grid.SetRowSpan(Player1Golgari, 3);
                
                grid.Children.Add(Player1Gruul, 0, 4);
                Grid.SetColumnSpan(Player1Gruul, 2);
                Grid.SetRowSpan(Player1Gruul, 3);
                
                grid.Children.Add(Player1Rakdos, 0, 4);
                Grid.SetColumnSpan(Player1Rakdos, 2);
                Grid.SetRowSpan(Player1Rakdos, 3);
                
                grid.Children.Add(Player1Selesnya, 0, 4);
                Grid.SetColumnSpan(Player1Selesnya, 2);
                Grid.SetRowSpan(Player1Selesnya, 3);
                
                grid.Children.Add(Player1Simic, 0, 4);
                Grid.SetColumnSpan(Player1Simic, 2);
                Grid.SetRowSpan(Player1Simic, 3);
            }
            */

            Player2Plains.SetBinding(Image.IsVisibleProperty, "White2text");
            Player2Island.SetBinding(Image.IsVisibleProperty, "Blue2text");
            Player2Swamp.SetBinding(Image.IsVisibleProperty, "Black2text");
            Player2Mountain.SetBinding(Image.IsVisibleProperty, "Red2text");
            Player2Forest.SetBinding(Image.IsVisibleProperty, "Green2text");
            Player2Izzet.SetBinding(Image.IsVisibleProperty, "Izzet2");
            Player2Orzhov.SetBinding(Image.IsVisibleProperty, "Orzhov2");
            Player2Azorius.SetBinding(Image.IsVisibleProperty, "Azorius2");
            Player2Boros.SetBinding(Image.IsVisibleProperty, "Boros2");
            Player2Dimir.SetBinding(Image.IsVisibleProperty, "Dimir2");
            Player2Golgari.SetBinding(Image.IsVisibleProperty, "Golgari2");
            Player2Gruul.SetBinding(Image.IsVisibleProperty, "Gruul2");
            Player2Rakdos.SetBinding(Image.IsVisibleProperty, "Rakdos2");
            Player2Selesnya.SetBinding(Image.IsVisibleProperty, "Selesnya2");
            Player2Simic.SetBinding(Image.IsVisibleProperty, "Simic2");
            Player2Abzan.SetBinding(Image.IsVisibleProperty, "Abzan2");
            Player2Jund.SetBinding(Image.IsVisibleProperty, "Jund2");
            Player2Bant.SetBinding(Image.IsVisibleProperty, "Bant2");
            Player2Grixis.SetBinding(Image.IsVisibleProperty, "Grixis2");
            Player2Naya.SetBinding(Image.IsVisibleProperty, "Naya2");
            Player2Esper.SetBinding(Image.IsVisibleProperty, "Esper2");
            Player2Jeskai.SetBinding(Image.IsVisibleProperty, "Jeskai2");
            Player2Mardu.SetBinding(Image.IsVisibleProperty, "Mardu2");
            Player2Sultai.SetBinding(Image.IsVisibleProperty, "Sultai2");
            Player2Temur.SetBinding(Image.IsVisibleProperty, "Temur2");

            // Create Images for background of health for player 2
            
            {
                grid.Children.Add(Player2Plains);
                Grid.SetColumnSpan(Player2Plains, 2);
                Grid.SetRowSpan(Player2Plains, 3);
               
                grid.Children.Add(Player2Island);
                Grid.SetColumnSpan(Player2Island, 2);
                Grid.SetRowSpan(Player2Island, 3);
               
                grid.Children.Add(Player2Swamp);
                Grid.SetColumnSpan(Player2Swamp, 2);
                Grid.SetRowSpan(Player2Swamp, 3);
                
                grid.Children.Add(Player2Mountain);
                Grid.SetColumnSpan(Player2Mountain, 2);
                Grid.SetRowSpan(Player2Mountain, 3);
                
                grid.Children.Add(Player2Forest);
                Grid.SetColumnSpan(Player2Forest, 2);
                Grid.SetRowSpan(Player2Forest, 3);
                
                grid.Children.Add(Player2Izzet);
                Grid.SetColumnSpan(Player2Izzet, 2);
                Grid.SetRowSpan(Player2Izzet, 3);
                
                grid.Children.Add(Player2Orzhov);
                Grid.SetColumnSpan(Player2Orzhov, 2);
                Grid.SetRowSpan(Player2Orzhov, 3);
                
                grid.Children.Add(Player2Azorius);
                Grid.SetColumnSpan(Player2Azorius, 2);
                Grid.SetRowSpan(Player2Azorius, 3);
                
                grid.Children.Add(Player2Boros);
                Grid.SetColumnSpan(Player2Boros, 2);
                Grid.SetRowSpan(Player2Boros, 3);

                grid.Children.Add(Player2Dimir);
                Grid.SetColumnSpan(Player2Dimir, 2);
                Grid.SetRowSpan(Player2Dimir, 3);
               
                grid.Children.Add(Player2Golgari);
                Grid.SetColumnSpan(Player2Golgari, 2);
                Grid.SetRowSpan(Player2Golgari, 3);
                
                grid.Children.Add(Player2Gruul);
                Grid.SetColumnSpan(Player2Gruul, 2);
                Grid.SetRowSpan(Player2Gruul, 3);
                
                Grid.SetColumnSpan(Player2Rakdos, 2);
                Grid.SetRowSpan(Player2Rakdos, 3);
                grid.Children.Add(Player2Rakdos);
                
                grid.Children.Add(Player2Selesnya);
                Grid.SetColumnSpan(Player2Selesnya, 2);
                Grid.SetRowSpan(Player2Selesnya, 3);
                
                grid.Children.Add(Player2Simic);
                Grid.SetColumnSpan(Player2Simic, 2);
                Grid.SetRowSpan(Player2Simic, 3);
            }
            

            var PoisonCounterImage = new Image { Source = "piosonCounterImage.png", BindingContext = MainPageViewModel.Player1, };
            var PoisonCounter2Image = new Image { Source = "piosonCounterImage.png", Rotation = 180, };
            var PoisonCounterImageBackground = new Image { Source = "piosonCounterImage.png", Margin = new Thickness(50), BindingContext = MainPageViewModel.Player1, };
            var PoisonCounterImageBackground2 = new Image
            {
                Source = "piosonCounterImage.png",
                Rotation = 180,
                Margin = new Thickness(50),
            };
            var ExperienceCounters = new Image
            {
                Source = "ExperienceCounter.png",
                BindingContext = MainPageViewModel.Player1,
            };
            var ExperienceCounters2 = new Image
            {
                Source = "ExperienceCounter.png",
                Rotation = 180,
            };
            var ExperienceCountersBackground = new Image
            {
                Source = "ExperienceCounter.png",
                BindingContext = MainPageViewModel.Player1,
            };
            var ExperienceCountersBackground2 = new Image
            {
                Source = "ExperienceCounter.png",
                Rotation = 180,
            };
            var CommanderDamageImage = new Image
            {
                Source = "commanderLogo.png",
                BindingContext = MainPageViewModel.Player1,
            };
            var CommanderDamage2Image = new Image
            {
                Source = "commanderLogo.png",
                Rotation = 180,
            };
            var CommanderDamageImageBackground = new Image
            {
                Source = "commanderLogo.png",
                BindingContext = MainPageViewModel.Player1,
            };
            var CommanderDamageImageBackground2 = new Image
            {
                Source = "commanderLogo.png",
                Rotation = 180,
            };
            var RetsartImage = new Image
            {
                Margin = new Thickness(5),
                Source = "RestartImage.png"
            };

            

            { 
                grid.Children.Add(PoisonCounterImageBackground, 0, 4);
                Grid.SetColumnSpan(PoisonCounterImageBackground, 2);
                Grid.SetRowSpan(PoisonCounterImageBackground, 3);
                PoisonCounterImageBackground.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.SelectedHealthCheck));

                grid.Children.Add(PoisonCounterImageBackground2);
                Grid.SetColumnSpan(PoisonCounterImageBackground2, 2);
                Grid.SetRowSpan(PoisonCounterImageBackground2, 3);
                PoisonCounterImageBackground2.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player2.SelectedHealthCheck));

                grid.Children.Add(ExperienceCountersBackground2);
                Grid.SetColumnSpan(ExperienceCountersBackground2, 2);
                Grid.SetRowSpan(ExperienceCountersBackground2, 3);
                ExperienceCountersBackground2.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.SelectedHealthCheck));

                grid.Children.Add(ExperienceCountersBackground, 0, 4);
                Grid.SetColumnSpan(ExperienceCountersBackground, 2);
                Grid.SetRowSpan(ExperienceCountersBackground, 3);
                ExperienceCountersBackground.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player2.SelectedHealthCheck));

                grid.Children.Add(CommanderDamageImageBackground2);
                Grid.SetColumnSpan(CommanderDamageImageBackground2, 2);
                Grid.SetRowSpan(CommanderDamageImageBackground2, 3);
                CommanderDamageImageBackground2.SetBinding(Image.IsVisibleProperty, "Commander2");

                grid.Children.Add(CommanderDamageImageBackground, 0, 4);
                Grid.SetColumnSpan(CommanderDamageImageBackground, 2);
                Grid.SetRowSpan(CommanderDamageImageBackground, 3);
                CommanderDamageImageBackground.SetBinding(Image.IsVisibleProperty, nameof(MainPageViewModel.Player1.SelectedHealthCheck));
            }
            Label Player1Health = new Label
            {
                Text = "20",
                FontSize = 100,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            };
            Player1Health.SetBinding(Label.TextProperty, "Health1");
            Player1Health.SetBinding(Label.TextColorProperty, "Player1Label1Color");

            grid.Children.Add(Player1Health, 0, 4);
            Grid.SetColumnSpan(Player1Health, 2);
            Grid.SetRowSpan(Player1Health, 3);
            Player1Health.BackgroundColor = Color.Transparent;

            Label Player2Health = new Label
            {
                Text = "20",
                FontSize = 100,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                Rotation = 180,
            };
            Player2Health.SetBinding(Label.TextProperty, "Health2");
            Player2Health.SetBinding(Label.TextColorProperty, "Player2Label1Color");

            grid.Children.Add(Player2Health, 0, 0);
            Grid.SetColumnSpan(Player2Health, 2);
            Grid.SetRowSpan(Player2Health, 3);
            Player2Health.BackgroundColor = Color.Transparent;

            //sets charachteristics of the button

            Button Player1experience = new Button
            {
                Text = "0",
                FontSize = 60,
                TextColor = Color.Blue,

            };
            Player1experience.SetBinding(Button.CommandProperty, "Player1Experience");
            Player1experience.SetBinding(Button.TextProperty, "Experience1");
            Player1experience.SetBinding(Label.TextColorProperty, "Player1Label4Color");

            grid.Children.Add(ExperienceCounters, 2, 6);
            Grid.SetColumnSpan(ExperienceCounters, 2);
            ExperienceCounters.SetBinding(Image.IsVisibleProperty, "Experience1Inverse");
            grid.Children.Add(Player1experience, 2, 6);
            Grid.SetColumnSpan(Player1experience, 2);
            Player1experience.BackgroundColor = Color.Transparent;


            Button Player2experience = new Button
            {
                Text = "0",
                FontSize = 60,
                TextColor = Color.Blue,
                Rotation = 180,

            };
            Player2experience.SetBinding(Button.CommandProperty, "Player2Experience");
            Player2experience.SetBinding(Button.TextProperty, "Experience2");
            Player2experience.SetBinding(Label.TextColorProperty, "Player2Label4Color");

            grid.Children.Add(ExperienceCounters2, 2, 0);
            Grid.SetColumnSpan(ExperienceCounters2, 2);
            ExperienceCounters2.SetBinding(Image.IsVisibleProperty, "Experience2Inverse");
            grid.Children.Add(Player2experience, 2, 0);
            Grid.SetColumnSpan(Player2experience, 2);
            Player2experience.BackgroundColor = Color.Transparent;


            Button CommanderDamage1 = new Button
            {
                Text = "0",
                FontSize = 60,
                TextColor = Color.Gold
            };
            CommanderDamage1.SetBinding(Button.CommandProperty, "CommanderDamage1");
            CommanderDamage1.SetBinding(Button.TextProperty, "Commander1");
            CommanderDamage1.SetBinding(Button.TextColorProperty, "Player1Label2Color");

            grid.Children.Add(CommanderDamageImage, 2, 4);
            Grid.SetColumnSpan(CommanderDamageImage, 2);
            CommanderDamageImage.SetBinding(Image.IsVisibleProperty, "Commander1Inverse");
            grid.Children.Add(CommanderDamage1, 2, 4);
            Grid.SetColumnSpan(CommanderDamage1, 2);
            CommanderDamage1.BackgroundColor = Color.Transparent;


            Button CommanderDamage2 = new Button
            {
                Text = "0",
                FontSize = 60,
                TextColor = Color.Gold,
                Rotation = 180,
            };
            CommanderDamage2.SetBinding(Button.CommandProperty, "CommanderDamage2");
            CommanderDamage2.SetBinding(Button.TextProperty, "Commander2");
            CommanderDamage2.SetBinding(Button.TextColorProperty, "Player2Label2Color");

            grid.Children.Add(CommanderDamage2Image, 2, 2);
            Grid.SetColumnSpan(CommanderDamage2Image, 2);
            CommanderDamage2Image.SetBinding(Image.IsVisibleProperty, "Commander2Inverse");
            grid.Children.Add(CommanderDamage2, 2, 2);
            Grid.SetColumnSpan(CommanderDamage2, 2);
            CommanderDamage2.BackgroundColor = Color.Transparent;


            Button PoisonCounter1 = new Button
            {
                Text = "0",
                FontSize = 60,
                TextColor = Color.Green,
            };
            PoisonCounter1.SetBinding(Button.CommandProperty, "PoisonCounter1");
            PoisonCounter1.SetBinding(Button.TextProperty, "Poison1");
            PoisonCounter1.SetBinding(Button.TextColorProperty, "Player1Label3Color");

            grid.Children.Add(PoisonCounterImage, 2, 5);
            Grid.SetColumnSpan(PoisonCounterImage, 2);
            PoisonCounterImage.SetBinding(Image.IsVisibleProperty, "Poison1Inverse");

            grid.Children.Add(PoisonCounter1, 2, 5);
            Grid.SetColumnSpan(PoisonCounter1, 2);
            PoisonCounter1.BackgroundColor = Color.Transparent;


            Button PoisonCounter2 = new Button
            {
                Text = "0",
                FontSize = 60,
                TextColor = Color.Green,
                Rotation = 180,
            };
            PoisonCounter2.SetBinding(Button.CommandProperty, "PoisonCounter2");
            PoisonCounter2.SetBinding(Button.TextProperty, "Poison2");
            PoisonCounter2.SetBinding(Button.TextColorProperty, "Player2Label3Color");

            grid.Children.Add(PoisonCounter2Image, 2, 1);
            Grid.SetColumnSpan(PoisonCounter2Image, 2);
            PoisonCounter2Image.SetBinding(Image.IsVisibleProperty, "Poison2Inverse");
            grid.Children.Add(PoisonCounter2, 2, 1);
            Grid.SetColumnSpan(PoisonCounter2, 2);
            PoisonCounter2.BackgroundColor = Color.Transparent;

            var SettingImage = new Image
            {
                Source = "SettingImage.png",
            };
            Button SettingsPage = new Button { };
            SettingsPage.SetBinding(Button.CommandProperty, "SettingPage");

            grid.Children.Add(SettingImage, 3, 3);
            grid.Children.Add(SettingsPage, 3, 3);
            SettingsPage.BackgroundColor = Color.Transparent;

            Button Player1AddButton = new Button
            {
                Text = "+",
                FontSize = 40,
                TextColor = Color.Black,
                BackgroundColor = Color.PowderBlue,
            };
            Player1AddButton.SetBinding(Button.CommandProperty, "Player1AddButton");
            //Player1AddButton.SetBinding(Button.TextColorProperty, "Player1label1off");
            

            //sets up the button size and loctaion and make the backgrounds transparent
            grid.Children.Add(Player1AddButton, 0, 4);
            Grid.SetColumnSpan(Player1AddButton, 2);
            Player1AddButton.BackgroundColor = Color.Transparent;

            Button Player2AddButton = new Button
            {
                Text = "+",
                FontSize = 40,
                TextColor = Color.Black,
                BackgroundColor = Color.PowderBlue,
            };
            Player2AddButton.SetBinding(Button.CommandProperty, "Player2AddButton");
            //Player2AddButton.SetBinding(Button.TextColorProperty, "Player2label1off");

            grid.Children.Add(Player2AddButton, 0, 2);
            Grid.SetColumnSpan(Player2AddButton, 2);
            Player2AddButton.BackgroundColor = Color.Transparent;

            Button Player1SubtractButton = new Button
            {
                Text = "-",
                FontSize = 50,
                TextColor = Color.Black,
                BackgroundColor = Color.PowderBlue,
            };
            Player1SubtractButton.SetBinding(Button.CommandProperty, "Player1SubtractButton");
            //Player1SubtractButton.SetBinding(Button.TextColorProperty, "Player1label1off");

            grid.Children.Add(Player1SubtractButton, 0, 6);
            Grid.SetColumnSpan(Player1SubtractButton, 2);
            Player1SubtractButton.BackgroundColor = Color.Transparent;


            Button Player2SubtractButton = new Button
            {
                Text = "-",
                FontSize = 50,
                TextColor = Color.Black,
                BackgroundColor = Color.PowderBlue,
            };
            Player2SubtractButton.SetBinding(Button.CommandProperty, "Player2SubtractButton");
            //Player2SubtractButton.SetBinding(Button.TextColorProperty, "Player2label1off");

            grid.Children.Add(Player2SubtractButton, 0, 0);
            Grid.SetColumnSpan(Player2SubtractButton, 2);
            Player2SubtractButton.BackgroundColor = Color.Transparent;

            Button StartGameButton = new Button
            {
                Text = "",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                TextColor = Color.Black,
                BackgroundColor = Color.PowderBlue,
            };
            StartGameButton.SetBinding(Button.CommandProperty, "StartGame");
            StartGameButton.BackgroundColor = Color.Transparent;

            grid.Children.Add(RetsartImage, 0, 3);

            grid.Children.Add(StartGameButton, 0, 3);

            Device.StartTimer(TimeSpan.FromSeconds(1f / 60), () =>
            {
                Player1.Background.InvalidateSurface();
                Player2Background.InvalidateSurface();
                return true;
            });


            void Player2Background_paintsurface(object sender, SKPaintSurfaceEventArgs e)
            {
                SKSurface surface = e.Surface;
                SKCanvas canvas = surface.Canvas;

                canvas.Clear(SKColors.WhiteSmoke);

                float x = e.Info.Width;
                float y = e.Info.Height;

                SKPaint white = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Color = SKColors.LightGoldenrodYellow,
                };

                SKPaint Blue = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Color = SKColors.DeepSkyBlue,
                };

                SKPaint Black = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Color = SKColors.MediumPurple,
                };

                SKPaint Red = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Color = SKColors.IndianRed,
                };

                SKPaint Green = new SKPaint
                {
                    Style = SKPaintStyle.Fill,
                    Color = SKColors.LightGreen,
                };

                if (Player2Plains.IsVisible) { canvas.DrawRect(0, 0, x, y, white); }

                if (Player2Island.IsVisible) { canvas.DrawRect(0, 0, x, y, Blue); }

                if (Player2Swamp.IsVisible) { canvas.DrawRect(0, 0, x, y, Black); }

                if (Player2Mountain.IsVisible) { canvas.DrawRect(0, 0, x, y, Red); }

                if (Player2Forest.IsVisible) { canvas.DrawRect(0, 0, x, y, Green); }

                SKPaint Izzet = new SKPaint();
                {
                    Izzet.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Red, SKColors.DeepSkyBlue },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Izzet.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Izzet);
                }
                SKPaint Orzhov = new SKPaint();
                {
                    Orzhov.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] {SKColors.MediumPurple, SKColors.LightGoldenrodYellow },
                        new float[] { 1, .6f },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Orzhov.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Orzhov);
                }
                SKPaint Azorius = new SKPaint();
                {
                    Azorius.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.DeepSkyBlue, SKColors.LightGoldenrodYellow },
                        new float[] { 1, .6f },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Azorius.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Azorius);
                }
                SKPaint Boros = new SKPaint();
                {
                    Boros.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.LightGoldenrodYellow, SKColors.IndianRed },
                        new float[] { .4f, 1 },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Boros.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Boros);
                }
                SKPaint Dimir = new SKPaint();
                {
                    Dimir.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.MediumPurple, SKColors.DeepSkyBlue },
                        new float[] { .4f, 1 },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Dimir.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Dimir);
                }
                SKPaint Golgari = new SKPaint();
                {
                    Golgari.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Green, SKColors.MediumPurple },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Golgari.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Golgari);
                }
                SKPaint Gruul = new SKPaint();
                {
                    Gruul.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Green, SKColors.Red },
                        new float[] { .2f, 1 },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Gruul.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Gruul);
                }
                SKPaint Rakdos = new SKPaint();
                {
                    Rakdos.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Red, SKColors.MediumPurple },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Rakdos.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Rakdos);
                }
                SKPaint Selesnya = new SKPaint();
                {
                    Selesnya.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.LightGoldenrodYellow, SKColors.Green, },
                        new float[] { .4f, 1 },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Selesnya.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Selesnya);
                }
                SKPaint Simic = new SKPaint();
                {
                    Simic.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.DeepSkyBlue, SKColors.Green },
                        new float[] { .1f, 0 },
                        SKShaderTileMode.Mirror);
                }
                if (Player2Simic.IsVisible)
                {
                    canvas.Clear(SKColors.WhiteSmoke);
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Simic);
                }
                
            }
            
            BindingContext = Application.Current.BindingContext;
            Content = Player1;
            Content = grid;
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

        public string NumberOfColors1 { get; set; }
        public string NumberOfColors2 { get; set; }
    }
}