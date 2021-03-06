﻿// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Collections.Generic;
using UnityEngine;

namespace XRTK.Inspectors.Utilities.SymbolicLinks
{
    /// <summary>
    /// Holds the current symbolic link references in the project
    /// </summary>
    [CreateAssetMenu(menuName = "Mixed Reality Toolkit/Symbolic Link Settings", fileName = "SymbolicLinkSettings"/*, order = (int)CreateProfileMenuItemIndices.Settings*/)]
    public class SymbolicLinkSettings : ScriptableObject
    {
        [SerializeField]
        private List<SymbolicLink> symbolicLinks = new List<SymbolicLink>();

        /// <summary>
        /// Returns a copy the the current symbolic links.
        /// </summary>
        public List<SymbolicLink> SymbolicLinks => symbolicLinks;
    }
}