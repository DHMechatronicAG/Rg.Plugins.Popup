using System;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Pages;

namespace Rg.Plugins.Popup.Contracts
{
    public interface IPopupPlatform
    {
        event EventHandler OnInitialized;

        bool IsInitialized { get; }

        bool IsSystemAnimationEnabled { get; }

        Task AddAsync(IPopupPage page);

        Task RemoveAsync(IPopupPage page);
    }
}
