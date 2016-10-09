using Xamarin.Forms;

namespace TestApplication.Code
{
   public class Calculator : ContentPage
   {
      public Calculator()
      {
         Title = "Calculator";
         BackgroundColor = Color.FromHex("#404040");

         // Make Global Style for Button
         var plainButton = new Style(typeof(Button))
         {  //Global property untuk Button Plain
            Setters =
            {
               new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#eee") },
               new Setter { Property = Button.TextColorProperty, Value = Color.Black },
               new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
               new Setter { Property = Button.FontSizeProperty, Value = 40 }
            }
         };

         var darkerButton = new Style(typeof(Button))
         {   //Global property untuk Button Dark
            Setters =
            {
               new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#ddd") },
               new Setter { Property = Button.TextColorProperty, Value = Color.Black },
               new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
               new Setter { Property = Button.FontSizeProperty, Value = 40 }
            }
         };

         var orangeButton = new Style(typeof(Button))
         {   //Global property untuk Button Orange
            Setters =
            {
               new Setter { Property = Button.BackgroundColorProperty, Value = Color.FromHex("#E8AD00") },
               new Setter { Property = Button.TextColorProperty, Value = Color.Black },
               new Setter { Property = Button.BorderRadiusProperty, Value = 0 },
               new Setter { Property = Button.FontSizeProperty, Value = 40 }
            }
         };

         var ctrGrid = new Grid { RowSpacing = 1, ColumnSpacing = 1 }; //buat per kotak

         // Bikin 6 Baris
         ctrGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(150) }); //untuk baris pertama lebih tinggi
         ctrGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // baris 2
         ctrGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // baris 3
         ctrGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // baris 4
         ctrGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // baris 5
         ctrGrid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }); // baris 6
                                                                                                          // Bikin 4 Kolom
         ctrGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }); // kolom 1
         ctrGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }); // kolom 2
         ctrGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }); // kolom 3
         ctrGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }); // kolom 4


         var labelHasil = new Label
         {
            Text = "0",
            HorizontalTextAlignment = TextAlignment.End,    // Teks rata kanan
            VerticalTextAlignment = TextAlignment.End,      // Teks rata bawah
            TextColor = Color.White,
            FontSize = 60
         };

         ctrGrid.Children.Add(labelHasil, 0, 0); // add to content posisi atas - kiri

         Grid.SetColumnSpan(labelHasil, 4); // span baris untuk label hasil


         //add button dengan global property button
         //Baris 1
         ctrGrid.Children.Add(new Button { Text = "C", Style = darkerButton }, 0, 1);
         ctrGrid.Children.Add(new Button { Text = "+/-", Style = darkerButton }, 1, 1);
         ctrGrid.Children.Add(new Button { Text = "%", Style = darkerButton }, 2, 1);
         ctrGrid.Children.Add(new Button { Text = "/", Style = orangeButton }, 3, 1);
         //Baris 2
         ctrGrid.Children.Add(new Button { Text = "7", Style = plainButton }, 0, 2);
         ctrGrid.Children.Add(new Button { Text = "8", Style = plainButton }, 1, 2);
         ctrGrid.Children.Add(new Button { Text = "9", Style = plainButton }, 2, 2);
         ctrGrid.Children.Add(new Button { Text = "x", Style = orangeButton }, 3, 2);
         //Baris 3
         ctrGrid.Children.Add(new Button { Text = "4", Style = plainButton }, 0, 3);
         ctrGrid.Children.Add(new Button { Text = "5", Style = plainButton }, 1, 3);
         ctrGrid.Children.Add(new Button { Text = "6", Style = plainButton }, 2, 3);
         ctrGrid.Children.Add(new Button { Text = "-", Style = orangeButton }, 3, 3);
         //Baris 4
         ctrGrid.Children.Add(new Button { Text = "1", Style = plainButton }, 0, 4);
         ctrGrid.Children.Add(new Button { Text = "2", Style = plainButton }, 1, 4);
         ctrGrid.Children.Add(new Button { Text = "3", Style = plainButton }, 2, 4);
         ctrGrid.Children.Add(new Button { Text = "+", Style = orangeButton }, 3, 4);
         //Baris 5
         ctrGrid.Children.Add(new Button { Text = ".", Style = plainButton }, 2, 5);
         ctrGrid.Children.Add(new Button { Text = "=", Style = orangeButton }, 3, 5);
         //Baris ke 5 angka 0 span 2 kolom
         var nolButton = new Button { Text = "0", Style = plainButton };
         ctrGrid.Children.Add(nolButton, 0, 5);
         Grid.SetColumnSpan(nolButton, 2);

         Content = ctrGrid;
      }
   }
}
