using MvvmCross.iOS.Views;
using MvvmCross.iOS.Support.XamarinSidebar;
using MvvmCross.iOS.Support.XamarinSidebar.Attributes;
using UIKit;
using System;
using XamarinSideBar.Core.ViewModels;

namespace XamarinSideBar.iOS.Views
{
    [MvxFromStoryboard("Main")]
    [MvxSidebarPresentation(MvxPanelEnum.Left, MvxPanelHintType.PushPanel, true)]
    public partial class LeftView : MvxViewController<LeftViewModel>
    {
        public LeftView(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

