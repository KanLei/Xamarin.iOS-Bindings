using System;
using ObjCRuntime;

namespace TZImagePicker
{
    [Native]
    public enum TZAssetModelMediaType : ulong
    {
        Photo = 0,
        LivePhoto,
        PhotoGif,
        Video,
        Audio
    }
}

