﻿using System.Text.Json.Serialization;

namespace JikanDotNet
{
	/// <summary>
	/// Model class representing sub item on MyAnimeList without image.
	/// </summary>
	public class MALSubItem
	{
		/// <summary>
		/// ID associated with MyAnimeList.
		/// </summary>
		[JsonPropertyName("mal_id")]
		public long MalId { get; set; }

		/// <summary>
		/// Item type (e. g. "anime", "manga").
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }

		/// <summary>
		/// Url to sub item main page.
		/// </summary>
		[JsonPropertyName("url")]
		public string Url { get; set; }

		/// <summary>
		/// Title of the item
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Overriden ToString method.
		/// </summary>
		/// <returns>Title if not null, base method elsewhere.</returns>
		public override string ToString()
		{
			return Name ?? base.ToString();
		}
	}
}