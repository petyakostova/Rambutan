﻿namespace Zoo.Interfaces
{
    using System;
    using Zoo.Animals.Consumables;

    public interface IHerbivore
    {
        FoodType TypeOfFood { get; set; }
    }
}
