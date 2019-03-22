﻿
using UnityEngine;

namespace TrekVRApplication {

    public static class XRInteractablePlanetConstants {

        public const int CoordinateIndicatorSegmentCount = 72;

        public const float CoordinateIndicatorStaticThickness = 1e-3f;

        public const float CoordinateIndicatorStaticBoldThickness = 2.5e-3f;

        public const float CoordinateIndicatorThickness = 1.5e-3f;

        public const float CoordinateIndicatorActiveThickness = 6.9e-3f;

        public const float CoordinateIndicatorRadiusOffset = 3.33e-3f;

        public const float CoordinateIndicatorLabelRadiusOffset = 3.1e-2f;

        public const float CoordinateIndicatorStaticFadeDuration = 0.5f;

        public const float CoordinateIndicatorStaticFadeInDistance = 3.7f;

        public const float CoordinateIndicatorStaticFadeOutDistance = 4.20f;

        public const float CoordinateIndicatorStaticLabelFadeInDistance = 2.0f;

        public const float CoordinateIndicatorStaticLabelFadeOutDistance = 2.5f;

        public static readonly Color32 CoordinateIndicatorColor = new Color32(0, 224, 255, 255);

        public static readonly Color32 CoordinateIndicatorStaticColor = new Color32(255, 127, 32, 255);

        public const int HemisphereLongLatCoordinateIndicatorCount = 5;

    }

}
