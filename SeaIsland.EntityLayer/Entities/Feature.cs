﻿namespace SeaIsland.EntityLayer.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public string ImageUrl { get; set; }
        public bool IsFeatureActive { get; set; }   
    }
}
