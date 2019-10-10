using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rg.Plugins.Popup.Pages
{
    public interface IPopupPage
    {
        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        Task AppearingTransactionTask { get; set; }

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        Task DisappearingTransactionTask { get; set; }

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        void PreparingAnimation();

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        Task AppearingAnimation();

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        Task DisappearingAnimation();

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        void DisposingAnimation();

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        void ForceLayout();

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        Element Parent { get; set; }

        /// <summary>
        /// Called internally my Rg.Plugins.Popup. DO NOT USE.
        /// </summary>
        ContentPage ContentPage { get; }
    }
}
