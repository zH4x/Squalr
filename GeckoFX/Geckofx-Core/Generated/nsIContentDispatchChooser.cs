// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIContentDispatchChooser.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// This is used to ask a user what they would like to do with a given piece of
    /// content.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("456ca3b2-02be-4f97-89a2-08c08d3ad88f")]
	public interface nsIContentDispatchChooser
	{
		
		/// <summary>
        /// Asks the user what to do with the content.
        ///
        /// @param aHander
        /// The interface describing the details of how this content should or
        /// can be handled.
        /// @param aWindowContext
        /// The parent window context to show this chooser.  This can be null,
        /// and some implementations may not care about it.  Generally, you'll
        /// want to pass an nsIDOMWindow in so the chooser can be properly
        /// parented when opened.
        /// @param aURI
        /// The URI of the resource that we are asking about.
        /// @param aReason
        /// The reason why we are asking (see above).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Ask([MarshalAs(UnmanagedType.Interface)] nsIHandlerInfo aHandler, [MarshalAs(UnmanagedType.Interface)] nsIInterfaceRequestor aWindowContext, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, uint aReason);
	}
	
	/// <summary>nsIContentDispatchChooserConsts </summary>
	public class nsIContentDispatchChooserConsts
	{
		
		// <summary>
        // This request is passed to the helper app dialog because Gecko can not
        // handle content of this type.
        // </summary>
		public const ulong REASON_CANNOT_HANDLE = 0;
	}
}