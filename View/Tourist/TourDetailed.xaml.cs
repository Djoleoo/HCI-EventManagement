﻿using BookingApp.Model;
using BookingApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookingApp.View.Tourist
{
    /// <summary>
    /// Interaction logic for TourDetailed.xaml
    /// </summary>
    public partial class TourDetailed : Window
    {
        public Tour Tour { get; set; }
        //public LocationRepository LocationRepository = new LocationRepository();
        //public List<Location> _locations {  get; set; }
        public TourDetailed(Tour selectedTour)
        {

            InitializeComponent();
            Tour = selectedTour;
            NameTextBlock.Text = Tour.Name;
            DescriptionTextBlock.Text = Tour.Description;
            StateTextBlock.Text = Tour.Location.State;
            if(!String.IsNullOrEmpty(Tour.Location.City))
            { 
                CityTextBlock.Text = ", " + Tour.Location.City;
            }
            else
            {
                CityTextBlock.Text = Tour.Location.City;
            }
            LanguageTextBlock.Text = Tour.Language;
            DateTextBlock.Text = Tour.DateTime.Date.ToString();

            DurationTextBlock.Text = Tour.Duration.ToString() + "h";

            MaxPeopleTextBlock.Text = Tour.MaxTourists.ToString();


            /*
            _locations = LocationRepository.GetAll();
            foreach(Location location in _locations)
            {
                if (location.Id == Tour.LocationId) 
                {
                    StateTextBlock.Text = location.State;
                    CityTextBlock.Text = location.City;
                }
            }
            */


        }
        private void LoadedFunctions(object sender, RoutedEventArgs e)
        {
            CenterWindow();
        }

        private void CenterWindow()
        {
            double SWidth = SystemParameters.PrimaryScreenWidth;
            double SHeight = SystemParameters.PrimaryScreenHeight;
            double WWidth = this.Width;
            double WHeight = this.Height;

            this.Left = (SWidth - WWidth) / 2;
            this.Top = (SHeight - WHeight) / 2;
        }

        public void GoBack(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void OpenReservationWindow(object sender, RoutedEventArgs e)
        {
            Close();
            TourReservation tourReservation = new TourReservation(Tour);
            tourReservation.ShowDialog();
        }
    }
}
