﻿using Lab2_Xam.Models;
using Lab2_Xam.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
// TODO: Question 5+
namespace Lab2_Xam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new StudentDetails(e.Item as Student));
        }
    }
}
