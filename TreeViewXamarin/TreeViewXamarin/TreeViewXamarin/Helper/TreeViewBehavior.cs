using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class TreeViewBehavior : Behavior<SfTreeView>
    {
        protected override void OnAttachedTo(SfTreeView bindable)
        {
            bindable.NodeExpanded += Bindable_NodeExpanded;
            bindable.NodeCollapsed += Bindable_NodeCollapsed;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfTreeView bindable)
        {
            bindable.NodeExpanded -= Bindable_NodeExpanded;
            bindable.NodeCollapsed -= Bindable_NodeCollapsed;
            base.OnDetachingFrom(bindable);
        }

        private void Bindable_NodeCollapsed(object sender, NodeExpandedCollapsedEventArgs e)
        {
            (e.Node.Content as FileManager).IsExpanded = e.Node.IsExpanded;
        }

        private void Bindable_NodeExpanded(object sender, NodeExpandedCollapsedEventArgs e)
        {
            (e.Node.Content as FileManager).IsExpanded = e.Node.IsExpanded;
        }
    }
}
