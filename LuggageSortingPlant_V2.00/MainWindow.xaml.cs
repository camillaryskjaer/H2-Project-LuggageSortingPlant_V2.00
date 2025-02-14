﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LuggageSortingPlant_V2._00
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainServer manager = new MainServer();

        public MainWindow()
        {
            InitializeComponent();
            manager = new MainServer();

            StartLuggageController();
            CheckInsOnAndOffColor();
        }
        private void Button_Start(object sender, RoutedEventArgs e)
        {
            manager.RunSimulation();
        }
        private void Button_Stop(object sender, RoutedEventArgs e)
        {

        }

        private void StartLuggageController()
        {
            LuggageController luggageController = new LuggageController();
            luggageController.countLuggage += OnLuggageCreated;
        }


        //Eventlistener to receive the current count of luggage in the hall.
        public void OnLuggageCreated(object sender, EventArgs e)//Event Listener
        {

            //EventListener
            if (e is LuggageEvent)
            {
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                {
                    lbl_luggageInQueue.Content = ((LuggageEvent)e).Count.ToString();
                }));
            }
        }


        //Controlling the colors on the checkins depending if they are open or closed
        private void CheckInsOnAndOffColor()
        {
            for (int i = 0; i < MainServer.amountOfCheckIns; i++)
            {
            CheckInController checkInController = new CheckInController(i);
            checkInController.OpenCloseCheckIns += ChangeColor;
            }
        }

        //Event Listener method
        public void ChangeColor(object sender, EventArgs e)//Event Listener
        {

            if (e is CheckInEvent)
            {
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() =>
                {
                    switch (((CheckInEvent)e).CheckIn.CheckInNumber)
                    {
                        case 0:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn0.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn0.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 1:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn1.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn1.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 2:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn2.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn2.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 3:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn3.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn3.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 4:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn4.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn4.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 5:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn5.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn5.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 6:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn6.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn6.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 7:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn7.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn7.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 8:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn8.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn8.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                        case 9:
                            if (((CheckInEvent)e).CheckIn.Open)
                            {
                                lbl_checkIn9.Background = new SolidColorBrush(Colors.Green);
                            }
                            else
                            {
                                lbl_checkIn9.Background = new SolidColorBrush(Colors.Red);
                            }
                            break;
                    }
                }));
            }
        }

    }
}
