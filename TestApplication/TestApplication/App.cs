﻿using System;
using Xamarin.Forms;

namespace TestApplication
{
   public class App : Application
   {
      public App()
      {

         MainPage = new CalculatorCode();
         //MainPage = new ContentPage { Content = new StackLayout { VerticalOptions = LayoutOptions.Center, Children = { new Label { HorizontalTextAlignment = TextAlignment.Center, Text = "Welcome to Xamarin Forms!" }}}};
      }

      protected override void OnStart()
      {
         // Handle when your app starts
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }
   }
}
