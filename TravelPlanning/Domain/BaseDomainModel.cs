﻿namespace TravelPlanning.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DataUpdated { get; set; }

       

    }
}
