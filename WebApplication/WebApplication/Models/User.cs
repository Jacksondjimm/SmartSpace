﻿namespace RazorPagesApp.Models 
{
    public class User // for test only
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }

		public float temp { get; set; }
		public float hum { get; set; }
		public float num { get; set; }
        public DateTime date { get; set; }
    }
}