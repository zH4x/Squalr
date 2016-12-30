// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium {
    using Event;

    /// <summary>
    /// Structure to implement to be notified of asynchronous completion via
    /// CfxCookieManager.DeleteCookies().
    /// </summary>
    /// <remarks>
    /// See also the original CEF documentation in
    /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
    /// </remarks>
    public class CfxDeleteCookiesCallback : CfxClientBase {

        private static object eventLock = new object();

        internal static void SetNativeCallbacks() {
            on_complete_native = on_complete;

            on_complete_native_ptr = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate(on_complete_native);
        }

        // on_complete
        [System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = false)]
        private delegate void on_complete_delegate(IntPtr gcHandlePtr, int num_deleted);
        private static on_complete_delegate on_complete_native;
        private static IntPtr on_complete_native_ptr;

        internal static void on_complete(IntPtr gcHandlePtr, int num_deleted) {
            var self = (CfxDeleteCookiesCallback)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null || self.CallbacksDisabled) {
                return;
            }
            var e = new CfxDeleteCookiesCallbackOnCompleteEventArgs(num_deleted);
            self.m_OnComplete?.Invoke(self, e);
            e.m_isInvalid = true;
        }

        internal CfxDeleteCookiesCallback(IntPtr nativePtr) : base(nativePtr) {}
        public CfxDeleteCookiesCallback() : base(CfxApi.DeleteCookiesCallback.cfx_delete_cookies_callback_ctor) {}

        /// <summary>
        /// Method that will be called upon completion. |NumDeleted| will be the
        /// number of cookies that were deleted or -1 if unknown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public event CfxDeleteCookiesCallbackOnCompleteEventHandler OnComplete {
            add {
                lock(eventLock) {
                    if(m_OnComplete == null) {
                        CfxApi.DeleteCookiesCallback.cfx_delete_cookies_callback_set_callback(NativePtr, 0, on_complete_native_ptr);
                    }
                    m_OnComplete += value;
                }
            }
            remove {
                lock(eventLock) {
                    m_OnComplete -= value;
                    if(m_OnComplete == null) {
                        CfxApi.DeleteCookiesCallback.cfx_delete_cookies_callback_set_callback(NativePtr, 0, IntPtr.Zero);
                    }
                }
            }
        }

        private CfxDeleteCookiesCallbackOnCompleteEventHandler m_OnComplete;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_OnComplete != null) {
                m_OnComplete = null;
                CfxApi.DeleteCookiesCallback.cfx_delete_cookies_callback_set_callback(NativePtr, 0, IntPtr.Zero);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        /// <summary>
        /// Method that will be called upon completion. |NumDeleted| will be the
        /// number of cookies that were deleted or -1 if unknown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public delegate void CfxDeleteCookiesCallbackOnCompleteEventHandler(object sender, CfxDeleteCookiesCallbackOnCompleteEventArgs e);

        /// <summary>
        /// Method that will be called upon completion. |NumDeleted| will be the
        /// number of cookies that were deleted or -1 if unknown.
        /// </summary>
        /// <remarks>
        /// See also the original CEF documentation in
        /// <see href="https://bitbucket.org/chromiumfx/chromiumfx/src/tip/cef/include/capi/cef_cookie_capi.h">cef/include/capi/cef_cookie_capi.h</see>.
        /// </remarks>
        public class CfxDeleteCookiesCallbackOnCompleteEventArgs : CfxEventArgs {

            internal int m_num_deleted;

            internal CfxDeleteCookiesCallbackOnCompleteEventArgs(int num_deleted) {
                m_num_deleted = num_deleted;
            }

            /// <summary>
            /// Get the NumDeleted parameter for the <see cref="CfxDeleteCookiesCallback.OnComplete"/> callback.
            /// </summary>
            public int NumDeleted {
                get {
                    CheckAccess();
                    return m_num_deleted;
                }
            }

            public override string ToString() {
                return String.Format("NumDeleted={{{0}}}", NumDeleted);
            }
        }

    }
}