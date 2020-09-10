﻿using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace JikanDotNet
{
	/// <summary>
	/// Model class representing collection of related anime entries.
	/// </summary>
	public class RelatedAnime
	{
		/// <summary>
		/// Collection of alternative versions.
		/// </summary>
		[JsonPropertyName("Alternative version")]
		public ICollection<MALSubItem> AlternativeVersions { get; set; }

		/// <summary>
		/// Collection of alternative settings.
		/// </summary>
		[JsonPropertyName("Alternative setting")]
		public ICollection<MALSubItem> AlternativeSettings { get; set; }

		/// <summary>
		/// Collection of adaptations.
		/// </summary>
		[JsonPropertyName("Adaptation")]
		public ICollection<MALSubItem> Adaptations { get; set; }

		/// <summary>
		/// Collection of character related entries.
		/// </summary>
		[JsonPropertyName("Character")]
		public ICollection<MALSubItem> Characters { get; set; }

		/// <summary>
		/// Collection of full stories.
		/// </summary>
		[JsonPropertyName("Full story")]
		public ICollection<MALSubItem> FullStories { get; set; }

		/// <summary>
		/// Collection of parent stories.
		/// </summary>
		[JsonPropertyName("Parent story")]
		public ICollection<MALSubItem> ParentStories { get; set; }

		/// <summary>
		/// Collection of prequels.
		/// </summary>
		[JsonPropertyName("Prequel")]
		public ICollection<MALSubItem> Prequels { get; set; }

		/// <summary>
		/// Collection of other entries.
		/// </summary>
		[JsonPropertyName("Other")]
		public ICollection<MALSubItem> Others { get; set; }

		/// <summary>
		/// Collection of sequels.
		/// </summary>
		[JsonPropertyName("Sequel")]
		public ICollection<MALSubItem> Sequels { get; set; }

		/// <summary>
		/// Collection of side stories.
		/// </summary>
		[JsonPropertyName("Side story")]
		public ICollection<MALSubItem> SideStories { get; set; }

		/// <summary>
		/// Collection of spin-off.
		/// </summary>
		[JsonPropertyName("Spin-off")]
		public ICollection<MALSubItem> SpinOffs { get; set; }

		/// <summary>
		/// Collection of summaries.
		/// </summary>
		[JsonPropertyName("Summary")]
		public ICollection<MALSubItem> Summaries { get; set; }
	}
}