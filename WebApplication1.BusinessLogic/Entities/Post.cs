﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.BusinessLogic.Entities
{
	public class Post
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PostId { get; set; }

		[Required]
		[StringLength(100)]
		public string Title { get; set; }

		[Required]
		[StringLength(10000)]
		public string PostContent { get; set; }

		[Required]
		[StringLength(200)]
		public string ImageUrl { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }
	}
}