using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using SOTFPostProcessing.Loader.Common.Configuration;

public class PostProcessingSettings
{
	public SAtmosphericScattering AtmosphericScattering;
	public SFog Fog;
	public SIndirectLightingController IndirectLightingController;
	public SScreenSpaceAmbientOcclusion ScreenSpaceAmbientOcclusion;
	public SScreenSpaceReflection ScreenSpaceReflection;
	public SContactShadows ContactShadows;
	public SMicroShadowing MicroShadowing;
	public SVolumetricClouds VolumetricClouds;
	public SBloom Bloom;
	public SChromaticAberration ChromaticAberration;
	public SColorAdjustments ColorAdjustments;
	public SDepthOfField DepthOfField;
	public SExposure Exposure;
	public SLiftGammaGain LiftGammaGain;
	public SMotionBlur MotionBlur;
	public STonemapping Tonemapping;
	public SWhiteBalance WhiteBalance;
	public SVisualEnvironment VisualEnvironment;

	public PostProcessingSettings(VolumeProfile profile)
	{
		if(profile.TryGet(out AtmosphericScattering atmosphericScattering))
			AtmosphericScattering = new SAtmosphericScattering(atmosphericScattering);
		if(profile.TryGet(out Fog fog))
			Fog = new SFog(fog);
		if(profile.TryGet(out IndirectLightingController indirectLightingController))
			IndirectLightingController = new SIndirectLightingController(indirectLightingController);
		if(profile.TryGet(out ScreenSpaceAmbientOcclusion screenSpaceAmbientOcclusion))
			ScreenSpaceAmbientOcclusion = new SScreenSpaceAmbientOcclusion(screenSpaceAmbientOcclusion);
		if(profile.TryGet(out ScreenSpaceReflection screenSpaceReflection))
			ScreenSpaceReflection = new SScreenSpaceReflection(screenSpaceReflection);
		if(profile.TryGet(out ContactShadows contactShadows))
			ContactShadows = new SContactShadows(contactShadows);
		if(profile.TryGet(out MicroShadowing microShadowing))
			MicroShadowing = new SMicroShadowing(microShadowing);
		if(profile.TryGet(out VolumetricClouds volumetricClouds))
			VolumetricClouds = new SVolumetricClouds(volumetricClouds);
		if(profile.TryGet(out Bloom bloom))
			Bloom = new SBloom(bloom);
		if(profile.TryGet(out ChromaticAberration chromaticAberration))
			ChromaticAberration = new SChromaticAberration(chromaticAberration);
		if(profile.TryGet(out ColorAdjustments colorAdjustments))
			ColorAdjustments = new SColorAdjustments(colorAdjustments);
		if(!profile.TryGet(out DepthOfField depthOfField))
		{
			depthOfField = profile.Add<DepthOfField>();
		}
		DepthOfField = new SDepthOfField(depthOfField);
		if(profile.TryGet(out Exposure exposure))
			Exposure = new SExposure(exposure);
		if(profile.TryGet(out LiftGammaGain liftGammaGain))
			LiftGammaGain = new SLiftGammaGain(liftGammaGain);
		if(profile.TryGet(out MotionBlur motionBlur))
			MotionBlur = new SMotionBlur(motionBlur);
		if(profile.TryGet(out Tonemapping tonemapping))
			Tonemapping = new STonemapping(tonemapping);
		if(profile.TryGet(out WhiteBalance whiteBalance))
			WhiteBalance = new SWhiteBalance(whiteBalance);
		if(profile.TryGet(out VisualEnvironment visualEnvironment))
			VisualEnvironment = new SVisualEnvironment(visualEnvironment);
	}

	public void ApplyFromConfig()
	{
		if(AtmosphericScattering != null)
			AtmosphericScattering.ApplyFromConfig();
		if(Fog != null)
			Fog.ApplyFromConfig();
		if(IndirectLightingController != null)
			IndirectLightingController.ApplyFromConfig();
		if(ScreenSpaceAmbientOcclusion != null)
			ScreenSpaceAmbientOcclusion.ApplyFromConfig();
		if(ScreenSpaceReflection != null)
			ScreenSpaceReflection.ApplyFromConfig();
		if(ContactShadows != null)
			ContactShadows.ApplyFromConfig();
		if(MicroShadowing != null)
			MicroShadowing.ApplyFromConfig();
		if(VolumetricClouds != null)
			VolumetricClouds.ApplyFromConfig();
		if(Bloom != null)
			Bloom.ApplyFromConfig();
		if(ChromaticAberration != null)
			ChromaticAberration.ApplyFromConfig();
		if(ColorAdjustments != null)
			ColorAdjustments.ApplyFromConfig();
		if(DepthOfField != null)
			DepthOfField.ApplyFromConfig();
		if(Exposure != null)
			Exposure.ApplyFromConfig();
		if(LiftGammaGain != null)
			LiftGammaGain.ApplyFromConfig();
		if(MotionBlur != null)
			MotionBlur.ApplyFromConfig();
		if(Tonemapping != null)
			Tonemapping.ApplyFromConfig();
		if(WhiteBalance != null)
			WhiteBalance.ApplyFromConfig();
		if(VisualEnvironment != null)
			VisualEnvironment.ApplyFromConfig();
	}

	public void SetSettings(VolumeProfile profile)
	{
		if(profile.TryGet(out AtmosphericScattering atmosphericScattering) && AtmosphericScattering != null)
			AtmosphericScattering.SetSetting(atmosphericScattering);
		if(profile.TryGet(out Fog fog) && Fog != null)
			Fog.SetSetting(fog);
		if(profile.TryGet(out IndirectLightingController indirectLightingController) && IndirectLightingController != null)
			IndirectLightingController.SetSetting(indirectLightingController);
		if(profile.TryGet(out ScreenSpaceAmbientOcclusion screenSpaceAmbientOcclusion) && ScreenSpaceAmbientOcclusion != null)
			ScreenSpaceAmbientOcclusion.SetSetting(screenSpaceAmbientOcclusion);
		if(profile.TryGet(out ScreenSpaceReflection screenSpaceReflection) && ScreenSpaceReflection != null)
			ScreenSpaceReflection.SetSetting(screenSpaceReflection);
		if(profile.TryGet(out ContactShadows contactShadows) && ContactShadows != null)
			ContactShadows.SetSetting(contactShadows);
		if(profile.TryGet(out MicroShadowing microShadowing) && MicroShadowing != null)
			MicroShadowing.SetSetting(microShadowing);
		if(profile.TryGet(out VolumetricClouds volumetricClouds) && VolumetricClouds != null)
			VolumetricClouds.SetSetting(volumetricClouds);
		if(profile.TryGet(out Bloom bloom) && Bloom != null)
			Bloom.SetSetting(bloom);
		if(profile.TryGet(out ChromaticAberration chromaticAberration) && ChromaticAberration != null)
			ChromaticAberration.SetSetting(chromaticAberration);
		if(profile.TryGet(out ColorAdjustments colorAdjustments) && ColorAdjustments != null)
			ColorAdjustments.SetSetting(colorAdjustments);
		if(!profile.TryGet(out DepthOfField depthOfField))
		{
			depthOfField = profile.Add<DepthOfField>();
		}
		if(DepthOfField == null)
			DepthOfField = new SDepthOfField(depthOfField);
		else
			DepthOfField.SetSetting(depthOfField);
		if(profile.TryGet(out Exposure exposure) && Exposure != null)
			Exposure.SetSetting(exposure);
		if(profile.TryGet(out LiftGammaGain liftGammaGain) && LiftGammaGain != null)
			LiftGammaGain.SetSetting(liftGammaGain);
		if(profile.TryGet(out MotionBlur motionBlur) && MotionBlur != null)
			MotionBlur.SetSetting(motionBlur);
		if(profile.TryGet(out Tonemapping tonemapping) && Tonemapping != null)
			Tonemapping.SetSetting(tonemapping);
		if(profile.TryGet(out WhiteBalance whiteBalance) && WhiteBalance != null)
			WhiteBalance.SetSetting(whiteBalance);
		if(profile.TryGet(out VisualEnvironment visualEnvironment) && VisualEnvironment != null)
			VisualEnvironment.SetSetting(visualEnvironment);
	}
}

public class SAtmosphericScattering
{
	private AtmosphericScattering _setting;

	public Color Color
	{
		get {return _setting.color.value;}
		set {_setting.color.Override(value);}
	}

	public Color Tint
	{
		get {return _setting.tint.value;}
		set {_setting.tint.Override(value);}
	}

	public float Density
	{
		get {return _setting.density.value;}
		set {_setting.density.Override(value);}
	}

	public float MaxFogDistance
	{
		get {return _setting.maxFogDistance.value;}
		set {_setting.maxFogDistance.Override(value);}
	}

	public float MipFogMaxMip
	{
		get {return _setting.mipFogMaxMip.value;}
		set {_setting.mipFogMaxMip.Override(value);}
	}

	public float MipFogNear
	{
		get {return _setting.mipFogNear.value;}
		set {_setting.mipFogNear.Override(value);}
	}

	public float MipFogFar
	{
		get {return _setting.mipFogFar.value;}
		set {_setting.mipFogFar.Override(value);}
	}

	private ConfigElement<Color> _configColor;
	private ConfigElement<bool> _configOverrideColor;
	private ConfigElement<Color> _configTint;
	private ConfigElement<bool> _configOverrideTint;
	private ConfigElement<float> _configDensity;
	private ConfigElement<bool> _configOverrideDensity;
	private ConfigElement<float> _configMaxFogDistance;
	private ConfigElement<bool> _configOverrideMaxFogDistance;
	private ConfigElement<float> _configMipFogMaxMip;
	private ConfigElement<bool> _configOverrideMipFogMaxMip;
	private ConfigElement<float> _configMipFogNear;
	private ConfigElement<bool> _configOverrideMipFogNear;
	private ConfigElement<float> _configMipFogFar;
	private ConfigElement<bool> _configOverrideMipFogFar;

	public SAtmosphericScattering(AtmosphericScattering setting)
	{
		_setting = setting;

		_configColor = new("color", "Color", _setting.color.value, "AtmosphericScattering");
		_configOverrideColor = new("OverrideColor", "Override default for Color", _setting.color.overrideState, "AtmosphericScattering");
		_configTint = new("tint", "Tint", _setting.tint.value, "AtmosphericScattering");
		_configOverrideTint = new("OverrideTint", "Override default for Tint", _setting.tint.overrideState, "AtmosphericScattering");
		_configDensity = new("density", "Density", _setting.density.value, "AtmosphericScattering");
		_configOverrideDensity = new("OverrideDensity", "Override default for Density", _setting.density.overrideState, "AtmosphericScattering");
		_configMaxFogDistance = new("maxFogDistance", "MaxFogDistance", _setting.maxFogDistance.value, "AtmosphericScattering");
		_configOverrideMaxFogDistance = new("OverrideMaxFogDistance", "Override default for MaxFogDistance", _setting.maxFogDistance.overrideState, "AtmosphericScattering");
		_configMipFogMaxMip = new("mipFogMaxMip", "MipFogMaxMip", _setting.mipFogMaxMip.value, "AtmosphericScattering");
		_configOverrideMipFogMaxMip = new("OverrideMipFogMaxMip", "Override default for MipFogMaxMip", _setting.mipFogMaxMip.overrideState, "AtmosphericScattering");
		_configMipFogNear = new("mipFogNear", "MipFogNear", _setting.mipFogNear.value, "AtmosphericScattering");
		_configOverrideMipFogNear = new("OverrideMipFogNear", "Override default for MipFogNear", _setting.mipFogNear.overrideState, "AtmosphericScattering");
		_configMipFogFar = new("mipFogFar", "MipFogFar", _setting.mipFogFar.value, "AtmosphericScattering");
		_configOverrideMipFogFar = new("OverrideMipFogFar", "Override default for MipFogFar", _setting.mipFogFar.overrideState, "AtmosphericScattering");
	}

	public void ApplyFromConfig()
	{
		_setting.color.overrideState = _configOverrideColor.Value;
		_setting.color.value = _configColor.Value;
		_setting.tint.overrideState = _configOverrideTint.Value;
		_setting.tint.value = _configTint.Value;
		_setting.density.overrideState = _configOverrideDensity.Value;
		_setting.density.value = _configDensity.Value;
		_setting.maxFogDistance.overrideState = _configOverrideMaxFogDistance.Value;
		_setting.maxFogDistance.value = _configMaxFogDistance.Value;
		_setting.mipFogMaxMip.overrideState = _configOverrideMipFogMaxMip.Value;
		_setting.mipFogMaxMip.value = _configMipFogMaxMip.Value;
		_setting.mipFogNear.overrideState = _configOverrideMipFogNear.Value;
		_setting.mipFogNear.value = _configMipFogNear.Value;
		_setting.mipFogFar.overrideState = _configOverrideMipFogFar.Value;
		_setting.mipFogFar.value = _configMipFogFar.Value;
	}

	public void SetSetting(AtmosphericScattering setting)
	{
		_setting = setting;
	}
}

public class SFog
{
	private Fog _setting;

	public bool Enabled
	{
		get {return _setting.enabled.value;}
		set {_setting.enabled.Override(value);}
	}

	public Color Color
	{
		get {return _setting.color.value;}
		set {_setting.color.Override(value);}
	}

	public Color Tint
	{
		get {return _setting.tint.value;}
		set {_setting.tint.Override(value);}
	}

	public float MaxFogDistance
	{
		get {return _setting.maxFogDistance.value;}
		set {_setting.maxFogDistance.Override(value);}
	}

	public float MipFogMaxMip
	{
		get {return _setting.mipFogMaxMip.value;}
		set {_setting.mipFogMaxMip.Override(value);}
	}

	public float MipFogNear
	{
		get {return _setting.mipFogNear.value;}
		set {_setting.mipFogNear.Override(value);}
	}

	public float MipFogFar
	{
		get {return _setting.mipFogFar.value;}
		set {_setting.mipFogFar.Override(value);}
	}

	public float MeanFreePath
	{
		get {return _setting.meanFreePath.value;}
		set {_setting.meanFreePath.Override(value);}
	}

	public bool EnableVolumetricFog
	{
		get {return _setting.enableVolumetricFog.value;}
		set {_setting.enableVolumetricFog.Override(value);}
	}

	public Color Albedo
	{
		get {return _setting.albedo.value;}
		set {_setting.albedo.Override(value);}
	}

	public float GlobalLightProbeDimmer
	{
		get {return _setting.globalLightProbeDimmer.value;}
		set {_setting.globalLightProbeDimmer.Override(value);}
	}

	public float DepthExtent
	{
		get {return _setting.depthExtent.value;}
		set {_setting.depthExtent.Override(value);}
	}

	public float Anisotropy
	{
		get {return _setting.anisotropy.value;}
		set {_setting.anisotropy.Override(value);}
	}

	public float SliceDistributionUniformity
	{
		get {return _setting.sliceDistributionUniformity.value;}
		set {_setting.sliceDistributionUniformity.Override(value);}
	}

	public float ScreenResolutionPercentage
	{
		get {return _setting.screenResolutionPercentage.value;}
		set {_setting.screenResolutionPercentage.Override(value);}
	}

	public float M_VolumetricFogBudget
	{
		get {return _setting.m_VolumetricFogBudget.value;}
		set {_setting.m_VolumetricFogBudget.Override(value);}
	}

	public float M_ResolutionDepthRatio
	{
		get {return _setting.m_ResolutionDepthRatio.value;}
		set {_setting.m_ResolutionDepthRatio.Override(value);}
	}

	public bool DirectionalLightsOnly
	{
		get {return _setting.directionalLightsOnly.value;}
		set {_setting.directionalLightsOnly.Override(value);}
	}

	private ConfigElement<bool> _configEnabled;
	private ConfigElement<bool> _configOverrideEnabled;
	private ConfigElement<Color> _configColor;
	private ConfigElement<bool> _configOverrideColor;
	private ConfigElement<Color> _configTint;
	private ConfigElement<bool> _configOverrideTint;
	private ConfigElement<float> _configMaxFogDistance;
	private ConfigElement<bool> _configOverrideMaxFogDistance;
	private ConfigElement<float> _configMipFogMaxMip;
	private ConfigElement<bool> _configOverrideMipFogMaxMip;
	private ConfigElement<float> _configMipFogNear;
	private ConfigElement<bool> _configOverrideMipFogNear;
	private ConfigElement<float> _configMipFogFar;
	private ConfigElement<bool> _configOverrideMipFogFar;
	private ConfigElement<float> _configMeanFreePath;
	private ConfigElement<bool> _configOverrideMeanFreePath;
	private ConfigElement<bool> _configEnableVolumetricFog;
	private ConfigElement<bool> _configOverrideEnableVolumetricFog;
	private ConfigElement<Color> _configAlbedo;
	private ConfigElement<bool> _configOverrideAlbedo;
	private ConfigElement<float> _configGlobalLightProbeDimmer;
	private ConfigElement<bool> _configOverrideGlobalLightProbeDimmer;
	private ConfigElement<float> _configDepthExtent;
	private ConfigElement<bool> _configOverrideDepthExtent;
	private ConfigElement<float> _configAnisotropy;
	private ConfigElement<bool> _configOverrideAnisotropy;
	private ConfigElement<float> _configSliceDistributionUniformity;
	private ConfigElement<bool> _configOverrideSliceDistributionUniformity;
	private ConfigElement<float> _configScreenResolutionPercentage;
	private ConfigElement<bool> _configOverrideScreenResolutionPercentage;
	private ConfigElement<float> _configM_VolumetricFogBudget;
	private ConfigElement<bool> _configOverrideM_VolumetricFogBudget;
	private ConfigElement<float> _configM_ResolutionDepthRatio;
	private ConfigElement<bool> _configOverrideM_ResolutionDepthRatio;
	private ConfigElement<bool> _configDirectionalLightsOnly;
	private ConfigElement<bool> _configOverrideDirectionalLightsOnly;

