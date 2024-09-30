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

using NtCoreLib.Utilities.Reflection;

namespace NtCoreLib.Win32.SideBySide.Parser;

/// <summary>
/// COM threading model.
/// </summary>
public enum ActivationContextDataComServerRedirectionThreadingModel
{
    [SDKName("ACTIVATION_CONTEXT_DATA_COM_SERVER_REDIRECTION_THREADING_MODEL_INVALID")]
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    Invalid = 0,
    [SDKName("ACTIVATION_CONTEXT_DATA_COM_SERVER_REDIRECTION_THREADING_MODEL_APARTMENT")]
    Apartment = 1,
    [SDKName("ACTIVATION_CONTEXT_DATA_COM_SERVER_REDIRECTION_THREADING_MODEL_FREE")]
    Free = 2,
    [SDKName("ACTIVATION_CONTEXT_DATA_COM_SERVER_REDIRECTION_THREADING_MODEL_SINGLE")]
    Single = 3,
    [SDKName("ACTIVATION_CONTEXT_DATA_COM_SERVER_REDIRECTION_THREADING_MODEL_BOTH")]
    Both = 4,
    [SDKName("ACTIVATION_CONTEXT_DATA_COM_SERVER_REDIRECTION_THREADING_MODEL_NEUTRAL")]
    Neutral = 5,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}