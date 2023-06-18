# SOTFPostProcessing
 Change almost every post processing setting in Sons Of The Forest.  
 This mod also lets you enable Depth of Field.

## Installation
For BepInEx:
1) Put the SOTFPostProcessing.dll in the `BepInEx/plugins` folder.

For MelonLoader:
1) Put the SOTFPostProcessing.dll in the `Mods` folder.

## Usage
1) Start the game
2) Open the SOTFPostProcessing.cfg file in the BepInEx/config (or UserData for MelonLoader) folder
3) Change the settings to your liking
4) Save the file

**Note: The post processing settings automatically reload once you save the file**

## TODO
- Add custom sharpen solution

## Settings that can be changed (currently)

[AtmosphericScattering]
 - color
 - tint
 - density
 - maxFogDistance
 - mipFogMaxMip
 - mipFogNear
 - mipFogFar

[Fog]
 - enabled
 - color
 - tint
 - maxFogDistance
 - mipFogMaxMip
 - mipFogNear
 - mipFogFar
 - meanFreePath
 - enableVolumetricFog
 - albedo
 - globalLightProbeDimmer
 - depthExtent
 - anisotropy
 - sliceDistributionUniformity
 - screenResolutionPercentage
 - m_VolumetricFogBudget
 - m_ResolutionDepthRatio
 - directionalLightsOnly

[IndirectLightingController]
 - indirectDiffuseLightingMultiplier
 - reflectionLightingMultiplier
 - reflectionProbeIntensityMultiplier

[ScreenSpaceAmbientOcclusion]
 - rayTracing
 - intensity
 - directLightingStrength
 - radius
 - spatialBilateralAggressiveness
 - temporalAccumulation
 - ghostingReduction
 - blurSharpness
 - specularOcclusion
 - occluderMotionRejection
 - receiverMotionRejection
 - m_FullResolution
 - m_BilateralUpsample
 - m_RayLength
 - m_Denoise
 - m_DenoiserRadius

[ScreenSpaceReflection]
 - enabled
 - enabledTransparent
 - m_MinSmoothness
 - m_SmoothnessFadeStart
 - reflectSky
 - depthBufferThickness
 - screenFadeDistance
 - accumulationFactor
 - biasFactor
 - speedRejectionScalerFactor
 - speedSmoothReject
 - speedSurfaceOnly
 - speedTargetOnly
 - enableWorldSpeedRejection
 - ambientProbeDimmer
 - m_RayLength
 - m_ClampValue
 - m_Denoise
 - m_AffectSmoothSurfaces
 - m_FullResolution

[ContactShadows]
 - enable
 - length
 - opacity
 - distanceScaleFactor
 - maxDistance
 - minDistance
 - fadeDistance
 - fadeInDistance
 - rayBias
 - thicknessScale

[MicroShadowing]
 - enable
 - opacity

[VolumetricClouds]
 - enable
 - localClouds
 - earthCurvature
 - bottomAltitude
 - altitudeRange
 - fadeInStart
 - fadeInDistance
 - cumulusMapMultiplier
 - altoStratusMapMultiplier
 - cumulonimbusMapMultiplier
 - scatteringTint
 - powderEffectIntensity
 - multiScattering
 - densityMultiplier
 - shapeFactor
 - shapeScale
 - erosionFactor
 - erosionScale
 - ambientLightProbeDimmer
 - sunLightDimmer
 - erosionOcclusion
 - altitudeDistortion
 - cloudMapSpeedMultiplier
 - shapeSpeedMultiplier
 - erosionSpeedMultiplier
 - temporalAccumulationFactor
 - ghostingReduction
 - perceptualBlending
 - shadows
 - shadowDistance
 - shadowOpacity
 - shadowOpacityFallback
 - m_ObsoleteWindSpeed
 - m_ObsoleteOrientation

[Bloom]
 - threshold
 - intensity
 - scatter
 - tint
 - dirtIntensity
 - anamorphic
 - m_HighQualityPrefiltering
 - m_HighQualityFiltering

[ChromaticAberration]
 - intensity

[ColorAdjustments]
 - contrast
 - colorFilter
 - hueShift
 - saturation

[DepthOfField]
 - focusDistance
 - nearFocusStart
 - nearFocusEnd
 - farFocusStart
 - farFocusEnd
 - m_NearMaxBlur
 - m_FarMaxBlur
 - m_HighQualityFiltering
 - m_PhysicallyBased
 - m_LimitManualRangeNearBlur

[Exposure]
 - adaptationSpeedDarkToLight
 - adaptationSpeedLightToDark
 - histogramUseCurveRemapping
 - centerAroundExposureTarget

[LiftGammaGain]

[MotionBlur]
 - intensity
 - maximumVelocity
 - minimumVelocity
 - cameraMotionBlur
 - cameraVelocityClamp
 - cameraTranslationVelocityClamp
 - cameraRotationVelocityClamp
 - depthComparisonExtent

[Tonemapping]
 - useFullACES
 - toeStrength
 - toeLength
 - shoulderStrength
 - shoulderLength
 - shoulderAngle
 - gamma
 - lutContribution
 - hueShiftAmount
 - detectPaperWhite
 - paperWhite
 - detectBrightnessLimits
 - minNits
 - maxNits

[WhiteBalance]
 - temperature
 - tint

[VisualEnvironment]
 - windOrientation