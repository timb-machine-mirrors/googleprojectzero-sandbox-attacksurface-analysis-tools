﻿//  Copyright 2023 Google LLC. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
//  Note this is relicensed from OleViewDotNet by the author.

using System;
using System.Runtime.InteropServices;

namespace NtCoreLib.Win32.SideBySide.Interop;

[StructLayout(LayoutKind.Sequential)]
struct ACTIVATION_CONTEXT_DATA_COM_INTERFACE_REDIRECTION
{
    public int Size;
    public ACTIVATION_CONTEXT_DATA_COM_INTERFACE_REDIRECTION_FLAGS Flags;
    public Guid ProxyStubClsid32;
    public int NumMethods;
    public Guid TypeLibraryId;
    public Guid BaseInterface;
    public int NameLength; // in bytes
    public int NameOffset; // offset from ACTIVATION_CONTEXT_DATA_COM_INTERFACE_REDIRECTION because this is not shared
}