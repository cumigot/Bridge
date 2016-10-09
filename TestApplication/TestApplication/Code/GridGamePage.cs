using System;
using Xamarin.Forms;

namespace TestApplication.Code
{
   public class GridGamePage : ContentPage
   {
      Func<View> portraitView;
      Func<View> landscapeView;

      public GridGamePage()
      {
         //Padding = 20;
         portraitView = () => new Grid /*************************************************** ORIENTATION PORTRAIT ************/
         {
            RowDefinitions =
            {
               new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
               new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
               new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
               new RowDefinition { Height = new GridLength(1,GridUnitType.Auto)}
            },
            ColumnDefinitions =
            {
               new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
            },
            Children =
            {
               //grid
               new Label { BackgroundColor = Color.Red, Text = "Nick"  }.GridRowCol(0,0),
               new Label { BackgroundColor = Color.Red, Text = "Coin"  }.GridRowCol(1,0),
               new Label { BackgroundColor = Color.Red, Text = "Table" }.GridRowCol(2,0),
               new Label { BackgroundColor = Color.Red, Text = "Bet"   }.GridRowCol(3,0),
               //menu
               new Label { BackgroundColor = Color.Purple, Text = "RM" }.GridRowCol(0,1).GridColSpan(1).GridRowSpan(4),
               new Label { BackgroundColor = Color.Pink,   Text = "CH" }.GridRowCol(0,2).GridColSpan(1).GridRowSpan(4),
               new Label { BackgroundColor = Color.Teal,   Text = "DP" }.GridRowCol(0,3).GridColSpan(1).GridRowSpan(4),
               new Label { BackgroundColor = Color.Olive,  Text = "WD" }.GridRowCol(0,4).GridColSpan(1).GridRowSpan(4),
               new Label { BackgroundColor = Color.Navy,   Text = "TC" }.GridRowCol(0,5).GridColSpan(1).GridRowSpan(4),
               new Label { BackgroundColor = Color.Silver, Text = "PW" }.GridRowCol(0,6).GridColSpan(1).GridRowSpan(4),
               new Label { BackgroundColor = Color.Gray,   Text = "QX" }.GridRowCol(0,7).GridColSpan(1).GridRowSpan(4),
               //gameView
               new Label { BackgroundColor = Color.Maroon, Text = "GAME VIEW" }.GridRowCol(4,0).GridRowSpan(5).GridColSpan(8)
            }
         };

         landscapeView = () => new Grid /*************************************************** ORIENTATION LANDSCAPE ************/
         {
            RowDefinitions =
            {
               new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
               new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
               new RowDefinition { Height = new GridLength(20, GridUnitType.Absolute) },
               new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }
            },
            ColumnDefinitions =
            {
               new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
            },
            Children =
            {
                //StatusBar
               new Label { BackgroundColor = Color.Red, Text = "Nick"  }.GridRowCol(0,0),
               new Label { BackgroundColor = Color.Red, Text = "Coin"  }.GridRowCol(1,0),
               new Label { BackgroundColor = Color.Red, Text = "Table" }.GridRowCol(2,0),
               new Label { BackgroundColor = Color.Red, Text = "Bet"   }.GridRowCol(3,0),
               //Menu Icon
               new Label { BackgroundColor = Color.Purple, Text = "ROOM" }.GridRowCol(4,0),
               new Label { BackgroundColor = Color.Pink,   Text = "CHAT" }.GridRowCol(5,0),
               new Label { BackgroundColor = Color.Teal,   Text = "DEPO" }.GridRowCol(6,0),
               new Label { BackgroundColor = Color.Olive,  Text = "WDR"  }.GridRowCol(7,0),
               new Label { BackgroundColor = Color.Navy,   Text = "COIN" }.GridRowCol(8,0),
               new Label { BackgroundColor = Color.Silver, Text = "PASS" }.GridRowCol(9,0),
               new Label { BackgroundColor = Color.Gray,   Text = "QUIT" }.GridRowCol(10,0),
               //Game View
               new Label { BackgroundColor = Color.Maroon, Text = "GAME VIEW" }.GridRowCol(0,1).GridColSpan(3).GridRowSpan(11)
             }
         };

         SizeChanged += (sender, e) => Content = IsPortrait(this) ? portraitView() : landscapeView();
      }

      static bool IsPortrait(Page p) { return p.Width < p.Height; }
   }

   static class GridExtensions
   {
      public static View GridRowCol(this View view, int row, int col)
      {
         Grid.SetRow(view, row);
         Grid.SetColumn(view, col);
         return view;
      }

      public static View GridRowSpan(this View view, int span)
      {
         Grid.SetRowSpan(view, span);
         return view;
      }

      public static View GridColSpan(this View view, int span)
      {
         Grid.SetColumnSpan(view, span);
         return view;
      }
   }
}//EOF
