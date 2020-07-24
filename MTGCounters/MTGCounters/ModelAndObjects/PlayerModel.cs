using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace MTGCounters
{
    public enum HealthValue
    {
        Health, Commander, Experience, Poison  
    }

    public class PlayerModel : INotifyPropertyChanged, IValueConverter
    {
        //settings page
        public string name;

        public string WhiteColor { get => whiteColor; set => SetField(ref whiteColor, value); }
        public Color BlueColor { get => blueColor; set => SetField(ref blueColor, value); }
        public Color BlackColor { get => blackColor; set => SetField(ref blackColor, value); }
        public Color RedColor { get => redColor; set => SetField(ref redColor, value); }
        public string GreenColor { get => greenColor; set => SetField(ref greenColor, value); }

        //mainpage
        private int _health = 20;
        private bool _whiteBox;
        private bool _blueBox;
        private bool _blackBox;
        private bool _redBox;
        private string _greenBox = "false";
        private int _commander = 0;
        private int _experience = 0;
        private int _poison = 0;
        private bool __health;
        private bool __commander;
        private bool __poison;
        private bool __experience;


        private HealthValue _healthValue = HealthValue.Health;
        private Color mainLabel;
        private Color topLabel;
        private Color middleLabel;
        private Color bottomLabel;
        private string whiteColor = "Color.Gray";
        private Color blueColor;
        private Color blackColor;
        private Color redColor;
        private string greenColor = "Color.Gray";

        public Color MainLabel { get => mainLabel; set => SetField(ref mainLabel, value); }
        public Color TopLabel { get => topLabel; set => SetField(ref topLabel, value); }
        public Color MiddleLabel { get => middleLabel; set => SetField(ref middleLabel, value); }
        public Color BottomLabel { get => bottomLabel; set => SetField(ref bottomLabel, value); }

        public int Health { get => _health; set => SetField(ref _health, value); }
        public int Commander { get => _commander; set => SetField(ref _commander, value); }
        public int Experience { get => _experience; set => SetField(ref _experience, value); }
        public int Poison { get => _poison; set => SetField(ref _poison, value); }

        public bool Health_ { get => __health; set => SetField(ref __health, value); }
        public bool Commander_ { get => __commander; set => SetField(ref __commander, value); }
        public bool Poison_ { get => __poison; set => SetField(ref __poison, value); }
        public bool Experience_ { get => __experience; set => SetField(ref __experience, value); }

        //1 color
        public bool White { get => _whiteBox; set => SetField(ref _whiteBox, value); }
        public bool Blue { get => _blueBox; set => SetField(ref _blueBox, value); }
        public bool Black { get => _blackBox; set => SetField(ref _blackBox, value); }
        public bool Red { get => _redBox; set => SetField(ref _redBox, value); }
        public string Green { get => _greenBox; set => SetField(ref _greenBox, value); }

        //2 colors
        public bool Izzet => Red && Blue && Black == false && White == false && Green == "false";
        public bool Orzhov => White && Blue == false && Black && Red == false && Green == "false";
        public bool Azorius => White && Blue && Black == false && Red == false && Green == "false";
        public bool Boros => White && Blue == false && Black == false && Red && Green == "false";
        public bool Dimir => White == false && Blue && Black && Red == false && Green == "false";
        public bool Golgari => White == false && Blue == false && Black && Red == false && Green == "true";
        public bool Gruul => White == false && Blue == false && Black == false && Red && Green == "true";
        public bool Rakdos => White == false && Blue == false && Black && Red && Green == "false";
        public bool Selesnya => White && Blue == false && Black == false && Red == false && Green == "true";
        public bool Simic => White == false && Blue && Black == false && Red == false && Green == "true";

        //3 colors
        public bool Jund => Green == "true" && Red && Black;
        public bool Bant { get; set; } = false;
        public bool Grixis { get; set; } = false;
        public bool Naya => White && Green == "true" && Red;
        public bool Esper { get; set; } = false;
        public bool Jeskai { get; set; } = false;
        public bool Mardu { get; set; } = false;
        public bool Sultai { get; set; } = false;
        public bool Temur { get; set; } = false;
        public bool Abzan { get; set; } = false;

        public HealthValue SelectedHealth
        {
            get => _healthValue;
            set => SetField(ref _healthValue, value);
        }

        public int SelectedHealthValue
        {
            get
            {
                switch (SelectedHealth)
                {
                    case HealthValue.Health:

                        return _health;

                    case HealthValue.Commander:

                        return _commander;

                    case HealthValue.Experience:

                        return _experience;

                    case HealthValue.Poison:

                        return _poison;

                    default:

                        return 0;
                }
            }

            set
            {
                switch (SelectedHealth)
                {
                    case HealthValue.Health:

                        _health = value;
                        break;

                    case HealthValue.Commander:

                        _poison = value;
                        break;

                    case HealthValue.Experience:

                        _experience = value;
                        break;

                    case HealthValue.Poison:

                        _poison = value;
                        break;

                    default:

                        break;
                }
            }
        }

        public bool SelectedHealthCheck
        {
            get
            {
                switch (SelectedHealth)
                {
                    case HealthValue.Health:

                        return __health;

                    case HealthValue.Commander:

                        return __commander;

                    case HealthValue.Experience:

                        return __experience;

                    case HealthValue.Poison:

                        return __poison;

                    default:

                        return false;
                }
            }

            set
            {
                switch (SelectedHealth)
                {
                    case HealthValue.Health:

                        __health = value;
                        break;

                    case HealthValue.Commander:

                        __poison = value;
                        break;

                    case HealthValue.Experience:

                        __experience = value;
                        break;

                    case HealthValue.Poison:

                        __poison = value;
                        break;

                    default:

                        break;
                }
            }
        }

        public void ClearColors()
        {
            White = false;
            Blue = false;
            Black = false;
            Red = false;
            Green = "false";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        //notifies property changed
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //checks to make sure property change needs to be called
        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {

            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