	public SFog(Fog setting)
	{
		_setting = setting;

		_configEnabled = new("enabled", "Enabled", _setting.enabled.value, "Fog");
		_configOverrideEnabled = new("OverrideEnabled", "Override default for Enabled", _setting.enabled.overrideState, "Fog");
		_configColor = new("color", "Color", _setting.color.value, "Fog");
		_configOverrideColor = new("OverrideColor", "Override default for Color", _setting.color.overrideState, "Fog");
		_configTint = new("tint", "Tint", _setting.tint.value, "Fog");
		_configOverrideTint = new("OverrideTint", "Override default for Tint", _setting.tint.overrideState, "Fog");
		_configMaxFogDistance = new("maxFogDistance", "MaxFogDistance", _setting.maxFogDistance.value, "Fog");
		_configOverrideMaxFogDistance = new("OverrideMaxFogDistance", "Override default for MaxFogDistance", _setting.maxFogDistance.overrideState, "Fog");
		_configMipFogMaxMip = new("mipFogMaxMip", "MipFogMaxMip", _setting.mipFogMaxMip.value, "Fog");
		_configOverrideMipFogMaxMip = new("OverrideMipFogMaxMip", "Override default for MipFogMaxMip", _setting.mipFogMaxMip.overrideState, "Fog");
		_configMipFogNear = new("mipFogNear", "MipFogNear", _setting.mipFogNear.value, "Fog");
		_configOverrideMipFogNear = new("OverrideMipFogNear", "Override default for MipFogNear", _setting.mipFogNear.overrideState, "Fog");
		_configMipFogFar = new("mipFogFar", "MipFogFar", _setting.mipFogFar.value, "Fog");
		_configOverrideMipFogFar = new("OverrideMipFogFar", "Override default for MipFogFar", _setting.mipFogFar.overrideState, "Fog");
		_configMeanFreePath = new("meanFreePath", "MeanFreePath", _setting.meanFreePath.value, "Fog");
		_configOverrideMeanFreePath = new("OverrideMeanFreePath", "Override default for MeanFreePath", _setting.meanFreePath.overrideState, "Fog");
		_configEnableVolumetricFog = new("enableVolumetricFog", "EnableVolumetricFog", _setting.enableVolumetricFog.value, "Fog");
		_configOverrideEnableVolumetricFog = new("OverrideEnableVolumetricFog", "Override default for EnableVolumetricFog", _setting.enableVolumetricFog.overrideState, "Fog");
		_configAlbedo = new("albedo", "Albedo", _setting.albedo.value, "Fog");
		_configOverrideAlbedo = new("OverrideAlbedo", "Override default for Albedo", _setting.albedo.overrideState, "Fog");
		_configGlobalLightProbeDimmer = new("globalLightProbeDimmer", "GlobalLightProbeDimmer", _setting.globalLightProbeDimmer.value, "Fog");
		_configOverrideGlobalLightProbeDimmer = new("OverrideGlobalLightProbeDimmer", "Override default for GlobalLightProbeDimmer", _setting.globalLightProbeDimmer.overrideState, "Fog");
		_configDepthExtent = new("depthExtent", "DepthExtent", _setting.depthExtent.value, "Fog");
		_configOverrideDepthExtent = new("OverrideDepthExtent", "Override default for DepthExtent", _setting.depthExtent.overrideState, "Fog");
		_configAnisotropy = new("anisotropy", "Anisotropy", _setting.anisotropy.value, "Fog");
		_configOverrideAnisotropy = new("OverrideAnisotropy", "Override default for Anisotropy", _setting.anisotropy.overrideState, "Fog");
		_configSliceDistributionUniformity = new("sliceDistributionUniformity", "SliceDistributionUniformity", _setting.sliceDistributionUniformity.value, "Fog");
		_configOverrideSliceDistributionUniformity = new("OverrideSliceDistributionUniformity", "Override default for SliceDistributionUniformity", _setting.sliceDistributionUniformity.overrideState, "Fog");
		_configScreenResolutionPercentage = new("screenResolutionPercentage", "ScreenResolutionPercentage", _setting.screenResolutionPercentage.value, "Fog");
		_configOverrideScreenResolutionPercentage = new("OverrideScreenResolutionPercentage", "Override default for ScreenResolutionPercentage", _setting.screenResolutionPercentage.overrideState, "Fog");
		_configM_VolumetricFogBudget = new("m_VolumetricFogBudget", "M_VolumetricFogBudget", _setting.m_VolumetricFogBudget.value, "Fog");
		_configOverrideM_VolumetricFogBudget = new("OverrideM_VolumetricFogBudget", "Override default for M_VolumetricFogBudget", _setting.m_VolumetricFogBudget.overrideState, "Fog");
		_configM_ResolutionDepthRatio = new("m_ResolutionDepthRatio", "M_ResolutionDepthRatio", _setting.m_ResolutionDepthRatio.value, "Fog");
		_configOverrideM_ResolutionDepthRatio = new("OverrideM_ResolutionDepthRatio", "Override default for M_ResolutionDepthRatio", _setting.m_ResolutionDepthRatio.overrideState, "Fog");
		_configDirectionalLightsOnly = new("directionalLightsOnly", "DirectionalLightsOnly", _setting.directionalLightsOnly.value, "Fog");
		_configOverrideDirectionalLightsOnly = new("OverrideDirectionalLightsOnly", "Override default for DirectionalLightsOnly", _setting.directionalLightsOnly.overrideState, "Fog");
	}

	public void ApplyFromConfig()
	{
		_setting.enabled.overrideState = _configOverrideEnabled.Value;
		_setting.enabled.value = _configEnabled.Value;
		_setting.color.overrideState = _configOverrideColor.Value;
		_setting.color.value = _configColor.Value;
		_setting.tint.overrideState = _configOverrideTint.Value;
		_setting.tint.value = _configTint.Value;
		_setting.maxFogDistance.overrideState = _configOverrideMaxFogDistance.Value;
		_setting.maxFogDistance.value = _configMaxFogDistance.Value;
		_setting.mipFogMaxMip.overrideState = _configOverrideMipFogMaxMip.Value;
		_setting.mipFogMaxMip.value = _configMipFogMaxMip.Value;
		_setting.mipFogNear.overrideState = _configOverrideMipFogNear.Value;
		_setting.mipFogNear.value = _configMipFogNear.Value;
		_setting.mipFogFar.overrideState = _configOverrideMipFogFar.Value;
		_setting.mipFogFar.value = _configMipFogFar.Value;
		_setting.meanFreePath.overrideState = _configOverrideMeanFreePath.Value;
		_setting.meanFreePath.value = _configMeanFreePath.Value;
		_setting.enableVolumetricFog.overrideState = _configOverrideEnableVolumetricFog.Value;
		_setting.enableVolumetricFog.value = _configEnableVolumetricFog.Value;
		_setting.albedo.overrideState = _configOverrideAlbedo.Value;
		_setting.albedo.value = _configAlbedo.Value;
		_setting.globalLightProbeDimmer.overrideState = _configOverrideGlobalLightProbeDimmer.Value;
		_setting.globalLightProbeDimmer.value = _configGlobalLightProbeDimmer.Value;
		_setting.depthExtent.overrideState = _configOverrideDepthExtent.Value;
		_setting.depthExtent.value = _configDepthExtent.Value;
		_setting.anisotropy.overrideState = _configOverrideAnisotropy.Value;
		_setting.anisotropy.value = _configAnisotropy.Value;
		_setting.sliceDistributionUniformity.overrideState = _configOverrideSliceDistributionUniformity.Value;
		_setting.sliceDistributionUniformity.value = _configSliceDistributionUniformity.Value;
		_setting.screenResolutionPercentage.overrideState = _configOverrideScreenResolutionPercentage.Value;
		_setting.screenResolutionPercentage.value = _configScreenResolutionPercentage.Value;
		_setting.m_VolumetricFogBudget.overrideState = _configOverrideM_VolumetricFogBudget.Value;
		_setting.m_VolumetricFogBudget.value = _configM_VolumetricFogBudget.Value;
		_setting.m_ResolutionDepthRatio.overrideState = _configOverrideM_ResolutionDepthRatio.Value;
		_setting.m_ResolutionDepthRatio.value = _configM_ResolutionDepthRatio.Value;
		_setting.directionalLightsOnly.overrideState = _configOverrideDirectionalLightsOnly.Value;
		_setting.directionalLightsOnly.value = _configDirectionalLightsOnly.Value;
	}

	public void SetSetting(Fog setting)
	{
		_setting = setting;
	}
}

public class SIndirectLightingController
{
	private IndirectLightingController _setting;

	public float IndirectDiffuseLightingMultiplier
	{
		get {return _setting.indirectDiffuseLightingMultiplier.value;}
		set {_setting.indirectDiffuseLightingMultiplier.Override(value);}
	}

	public float ReflectionLightingMultiplier
	{
		get {return _setting.reflectionLightingMultiplier.value;}
		set {_setting.reflectionLightingMultiplier.Override(value);}
	}

	public float ReflectionProbeIntensityMultiplier
	{
		get {return _setting.reflectionProbeIntensityMultiplier.value;}
		set {_setting.reflectionProbeIntensityMultiplier.Override(value);}
	}

	private ConfigElement<float> _configIndirectDiffuseLightingMultiplier;
	private ConfigElement<bool> _configOverrideIndirectDiffuseLightingMultiplier;
	private ConfigElement<float> _configReflectionLightingMultiplier;
	private ConfigElement<bool> _configOverrideReflectionLightingMultiplier;
	private ConfigElement<float> _configReflectionProbeIntensityMultiplier;
	private ConfigElement<bool> _configOverrideReflectionProbeIntensityMultiplier;

	public SIndirectLightingController(IndirectLightingController setting)
	{
		_setting = setting;

		_configIndirectDiffuseLightingMultiplier = new("indirectDiffuseLightingMultiplier", "IndirectDiffuseLightingMultiplier", _setting.indirectDiffuseLightingMultiplier.value, "IndirectLightingController");
		_configOverrideIndirectDiffuseLightingMultiplier = new("OverrideIndirectDiffuseLightingMultiplier", "Override default for IndirectDiffuseLightingMultiplier", _setting.indirectDiffuseLightingMultiplier.overrideState, "IndirectLightingController");
		_configReflectionLightingMultiplier = new("reflectionLightingMultiplier", "ReflectionLightingMultiplier", _setting.reflectionLightingMultiplier.value, "IndirectLightingController");
		_configOverrideReflectionLightingMultiplier = new("OverrideReflectionLightingMultiplier", "Override default for ReflectionLightingMultiplier", _setting.reflectionLightingMultiplier.overrideState, "IndirectLightingController");
		_configReflectionProbeIntensityMultiplier = new("reflectionProbeIntensityMultiplier", "ReflectionProbeIntensityMultiplier", _setting.reflectionProbeIntensityMultiplier.value, "IndirectLightingController");
		_configOverrideReflectionProbeIntensityMultiplier = new("OverrideReflectionProbeIntensityMultiplier", "Override default for ReflectionProbeIntensityMultiplier", _setting.reflectionProbeIntensityMultiplier.overrideState, "IndirectLightingController");
	}

	public void ApplyFromConfig()
	{
		_setting.indirectDiffuseLightingMultiplier.overrideState = _configOverrideIndirectDiffuseLightingMultiplier.Value;
		_setting.indirectDiffuseLightingMultiplier.value = _configIndirectDiffuseLightingMultiplier.Value;
		_setting.reflectionLightingMultiplier.overrideState = _configOverrideReflectionLightingMultiplier.Value;
		_setting.reflectionLightingMultiplier.value = _configReflectionLightingMultiplier.Value;
		_setting.reflectionProbeIntensityMultiplier.overrideState = _configOverrideReflectionProbeIntensityMultiplier.Value;
		_setting.reflectionProbeIntensityMultiplier.value = _configReflectionProbeIntensityMultiplier.Value;
	}

	public void SetSetting(IndirectLightingController setting)
	{
		_setting = setting;
	}
}

public class SScreenSpaceAmbientOcclusion
{
	private ScreenSpaceAmbientOcclusion _setting;

	public bool RayTracing
	{
		get {return _setting.rayTracing.value;}
		set {_setting.rayTracing.Override(value);}
	}

	public float Intensity
	{
		get {return _setting.intensity.value;}
		set {_setting.intensity.Override(value);}
	}

	public float DirectLightingStrength
	{
		get {return _setting.directLightingStrength.value;}
		set {_setting.directLightingStrength.Override(value);}
	}

	public float Radius
	{
		get {return _setting.radius.value;}
		set {_setting.radius.Override(value);}
	}

	public float SpatialBilateralAggressiveness
	{
		get {return _setting.spatialBilateralAggressiveness.value;}
		set {_setting.spatialBilateralAggressiveness.Override(value);}
	}

	public bool TemporalAccumulation
	{
		get {return _setting.temporalAccumulation.value;}
		set {_setting.temporalAccumulation.Override(value);}
	}

	public float GhostingReduction
	{
		get {return _setting.ghostingReduction.value;}
		set {_setting.ghostingReduction.Override(value);}
	}

	public float BlurSharpness
	{
		get {return _setting.blurSharpness.value;}
		set {_setting.blurSharpness.Override(value);}
	}

	public float SpecularOcclusion
	{
		get {return _setting.specularOcclusion.value;}
		set {_setting.specularOcclusion.Override(value);}
	}

	public bool OccluderMotionRejection
	{
		get {return _setting.occluderMotionRejection.value;}
		set {_setting.occluderMotionRejection.Override(value);}
	}

	public bool ReceiverMotionRejection
	{
		get {return _setting.receiverMotionRejection.value;}
		set {_setting.receiverMotionRejection.Override(value);}
	}

	public bool M_FullResolution
	{
		get {return _setting.m_FullResolution.value;}
		set {_setting.m_FullResolution.Override(value);}
	}

	public bool M_BilateralUpsample
	{
		get {return _setting.m_BilateralUpsample.value;}
		set {_setting.m_BilateralUpsample.Override(value);}
	}

	public float M_RayLength
	{
		get {return _setting.m_RayLength.value;}
		set {_setting.m_RayLength.Override(value);}
	}

	public bool M_Denoise
	{
		get {return _setting.m_Denoise.value;}
		set {_setting.m_Denoise.Override(value);}
	}

	public float M_DenoiserRadius
	{
		get {return _setting.m_DenoiserRadius.value;}
		set {_setting.m_DenoiserRadius.Override(value);}
	}

	private ConfigElement<bool> _configRayTracing;
	private ConfigElement<bool> _configOverrideRayTracing;
	private ConfigElement<float> _configIntensity;
	private ConfigElement<bool> _configOverrideIntensity;
	private ConfigElement<float> _configDirectLightingStrength;
	private ConfigElement<bool> _configOverrideDirectLightingStrength;
	private ConfigElement<float> _configRadius;
	private ConfigElement<bool> _configOverrideRadius;
	private ConfigElement<float> _configSpatialBilateralAggressiveness;
	private ConfigElement<bool> _configOverrideSpatialBilateralAggressiveness;
	private ConfigElement<bool> _configTemporalAccumulation;
	private ConfigElement<bool> _configOverrideTemporalAccumulation;
	private ConfigElement<float> _configGhostingReduction;
	private ConfigElement<bool> _configOverrideGhostingReduction;
	private ConfigElement<float> _configBlurSharpness;
	private ConfigElement<bool> _configOverrideBlurSharpness;
	private ConfigElement<float> _configSpecularOcclusion;
	private ConfigElement<bool> _configOverrideSpecularOcclusion;
	private ConfigElement<bool> _configOccluderMotionRejection;
	private ConfigElement<bool> _configOverrideOccluderMotionRejection;
	private ConfigElement<bool> _configReceiverMotionRejection;
	private ConfigElement<bool> _configOverrideReceiverMotionRejection;
	private ConfigElement<bool> _configM_FullResolution;
	private ConfigElement<bool> _configOverrideM_FullResolution;
	private ConfigElement<bool> _configM_BilateralUpsample;
	private ConfigElement<bool> _configOverrideM_BilateralUpsample;
	private ConfigElement<float> _configM_RayLength;
	private ConfigElement<bool> _configOverrideM_RayLength;
	private ConfigElement<bool> _configM_Denoise;
	private ConfigElement<bool> _configOverrideM_Denoise;
	private ConfigElement<float> _configM_DenoiserRadius;
	private ConfigElement<bool> _configOverrideM_DenoiserRadius;

