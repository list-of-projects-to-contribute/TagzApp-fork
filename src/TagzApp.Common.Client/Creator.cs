﻿namespace TagzApp.Common.Models;

public class Creator
{
	/// <summary>
	///   Provider that this creator is associated with
	/// </summary>
	public string ProviderId { get; set; } = string.Empty;

	/// <summary>
	///   The screenname for the user
	/// </summary>
	public string UserName { get; set; } = string.Empty;

	/// <summary>
	///   Name of the creator
	/// </summary>
	public string DisplayName { get; set; } = string.Empty;

	/// <summary>
	///   Uri to the profile of the creator
	/// </summary>
	public required Uri ProfileUri { get; set; } = new Uri("/img/user.jpg", UriKind.Relative);

	/// <summary>
	///   Uri to the profile image of the creator
	/// </summary>
	public required Uri ProfileImageUri { get; set; }
}
