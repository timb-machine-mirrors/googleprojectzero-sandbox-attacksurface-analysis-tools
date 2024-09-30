﻿//  Copyright 2019 Google Inc. All Rights Reserved.
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

using System;

namespace NtCoreLib.Kernel.Debugger;

/// <summary>
/// Debug event for the Create Thread event.
/// </summary>
public sealed class CreateThreadDebugEvent : DebugEvent
{
    /// <summary>
    /// Subsystem key for the thread.
    /// </summary>
    public int ThreadSubSystemKey { get; }
    /// <summary>
    /// Start address of the thread.
    /// </summary>
    public long ThreadStartAddress { get; }
    /// <summary>
    /// Handle to the thread (if available).
    /// </summary>
    public NtThread Thread { get; }

    internal CreateThreadDebugEvent(DbgUiWaitStatusChange debug_event, NtDebug debug)
        : base(debug_event, debug)
    {
        var info = debug_event.StateInfo.CreateThread;
        Thread = info.HandleToThread == IntPtr.Zero ? null : NtThread.FromHandle(info.HandleToThread);
        var thread = info.NewThread;
        ThreadSubSystemKey = thread.SubSystemKey;
        ThreadStartAddress = thread.StartAddress.ToInt64();
    }

    /// <summary>
    /// Dispose the event.
    /// </summary>
    public override void Dispose()
    {
        Thread?.Dispose();
    }
}