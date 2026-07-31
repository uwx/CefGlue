namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;

    /// <summary>
    /// Callback interface for component update results.
    /// </summary>
    public abstract unsafe partial class CefComponentUpdateCallback
    {
        private void on_complete(cef_component_update_callback_t* self, cef_string_t* component_id, CefComponentUpdateError error)
        {
            CheckSelf(self);

            OnComplete(cef_string_t.ToString(component_id), error);
        }

        /// <summary>
        /// Method that will be called when component update is complete.
        /// </summary>
        /// <param name="componentId">The component ID.</param>
        /// <param name="error">The update error result.</param>
        protected abstract void OnComplete(string componentId, CefComponentUpdateError error);
    }
}
