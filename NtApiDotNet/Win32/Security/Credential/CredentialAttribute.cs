﻿//  Copyright 2021 Google Inc. All Rights Reserved.
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

using NtApiDotNet.Win32.Security.Native;
using System.Runtime.InteropServices;

namespace NtApiDotNet.Win32.Security.Credential
{
    /// <summary>
    /// Class to represent a credential attribute.
    /// </summary>
    public class CredentialAttribute
    {
        private readonly byte[] _value;

        /// <summary>
        /// Attribute keyword.
        /// </summary>
        public string Keyword { get; }
        /// <summary>
        /// Attribute flags.
        /// </summary>
        public CredentialAttributeFlags Flags { get; }
        /// <summary>
        /// Attribute value.
        /// </summary>
        public byte[] Value => _value.CloneBytes();

        /// <summary>
        /// Overridden ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Keyword;
        }

        internal CredentialAttribute(CREDENTIAL_ATTRIBUTE attr)
        {
            Keyword = attr.Keyword;
            Flags = attr.Flags;
            _value = new byte[attr.ValueSize];
            Marshal.Copy(attr.Value, _value, 0, _value.Length);
        }
    }
}
