﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using UnityEngine;
using XRTK.Definitions.Devices;

namespace XRTK.Providers.Controllers.UnityInput.Profiles
{
    [CreateAssetMenu(menuName = "Mixed Reality Toolkit/Input System/Controller Mappings/Xbox Controller Mapping Profile", fileName = "XboxControllerMappingProfile")]
    public class XboxControllerMappingProfile : BaseMixedRealityControllerMappingProfile
    {
        /// <inheritdoc />
        public override SupportedControllerType ControllerType => SupportedControllerType.Xbox;

        /// <inheritdoc />
        public override string TexturePath => $"{base.TexturePath}XboxController";

        protected override void Awake()
        {
            if (!HasSetupDefaults)
            {
                ControllerMappings = new[]
                {
                    new MixedRealityControllerMapping("Xbox Controller", typeof(XboxController))
                };
            }

            base.Awake();
        }
    }
}