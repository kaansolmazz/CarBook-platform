﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
	public class GetCarWithBrandQueryResult
	{
		public int CarId { get; set; }
		public string BrandName { get; set; }
		public string Model { get; set; }
		public string CoverImage { get; set; }
		public int km { get; set; }
		public string Transmission { get; set; }
		public byte Seat { get; set; }
		public byte Luggage { get; set; }
		public string Fuel { get; set; }
		public string BigImageUrl { get; set; }
		public bool Vitrin { get; set; }
	}
}
