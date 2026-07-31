//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_chrome_toolbar_button_type_t.
//
namespace Xilium.CefGlue
{
    /// <summary>
    /// Chrome toolbar button types. Should be kept in sync with CEF's internal
    /// ToolbarButtonType type.
    /// </summary>
    public enum CefChromeToolbarButtonType
    {
        /// <summary>
        /// Deprecated since API 14000.
        /// </summary>
        CastDeprecated,

        /// <summary>
        /// Deprecated since API 13600.
        /// </summary>
        DownloadDeprecated,

        /// <summary>
        /// Deprecated since API 13600.
        /// </summary>
        SendTabToSelfDeprecated,

        /// <summary>
        /// Deprecated since API 14000.
        /// </summary>
        SidePanelDeprecated,

        /// <summary>
        /// Media button (API 14000+).
        /// </summary>
        Media,

        /// <summary>
        /// Tab search button. Deprecated since API 15100.
        /// </summary>
        TabSearchDeprecated,

        /// <summary>
        /// Battery saver button (API 14000+).
        /// </summary>
        BatterySaver,

        /// <summary>
        /// Avatar button (API 14000+).
        /// </summary>
        Avatar,

        NumValues,
    }
}
