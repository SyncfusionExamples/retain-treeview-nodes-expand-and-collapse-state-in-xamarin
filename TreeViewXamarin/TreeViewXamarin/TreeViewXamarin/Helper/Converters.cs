using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    #region ExpanderIconConverter
    public class ExpanderIconConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? ImageSource.FromResource("TreeViewXamarin.Icons.expand.png") : ImageSource.FromResource("TreeViewXamarin.Icons.collapse.png");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ExpanderIconVisibilityConverter
    public class ExpanderIconVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? true : false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region ExpanderStateConverer
    public class ExpanderStateConverer : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;

            var treeViewNode = value as Syncfusion.TreeView.Engine.TreeViewNode;
            var dataObject = treeViewNode.Content as FileManager;
            treeViewNode.IsExpanded = dataObject.IsExpanded;
            return dataObject.ItemName;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