	public SScreenSpaceAmbientOcclusion(ScreenSpaceAmbientOcclusion setting)
	{
		_setting = setting;

		_configRayTracing = new("rayTracing", "RayTracing", _setting.rayTracing.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideRayTracing = new("OverrideRayTracing", "Override default for RayTracing", _setting.rayTracing.overrideState, "ScreenSpaceAmbientOcclusion");
		_configIntensity = new("intensity", "Intensity", _setting.intensity.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideIntensity = new("OverrideIntensity", "Override default for Intensity", _setting.intensity.overrideState, "ScreenSpaceAmbientOcclusion");
		_configDirectLightingStrength = new("directLightingStrength", "DirectLightingStrength", _setting.directLightingStrength.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideDirectLightingStrength = new("OverrideDirectLightingStrength", "Override default for DirectLightingStrength", _setting.directLightingStrength.overrideState, "ScreenSpaceAmbientOcclusion");
		_configRadius = new("radius", "Radius", _setting.radius.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideRadius = new("OverrideRadius", "Override default for Radius", _setting.radius.overrideState, "ScreenSpaceAmbientOcclusion");
		_configSpatialBilateralAggressiveness = new("spatialBilateralAggressiveness", "SpatialBilateralAggressiveness", _setting.spatialBilateralAggressiveness.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideSpatialBilateralAggressiveness = new("OverrideSpatialBilateralAggressiveness", "Override default for SpatialBilateralAggressiveness", _setting.spatialBilateralAggressiveness.overrideState, "ScreenSpaceAmbientOcclusion");
		_configTemporalAccumulation = new("temporalAccumulation", "TemporalAccumulation", _setting.temporalAccumulation.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideTemporalAccumulation = new("OverrideTemporalAccumulation", "Override default for TemporalAccumulation", _setting.temporalAccumulation.overrideState, "ScreenSpaceAmbientOcclusion");
		_configGhostingReduction = new("ghostingReduction", "GhostingReduction", _setting.ghostingReduction.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideGhostingReduction = new("OverrideGhostingReduction", "Override default for GhostingReduction", _setting.ghostingReduction.overrideState, "ScreenSpaceAmbientOcclusion");
		_configBlurSharpness = new("blurSharpness", "BlurSharpness", _setting.blurSharpness.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideBlurSharpness = new("OverrideBlurSharpness", "Override default for BlurSharpness", _setting.blurSharpness.overrideState, "ScreenSpaceAmbientOcclusion");
		_configSpecularOcclusion = new("specularOcclusion", "SpecularOcclusion", _setting.specularOcclusion.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideSpecularOcclusion = new("OverrideSpecularOcclusion", "Override default for SpecularOcclusion", _setting.specularOcclusion.overrideState, "ScreenSpaceAmbientOcclusion");
		_configOccluderMotionRejection = new("occluderMotionRejection", "OccluderMotionRejection", _setting.occluderMotionRejection.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideOccluderMotionRejection = new("OverrideOccluderMotionRejection", "Override default for OccluderMotionRejection", _setting.occluderMotionRejection.overrideState, "ScreenSpaceAmbientOcclusion");
		_configReceiverMotionRejection = new("receiverMotionRejection", "ReceiverMotionRejection", _setting.receiverMotionRejection.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideReceiverMotionRejection = new("OverrideReceiverMotionRejection", "Override default for ReceiverMotionRejection", _setting.receiverMotionRejection.overrideState, "ScreenSpaceAmbientOcclusion");
		_configM_FullResolution = new("m_FullResolution", "M_FullResolution", _setting.m_FullResolution.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideM_FullResolution = new("OverrideM_FullResolution", "Override default for M_FullResolution", _setting.m_FullResolution.overrideState, "ScreenSpaceAmbientOcclusion");
		_configM_BilateralUpsample = new("m_BilateralUpsample", "M_BilateralUpsample", _setting.m_BilateralUpsample.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideM_BilateralUpsample = new("OverrideM_BilateralUpsample", "Override default for M_BilateralUpsample", _setting.m_BilateralUpsample.overrideState, "ScreenSpaceAmbientOcclusion");
		_configM_RayLength = new("m_RayLength", "M_RayLength", _setting.m_RayLength.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideM_RayLength = new("OverrideM_RayLength", "Override default for M_RayLength", _setting.m_RayLength.overrideState, "ScreenSpaceAmbientOcclusion");
		_configM_Denoise = new("m_Denoise", "M_Denoise", _setting.m_Denoise.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideM_Denoise = new("OverrideM_Denoise", "Override default for M_Denoise", _setting.m_Denoise.overrideState, "ScreenSpaceAmbientOcclusion");
		_configM_DenoiserRadius = new("m_DenoiserRadius", "M_DenoiserRadius", _setting.m_DenoiserRadius.value, "ScreenSpaceAmbientOcclusion");
		_configOverrideM_DenoiserRadius = new("OverrideM_DenoiserRadius", "Override default for M_DenoiserRadius", _setting.m_DenoiserRadius.overrideState, "ScreenSpaceAmbientOcclusion");
	}

	public void ApplyFromConfig()
	{
		_setting.rayTracing.overrideState = _configOverrideRayTracing.Value;
		_setting.rayTracing.value = _configRayTracing.Value;
		_setting.intensity.overrideState = _configOverrideIntensity.Value;
		_setting.intensity.value = _configIntensity.Value;
		_setting.directLightingStrength.overrideState = _configOverrideDirectLightingStrength.Value;
		_setting.directLightingStrength.value = _configDirectLightingStrength.Value;
		_setting.radius.overrideState = _configOverrideRadius.Value;
		_setting.radius.value = _configRadius.Value;
		_setting.spatialBilateralAggressiveness.overrideState = _configOverrideSpatialBilateralAggressiveness.Value;
		_setting.spatialBilateralAggressiveness.value = _configSpatialBilateralAggressiveness.Value;
		_setting.temporalAccumulation.overrideState = _configOverrideTemporalAccumulation.Value;
		_setting.temporalAccumulation.value = _configTemporalAccumulation.Value;
		_setting.ghostingReduction.overrideState = _configOverrideGhostingReduction.Value;
		_setting.ghostingReduction.value = _configGhostingReduction.Value;
		_setting.blurSharpness.overrideState = _configOverrideBlurSharpness.Value;
		_setting.blurSharpness.value = _configBlurSharpness.Value;
		_setting.specularOcclusion.overrideState = _configOverrideSpecularOcclusion.Value;
		_setting.specularOcclusion.value = _configSpecularOcclusion.Value;
		_setting.occluderMotionRejection.overrideState = _configOverrideOccluderMotionRejection.Value;
		_setting.occluderMotionRejection.value = _configOccluderMotionRejection.Value;
		_setting.receiverMotionRejection.overrideState = _configOverrideReceiverMotionRejection.Value;
		_setting.receiverMotionRejection.value = _configReceiverMotionRejection.Value;
		_setting.m_FullResolution.overrideState = _configOverrideM_FullResolution.Value;
		_setting.m_FullResolution.value = _configM_FullResolution.Value;
		_setting.m_BilateralUpsample.overrideState = _configOverrideM_BilateralUpsample.Value;
		_setting.m_BilateralUpsample.value = _configM_BilateralUpsample.Value;
		_setting.m_RayLength.overrideState = _configOverrideM_RayLength.Value;
		_setting.m_RayLength.value = _configM_RayLength.Value;
		_setting.m_Denoise.overrideState = _configOverrideM_Denoise.Value;
		_setting.m_Denoise.value = _configM_Denoise.Value;
		_setting.m_DenoiserRadius.overrideState = _configOverrideM_DenoiserRadius.Value;
		_setting.m_DenoiserRadius.value = _configM_DenoiserRadius.Value;
	}

	public void SetSetting(ScreenSpaceAmbientOcclusion setting)
	{
		_setting = setting;
	}
}

public class SScreenSpaceReflection
{
	private ScreenSpaceReflection _setting;

	public bool Enabled
	{
		get {return _setting.enabled.value;}
		set {_setting.enabled.Override(value);}
	}

	public bool EnabledTransparent
	{
		get {return _setting.enabledTransparent.value;}
		set {_setting.enabledTransparent.Override(value);}
	}

	public float M_MinSmoothness
	{
		get {return _setting.m_MinSmoothness.value;}
		set {_setting.m_MinSmoothness.Override(value);}
	}

	public float M_SmoothnessFadeStart
	{
		get {return _setting.m_SmoothnessFadeStart.value;}
		set {_setting.m_SmoothnessFadeStart.Override(value);}
	}

	public bool ReflectSky
	{
		get {return _setting.reflectSky.value;}
		set {_setting.reflectSky.Override(value);}
	}

	public float DepthBufferThickness
	{
		get {return _setting.depthBufferThickness.value;}
		set {_setting.depthBufferThickness.Override(value);}
	}

	public float ScreenFadeDistance
	{
		get {return _setting.screenFadeDistance.value;}
		set {_setting.screenFadeDistance.Override(value);}
	}

	public float AccumulationFactor
	{
		get {return _setting.accumulationFactor.value;}
		set {_setting.accumulationFactor.Override(value);}
	}

	public float BiasFactor
	{
		get {return _setting.biasFactor.value;}
		set {_setting.biasFactor.Override(value);}
	}

	public float SpeedRejectionScalerFactor
	{
		get {return _setting.speedRejectionScalerFactor.value;}
		set {_setting.speedRejectionScalerFactor.Override(value);}
	}

	public bool SpeedSmoothReject
	{
		get {return _setting.speedSmoothReject.value;}
		set {_setting.speedSmoothReject.Override(value);}
	}

	public bool SpeedSurfaceOnly
	{
		get {return _setting.speedSurfaceOnly.value;}
		set {_setting.speedSurfaceOnly.Override(value);}
	}

	public bool SpeedTargetOnly
	{
		get {return _setting.speedTargetOnly.value;}
		set {_setting.speedTargetOnly.Override(value);}
	}

	public bool EnableWorldSpeedRejection
	{
		get {return _setting.enableWorldSpeedRejection.value;}
		set {_setting.enableWorldSpeedRejection.Override(value);}
	}

	public float AmbientProbeDimmer
	{
		get {return _setting.ambientProbeDimmer.value;}
		set {_setting.ambientProbeDimmer.Override(value);}
	}

	public float M_RayLength
	{
		get {return _setting.m_RayLength.value;}
		set {_setting.m_RayLength.Override(value);}
	}

	public float M_ClampValue
	{
		get {return _setting.m_ClampValue.value;}
		set {_setting.m_ClampValue.Override(value);}
	}

	public bool M_Denoise
	{
		get {return _setting.m_Denoise.value;}
		set {_setting.m_Denoise.Override(value);}
	}

	public bool M_AffectSmoothSurfaces
	{
		get {return _setting.m_AffectSmoothSurfaces.value;}
		set {_setting.m_AffectSmoothSurfaces.Override(value);}
	}

	public bool M_FullResolution
	{
		get {return _setting.m_FullResolution.value;}
		set {_setting.m_FullResolution.Override(value);}
	}

	private ConfigElement<bool> _configEnabled;
	private ConfigElement<bool> _configOverrideEnabled;
	private ConfigElement<bool> _configEnabledTransparent;
	private ConfigElement<bool> _configOverrideEnabledTransparent;
	private ConfigElement<float> _configM_MinSmoothness;
	private ConfigElement<bool> _configOverrideM_MinSmoothness;
	private ConfigElement<float> _configM_SmoothnessFadeStart;
	private ConfigElement<bool> _configOverrideM_SmoothnessFadeStart;
	private ConfigElement<bool> _configReflectSky;
	private ConfigElement<bool> _configOverrideReflectSky;
	private ConfigElement<float> _configDepthBufferThickness;
	private ConfigElement<bool> _configOverrideDepthBufferThickness;
	private ConfigElement<float> _configScreenFadeDistance;
	private ConfigElement<bool> _configOverrideScreenFadeDistance;
	private ConfigElement<float> _configAccumulationFactor;
	private ConfigElement<bool> _configOverrideAccumulationFactor;
	private ConfigElement<float> _configBiasFactor;
	private ConfigElement<bool> _configOverrideBiasFactor;
	private ConfigElement<float> _configSpeedRejectionScalerFactor;
	private ConfigElement<bool> _configOverrideSpeedRejectionScalerFactor;
	private ConfigElement<bool> _configSpeedSmoothReject;
	private ConfigElement<bool> _configOverrideSpeedSmoothReject;
	private ConfigElement<bool> _configSpeedSurfaceOnly;
	private ConfigElement<bool> _configOverrideSpeedSurfaceOnly;
	private ConfigElement<bool> _configSpeedTargetOnly;
	private ConfigElement<bool> _configOverrideSpeedTargetOnly;
	private ConfigElement<bool> _configEnableWorldSpeedRejection;
	private ConfigElement<bool> _configOverrideEnableWorldSpeedRejection;
	private ConfigElement<float> _configAmbientProbeDimmer;
	private ConfigElement<bool> _configOverrideAmbientProbeDimmer;
	private ConfigElement<float> _configM_RayLength;
	private ConfigElement<bool> _configOverrideM_RayLength;
	private ConfigElement<float> _configM_ClampValue;
	private ConfigElement<bool> _configOverrideM_ClampValue;
	private ConfigElement<bool> _configM_Denoise;
	private ConfigElement<bool> _configOverrideM_Denoise;
	private ConfigElement<bool> _configM_AffectSmoothSurfaces;
	private ConfigElement<bool> _configOverrideM_AffectSmoothSurfaces;
	private ConfigElement<bool> _configM_FullResolution;
	private ConfigElement<bool> _configOverrideM_FullResolution;

	public SScreenSpaceReflection(ScreenSpaceReflection setting)
	{
		_setting = setting;

		_configEnabled = new("enabled", "Enabled", _setting.enabled.value, "ScreenSpaceReflection");
		_configOverrideEnabled = new("OverrideEnabled", "Override default for Enabled", _setting.enabled.overrideState, "ScreenSpaceReflection");
		_configEnabledTransparent = new("enabledTransparent", "EnabledTransparent", _setting.enabledTransparent.value, "ScreenSpaceReflection");
		_configOverrideEnabledTransparent = new("OverrideEnabledTransparent", "Override default for EnabledTransparent", _setting.enabledTransparent.overrideState, "ScreenSpaceReflection");
		_configM_MinSmoothness = new("m_MinSmoothness", "M_MinSmoothness", _setting.m_MinSmoothness.value, "ScreenSpaceReflection");
		_configOverrideM_MinSmoothness = new("OverrideM_MinSmoothness", "Override default for M_MinSmoothness", _setting.m_MinSmoothness.overrideState, "ScreenSpaceReflection");
		_configM_SmoothnessFadeStart = new("m_SmoothnessFadeStart", "M_SmoothnessFadeStart", _setting.m_SmoothnessFadeStart.value, "ScreenSpaceReflection");
		_configOverrideM_SmoothnessFadeStart = new("OverrideM_SmoothnessFadeStart", "Override default for M_SmoothnessFadeStart", _setting.m_SmoothnessFadeStart.overrideState, "ScreenSpaceReflection");
		_configReflectSky = new("reflectSky", "ReflectSky", _setting.reflectSky.value, "ScreenSpaceReflection");
		_configOverrideReflectSky = new("OverrideReflectSky", "Override default for ReflectSky", _setting.reflectSky.overrideState, "ScreenSpaceReflection");
		_configDepthBufferThickness = new("depthBufferThickness", "DepthBufferThickness", _setting.depthBufferThickness.value, "ScreenSpaceReflection");
		_configOverrideDepthBufferThickness = new("OverrideDepthBufferThickness", "Override default for DepthBufferThickness", _setting.depthBufferThickness.overrideState, "ScreenSpaceReflection");
		_configScreenFadeDistance = new("screenFadeDistance", "ScreenFadeDistance", _setting.screenFadeDistance.value, "ScreenSpaceReflection");
		_configOverrideScreenFadeDistance = new("OverrideScreenFadeDistance", "Override default for ScreenFadeDistance", _setting.screenFadeDistance.overrideState, "ScreenSpaceReflection");
		_configAccumulationFactor = new("accumulationFactor", "AccumulationFactor", _setting.accumulationFactor.value, "ScreenSpaceReflection");
		_configOverrideAccumulationFactor = new("OverrideAccumulationFactor", "Override default for AccumulationFactor", _setting.accumulationFactor.overrideState, "ScreenSpaceReflection");
		_configBiasFactor = new("biasFactor", "BiasFactor", _setting.biasFactor.value, "ScreenSpaceReflection");
		_configOverrideBiasFactor = new("OverrideBiasFactor", "Override default for BiasFactor", _setting.biasFactor.overrideState, "ScreenSpaceReflection");
		_configSpeedRejectionScalerFactor = new("speedRejectionScalerFactor", "SpeedRejectionScalerFactor", _setting.speedRejectionScalerFactor.value, "ScreenSpaceReflection");
		_configOverrideSpeedRejectionScalerFactor = new("OverrideSpeedRejectionScalerFactor", "Override default for SpeedRejectionScalerFactor", _setting.speedRejectionScalerFactor.overrideState, "ScreenSpaceReflection");
		_configSpeedSmoothReject = new("speedSmoothReject", "SpeedSmoothReject", _setting.speedSmoothReject.value, "ScreenSpaceReflection");
		_configOverrideSpeedSmoothReject = new("OverrideSpeedSmoothReject", "Override default for SpeedSmoothReject", _setting.speedSmoothReject.overrideState, "ScreenSpaceReflection");
		_configSpeedSurfaceOnly = new("speedSurfaceOnly", "SpeedSurfaceOnly", _setting.speedSurfaceOnly.value, "ScreenSpaceReflection");
		_configOverrideSpeedSurfaceOnly = new("OverrideSpeedSurfaceOnly", "Override default for SpeedSurfaceOnly", _setting.speedSurfaceOnly.overrideState, "ScreenSpaceReflection");
		_configSpeedTargetOnly = new("speedTargetOnly", "SpeedTargetOnly", _setting.speedTargetOnly.value, "ScreenSpaceReflection");
		_configOverrideSpeedTargetOnly = new("OverrideSpeedTargetOnly", "Override default for SpeedTargetOnly", _setting.speedTargetOnly.overrideState, "ScreenSpaceReflection");
		_configEnableWorldSpeedRejection = new("enableWorldSpeedRejection", "EnableWorldSpeedRejection", _setting.enableWorldSpeedRejection.value, "ScreenSpaceReflection");
		_configOverrideEnableWorldSpeedRejection = new("OverrideEnableWorldSpeedRejection", "Override default for EnableWorldSpeedRejection", _setting.enableWorldSpeedRejection.overrideState, "ScreenSpaceReflection");
		_configAmbientProbeDimmer = new("ambientProbeDimmer", "AmbientProbeDimmer", _setting.ambientProbeDimmer.value, "ScreenSpaceReflection");
		_configOverrideAmbientProbeDimmer = new("OverrideAmbientProbeDimmer", "Override default for AmbientProbeDimmer", _setting.ambientProbeDimmer.overrideState, "ScreenSpaceReflection");
		_configM_RayLength = new("m_RayLength", "M_RayLength", _setting.m_RayLength.value, "ScreenSpaceReflection");
		_configOverrideM_RayLength = new("OverrideM_RayLength", "Override default for M_RayLength", _setting.m_RayLength.overrideState, "ScreenSpaceReflection");
		_configM_ClampValue = new("m_ClampValue", "M_ClampValue", _setting.m_ClampValue.value, "ScreenSpaceReflection");
		_configOverrideM_ClampValue = new("OverrideM_ClampValue", "Override default for M_ClampValue", _setting.m_ClampValue.overrideState, "ScreenSpaceReflection");
		_configM_Denoise = new("m_Denoise", "M_Denoise", _setting.m_Denoise.value, "ScreenSpaceReflection");
		_configOverrideM_Denoise = new("OverrideM_Denoise", "Override default for M_Denoise", _setting.m_Denoise.overrideState, "ScreenSpaceReflection");
		_configM_AffectSmoothSurfaces = new("m_AffectSmoothSurfaces", "M_AffectSmoothSurfaces", _setting.m_AffectSmoothSurfaces.value, "ScreenSpaceReflection");
		_configOverrideM_AffectSmoothSurfaces = new("OverrideM_AffectSmoothSurfaces", "Override default for M_AffectSmoothSurfaces", _setting.m_AffectSmoothSurfaces.overrideState, "ScreenSpaceReflection");
		_configM_FullResolution = new("m_FullResolution", "M_FullResolution", _setting.m_FullResolution.value, "ScreenSpaceReflection");
		_configOverrideM_FullResolution = new("OverrideM_FullResolution", "Override default for M_FullResolution", _setting.m_FullResolution.overrideState, "ScreenSpaceReflection");
	}

	public void ApplyFromConfig()
	{
		_setting.enabled.overrideState = _configOverrideEnabled.Value;
		_setting.enabled.value = _configEnabled.Value;
		_setting.enabledTransparent.overrideState = _configOverrideEnabledTransparent.Value;
		_setting.enabledTransparent.value = _configEnabledTransparent.Value;
		_setting.m_MinSmoothness.overrideState = _configOverrideM_MinSmoothness.Value;
		_setting.m_MinSmoothness.value = _configM_MinSmoothness.Value;
		_setting.m_SmoothnessFadeStart.overrideState = _configOverrideM_SmoothnessFadeStart.Value;
		_setting.m_SmoothnessFadeStart.value = _configM_SmoothnessFadeStart.Value;
		_setting.reflectSky.overrideState = _configOverrideReflectSky.Value;
		_setting.reflectSky.value = _configReflectSky.Value;
		_setting.depthBufferThickness.overrideState = _configOverrideDepthBufferThickness.Value;
		_setting.depthBufferThickness.value = _configDepthBufferThickness.Value;
		_setting.screenFadeDistance.overrideState = _configOverrideScreenFadeDistance.Value;
		_setting.screenFadeDistance.value = _configScreenFadeDistance.Value;
		_setting.accumulationFactor.overrideState = _configOverrideAccumulationFactor.Value;
		_setting.accumulationFactor.value = _configAccumulationFactor.Value;
		_setting.biasFactor.overrideState = _configOverrideBiasFactor.Value;
		_setting.biasFactor.value = _configBiasFactor.Value;
		_setting.speedRejectionScalerFactor.overrideState = _configOverrideSpeedRejectionScalerFactor.Value;
		_setting.speedRejectionScalerFactor.value = _configSpeedRejectionScalerFactor.Value;
		_setting.speedSmoothReject.overrideState = _configOverrideSpeedSmoothReject.Value;
		_setting.speedSmoothReject.value = _configSpeedSmoothReject.Value;
		_setting.speedSurfaceOnly.overrideState = _configOverrideSpeedSurfaceOnly.Value;
		_setting.speedSurfaceOnly.value = _configSpeedSurfaceOnly.Value;
		_setting.speedTargetOnly.overrideState = _configOverrideSpeedTargetOnly.Value;
		_setting.speedTargetOnly.value = _configSpeedTargetOnly.Value;
		_setting.enableWorldSpeedRejection.overrideState = _configOverrideEnableWorldSpeedRejection.Value;
		_setting.enableWorldSpeedRejection.value = _configEnableWorldSpeedRejection.Value;
		_setting.ambientProbeDimmer.overrideState = _configOverrideAmbientProbeDimmer.Value;
		_setting.ambientProbeDimmer.value = _configAmbientProbeDimmer.Value;
		_setting.m_RayLength.overrideState = _configOverrideM_RayLength.Value;
		_setting.m_RayLength.value = _configM_RayLength.Value;
		_setting.m_ClampValue.overrideState = _configOverrideM_ClampValue.Value;
		_setting.m_ClampValue.value = _configM_ClampValue.Value;
		_setting.m_Denoise.overrideState = _configOverrideM_Denoise.Value;
		_setting.m_Denoise.value = _configM_Denoise.Value;
		_setting.m_AffectSmoothSurfaces.overrideState = _configOverrideM_AffectSmoothSurfaces.Value;
		_setting.m_AffectSmoothSurfaces.value = _configM_AffectSmoothSurfaces.Value;
		_setting.m_FullResolution.overrideState = _configOverrideM_FullResolution.Value;
		_setting.m_FullResolution.value = _configM_FullResolution.Value;
	}

	public void SetSetting(ScreenSpaceReflection setting)
	{
		_setting = setting;
	}
}

public class SContactShadows
{
	private ContactShadows _setting;

	public bool Enable
	{
		get {return _setting.enable.value;}
		set {_setting.enable.Override(value);}
	}

	public float Length
	{
		get {return _setting.length.value;}
		set {_setting.length.Override(value);}
	}

	public float Opacity
	{
		get {return _setting.opacity.value;}
		set {_setting.opacity.Override(value);}
	}

	public float DistanceScaleFactor
	{
		get {return _setting.distanceScaleFactor.value;}
		set {_setting.distanceScaleFactor.Override(value);}
	}

	public float MaxDistance
	{
		get {return _setting.maxDistance.value;}
		set {_setting.maxDistance.Override(value);}
	}

	public float MinDistance
	{
		get {return _setting.minDistance.value;}
		set {_setting.minDistance.Override(value);}
	}

	public float FadeDistance
	{
		get {return _setting.fadeDistance.value;}
		set {_setting.fadeDistance.Override(value);}
	}

	public float FadeInDistance
	{
		get {return _setting.fadeInDistance.value;}
		set {_setting.fadeInDistance.Override(value);}
	}

	public float RayBias
	{
		get {return _setting.rayBias.value;}
		set {_setting.rayBias.Override(value);}
	}

	public float ThicknessScale
	{
		get {return _setting.thicknessScale.value;}
		set {_setting.thicknessScale.Override(value);}
	}

	private ConfigElement<bool> _configEnable;
	private ConfigElement<bool> _configOverrideEnable;
	private ConfigElement<float> _configLength;
	private ConfigElement<bool> _configOverrideLength;
	private ConfigElement<float> _configOpacity;
	private ConfigElement<bool> _configOverrideOpacity;
	private ConfigElement<float> _configDistanceScaleFactor;
	private ConfigElement<bool> _configOverrideDistanceScaleFactor;
	private ConfigElement<float> _configMaxDistance;
	private ConfigElement<bool> _configOverrideMaxDistance;
	private ConfigElement<float> _configMinDistance;
	private ConfigElement<bool> _configOverrideMinDistance;
	private ConfigElement<float> _configFadeDistance;
	private ConfigElement<bool> _configOverrideFadeDistance;
	private ConfigElement<float> _configFadeInDistance;
	private ConfigElement<bool> _configOverrideFadeInDistance;
	private ConfigElement<float> _configRayBias;
	private ConfigElement<bool> _configOverrideRayBias;
	private ConfigElement<float> _configThicknessScale;
	private ConfigElement<bool> _configOverrideThicknessScale;

	public SContactShadows(ContactShadows setting)
	{
		_setting = setting;

		_configEnable = new("enable", "Enable", _setting.enable.value, "ContactShadows");
		_configOverrideEnable = new("OverrideEnable", "Override default for Enable", _setting.enable.overrideState, "ContactShadows");
		_configLength = new("length", "Length", _setting.length.value, "ContactShadows");
		_configOverrideLength = new("OverrideLength", "Override default for Length", _setting.length.overrideState, "ContactShadows");
		_configOpacity = new("opacity", "Opacity", _setting.opacity.value, "ContactShadows");
		_configOverrideOpacity = new("OverrideOpacity", "Override default for Opacity", _setting.opacity.overrideState, "ContactShadows");
		_configDistanceScaleFactor = new("distanceScaleFactor", "DistanceScaleFactor", _setting.distanceScaleFactor.value, "ContactShadows");
		_configOverrideDistanceScaleFactor = new("OverrideDistanceScaleFactor", "Override default for DistanceScaleFactor", _setting.distanceScaleFactor.overrideState, "ContactShadows");
		_configMaxDistance = new("maxDistance", "MaxDistance", _setting.maxDistance.value, "ContactShadows");
		_configOverrideMaxDistance = new("OverrideMaxDistance", "Override default for MaxDistance", _setting.maxDistance.overrideState, "ContactShadows");
		_configMinDistance = new("minDistance", "MinDistance", _setting.minDistance.value, "ContactShadows");
		_configOverrideMinDistance = new("OverrideMinDistance", "Override default for MinDistance", _setting.minDistance.overrideState, "ContactShadows");
		_configFadeDistance = new("fadeDistance", "FadeDistance", _setting.fadeDistance.value, "ContactShadows");
		_configOverrideFadeDistance = new("OverrideFadeDistance", "Override default for FadeDistance", _setting.fadeDistance.overrideState, "ContactShadows");
		_configFadeInDistance = new("fadeInDistance", "FadeInDistance", _setting.fadeInDistance.value, "ContactShadows");
		_configOverrideFadeInDistance = new("OverrideFadeInDistance", "Override default for FadeInDistance", _setting.fadeInDistance.overrideState, "ContactShadows");
		_configRayBias = new("rayBias", "RayBias", _setting.rayBias.value, "ContactShadows");
		_configOverrideRayBias = new("OverrideRayBias", "Override default for RayBias", _setting.rayBias.overrideState, "ContactShadows");
		_configThicknessScale = new("thicknessScale", "ThicknessScale", _setting.thicknessScale.value, "ContactShadows");
		_configOverrideThicknessScale = new("OverrideThicknessScale", "Override default for ThicknessScale", _setting.thicknessScale.overrideState, "ContactShadows");
	}

	public void ApplyFromConfig()
	{
		_setting.enable.overrideState = _configOverrideEnable.Value;
		_setting.enable.value = _configEnable.Value;
		_setting.length.overrideState = _configOverrideLength.Value;
		_setting.length.value = _configLength.Value;
		_setting.opacity.overrideState = _configOverrideOpacity.Value;
		_setting.opacity.value = _configOpacity.Value;
		_setting.distanceScaleFactor.overrideState = _configOverrideDistanceScaleFactor.Value;
		_setting.distanceScaleFactor.value = _configDistanceScaleFactor.Value;
		_setting.maxDistance.overrideState = _configOverrideMaxDistance.Value;
		_setting.maxDistance.value = _configMaxDistance.Value;
		_setting.minDistance.overrideState = _configOverrideMinDistance.Value;
		_setting.minDistance.value = _configMinDistance.Value;
		_setting.fadeDistance.overrideState = _configOverrideFadeDistance.Value;
		_setting.fadeDistance.value = _configFadeDistance.Value;
		_setting.fadeInDistance.overrideState = _configOverrideFadeInDistance.Value;
		_setting.fadeInDistance.value = _configFadeInDistance.Value;
		_setting.rayBias.overrideState = _configOverrideRayBias.Value;
		_setting.rayBias.value = _configRayBias.Value;
		_setting.thicknessScale.overrideState = _configOverrideThicknessScale.Value;
		_setting.thicknessScale.value = _configThicknessScale.Value;
	}

	public void SetSetting(ContactShadows setting)
	{
		_setting = setting;
	}
}

public class SMicroShadowing
{
	private MicroShadowing _setting;

	public bool Enable
	{
		get {return _setting.enable.value;}
		set {_setting.enable.Override(value);}
	}

	public float Opacity
	{
		get {return _setting.opacity.value;}
		set {_setting.opacity.Override(value);}
	}

	private ConfigElement<bool> _configEnable;
	private ConfigElement<bool> _configOverrideEnable;
	private ConfigElement<float> _configOpacity;
	private ConfigElement<bool> _configOverrideOpacity;

	public SMicroShadowing(MicroShadowing setting)
	{
		_setting = setting;

		_configEnable = new("enable", "Enable", _setting.enable.value, "MicroShadowing");
		_configOverrideEnable = new("OverrideEnable", "Override default for Enable", _setting.enable.overrideState, "MicroShadowing");
		_configOpacity = new("opacity", "Opacity", _setting.opacity.value, "MicroShadowing");
		_configOverrideOpacity = new("OverrideOpacity", "Override default for Opacity", _setting.opacity.overrideState, "MicroShadowing");
	}

	public void ApplyFromConfig()
	{
		_setting.enable.overrideState = _configOverrideEnable.Value;
		_setting.enable.value = _configEnable.Value;
		_setting.opacity.overrideState = _configOverrideOpacity.Value;
		_setting.opacity.value = _configOpacity.Value;
	}

	public void SetSetting(MicroShadowing setting)
	{
		_setting = setting;
	}
}

public class SVolumetricClouds
{
	private VolumetricClouds _setting;

	public bool Enable
	{
		get {return _setting.enable.value;}
		set {_setting.enable.Override(value);}
	}

	public bool LocalClouds
	{
		get {return _setting.localClouds.value;}
		set {_setting.localClouds.Override(value);}
	}

	public float EarthCurvature
	{
		get {return _setting.earthCurvature.value;}
		set {_setting.earthCurvature.Override(value);}
	}

	public float BottomAltitude
	{
		get {return _setting.bottomAltitude.value;}
		set {_setting.bottomAltitude.Override(value);}
	}

	public float AltitudeRange
	{
		get {return _setting.altitudeRange.value;}
		set {_setting.altitudeRange.Override(value);}
	}

	public float FadeInStart
	{
		get {return _setting.fadeInStart.value;}
		set {_setting.fadeInStart.Override(value);}
	}

	public float FadeInDistance
	{
		get {return _setting.fadeInDistance.value;}
		set {_setting.fadeInDistance.Override(value);}
	}

	public float CumulusMapMultiplier
	{
		get {return _setting.cumulusMapMultiplier.value;}
		set {_setting.cumulusMapMultiplier.Override(value);}
	}

	public float AltoStratusMapMultiplier
	{
		get {return _setting.altoStratusMapMultiplier.value;}
		set {_setting.altoStratusMapMultiplier.Override(value);}
	}

	public float CumulonimbusMapMultiplier
	{
		get {return _setting.cumulonimbusMapMultiplier.value;}
		set {_setting.cumulonimbusMapMultiplier.Override(value);}
	}

	public Color ScatteringTint
	{
		get {return _setting.scatteringTint.value;}
		set {_setting.scatteringTint.Override(value);}
	}

	public float PowderEffectIntensity
	{
		get {return _setting.powderEffectIntensity.value;}
		set {_setting.powderEffectIntensity.Override(value);}
	}

	public float MultiScattering
	{
		get {return _setting.multiScattering.value;}
		set {_setting.multiScattering.Override(value);}
	}

	public float DensityMultiplier
	{
		get {return _setting.densityMultiplier.value;}
		set {_setting.densityMultiplier.Override(value);}
	}

	public float ShapeFactor
	{
		get {return _setting.shapeFactor.value;}
		set {_setting.shapeFactor.Override(value);}
	}

	public float ShapeScale
	{
		get {return _setting.shapeScale.value;}
		set {_setting.shapeScale.Override(value);}
	}

	public float ErosionFactor
	{
		get {return _setting.erosionFactor.value;}
		set {_setting.erosionFactor.Override(value);}
	}

	public float ErosionScale
	{
		get {return _setting.erosionScale.value;}
		set {_setting.erosionScale.Override(value);}
	}

	public float AmbientLightProbeDimmer
	{
		get {return _setting.ambientLightProbeDimmer.value;}
		set {_setting.ambientLightProbeDimmer.Override(value);}
	}

	public float SunLightDimmer
	{
		get {return _setting.sunLightDimmer.value;}
		set {_setting.sunLightDimmer.Override(value);}
	}

	public float ErosionOcclusion
	{
		get {return _setting.erosionOcclusion.value;}
		set {_setting.erosionOcclusion.Override(value);}
	}

	public float AltitudeDistortion
	{
		get {return _setting.altitudeDistortion.value;}
		set {_setting.altitudeDistortion.Override(value);}
	}

	public float CloudMapSpeedMultiplier
	{
		get {return _setting.cloudMapSpeedMultiplier.value;}
		set {_setting.cloudMapSpeedMultiplier.Override(value);}
	}

	public float ShapeSpeedMultiplier
	{
		get {return _setting.shapeSpeedMultiplier.value;}
		set {_setting.shapeSpeedMultiplier.Override(value);}
	}

	public float ErosionSpeedMultiplier
	{
		get {return _setting.erosionSpeedMultiplier.value;}
		set {_setting.erosionSpeedMultiplier.Override(value);}
	}

	public float TemporalAccumulationFactor
	{
		get {return _setting.temporalAccumulationFactor.value;}
		set {_setting.temporalAccumulationFactor.Override(value);}
	}

	public bool GhostingReduction
	{
		get {return _setting.ghostingReduction.value;}
		set {_setting.ghostingReduction.Override(value);}
	}

	public float PerceptualBlending
	{
		get {return _setting.perceptualBlending.value;}
		set {_setting.perceptualBlending.Override(value);}
	}

	public bool Shadows
	{
		get {return _setting.shadows.value;}
		set {_setting.shadows.Override(value);}
	}

	public float ShadowDistance
	{
		get {return _setting.shadowDistance.value;}
		set {_setting.shadowDistance.Override(value);}
	}

	public float ShadowOpacity
	{
		get {return _setting.shadowOpacity.value;}
		set {_setting.shadowOpacity.Override(value);}
	}

	public float ShadowOpacityFallback
	{
		get {return _setting.shadowOpacityFallback.value;}
		set {_setting.shadowOpacityFallback.Override(value);}
	}

	public float M_ObsoleteWindSpeed
	{
		get {return _setting.m_ObsoleteWindSpeed.value;}
		set {_setting.m_ObsoleteWindSpeed.Override(value);}
	}

	public float M_ObsoleteOrientation
	{
		get {return _setting.m_ObsoleteOrientation.value;}
		set {_setting.m_ObsoleteOrientation.Override(value);}
	}

	private ConfigElement<bool> _configEnable;
	private ConfigElement<bool> _configOverrideEnable;
	private ConfigElement<bool> _configLocalClouds;
	private ConfigElement<bool> _configOverrideLocalClouds;
	private ConfigElement<float> _configEarthCurvature;
	private ConfigElement<bool> _configOverrideEarthCurvature;
	private ConfigElement<float> _configBottomAltitude;
	private ConfigElement<bool> _configOverrideBottomAltitude;
	private ConfigElement<float> _configAltitudeRange;
	private ConfigElement<bool> _configOverrideAltitudeRange;
	private ConfigElement<float> _configFadeInStart;
	private ConfigElement<bool> _configOverrideFadeInStart;
	private ConfigElement<float> _configFadeInDistance;
	private ConfigElement<bool> _configOverrideFadeInDistance;
	private ConfigElement<float> _configCumulusMapMultiplier;
	private ConfigElement<bool> _configOverrideCumulusMapMultiplier;
	private ConfigElement<float> _configAltoStratusMapMultiplier;
	private ConfigElement<bool> _configOverrideAltoStratusMapMultiplier;
	private ConfigElement<float> _configCumulonimbusMapMultiplier;
	private ConfigElement<bool> _configOverrideCumulonimbusMapMultiplier;
	private ConfigElement<Color> _configScatteringTint;
	private ConfigElement<bool> _configOverrideScatteringTint;
	private ConfigElement<float> _configPowderEffectIntensity;
	private ConfigElement<bool> _configOverridePowderEffectIntensity;
	private ConfigElement<float> _configMultiScattering;
	private ConfigElement<bool> _configOverrideMultiScattering;
	private ConfigElement<float> _configDensityMultiplier;
	private ConfigElement<bool> _configOverrideDensityMultiplier;
	private ConfigElement<float> _configShapeFactor;
	private ConfigElement<bool> _configOverrideShapeFactor;
	private ConfigElement<float> _configShapeScale;
	private ConfigElement<bool> _configOverrideShapeScale;
	private ConfigElement<float> _configErosionFactor;
	private ConfigElement<bool> _configOverrideErosionFactor;
	private ConfigElement<float> _configErosionScale;
	private ConfigElement<bool> _configOverrideErosionScale;
	private ConfigElement<float> _configAmbientLightProbeDimmer;
	private ConfigElement<bool> _configOverrideAmbientLightProbeDimmer;
	private ConfigElement<float> _configSunLightDimmer;
	private ConfigElement<bool> _configOverrideSunLightDimmer;
	private ConfigElement<float> _configErosionOcclusion;
	private ConfigElement<bool> _configOverrideErosionOcclusion;
	private ConfigElement<float> _configAltitudeDistortion;
	private ConfigElement<bool> _configOverrideAltitudeDistortion;
	private ConfigElement<float> _configCloudMapSpeedMultiplier;
	private ConfigElement<bool> _configOverrideCloudMapSpeedMultiplier;
	private ConfigElement<float> _configShapeSpeedMultiplier;
	private ConfigElement<bool> _configOverrideShapeSpeedMultiplier;
	private ConfigElement<float> _configErosionSpeedMultiplier;
	private ConfigElement<bool> _configOverrideErosionSpeedMultiplier;
	private ConfigElement<float> _configTemporalAccumulationFactor;
	private ConfigElement<bool> _configOverrideTemporalAccumulationFactor;
	private ConfigElement<bool> _configGhostingReduction;
	private ConfigElement<bool> _configOverrideGhostingReduction;
	private ConfigElement<float> _configPerceptualBlending;
	private ConfigElement<bool> _configOverridePerceptualBlending;
	private ConfigElement<bool> _configShadows;
	private ConfigElement<bool> _configOverrideShadows;
	private ConfigElement<float> _configShadowDistance;
	private ConfigElement<bool> _configOverrideShadowDistance;
	private ConfigElement<float> _configShadowOpacity;
	private ConfigElement<bool> _configOverrideShadowOpacity;
	private ConfigElement<float> _configShadowOpacityFallback;
	private ConfigElement<bool> _configOverrideShadowOpacityFallback;
	private ConfigElement<float> _configM_ObsoleteWindSpeed;
	private ConfigElement<bool> _configOverrideM_ObsoleteWindSpeed;
	private ConfigElement<float> _configM_ObsoleteOrientation;
	private ConfigElement<bool> _configOverrideM_ObsoleteOrientation;

	public SVolumetricClouds(VolumetricClouds setting)
	{
		_setting = setting;

		_configEnable = new("enable", "Enable", _setting.enable.value, "VolumetricClouds");
		_configOverrideEnable = new("OverrideEnable", "Override default for Enable", _setting.enable.overrideState, "VolumetricClouds");
		_configLocalClouds = new("localClouds", "LocalClouds", _setting.localClouds.value, "VolumetricClouds");
		_configOverrideLocalClouds = new("OverrideLocalClouds", "Override default for LocalClouds", _setting.localClouds.overrideState, "VolumetricClouds");
		_configEarthCurvature = new("earthCurvature", "EarthCurvature", _setting.earthCurvature.value, "VolumetricClouds");
		_configOverrideEarthCurvature = new("OverrideEarthCurvature", "Override default for EarthCurvature", _setting.earthCurvature.overrideState, "VolumetricClouds");
		_configBottomAltitude = new("bottomAltitude", "BottomAltitude", _setting.bottomAltitude.value, "VolumetricClouds");
		_configOverrideBottomAltitude = new("OverrideBottomAltitude", "Override default for BottomAltitude", _setting.bottomAltitude.overrideState, "VolumetricClouds");
		_configAltitudeRange = new("altitudeRange", "AltitudeRange", _setting.altitudeRange.value, "VolumetricClouds");
		_configOverrideAltitudeRange = new("OverrideAltitudeRange", "Override default for AltitudeRange", _setting.altitudeRange.overrideState, "VolumetricClouds");
		_configFadeInStart = new("fadeInStart", "FadeInStart", _setting.fadeInStart.value, "VolumetricClouds");
		_configOverrideFadeInStart = new("OverrideFadeInStart", "Override default for FadeInStart", _setting.fadeInStart.overrideState, "VolumetricClouds");
		_configFadeInDistance = new("fadeInDistance", "FadeInDistance", _setting.fadeInDistance.value, "VolumetricClouds");
		_configOverrideFadeInDistance = new("OverrideFadeInDistance", "Override default for FadeInDistance", _setting.fadeInDistance.overrideState, "VolumetricClouds");
		_configCumulusMapMultiplier = new("cumulusMapMultiplier", "CumulusMapMultiplier", _setting.cumulusMapMultiplier.value, "VolumetricClouds");
		_configOverrideCumulusMapMultiplier = new("OverrideCumulusMapMultiplier", "Override default for CumulusMapMultiplier", _setting.cumulusMapMultiplier.overrideState, "VolumetricClouds");
		_configAltoStratusMapMultiplier = new("altoStratusMapMultiplier", "AltoStratusMapMultiplier", _setting.altoStratusMapMultiplier.value, "VolumetricClouds");
		_configOverrideAltoStratusMapMultiplier = new("OverrideAltoStratusMapMultiplier", "Override default for AltoStratusMapMultiplier", _setting.altoStratusMapMultiplier.overrideState, "VolumetricClouds");
		_configCumulonimbusMapMultiplier = new("cumulonimbusMapMultiplier", "CumulonimbusMapMultiplier", _setting.cumulonimbusMapMultiplier.value, "VolumetricClouds");
		_configOverrideCumulonimbusMapMultiplier = new("OverrideCumulonimbusMapMultiplier", "Override default for CumulonimbusMapMultiplier", _setting.cumulonimbusMapMultiplier.overrideState, "VolumetricClouds");
		_configScatteringTint = new("scatteringTint", "ScatteringTint", _setting.scatteringTint.value, "VolumetricClouds");
		_configOverrideScatteringTint = new("OverrideScatteringTint", "Override default for ScatteringTint", _setting.scatteringTint.overrideState, "VolumetricClouds");
		_configPowderEffectIntensity = new("powderEffectIntensity", "PowderEffectIntensity", _setting.powderEffectIntensity.value, "VolumetricClouds");
		_configOverridePowderEffectIntensity = new("OverridePowderEffectIntensity", "Override default for PowderEffectIntensity", _setting.powderEffectIntensity.overrideState, "VolumetricClouds");
		_configMultiScattering = new("multiScattering", "MultiScattering", _setting.multiScattering.value, "VolumetricClouds");
		_configOverrideMultiScattering = new("OverrideMultiScattering", "Override default for MultiScattering", _setting.multiScattering.overrideState, "VolumetricClouds");
		_configDensityMultiplier = new("densityMultiplier", "DensityMultiplier", _setting.densityMultiplier.value, "VolumetricClouds");
		_configOverrideDensityMultiplier = new("OverrideDensityMultiplier", "Override default for DensityMultiplier", _setting.densityMultiplier.overrideState, "VolumetricClouds");
		_configShapeFactor = new("shapeFactor", "ShapeFactor", _setting.shapeFactor.value, "VolumetricClouds");
		_configOverrideShapeFactor = new("OverrideShapeFactor", "Override default for ShapeFactor", _setting.shapeFactor.overrideState, "VolumetricClouds");
		_configShapeScale = new("shapeScale", "ShapeScale", _setting.shapeScale.value, "VolumetricClouds");
		_configOverrideShapeScale = new("OverrideShapeScale", "Override default for ShapeScale", _setting.shapeScale.overrideState, "VolumetricClouds");
		_configErosionFactor = new("erosionFactor", "ErosionFactor", _setting.erosionFactor.value, "VolumetricClouds");
		_configOverrideErosionFactor = new("OverrideErosionFactor", "Override default for ErosionFactor", _setting.erosionFactor.overrideState, "VolumetricClouds");
		_configErosionScale = new("erosionScale", "ErosionScale", _setting.erosionScale.value, "VolumetricClouds");
		_configOverrideErosionScale = new("OverrideErosionScale", "Override default for ErosionScale", _setting.erosionScale.overrideState, "VolumetricClouds");
		_configAmbientLightProbeDimmer = new("ambientLightProbeDimmer", "AmbientLightProbeDimmer", _setting.ambientLightProbeDimmer.value, "VolumetricClouds");
		_configOverrideAmbientLightProbeDimmer = new("OverrideAmbientLightProbeDimmer", "Override default for AmbientLightProbeDimmer", _setting.ambientLightProbeDimmer.overrideState, "VolumetricClouds");
		_configSunLightDimmer = new("sunLightDimmer", "SunLightDimmer", _setting.sunLightDimmer.value, "VolumetricClouds");
		_configOverrideSunLightDimmer = new("OverrideSunLightDimmer", "Override default for SunLightDimmer", _setting.sunLightDimmer.overrideState, "VolumetricClouds");
		_configErosionOcclusion = new("erosionOcclusion", "ErosionOcclusion", _setting.erosionOcclusion.value, "VolumetricClouds");
		_configOverrideErosionOcclusion = new("OverrideErosionOcclusion", "Override default for ErosionOcclusion", _setting.erosionOcclusion.overrideState, "VolumetricClouds");
		_configAltitudeDistortion = new("altitudeDistortion", "AltitudeDistortion", _setting.altitudeDistortion.value, "VolumetricClouds");
		_configOverrideAltitudeDistortion = new("OverrideAltitudeDistortion", "Override default for AltitudeDistortion", _setting.altitudeDistortion.overrideState, "VolumetricClouds");
		_configCloudMapSpeedMultiplier = new("cloudMapSpeedMultiplier", "CloudMapSpeedMultiplier", _setting.cloudMapSpeedMultiplier.value, "VolumetricClouds");
		_configOverrideCloudMapSpeedMultiplier = new("OverrideCloudMapSpeedMultiplier", "Override default for CloudMapSpeedMultiplier", _setting.cloudMapSpeedMultiplier.overrideState, "VolumetricClouds");
		_configShapeSpeedMultiplier = new("shapeSpeedMultiplier", "ShapeSpeedMultiplier", _setting.shapeSpeedMultiplier.value, "VolumetricClouds");
		_configOverrideShapeSpeedMultiplier = new("OverrideShapeSpeedMultiplier", "Override default for ShapeSpeedMultiplier", _setting.shapeSpeedMultiplier.overrideState, "VolumetricClouds");
		_configErosionSpeedMultiplier = new("erosionSpeedMultiplier", "ErosionSpeedMultiplier", _setting.erosionSpeedMultiplier.value, "VolumetricClouds");
		_configOverrideErosionSpeedMultiplier = new("OverrideErosionSpeedMultiplier", "Override default for ErosionSpeedMultiplier", _setting.erosionSpeedMultiplier.overrideState, "VolumetricClouds");
		_configTemporalAccumulationFactor = new("temporalAccumulationFactor", "TemporalAccumulationFactor", _setting.temporalAccumulationFactor.value, "VolumetricClouds");
		_configOverrideTemporalAccumulationFactor = new("OverrideTemporalAccumulationFactor", "Override default for TemporalAccumulationFactor", _setting.temporalAccumulationFactor.overrideState, "VolumetricClouds");
		_configGhostingReduction = new("ghostingReduction", "GhostingReduction", _setting.ghostingReduction.value, "VolumetricClouds");
		_configOverrideGhostingReduction = new("OverrideGhostingReduction", "Override default for GhostingReduction", _setting.ghostingReduction.overrideState, "VolumetricClouds");
		_configPerceptualBlending = new("perceptualBlending", "PerceptualBlending", _setting.perceptualBlending.value, "VolumetricClouds");
		_configOverridePerceptualBlending = new("OverridePerceptualBlending", "Override default for PerceptualBlending", _setting.perceptualBlending.overrideState, "VolumetricClouds");
		_configShadows = new("shadows", "Shadows", _setting.shadows.value, "VolumetricClouds");
		_configOverrideShadows = new("OverrideShadows", "Override default for Shadows", _setting.shadows.overrideState, "VolumetricClouds");
		_configShadowDistance = new("shadowDistance", "ShadowDistance", _setting.shadowDistance.value, "VolumetricClouds");
		_configOverrideShadowDistance = new("OverrideShadowDistance", "Override default for ShadowDistance", _setting.shadowDistance.overrideState, "VolumetricClouds");
		_configShadowOpacity = new("shadowOpacity", "ShadowOpacity", _setting.shadowOpacity.value, "VolumetricClouds");
		_configOverrideShadowOpacity = new("OverrideShadowOpacity", "Override default for ShadowOpacity", _setting.shadowOpacity.overrideState, "VolumetricClouds");
		_configShadowOpacityFallback = new("shadowOpacityFallback", "ShadowOpacityFallback", _setting.shadowOpacityFallback.value, "VolumetricClouds");
		_configOverrideShadowOpacityFallback = new("OverrideShadowOpacityFallback", "Override default for ShadowOpacityFallback", _setting.shadowOpacityFallback.overrideState, "VolumetricClouds");
		_configM_ObsoleteWindSpeed = new("m_ObsoleteWindSpeed", "M_ObsoleteWindSpeed", _setting.m_ObsoleteWindSpeed.value, "VolumetricClouds");
		_configOverrideM_ObsoleteWindSpeed = new("OverrideM_ObsoleteWindSpeed", "Override default for M_ObsoleteWindSpeed", _setting.m_ObsoleteWindSpeed.overrideState, "VolumetricClouds");
		_configM_ObsoleteOrientation = new("m_ObsoleteOrientation", "M_ObsoleteOrientation", _setting.m_ObsoleteOrientation.value, "VolumetricClouds");
		_configOverrideM_ObsoleteOrientation = new("OverrideM_ObsoleteOrientation", "Override default for M_ObsoleteOrientation", _setting.m_ObsoleteOrientation.overrideState, "VolumetricClouds");
	}

	public void ApplyFromConfig()
	{
		_setting.enable.overrideState = _configOverrideEnable.Value;
		_setting.enable.value = _configEnable.Value;
		_setting.localClouds.overrideState = _configOverrideLocalClouds.Value;
		_setting.localClouds.value = _configLocalClouds.Value;
		_setting.earthCurvature.overrideState = _configOverrideEarthCurvature.Value;
		_setting.earthCurvature.value = _configEarthCurvature.Value;
		_setting.bottomAltitude.overrideState = _configOverrideBottomAltitude.Value;
		_setting.bottomAltitude.value = _configBottomAltitude.Value;
		_setting.altitudeRange.overrideState = _configOverrideAltitudeRange.Value;
		_setting.altitudeRange.value = _configAltitudeRange.Value;
		_setting.fadeInStart.overrideState = _configOverrideFadeInStart.Value;
		_setting.fadeInStart.value = _configFadeInStart.Value;
		_setting.fadeInDistance.overrideState = _configOverrideFadeInDistance.Value;
		_setting.fadeInDistance.value = _configFadeInDistance.Value;
		_setting.cumulusMapMultiplier.overrideState = _configOverrideCumulusMapMultiplier.Value;
		_setting.cumulusMapMultiplier.value = _configCumulusMapMultiplier.Value;
		_setting.altoStratusMapMultiplier.overrideState = _configOverrideAltoStratusMapMultiplier.Value;
		_setting.altoStratusMapMultiplier.value = _configAltoStratusMapMultiplier.Value;
		_setting.cumulonimbusMapMultiplier.overrideState = _configOverrideCumulonimbusMapMultiplier.Value;
		_setting.cumulonimbusMapMultiplier.value = _configCumulonimbusMapMultiplier.Value;
		_setting.scatteringTint.overrideState = _configOverrideScatteringTint.Value;
		_setting.scatteringTint.value = _configScatteringTint.Value;
		_setting.powderEffectIntensity.overrideState = _configOverridePowderEffectIntensity.Value;
		_setting.powderEffectIntensity.value = _configPowderEffectIntensity.Value;
		_setting.multiScattering.overrideState = _configOverrideMultiScattering.Value;
		_setting.multiScattering.value = _configMultiScattering.Value;
		_setting.densityMultiplier.overrideState = _configOverrideDensityMultiplier.Value;
		_setting.densityMultiplier.value = _configDensityMultiplier.Value;
		_setting.shapeFactor.overrideState = _configOverrideShapeFactor.Value;
		_setting.shapeFactor.value = _configShapeFactor.Value;
		_setting.shapeScale.overrideState = _configOverrideShapeScale.Value;
		_setting.shapeScale.value = _configShapeScale.Value;
		_setting.erosionFactor.overrideState = _configOverrideErosionFactor.Value;
		_setting.erosionFactor.value = _configErosionFactor.Value;
		_setting.erosionScale.overrideState = _configOverrideErosionScale.Value;
		_setting.erosionScale.value = _configErosionScale.Value;
		_setting.ambientLightProbeDimmer.overrideState = _configOverrideAmbientLightProbeDimmer.Value;
		_setting.ambientLightProbeDimmer.value = _configAmbientLightProbeDimmer.Value;
		_setting.sunLightDimmer.overrideState = _configOverrideSunLightDimmer.Value;
		_setting.sunLightDimmer.value = _configSunLightDimmer.Value;
		_setting.erosionOcclusion.overrideState = _configOverrideErosionOcclusion.Value;
		_setting.erosionOcclusion.value = _configErosionOcclusion.Value;
		_setting.altitudeDistortion.overrideState = _configOverrideAltitudeDistortion.Value;
		_setting.altitudeDistortion.value = _configAltitudeDistortion.Value;
		_setting.cloudMapSpeedMultiplier.overrideState = _configOverrideCloudMapSpeedMultiplier.Value;
		_setting.cloudMapSpeedMultiplier.value = _configCloudMapSpeedMultiplier.Value;
		_setting.shapeSpeedMultiplier.overrideState = _configOverrideShapeSpeedMultiplier.Value;
		_setting.shapeSpeedMultiplier.value = _configShapeSpeedMultiplier.Value;
		_setting.erosionSpeedMultiplier.overrideState = _configOverrideErosionSpeedMultiplier.Value;
		_setting.erosionSpeedMultiplier.value = _configErosionSpeedMultiplier.Value;
		_setting.temporalAccumulationFactor.overrideState = _configOverrideTemporalAccumulationFactor.Value;
		_setting.temporalAccumulationFactor.value = _configTemporalAccumulationFactor.Value;
		_setting.ghostingReduction.overrideState = _configOverrideGhostingReduction.Value;
		_setting.ghostingReduction.value = _configGhostingReduction.Value;
		_setting.perceptualBlending.overrideState = _configOverridePerceptualBlending.Value;
		_setting.perceptualBlending.value = _configPerceptualBlending.Value;
		_setting.shadows.overrideState = _configOverrideShadows.Value;
		_setting.shadows.value = _configShadows.Value;
		_setting.shadowDistance.overrideState = _configOverrideShadowDistance.Value;
		_setting.shadowDistance.value = _configShadowDistance.Value;
		_setting.shadowOpacity.overrideState = _configOverrideShadowOpacity.Value;
		_setting.shadowOpacity.value = _configShadowOpacity.Value;
		_setting.shadowOpacityFallback.overrideState = _configOverrideShadowOpacityFallback.Value;
		_setting.shadowOpacityFallback.value = _configShadowOpacityFallback.Value;
		_setting.m_ObsoleteWindSpeed.overrideState = _configOverrideM_ObsoleteWindSpeed.Value;
		_setting.m_ObsoleteWindSpeed.value = _configM_ObsoleteWindSpeed.Value;
		_setting.m_ObsoleteOrientation.overrideState = _configOverrideM_ObsoleteOrientation.Value;
		_setting.m_ObsoleteOrientation.value = _configM_ObsoleteOrientation.Value;
	}

	public void SetSetting(VolumetricClouds setting)
	{
		_setting = setting;
	}
}

public class SBloom
{
	private Bloom _setting;

	public float Threshold
	{
		get {return _setting.threshold.value;}
		set {_setting.threshold.Override(value);}
	}

	public float Intensity
	{
		get {return _setting.intensity.value;}
		set {_setting.intensity.Override(value);}
	}

	public float Scatter
	{
		get {return _setting.scatter.value;}
		set {_setting.scatter.Override(value);}
	}

	public Color Tint
	{
		get {return _setting.tint.value;}
		set {_setting.tint.Override(value);}
	}

	public float DirtIntensity
	{
		get {return _setting.dirtIntensity.value;}
		set {_setting.dirtIntensity.Override(value);}
	}

	public bool Anamorphic
	{
		get {return _setting.anamorphic.value;}
		set {_setting.anamorphic.Override(value);}
	}

	public bool M_HighQualityPrefiltering
	{
		get {return _setting.m_HighQualityPrefiltering.value;}
		set {_setting.m_HighQualityPrefiltering.Override(value);}
	}

	public bool M_HighQualityFiltering
	{
		get {return _setting.m_HighQualityFiltering.value;}
		set {_setting.m_HighQualityFiltering.Override(value);}
	}

	private ConfigElement<float> _configThreshold;
	private ConfigElement<bool> _configOverrideThreshold;
	private ConfigElement<float> _configIntensity;
	private ConfigElement<bool> _configOverrideIntensity;
	private ConfigElement<float> _configScatter;
	private ConfigElement<bool> _configOverrideScatter;
	private ConfigElement<Color> _configTint;
	private ConfigElement<bool> _configOverrideTint;
	private ConfigElement<float> _configDirtIntensity;
	private ConfigElement<bool> _configOverrideDirtIntensity;
	private ConfigElement<bool> _configAnamorphic;
	private ConfigElement<bool> _configOverrideAnamorphic;
	private ConfigElement<bool> _configM_HighQualityPrefiltering;
	private ConfigElement<bool> _configOverrideM_HighQualityPrefiltering;
	private ConfigElement<bool> _configM_HighQualityFiltering;
	private ConfigElement<bool> _configOverrideM_HighQualityFiltering;

	public SBloom(Bloom setting)
	{
		_setting = setting;

		_configThreshold = new("threshold", "Threshold", _setting.threshold.value, "Bloom");
		_configOverrideThreshold = new("OverrideThreshold", "Override default for Threshold", _setting.threshold.overrideState, "Bloom");
		_configIntensity = new("intensity", "Intensity", _setting.intensity.value, "Bloom");
		_configOverrideIntensity = new("OverrideIntensity", "Override default for Intensity", _setting.intensity.overrideState, "Bloom");
		_configScatter = new("scatter", "Scatter", _setting.scatter.value, "Bloom");
		_configOverrideScatter = new("OverrideScatter", "Override default for Scatter", _setting.scatter.overrideState, "Bloom");
		_configTint = new("tint", "Tint", _setting.tint.value, "Bloom");
		_configOverrideTint = new("OverrideTint", "Override default for Tint", _setting.tint.overrideState, "Bloom");
		_configDirtIntensity = new("dirtIntensity", "DirtIntensity", _setting.dirtIntensity.value, "Bloom");
		_configOverrideDirtIntensity = new("OverrideDirtIntensity", "Override default for DirtIntensity", _setting.dirtIntensity.overrideState, "Bloom");
		_configAnamorphic = new("anamorphic", "Anamorphic", _setting.anamorphic.value, "Bloom");
		_configOverrideAnamorphic = new("OverrideAnamorphic", "Override default for Anamorphic", _setting.anamorphic.overrideState, "Bloom");
		_configM_HighQualityPrefiltering = new("m_HighQualityPrefiltering", "M_HighQualityPrefiltering", _setting.m_HighQualityPrefiltering.value, "Bloom");
		_configOverrideM_HighQualityPrefiltering = new("OverrideM_HighQualityPrefiltering", "Override default for M_HighQualityPrefiltering", _setting.m_HighQualityPrefiltering.overrideState, "Bloom");
		_configM_HighQualityFiltering = new("m_HighQualityFiltering", "M_HighQualityFiltering", _setting.m_HighQualityFiltering.value, "Bloom");
		_configOverrideM_HighQualityFiltering = new("OverrideM_HighQualityFiltering", "Override default for M_HighQualityFiltering", _setting.m_HighQualityFiltering.overrideState, "Bloom");
	}

	public void ApplyFromConfig()
	{
		_setting.threshold.overrideState = _configOverrideThreshold.Value;
		_setting.threshold.value = _configThreshold.Value;
		_setting.intensity.overrideState = _configOverrideIntensity.Value;
		_setting.intensity.value = _configIntensity.Value;
		_setting.scatter.overrideState = _configOverrideScatter.Value;
		_setting.scatter.value = _configScatter.Value;
		_setting.tint.overrideState = _configOverrideTint.Value;
		_setting.tint.value = _configTint.Value;
		_setting.dirtIntensity.overrideState = _configOverrideDirtIntensity.Value;
		_setting.dirtIntensity.value = _configDirtIntensity.Value;
		_setting.anamorphic.overrideState = _configOverrideAnamorphic.Value;
		_setting.anamorphic.value = _configAnamorphic.Value;
		_setting.m_HighQualityPrefiltering.overrideState = _configOverrideM_HighQualityPrefiltering.Value;
		_setting.m_HighQualityPrefiltering.value = _configM_HighQualityPrefiltering.Value;
		_setting.m_HighQualityFiltering.overrideState = _configOverrideM_HighQualityFiltering.Value;
		_setting.m_HighQualityFiltering.value = _configM_HighQualityFiltering.Value;
	}

	public void SetSetting(Bloom setting)
	{
		_setting = setting;
	}
}

public class SChromaticAberration
{
	private ChromaticAberration _setting;

	public float Intensity
	{
		get {return _setting.intensity.value;}
		set {_setting.intensity.Override(value);}
	}

	private ConfigElement<float> _configIntensity;
	private ConfigElement<bool> _configOverrideIntensity;

	public SChromaticAberration(ChromaticAberration setting)
	{
		_setting = setting;

		_configIntensity = new("intensity", "Intensity", _setting.intensity.value, "ChromaticAberration");
		_configOverrideIntensity = new("OverrideIntensity", "Override default for Intensity", _setting.intensity.overrideState, "ChromaticAberration");
	}

	public void ApplyFromConfig()
	{
		_setting.intensity.overrideState = _configOverrideIntensity.Value;
		_setting.intensity.value = _configIntensity.Value;
	}

	public void SetSetting(ChromaticAberration setting)
	{
		_setting = setting;
	}
}

public class SColorAdjustments
{
	private ColorAdjustments _setting;

	public float Contrast
	{
		get {return _setting.contrast.value;}
		set {_setting.contrast.Override(value);}
	}

	public Color ColorFilter
	{
		get {return _setting.colorFilter.value;}
		set {_setting.colorFilter.Override(value);}
	}

	public float HueShift
	{
		get {return _setting.hueShift.value;}
		set {_setting.hueShift.Override(value);}
	}

	public float Saturation
	{
		get {return _setting.saturation.value;}
		set {_setting.saturation.Override(value);}
	}

	private ConfigElement<float> _configContrast;
	private ConfigElement<bool> _configOverrideContrast;
	private ConfigElement<Color> _configColorFilter;
	private ConfigElement<bool> _configOverrideColorFilter;
	private ConfigElement<float> _configHueShift;
	private ConfigElement<bool> _configOverrideHueShift;
	private ConfigElement<float> _configSaturation;
	private ConfigElement<bool> _configOverrideSaturation;

	public SColorAdjustments(ColorAdjustments setting)
	{
		_setting = setting;

		_configContrast = new("contrast", "Contrast", _setting.contrast.value, "ColorAdjustments");
		_configOverrideContrast = new("OverrideContrast", "Override default for Contrast", _setting.contrast.overrideState, "ColorAdjustments");
		_configColorFilter = new("colorFilter", "ColorFilter", _setting.colorFilter.value, "ColorAdjustments");
		_configOverrideColorFilter = new("OverrideColorFilter", "Override default for ColorFilter", _setting.colorFilter.overrideState, "ColorAdjustments");
		_configHueShift = new("hueShift", "HueShift", _setting.hueShift.value, "ColorAdjustments");
		_configOverrideHueShift = new("OverrideHueShift", "Override default for HueShift", _setting.hueShift.overrideState, "ColorAdjustments");
		_configSaturation = new("saturation", "Saturation", _setting.saturation.value, "ColorAdjustments");
		_configOverrideSaturation = new("OverrideSaturation", "Override default for Saturation", _setting.saturation.overrideState, "ColorAdjustments");
	}

	public void ApplyFromConfig()
	{
		_setting.contrast.overrideState = _configOverrideContrast.Value;
		_setting.contrast.value = _configContrast.Value;
		_setting.colorFilter.overrideState = _configOverrideColorFilter.Value;
		_setting.colorFilter.value = _configColorFilter.Value;
		_setting.hueShift.overrideState = _configOverrideHueShift.Value;
		_setting.hueShift.value = _configHueShift.Value;
		_setting.saturation.overrideState = _configOverrideSaturation.Value;
		_setting.saturation.value = _configSaturation.Value;
	}

	public void SetSetting(ColorAdjustments setting)
	{
		_setting = setting;
	}
}

public class SDepthOfField
{
	private DepthOfField _setting;

	public float FocusDistance
	{
		get {return _setting.focusDistance.value;}
		set {_setting.focusDistance.Override(value);}
	}

	public float NearFocusStart
	{
		get {return _setting.nearFocusStart.value;}
		set {_setting.nearFocusStart.Override(value);}
	}

	public float NearFocusEnd
	{
		get {return _setting.nearFocusEnd.value;}
		set {_setting.nearFocusEnd.Override(value);}
	}

	public float FarFocusStart
	{
		get {return _setting.farFocusStart.value;}
		set {_setting.farFocusStart.Override(value);}
	}

	public float FarFocusEnd
	{
		get {return _setting.farFocusEnd.value;}
		set {_setting.farFocusEnd.Override(value);}
	}

	public float M_NearMaxBlur
	{
		get {return _setting.m_NearMaxBlur.value;}
		set {_setting.m_NearMaxBlur.Override(value);}
	}

	public float M_FarMaxBlur
	{
		get {return _setting.m_FarMaxBlur.value;}
		set {_setting.m_FarMaxBlur.Override(value);}
	}

	public bool M_HighQualityFiltering
	{
		get {return _setting.m_HighQualityFiltering.value;}
		set {_setting.m_HighQualityFiltering.Override(value);}
	}

	public bool M_PhysicallyBased
	{
		get {return _setting.m_PhysicallyBased.value;}
		set {_setting.m_PhysicallyBased.Override(value);}
	}

	public bool M_LimitManualRangeNearBlur
	{
		get {return _setting.m_LimitManualRangeNearBlur.value;}
		set {_setting.m_LimitManualRangeNearBlur.Override(value);}
	}

	private ConfigElement<bool> _configEnabled;
	private ConfigElement<float> _configFocusDistance;
	private ConfigElement<bool> _configOverrideFocusDistance;
	private ConfigElement<float> _configNearFocusStart;
	private ConfigElement<bool> _configOverrideNearFocusStart;
	private ConfigElement<float> _configNearFocusEnd;
	private ConfigElement<bool> _configOverrideNearFocusEnd;
	private ConfigElement<float> _configFarFocusStart;
	private ConfigElement<bool> _configOverrideFarFocusStart;
	private ConfigElement<float> _configFarFocusEnd;
	private ConfigElement<bool> _configOverrideFarFocusEnd;
	private ConfigElement<float> _configM_NearMaxBlur;
	private ConfigElement<bool> _configOverrideM_NearMaxBlur;
	private ConfigElement<float> _configM_FarMaxBlur;
	private ConfigElement<bool> _configOverrideM_FarMaxBlur;
	private ConfigElement<bool> _configM_HighQualityFiltering;
	private ConfigElement<bool> _configOverrideM_HighQualityFiltering;
	private ConfigElement<bool> _configM_PhysicallyBased;
	private ConfigElement<bool> _configOverrideM_PhysicallyBased;
	private ConfigElement<bool> _configM_LimitManualRangeNearBlur;
	private ConfigElement<bool> _configOverrideM_LimitManualRangeNearBlur;

	public SDepthOfField(DepthOfField setting)
	{
		_setting = setting;

		_configEnabled = new("enabled", "Enabled", false, "DepthOfField");
		_configFocusDistance = new("focusDistance", "FocusDistance", _setting.focusDistance.value, "DepthOfField");
		_configOverrideFocusDistance = new("OverrideFocusDistance", "Override default for FocusDistance", _setting.focusDistance.overrideState, "DepthOfField");
		_configNearFocusStart = new("nearFocusStart", "NearFocusStart", _setting.nearFocusStart.value, "DepthOfField");
		_configOverrideNearFocusStart = new("OverrideNearFocusStart", "Override default for NearFocusStart", _setting.nearFocusStart.overrideState, "DepthOfField");
		_configNearFocusEnd = new("nearFocusEnd", "NearFocusEnd", _setting.nearFocusEnd.value, "DepthOfField");
		_configOverrideNearFocusEnd = new("OverrideNearFocusEnd", "Override default for NearFocusEnd", _setting.nearFocusEnd.overrideState, "DepthOfField");
		_configFarFocusStart = new("farFocusStart", "FarFocusStart", _setting.farFocusStart.value, "DepthOfField");
		_configOverrideFarFocusStart = new("OverrideFarFocusStart", "Override default for FarFocusStart", _setting.farFocusStart.overrideState, "DepthOfField");
		_configFarFocusEnd = new("farFocusEnd", "FarFocusEnd", _setting.farFocusEnd.value, "DepthOfField");
		_configOverrideFarFocusEnd = new("OverrideFarFocusEnd", "Override default for FarFocusEnd", _setting.farFocusEnd.overrideState, "DepthOfField");
		_configM_NearMaxBlur = new("m_NearMaxBlur", "M_NearMaxBlur", _setting.m_NearMaxBlur.value, "DepthOfField");
		_configOverrideM_NearMaxBlur = new("OverrideM_NearMaxBlur", "Override default for M_NearMaxBlur", _setting.m_NearMaxBlur.overrideState, "DepthOfField");
		_configM_FarMaxBlur = new("m_FarMaxBlur", "M_FarMaxBlur", _setting.m_FarMaxBlur.value, "DepthOfField");
		_configOverrideM_FarMaxBlur = new("OverrideM_FarMaxBlur", "Override default for M_FarMaxBlur", _setting.m_FarMaxBlur.overrideState, "DepthOfField");
		_configM_HighQualityFiltering = new("m_HighQualityFiltering", "M_HighQualityFiltering", _setting.m_HighQualityFiltering.value, "DepthOfField");
		_configOverrideM_HighQualityFiltering = new("OverrideM_HighQualityFiltering", "Override default for M_HighQualityFiltering", _setting.m_HighQualityFiltering.overrideState, "DepthOfField");
		_configM_PhysicallyBased = new("m_PhysicallyBased", "M_PhysicallyBased", _setting.m_PhysicallyBased.value, "DepthOfField");
		_configOverrideM_PhysicallyBased = new("OverrideM_PhysicallyBased", "Override default for M_PhysicallyBased", _setting.m_PhysicallyBased.overrideState, "DepthOfField");
		_configM_LimitManualRangeNearBlur = new("m_LimitManualRangeNearBlur", "M_LimitManualRangeNearBlur", _setting.m_LimitManualRangeNearBlur.value, "DepthOfField");
		_configOverrideM_LimitManualRangeNearBlur = new("OverrideM_LimitManualRangeNearBlur", "Override default for M_LimitManualRangeNearBlur", _setting.m_LimitManualRangeNearBlur.overrideState, "DepthOfField");
	}

	public void ApplyFromConfig()
	{
		_setting.focusMode.Override(_configEnabled.Value ? DepthOfFieldMode.Manual : DepthOfFieldMode.Off);
		_setting.focusDistance.overrideState = _configOverrideFocusDistance.Value;
		_setting.focusDistance.value = _configFocusDistance.Value;
		_setting.nearFocusStart.overrideState = _configOverrideNearFocusStart.Value;
		_setting.nearFocusStart.value = _configNearFocusStart.Value;
		_setting.nearFocusEnd.overrideState = _configOverrideNearFocusEnd.Value;
		_setting.nearFocusEnd.value = _configNearFocusEnd.Value;
		_setting.farFocusStart.overrideState = _configOverrideFarFocusStart.Value;
		_setting.farFocusStart.value = _configFarFocusStart.Value;
		_setting.farFocusEnd.overrideState = _configOverrideFarFocusEnd.Value;
		_setting.farFocusEnd.value = _configFarFocusEnd.Value;
		_setting.m_NearMaxBlur.overrideState = _configOverrideM_NearMaxBlur.Value;
		_setting.m_NearMaxBlur.value = _configM_NearMaxBlur.Value;
		_setting.m_FarMaxBlur.overrideState = _configOverrideM_FarMaxBlur.Value;
		_setting.m_FarMaxBlur.value = _configM_FarMaxBlur.Value;
		_setting.m_HighQualityFiltering.overrideState = _configOverrideM_HighQualityFiltering.Value;
		_setting.m_HighQualityFiltering.value = _configM_HighQualityFiltering.Value;
		_setting.m_PhysicallyBased.overrideState = _configOverrideM_PhysicallyBased.Value;
		_setting.m_PhysicallyBased.value = _configM_PhysicallyBased.Value;
		_setting.m_LimitManualRangeNearBlur.overrideState = _configOverrideM_LimitManualRangeNearBlur.Value;
		_setting.m_LimitManualRangeNearBlur.value = _configM_LimitManualRangeNearBlur.Value;
	}

	public void SetSetting(DepthOfField setting)
	{
		_setting = setting;
	}
}

public class SExposure
{
	private Exposure _setting;

	public float AdaptationSpeedDarkToLight
	{
		get {return _setting.adaptationSpeedDarkToLight.value;}
		set {_setting.adaptationSpeedDarkToLight.Override(value);}
	}

	public float AdaptationSpeedLightToDark
	{
		get {return _setting.adaptationSpeedLightToDark.value;}
		set {_setting.adaptationSpeedLightToDark.Override(value);}
	}

	public bool HistogramUseCurveRemapping
	{
		get {return _setting.histogramUseCurveRemapping.value;}
		set {_setting.histogramUseCurveRemapping.Override(value);}
	}

	public bool CenterAroundExposureTarget
	{
		get {return _setting.centerAroundExposureTarget.value;}
		set {_setting.centerAroundExposureTarget.Override(value);}
	}

	private ConfigElement<float> _configAdaptationSpeedDarkToLight;
	private ConfigElement<bool> _configOverrideAdaptationSpeedDarkToLight;
	private ConfigElement<float> _configAdaptationSpeedLightToDark;
	private ConfigElement<bool> _configOverrideAdaptationSpeedLightToDark;
	private ConfigElement<bool> _configHistogramUseCurveRemapping;
	private ConfigElement<bool> _configOverrideHistogramUseCurveRemapping;
	private ConfigElement<bool> _configCenterAroundExposureTarget;
	private ConfigElement<bool> _configOverrideCenterAroundExposureTarget;

	public SExposure(Exposure setting)
	{
		_setting = setting;

		_configAdaptationSpeedDarkToLight = new("adaptationSpeedDarkToLight", "AdaptationSpeedDarkToLight", _setting.adaptationSpeedDarkToLight.value, "Exposure");
		_configOverrideAdaptationSpeedDarkToLight = new("OverrideAdaptationSpeedDarkToLight", "Override default for AdaptationSpeedDarkToLight", _setting.adaptationSpeedDarkToLight.overrideState, "Exposure");
		_configAdaptationSpeedLightToDark = new("adaptationSpeedLightToDark", "AdaptationSpeedLightToDark", _setting.adaptationSpeedLightToDark.value, "Exposure");
		_configOverrideAdaptationSpeedLightToDark = new("OverrideAdaptationSpeedLightToDark", "Override default for AdaptationSpeedLightToDark", _setting.adaptationSpeedLightToDark.overrideState, "Exposure");
		_configHistogramUseCurveRemapping = new("histogramUseCurveRemapping", "HistogramUseCurveRemapping", _setting.histogramUseCurveRemapping.value, "Exposure");
		_configOverrideHistogramUseCurveRemapping = new("OverrideHistogramUseCurveRemapping", "Override default for HistogramUseCurveRemapping", _setting.histogramUseCurveRemapping.overrideState, "Exposure");
		_configCenterAroundExposureTarget = new("centerAroundExposureTarget", "CenterAroundExposureTarget", _setting.centerAroundExposureTarget.value, "Exposure");
		_configOverrideCenterAroundExposureTarget = new("OverrideCenterAroundExposureTarget", "Override default for CenterAroundExposureTarget", _setting.centerAroundExposureTarget.overrideState, "Exposure");
	}

	public void ApplyFromConfig()
	{
		_setting.adaptationSpeedDarkToLight.overrideState = _configOverrideAdaptationSpeedDarkToLight.Value;
		_setting.adaptationSpeedDarkToLight.value = _configAdaptationSpeedDarkToLight.Value;
		_setting.adaptationSpeedLightToDark.overrideState = _configOverrideAdaptationSpeedLightToDark.Value;
		_setting.adaptationSpeedLightToDark.value = _configAdaptationSpeedLightToDark.Value;
		_setting.histogramUseCurveRemapping.overrideState = _configOverrideHistogramUseCurveRemapping.Value;
		_setting.histogramUseCurveRemapping.value = _configHistogramUseCurveRemapping.Value;
		_setting.centerAroundExposureTarget.overrideState = _configOverrideCenterAroundExposureTarget.Value;
		_setting.centerAroundExposureTarget.value = _configCenterAroundExposureTarget.Value;
	}

	public void SetSetting(Exposure setting)
	{
		_setting = setting;
	}
}

public class SLiftGammaGain
{
	private LiftGammaGain _setting;


	public SLiftGammaGain(LiftGammaGain setting)
	{
		_setting = setting;

	}

	public void ApplyFromConfig()
	{
	}

	public void SetSetting(LiftGammaGain setting)
	{
		_setting = setting;
	}
}

public class SMotionBlur
{
	private MotionBlur _setting;

	public float Intensity
	{
		get {return _setting.intensity.value;}
		set {_setting.intensity.Override(value);}
	}

	public float MaximumVelocity
	{
		get {return _setting.maximumVelocity.value;}
		set {_setting.maximumVelocity.Override(value);}
	}

	public float MinimumVelocity
	{
		get {return _setting.minimumVelocity.value;}
		set {_setting.minimumVelocity.Override(value);}
	}

	public bool CameraMotionBlur
	{
		get {return _setting.cameraMotionBlur.value;}
		set {_setting.cameraMotionBlur.Override(value);}
	}

	public float CameraVelocityClamp
	{
		get {return _setting.cameraVelocityClamp.value;}
		set {_setting.cameraVelocityClamp.Override(value);}
	}

	public float CameraTranslationVelocityClamp
	{
		get {return _setting.cameraTranslationVelocityClamp.value;}
		set {_setting.cameraTranslationVelocityClamp.Override(value);}
	}

	public float CameraRotationVelocityClamp
	{
		get {return _setting.cameraRotationVelocityClamp.value;}
		set {_setting.cameraRotationVelocityClamp.Override(value);}
	}

	public float DepthComparisonExtent
	{
		get {return _setting.depthComparisonExtent.value;}
		set {_setting.depthComparisonExtent.Override(value);}
	}

	private ConfigElement<float> _configIntensity;
	private ConfigElement<bool> _configOverrideIntensity;
	private ConfigElement<float> _configMaximumVelocity;
	private ConfigElement<bool> _configOverrideMaximumVelocity;
	private ConfigElement<float> _configMinimumVelocity;
	private ConfigElement<bool> _configOverrideMinimumVelocity;
	private ConfigElement<bool> _configCameraMotionBlur;
	private ConfigElement<bool> _configOverrideCameraMotionBlur;
	private ConfigElement<float> _configCameraVelocityClamp;
	private ConfigElement<bool> _configOverrideCameraVelocityClamp;
	private ConfigElement<float> _configCameraTranslationVelocityClamp;
	private ConfigElement<bool> _configOverrideCameraTranslationVelocityClamp;
	private ConfigElement<float> _configCameraRotationVelocityClamp;
	private ConfigElement<bool> _configOverrideCameraRotationVelocityClamp;
	private ConfigElement<float> _configDepthComparisonExtent;
	private ConfigElement<bool> _configOverrideDepthComparisonExtent;

	public SMotionBlur(MotionBlur setting)
	{
		_setting = setting;

		_configIntensity = new("intensity", "Intensity", _setting.intensity.value, "MotionBlur");
		_configOverrideIntensity = new("OverrideIntensity", "Override default for Intensity", _setting.intensity.overrideState, "MotionBlur");
		_configMaximumVelocity = new("maximumVelocity", "MaximumVelocity", _setting.maximumVelocity.value, "MotionBlur");
		_configOverrideMaximumVelocity = new("OverrideMaximumVelocity", "Override default for MaximumVelocity", _setting.maximumVelocity.overrideState, "MotionBlur");
		_configMinimumVelocity = new("minimumVelocity", "MinimumVelocity", _setting.minimumVelocity.value, "MotionBlur");
		_configOverrideMinimumVelocity = new("OverrideMinimumVelocity", "Override default for MinimumVelocity", _setting.minimumVelocity.overrideState, "MotionBlur");
		_configCameraMotionBlur = new("cameraMotionBlur", "CameraMotionBlur", _setting.cameraMotionBlur.value, "MotionBlur");
		_configOverrideCameraMotionBlur = new("OverrideCameraMotionBlur", "Override default for CameraMotionBlur", _setting.cameraMotionBlur.overrideState, "MotionBlur");
		_configCameraVelocityClamp = new("cameraVelocityClamp", "CameraVelocityClamp", _setting.cameraVelocityClamp.value, "MotionBlur");
		_configOverrideCameraVelocityClamp = new("OverrideCameraVelocityClamp", "Override default for CameraVelocityClamp", _setting.cameraVelocityClamp.overrideState, "MotionBlur");
		_configCameraTranslationVelocityClamp = new("cameraTranslationVelocityClamp", "CameraTranslationVelocityClamp", _setting.cameraTranslationVelocityClamp.value, "MotionBlur");
		_configOverrideCameraTranslationVelocityClamp = new("OverrideCameraTranslationVelocityClamp", "Override default for CameraTranslationVelocityClamp", _setting.cameraTranslationVelocityClamp.overrideState, "MotionBlur");
		_configCameraRotationVelocityClamp = new("cameraRotationVelocityClamp", "CameraRotationVelocityClamp", _setting.cameraRotationVelocityClamp.value, "MotionBlur");
		_configOverrideCameraRotationVelocityClamp = new("OverrideCameraRotationVelocityClamp", "Override default for CameraRotationVelocityClamp", _setting.cameraRotationVelocityClamp.overrideState, "MotionBlur");
		_configDepthComparisonExtent = new("depthComparisonExtent", "DepthComparisonExtent", _setting.depthComparisonExtent.value, "MotionBlur");
		_configOverrideDepthComparisonExtent = new("OverrideDepthComparisonExtent", "Override default for DepthComparisonExtent", _setting.depthComparisonExtent.overrideState, "MotionBlur");
	}

	public void ApplyFromConfig()
	{
		_setting.intensity.overrideState = _configOverrideIntensity.Value;
		_setting.intensity.value = _configIntensity.Value;
		_setting.maximumVelocity.overrideState = _configOverrideMaximumVelocity.Value;
		_setting.maximumVelocity.value = _configMaximumVelocity.Value;
		_setting.minimumVelocity.overrideState = _configOverrideMinimumVelocity.Value;
		_setting.minimumVelocity.value = _configMinimumVelocity.Value;
		_setting.cameraMotionBlur.overrideState = _configOverrideCameraMotionBlur.Value;
		_setting.cameraMotionBlur.value = _configCameraMotionBlur.Value;
		_setting.cameraVelocityClamp.overrideState = _configOverrideCameraVelocityClamp.Value;
		_setting.cameraVelocityClamp.value = _configCameraVelocityClamp.Value;
		_setting.cameraTranslationVelocityClamp.overrideState = _configOverrideCameraTranslationVelocityClamp.Value;
		_setting.cameraTranslationVelocityClamp.value = _configCameraTranslationVelocityClamp.Value;
		_setting.cameraRotationVelocityClamp.overrideState = _configOverrideCameraRotationVelocityClamp.Value;
		_setting.cameraRotationVelocityClamp.value = _configCameraRotationVelocityClamp.Value;
		_setting.depthComparisonExtent.overrideState = _configOverrideDepthComparisonExtent.Value;
		_setting.depthComparisonExtent.value = _configDepthComparisonExtent.Value;
	}

	public void SetSetting(MotionBlur setting)
	{
		_setting = setting;
	}
}

public class STonemapping
{
	private Tonemapping _setting;

	public bool UseFullACES
	{
		get {return _setting.useFullACES.value;}
		set {_setting.useFullACES.Override(value);}
	}

	public float ToeStrength
	{
		get {return _setting.toeStrength.value;}
		set {_setting.toeStrength.Override(value);}
	}

	public float ToeLength
	{
		get {return _setting.toeLength.value;}
		set {_setting.toeLength.Override(value);}
	}

	public float ShoulderStrength
	{
		get {return _setting.shoulderStrength.value;}
		set {_setting.shoulderStrength.Override(value);}
	}

	public float ShoulderLength
	{
		get {return _setting.shoulderLength.value;}
		set {_setting.shoulderLength.Override(value);}
	}

	public float ShoulderAngle
	{
		get {return _setting.shoulderAngle.value;}
		set {_setting.shoulderAngle.Override(value);}
	}

	public float Gamma
	{
		get {return _setting.gamma.value;}
		set {_setting.gamma.Override(value);}
	}

	public float LutContribution
	{
		get {return _setting.lutContribution.value;}
		set {_setting.lutContribution.Override(value);}
	}

	public float HueShiftAmount
	{
		get {return _setting.hueShiftAmount.value;}
		set {_setting.hueShiftAmount.Override(value);}
	}

	public bool DetectPaperWhite
	{
		get {return _setting.detectPaperWhite.value;}
		set {_setting.detectPaperWhite.Override(value);}
	}

	public float PaperWhite
	{
		get {return _setting.paperWhite.value;}
		set {_setting.paperWhite.Override(value);}
	}

	public bool DetectBrightnessLimits
	{
		get {return _setting.detectBrightnessLimits.value;}
		set {_setting.detectBrightnessLimits.Override(value);}
	}

	public float MinNits
	{
		get {return _setting.minNits.value;}
		set {_setting.minNits.Override(value);}
	}

	public float MaxNits
	{
		get {return _setting.maxNits.value;}
		set {_setting.maxNits.Override(value);}
	}

	private ConfigElement<bool> _configUseFullACES;
	private ConfigElement<bool> _configOverrideUseFullACES;
	private ConfigElement<float> _configToeStrength;
	private ConfigElement<bool> _configOverrideToeStrength;
	private ConfigElement<float> _configToeLength;
	private ConfigElement<bool> _configOverrideToeLength;
	private ConfigElement<float> _configShoulderStrength;
	private ConfigElement<bool> _configOverrideShoulderStrength;
	private ConfigElement<float> _configShoulderLength;
	private ConfigElement<bool> _configOverrideShoulderLength;
	private ConfigElement<float> _configShoulderAngle;
	private ConfigElement<bool> _configOverrideShoulderAngle;
	private ConfigElement<float> _configGamma;
	private ConfigElement<bool> _configOverrideGamma;
	private ConfigElement<float> _configLutContribution;
	private ConfigElement<bool> _configOverrideLutContribution;
	private ConfigElement<float> _configHueShiftAmount;
	private ConfigElement<bool> _configOverrideHueShiftAmount;
	private ConfigElement<bool> _configDetectPaperWhite;
	private ConfigElement<bool> _configOverrideDetectPaperWhite;
	private ConfigElement<float> _configPaperWhite;
	private ConfigElement<bool> _configOverridePaperWhite;
	private ConfigElement<bool> _configDetectBrightnessLimits;
	private ConfigElement<bool> _configOverrideDetectBrightnessLimits;
	private ConfigElement<float> _configMinNits;
	private ConfigElement<bool> _configOverrideMinNits;
	private ConfigElement<float> _configMaxNits;
	private ConfigElement<bool> _configOverrideMaxNits;

	public STonemapping(Tonemapping setting)
	{
		_setting = setting;

		_configUseFullACES = new("useFullACES", "UseFullACES", _setting.useFullACES.value, "Tonemapping");
		_configOverrideUseFullACES = new("OverrideUseFullACES", "Override default for UseFullACES", _setting.useFullACES.overrideState, "Tonemapping");
		_configToeStrength = new("toeStrength", "ToeStrength", _setting.toeStrength.value, "Tonemapping");
		_configOverrideToeStrength = new("OverrideToeStrength", "Override default for ToeStrength", _setting.toeStrength.overrideState, "Tonemapping");
		_configToeLength = new("toeLength", "ToeLength", _setting.toeLength.value, "Tonemapping");
		_configOverrideToeLength = new("OverrideToeLength", "Override default for ToeLength", _setting.toeLength.overrideState, "Tonemapping");
		_configShoulderStrength = new("shoulderStrength", "ShoulderStrength", _setting.shoulderStrength.value, "Tonemapping");
		_configOverrideShoulderStrength = new("OverrideShoulderStrength", "Override default for ShoulderStrength", _setting.shoulderStrength.overrideState, "Tonemapping");
		_configShoulderLength = new("shoulderLength", "ShoulderLength", _setting.shoulderLength.value, "Tonemapping");
		_configOverrideShoulderLength = new("OverrideShoulderLength", "Override default for ShoulderLength", _setting.shoulderLength.overrideState, "Tonemapping");
		_configShoulderAngle = new("shoulderAngle", "ShoulderAngle", _setting.shoulderAngle.value, "Tonemapping");
		_configOverrideShoulderAngle = new("OverrideShoulderAngle", "Override default for ShoulderAngle", _setting.shoulderAngle.overrideState, "Tonemapping");
		_configGamma = new("gamma", "Gamma", _setting.gamma.value, "Tonemapping");
		_configOverrideGamma = new("OverrideGamma", "Override default for Gamma", _setting.gamma.overrideState, "Tonemapping");
		_configLutContribution = new("lutContribution", "LutContribution", _setting.lutContribution.value, "Tonemapping");
		_configOverrideLutContribution = new("OverrideLutContribution", "Override default for LutContribution", _setting.lutContribution.overrideState, "Tonemapping");
		_configHueShiftAmount = new("hueShiftAmount", "HueShiftAmount", _setting.hueShiftAmount.value, "Tonemapping");
		_configOverrideHueShiftAmount = new("OverrideHueShiftAmount", "Override default for HueShiftAmount", _setting.hueShiftAmount.overrideState, "Tonemapping");
		_configDetectPaperWhite = new("detectPaperWhite", "DetectPaperWhite", _setting.detectPaperWhite.value, "Tonemapping");
		_configOverrideDetectPaperWhite = new("OverrideDetectPaperWhite", "Override default for DetectPaperWhite", _setting.detectPaperWhite.overrideState, "Tonemapping");
		_configPaperWhite = new("paperWhite", "PaperWhite", _setting.paperWhite.value, "Tonemapping");
		_configOverridePaperWhite = new("OverridePaperWhite", "Override default for PaperWhite", _setting.paperWhite.overrideState, "Tonemapping");
		_configDetectBrightnessLimits = new("detectBrightnessLimits", "DetectBrightnessLimits", _setting.detectBrightnessLimits.value, "Tonemapping");
		_configOverrideDetectBrightnessLimits = new("OverrideDetectBrightnessLimits", "Override default for DetectBrightnessLimits", _setting.detectBrightnessLimits.overrideState, "Tonemapping");
		_configMinNits = new("minNits", "MinNits", _setting.minNits.value, "Tonemapping");
		_configOverrideMinNits = new("OverrideMinNits", "Override default for MinNits", _setting.minNits.overrideState, "Tonemapping");
		_configMaxNits = new("maxNits", "MaxNits", _setting.maxNits.value, "Tonemapping");
		_configOverrideMaxNits = new("OverrideMaxNits", "Override default for MaxNits", _setting.maxNits.overrideState, "Tonemapping");
	}

	public void ApplyFromConfig()
	{
		_setting.useFullACES.overrideState = _configOverrideUseFullACES.Value;
		_setting.useFullACES.value = _configUseFullACES.Value;
		_setting.toeStrength.overrideState = _configOverrideToeStrength.Value;
		_setting.toeStrength.value = _configToeStrength.Value;
		_setting.toeLength.overrideState = _configOverrideToeLength.Value;
		_setting.toeLength.value = _configToeLength.Value;
		_setting.shoulderStrength.overrideState = _configOverrideShoulderStrength.Value;
		_setting.shoulderStrength.value = _configShoulderStrength.Value;
		_setting.shoulderLength.overrideState = _configOverrideShoulderLength.Value;
		_setting.shoulderLength.value = _configShoulderLength.Value;
		_setting.shoulderAngle.overrideState = _configOverrideShoulderAngle.Value;
		_setting.shoulderAngle.value = _configShoulderAngle.Value;
		_setting.gamma.overrideState = _configOverrideGamma.Value;
		_setting.gamma.value = _configGamma.Value;
		_setting.lutContribution.overrideState = _configOverrideLutContribution.Value;
		_setting.lutContribution.value = _configLutContribution.Value;
		_setting.hueShiftAmount.overrideState = _configOverrideHueShiftAmount.Value;
		_setting.hueShiftAmount.value = _configHueShiftAmount.Value;
		_setting.detectPaperWhite.overrideState = _configOverrideDetectPaperWhite.Value;
		_setting.detectPaperWhite.value = _configDetectPaperWhite.Value;
		_setting.paperWhite.overrideState = _configOverridePaperWhite.Value;
		_setting.paperWhite.value = _configPaperWhite.Value;
		_setting.detectBrightnessLimits.overrideState = _configOverrideDetectBrightnessLimits.Value;
		_setting.detectBrightnessLimits.value = _configDetectBrightnessLimits.Value;
		_setting.minNits.overrideState = _configOverrideMinNits.Value;
		_setting.minNits.value = _configMinNits.Value;
		_setting.maxNits.overrideState = _configOverrideMaxNits.Value;
		_setting.maxNits.value = _configMaxNits.Value;
	}

	public void SetSetting(Tonemapping setting)
	{
		_setting = setting;
	}
}

public class SWhiteBalance
{
	private WhiteBalance _setting;

	public float Temperature
	{
		get {return _setting.temperature.value;}
		set {_setting.temperature.Override(value);}
	}

	public float Tint
	{
		get {return _setting.tint.value;}
		set {_setting.tint.Override(value);}
	}

	private ConfigElement<float> _configTemperature;
	private ConfigElement<bool> _configOverrideTemperature;
	private ConfigElement<float> _configTint;
	private ConfigElement<bool> _configOverrideTint;

	public SWhiteBalance(WhiteBalance setting)
	{
		_setting = setting;

		_configTemperature = new("temperature", "Temperature", _setting.temperature.value, "WhiteBalance");
		_configOverrideTemperature = new("OverrideTemperature", "Override default for Temperature", _setting.temperature.overrideState, "WhiteBalance");
		_configTint = new("tint", "Tint", _setting.tint.value, "WhiteBalance");
		_configOverrideTint = new("OverrideTint", "Override default for Tint", _setting.tint.overrideState, "WhiteBalance");
	}

	public void ApplyFromConfig()
	{
		_setting.temperature.overrideState = _configOverrideTemperature.Value;
		_setting.temperature.value = _configTemperature.Value;
		_setting.tint.overrideState = _configOverrideTint.Value;
		_setting.tint.value = _configTint.Value;
	}

	public void SetSetting(WhiteBalance setting)
	{
		_setting = setting;
	}
}

public class SVisualEnvironment
{
	private VisualEnvironment _setting;

	public float WindOrientation
	{
		get {return _setting.windOrientation.value;}
		set {_setting.windOrientation.Override(value);}
	}

	private ConfigElement<float> _configWindOrientation;
	private ConfigElement<bool> _configOverrideWindOrientation;

	public SVisualEnvironment(VisualEnvironment setting)
	{
		_setting = setting;

		_configWindOrientation = new("windOrientation", "WindOrientation", _setting.windOrientation.value, "VisualEnvironment");
		_configOverrideWindOrientation = new("OverrideWindOrientation", "Override default for WindOrientation", _setting.windOrientation.overrideState, "VisualEnvironment");
	}

	public void ApplyFromConfig()
	{
		_setting.windOrientation.overrideState = _configOverrideWindOrientation.Value;
		_setting.windOrientation.value = _configWindOrientation.Value;
	}

	public void SetSetting(VisualEnvironment setting)
	{
		_setting = setting;
	}
}

