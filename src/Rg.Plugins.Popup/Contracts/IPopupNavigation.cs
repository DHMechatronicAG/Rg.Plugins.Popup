﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Events;
using Rg.Plugins.Popup.Pages;

namespace Rg.Plugins.Popup.Contracts
{
    public interface IPopupNavigation
    {
        IReadOnlyList<IPopupPage> PopupStack { get; }

        event EventHandler<PopupNavigationEventArgs> Pushing;

        event EventHandler<PopupNavigationEventArgs> Pushed;

        event EventHandler<PopupNavigationEventArgs> Popping;

        event EventHandler<PopupNavigationEventArgs> Popped;
        Task PushAsync(IPopupPage page, bool animate = true);

        Task PopAsync(bool animate = true);

        Task PopAllAsync(bool animate = true);

        Task RemovePageAsync(IPopupPage page, bool animate = true);
    }
}
