using Xamarin.Forms;

namespace TestApplication.Code
{
   static class GridExtend
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
}
