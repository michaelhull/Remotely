﻿/*

Copyright 1985, 1986, 1987, 1991, 1998  The Open Group

Permission to use, copy, modify, distribute, and sell this software and its
documentation for any purpose is hereby granted without fee, provided that
the above copyright notice appear in all copies and that both that
copyright notice and this permission notice appear in supporting
documentation.

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.  IN NO EVENT SHALL THE
OPEN GROUP BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN
AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Except as contained in this notice, the name of The Open Group shall not be
used in advertising or otherwise to promote the sale, use or other dealings
in this Software without prior written authorization from The Open Group.

*/

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace Remotely_ScreenCast.Linux.X11Interop
{
    public static unsafe class LibX11
    {

        [DllImport("libX11")]
        public static extern IntPtr XGetImage(IntPtr display, IntPtr drawable, int x, int y, uint width, uint height, ulong plane_mask, int format);
        [DllImport("libX11")]
        public static extern int XScreenCount(IntPtr display);
        [DllImport("libX11")]
        public static extern int XDefaultScreen(IntPtr display);
        [DllImport("libX11")]
        public static extern IntPtr XOpenDisplay(string display_name);
        [DllImport("libX11")]
        public static extern void XCloseDisplay(IntPtr display);
        [DllImport("libX11")]
        public static extern IntPtr XRootWindow(IntPtr display, int screen_number);

        [DllImport("libX11")]
        public static extern IntPtr XGetSubImage(IntPtr display, IntPtr drawable, int x, int y, uint width, uint height, ulong plane_mask, int format, IntPtr dest_image, int dest_x, int dest_y);
        [DllImport("libX11")]
        public static extern IntPtr XScreenOfDisplay(IntPtr display, int screen_number);
        [DllImport("libX11")]
        public static extern int XDisplayWidth(IntPtr display, int screen_number);
        [DllImport("libX11")]
        public static extern int XDisplayHeight(IntPtr display, int screen_number);
        [DllImport("libX11")]
        public static extern int XWidthOfScreen(IntPtr screen);
        [DllImport("libX11")]
        public static extern int XHeightOfScreen(IntPtr screen);
        [DllImport("libX11")]
        public static extern IntPtr XDefaultGC(IntPtr display, int screen_number);
        [DllImport("libX11")]
        public static extern IntPtr XDefaultRootWindow(IntPtr display);
        [DllImport("libX11")]
        public static extern void XGetInputFocus(IntPtr display, out IntPtr focus_return, out int revert_to_return);
        [DllImport("libX11")]
        public static extern IntPtr XStringToKeysym(string key);
        [DllImport("libX11")]
        public static extern uint XKeysymToKeycode(IntPtr display, IntPtr keysym);

        [DllImport("libX11")]
        public static extern IntPtr XRootWindowOfScreen(IntPtr screen);
        [DllImport("libX11")]
        public static extern ulong XNextRequest(IntPtr display);
        [DllImport("libX11")]
        public static extern void XForceScreenSaver(IntPtr display, int mode);
        [DllImport("libX11")]
        public static extern void XSync(IntPtr display, bool discard);
    }
}
