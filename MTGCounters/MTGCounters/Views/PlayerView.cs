using System;
using Xamarin;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace MTGCounters
{
    [ContentProperty("ContainerContent")]
    public partial class PlayerView : ContentView
    {
        public Image PlainsImage = new Image { Source = "Plains.png", };
        public Image IslandImage = new Image { Source = "Island.png" };
        public Image SwampImage = new Image { Source = "Swamp.png" };
        public Image MountainImage = new Image { Source = "Mountain.png" };
        public Image ForestImage = new Image { Source = "Forest.png" };
        public Image IzzetImage = new Image { Source = "Izzet.png" };
        public Image OrzhovImage = new Image { Source = "Orzhov.png" };
        public Image AzoriusImage = new Image { Source = "Azorius.png" };
        public Image BorosImage = new Image { Source = "Boros.png" };
        public Image DimirImage = new Image { Source = "Dimir.png" };
        public Image GolgariImage = new Image { Source = "Golgari.png" };
        public Image GruulImage = new Image { Source = "Gruul.png" };
        public Image RakdosImage = new Image { Source = "Rakdos.png" };
        public Image SelesnyaImage = new Image { Source = "Selesnya.png" };
        public Image SimicImage = new Image { Source = "Simic.png" };
        public Image JundImage = new Image { };
        public Image BantImage = new Image { };
        public Image GrixisImage = new Image { };
        public Image NayaImage = new Image { };
        public Image EsperImage = new Image { };
        public Image JeskaiImage = new Image { };
        public Image MarduImage = new Image { };
        public Image SultaiImage = new Image { };
        public Image TemurImage = new Image { };
        public Image AbzanImage = new Image { };

        public SKCanvasView Background = new SKCanvasView() { };

        public PlayerView()
        {
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
                },

            };

            
            Background.PaintSurface += Background_paintsurface;

            

            grid.Children.Add(Background);
            Grid.SetColumnSpan(Background, 4);
            Grid.SetRowSpan(Background, 3);

            // Create Images for background of health
            {

                grid.Children.Add(PlainsImage);
                Grid.SetColumnSpan(PlainsImage, 2);
                Grid.SetRowSpan(PlainsImage, 3);

                grid.Children.Add(IslandImage);
                Grid.SetColumnSpan(IslandImage, 2);
                Grid.SetRowSpan(IslandImage, 3);

                grid.Children.Add(SwampImage);
                Grid.SetColumnSpan(SwampImage, 2);
                Grid.SetRowSpan(SwampImage, 3);

                grid.Children.Add(MountainImage);
                Grid.SetColumnSpan(MountainImage, 2);
                Grid.SetRowSpan(MountainImage, 3);

                grid.Children.Add(ForestImage);
                Grid.SetColumnSpan(ForestImage, 2);
                Grid.SetRowSpan(ForestImage, 3);

                grid.Children.Add(IzzetImage);
                Grid.SetColumnSpan(IzzetImage, 2);
                Grid.SetRowSpan(IzzetImage, 3);

                grid.Children.Add(OrzhovImage);
                Grid.SetColumnSpan(OrzhovImage, 2);
                Grid.SetRowSpan(OrzhovImage, 3);

                grid.Children.Add(AzoriusImage);
                Grid.SetColumnSpan(AzoriusImage, 2);
                Grid.SetRowSpan(AzoriusImage, 3);

                grid.Children.Add(BorosImage);
                Grid.SetColumnSpan(BorosImage, 2);
                Grid.SetRowSpan(BorosImage, 3);

                grid.Children.Add(DimirImage);
                Grid.SetColumnSpan(DimirImage, 2);
                Grid.SetRowSpan(DimirImage, 3);

                grid.Children.Add(GolgariImage);
                Grid.SetColumnSpan(GolgariImage, 2);
                Grid.SetRowSpan(GolgariImage, 3);

                grid.Children.Add(GruulImage);
                Grid.SetColumnSpan(GruulImage, 2);
                Grid.SetRowSpan(GruulImage, 3);

                grid.Children.Add(RakdosImage);
                Grid.SetColumnSpan(RakdosImage, 2);
                Grid.SetRowSpan(RakdosImage, 3);

                grid.Children.Add(SelesnyaImage);
                Grid.SetColumnSpan(SelesnyaImage, 2);
                Grid.SetRowSpan(SelesnyaImage, 3);

                grid.Children.Add(SimicImage);
                Grid.SetColumnSpan(SimicImage, 2);
                Grid.SetRowSpan(SimicImage, 3);
            }

            Device.StartTimer(TimeSpan.FromSeconds(1f / 60), () =>
            {
                Background.InvalidateSurface();
                return true;
            });

            void Background_paintsurface(object sender, SKPaintSurfaceEventArgs e)
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

                if (PlainsImage.IsVisible) { canvas.DrawRect(0, 0, x, y, white); }

                if (IslandImage.IsVisible) { canvas.DrawRect(0, 0, x, y, Blue); }

                if (SwampImage.IsVisible) { canvas.DrawRect(0, 0, x, y, Black); }

                if (MountainImage.IsVisible) { canvas.DrawRect(0, 0, x, y, Red); }

                if (ForestImage.IsVisible) { canvas.DrawRect(0, 0, x, y, Green); }
                SKPaint Izzet = new SKPaint();
                {
                    Izzet.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.DeepSkyBlue, SKColors.Red },
                        SKShaderTileMode.Mirror);
                }
                if (IzzetImage.IsVisible)
                {
                    canvas.Clear(SKColors.WhiteSmoke);
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Izzet);
                }
                SKPaint Orzhov = new SKPaint();
                {
                    Orzhov.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.LightGoldenrodYellow, SKColors.MediumPurple },
                        new float[] { 0.4f, 1 },
                        SKShaderTileMode.Mirror);
                }
                if (OrzhovImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Orzhov);
                }
                SKPaint Azorius = new SKPaint();
                {
                    Azorius.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.LightGoldenrodYellow, SKColors.DeepSkyBlue },
                        new float[] { 0.4f, 1 },
                        SKShaderTileMode.Mirror);
                }
                if (AzoriusImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Azorius);
                }
                SKPaint Boros = new SKPaint();
                {
                    Boros.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.IndianRed, SKColors.LightGoldenrodYellow },
                        new float[] { 0, .6f },
                        SKShaderTileMode.Mirror);
                }
                if (BorosImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Boros);
                }
                SKPaint Dimir = new SKPaint();
                {
                    Dimir.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.DeepSkyBlue, SKColors.MediumPurple },
                        new float[] { 0, .6f },
                        SKShaderTileMode.Mirror);
                }
                if (DimirImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Dimir);
                }
                SKPaint Golgari = new SKPaint();
                {
                    Golgari.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.MediumPurple, SKColors.Green },
                        SKShaderTileMode.Mirror);
                }
                if (GolgariImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Golgari);
                }
                SKPaint Gruul = new SKPaint();
                {
                    Gruul.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Red, SKColors.Green },
                        new float[] { 0, .8f },
                        SKShaderTileMode.Mirror);
                }
                if (GruulImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Gruul);
                }
                SKPaint Rakdos = new SKPaint();
                {
                    Rakdos.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.MediumPurple, SKColors.Red },
                        SKShaderTileMode.Mirror);
                }
                if (RakdosImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Rakdos);
                }
                SKPaint Selesnya = new SKPaint();
                {
                    Selesnya.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Green, SKColors.LightGoldenrodYellow },
                        new float[] { 0, .6f },
                        SKShaderTileMode.Mirror);
                }
                if (SelesnyaImage.IsVisible)
                {
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Selesnya);
                }
                SKPaint Simic = new SKPaint();
                {
                    Simic.Shader = SKShader.CreateLinearGradient(
                        new SKPoint(0, 0),
                        new SKPoint(x, y),
                        new SKColor[] { SKColors.Green, SKColors.DeepSkyBlue },
                        new float[] { 0, .9f },
                        SKShaderTileMode.Mirror);
                }
                if (SimicImage.IsVisible)
                {
                    canvas.Clear(SKColors.WhiteSmoke);
                    canvas.DrawRect(0, 0, e.Info.Width, e.Info.Height, Simic);
                }
                SKPaint Jund = new SKPaint();
                {
                    Jund.Shader = SKShader.CreateSweepGradient(
                        new SKPoint(x / 2, y / 2),
                        new SKColor[] { SKColors.Red, SKColors.Green, SKColors.MediumPurple },
                        new float[] { .00016f, .5f, .83f });
                }
                if (JundImage.IsVisible)
                {
                    canvas.Clear();
                    canvas.DrawCircle(new SKPoint(x/2,y/2), e.Info.Width, Jund);
                }
                Content = grid;
                new ContentPresenter();
            }
        }
        public View ContainerContent { get; set; }
    }
    
}
