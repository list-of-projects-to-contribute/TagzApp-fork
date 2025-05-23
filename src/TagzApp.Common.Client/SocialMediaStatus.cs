﻿namespace TagzApp.Common;

/// <summary>
/// Defines the health status of a Social Media Provider
/// </summary>
public enum SocialMediaStatus
{
	Disabled = -2,
	Unknown = -1,
	Unhealthy = 0,
	Degraded = 1,
	Healthy = 2
}
