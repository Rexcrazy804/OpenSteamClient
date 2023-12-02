namespace OpenSteamworks.Enums;

public enum EVRInitError : uint
{
	None = 0,
	Unknown = 1,

	Init_InstallationNotFound	= 100,
	Init_InstallationCorrupt	= 101,
	Init_VRClientDLLNotFound	= 102,
	Init_FileNotFound			= 103,
	Init_FactoryNotFound		= 104,
	Init_InterfaceNotFound		= 105,
	Init_InvalidInterface		= 106,
	Init_UserConfigDirectoryInvalid = 107,
	Init_HmdNotFound			= 108,
	Init_NotInitialized		= 109,
	Init_PathRegistryNotFound	= 110,
	Init_NoConfigPath			= 111,
	Init_NoLogPath				= 112,
	Init_PathRegistryNotWritable = 113,
	Init_AppInfoInitFailed		= 114,
	Init_Retry					= 115,
	Init_InitCanceledByUser	= 116,
	Init_AnotherAppLaunching	= 117, 
	Init_SettingsInitFailed	= 118, 
	Init_ShuttingDown			= 119,
	Init_TooManyObjects		= 120,
	Init_NoServerForBackgroundApp = 121,
	Init_NotSupportedWithCompositor = 122,
	Init_NotAvailableToUtilityApps = 123,

	Driver_Failed				= 200,
	Driver_Unknown				= 201,
	Driver_HmdUnknown			= 202,
	Driver_NotLoaded			= 203,
	Driver_RuntimeOutOfDate	= 204,
	Driver_HmdInUse			= 205,
	Driver_NotCalibrated		= 206,
	Driver_CalibrationInvalid	= 207,
	Driver_HmdDisplayNotFound  = 208,
	
	IPC_ServerInitFailed		= 300,
	IPC_ConnectFailed			= 301,
	IPC_SharedStateInitFailed	= 302,
	IPC_CompositorInitFailed	= 303,
	IPC_MutexInitFailed		= 304,
	IPC_Failed					= 305,

	VendorSpecific_UnableToConnectToOculusRuntime = 1000,

	VendorSpecific_HmdFound_But						= 1100,
	VendorSpecific_HmdFound_CantOpenDevice 			= 1101,
	VendorSpecific_HmdFound_UnableToRequestConfigStart = 1102,
	VendorSpecific_HmdFound_NoStoredConfig 			= 1103,
	VendorSpecific_HmdFound_ConfigTooBig 				= 1104,
	VendorSpecific_HmdFound_ConfigTooSmall 			= 1105,
	VendorSpecific_HmdFound_UnableToInitZLib 			= 1106,
	VendorSpecific_HmdFound_CantReadFirmwareVersion 	= 1107,
	VendorSpecific_HmdFound_UnableToSendUserDataStart  = 1108,
	VendorSpecific_HmdFound_UnableToGetUserDataStart   = 1109,
	VendorSpecific_HmdFound_UnableToGetUserDataNext    = 1110,
	VendorSpecific_HmdFound_UserDataAddressRange       = 1111,
	VendorSpecific_HmdFound_UserDataError              = 1112,
	VendorSpecific_HmdFound_ConfigFailedSanityCheck    = 1113,

	Steam_SteamInstallationNotFound = 2000,

};