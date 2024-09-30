﻿//  Copyright 2020 Google Inc. All Rights Reserved.
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

using System.Runtime.InteropServices;

namespace NtCoreLib.Win32.Filter.Interop;

[StructLayout(LayoutKind.Sequential)]
internal struct FILTER_INSTANCE_FULL_INFORMATION
{
    public int NextEntryOffset;
    public ushort InstanceNameLength;
    public ushort InstanceNameBufferOffset;
    public ushort AltitudeLength;
    public ushort AltitudeBufferOffset;
    public ushort VolumeNameLength;
    public ushort VolumeNameBufferOffset;
    public ushort FilterNameLength;
    public ushort FilterNameBufferOffset;
}