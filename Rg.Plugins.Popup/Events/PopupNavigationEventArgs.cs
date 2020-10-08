using System;
using Rg.Plugins.Popup.Pages;

namespace Rg.Plugins.Popup.Events
{
    public class PopupNavigationEventArgs : EventArgs
    {
        public IPopupPage Page { get; }

        public bool IsAnimated { get; }

        public PopupNavigationEventArgs(IPopupPage page, bool isAnimated)
        {
            Page = page;
            IsAnimated = isAnimated;
        }
    }
}
