﻿using System.Runtime.InteropServices;

namespace OpenCover.Framework.Communication
{
    public enum MSG_Type : int
    {
        MSG_TrackAssembly = 1,
        MSG_GetSequencePoints = 2,
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct MSG_TrackAssembly_Request
    {
        public MSG_Type type;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string module;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string assembly;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MSG_TrackAssembly_Response
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool track;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Unicode)]
    public struct MSG_GetSequencePoints_Request
    {
        public MSG_Type type;
        public int functionToken;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
        public string module;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MSG_SequencePoint
    {
        public uint UniqueId;
        public int Offset;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct MSG_GetSequencePoints_Response
    {
        [MarshalAs(UnmanagedType.Bool)]
        public bool more;

        public int count;
    }

}
