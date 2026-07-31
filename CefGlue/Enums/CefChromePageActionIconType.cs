//
// This file manually written from cef/include/internal/cef_types.h.
// C API name: cef_chrome_page_action_icon_type_t.
//
namespace Xilium.CefGlue
{
    using System;

    /// <summary>
    /// Chrome page action icon types. Should be kept in sync with Chromium's
    /// PageActionIconType type.
    /// </summary>
    public enum CefChromePageActionIconType
    {
        BookmarkStar,
        ClickToCall,
        CookieControls,
        FileSystemAccess,
        Find,
        MemorySaver,
        IntentPicker,
        LocalCardMigration,
        ManagePasswords,
        PaymentsOfferNotification,
        PriceTracking,
        PwaInstall,
        QrCodeGeneratorDeprecated,
        ReaderModeDeprecated,
        SaveAutofillAddress,
        SaveCard,
        SendTabToSelfDeprecated,
        SharingHub,
        SideSearchDeprecated,
        SmsRemoteFetcher,
        Translate,
        VirtualCardEnroll,
        VirtualCardInformation,
        Zoom,
        SaveIban,
        MandatoryReauth,
        PriceInsights,
        ReadAnythingDeprecated,
        ProductSpecifications,
        LensOverlay,
        Discounts,
        OptimizationGuide,
        CollaborationMessaging,
        ChangePassword,

        /// <summary>
        /// Lens overlay homework (API 13800+).
        /// </summary>
        LensOverlayHomework,

        /// <summary>
        /// AI mode (API 14000+).
        /// </summary>
        AiMode,

        /// <summary>
        /// Reading mode (API 14400+).
        /// </summary>
        ReadingMode,

        /// <summary>
        /// Contextual side panel (API 14400+).
        /// </summary>
        ContextualSidePanel,

        /// <summary>
        /// JS optimizations (API 14400+).
        /// </summary>
        JsOptimizations,

        /// <summary>
        /// Record replay (API 14700+).
        /// </summary>
        RecordReplay,

        /// <summary>
        /// Indigo (API 14700+).
        /// </summary>
        Indigo,

        /// <summary>
        /// Federation (API 14800+).
        /// </summary>
        Federation,

        /// <summary>
        /// Glic (API 14800+).
        /// </summary>
        Glic,

        /// <summary>
        /// Anchored contextual cue (API 14900+).
        /// </summary>
        AnchoredContextualCue,

        /// <summary>
        /// WebAuthn ambient sign-in (API 14900+).
        /// </summary>
        WebAuthnAmbientSignin,

        /// <summary>
        /// Autofill payment (API 15000+).
        /// </summary>
        AutofillPayment,

        /// <summary>
        /// Multistep filter (API 15000+).
        /// </summary>
        MultistepFilter,

        NumValues,
    }
}
