﻿namespace Zoo.Animals.Species.Aquatic
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Dolphin : Aquatic, IFeedable, IAnimal
    {

        public Dolphin(){

        }
        public Dolphin(Object[] dataInit)
            : base(dataInit)
        {
        }

        public Dolphin(int quanty_of_food, long animalID, Gender gender, int age, decimal price, long cageID, HealthStatus healthStatus)
            : base(animalID, AnimalSpeciesType.Dolphin, gender, age, FoodType.Meat, price, cageID, HabitatType.Pool, healthStatus)
        {
        }


        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
        //public void replenishFoodPersonal(int replenishQuantity)
        //{
        //    this.fish.ReplenishAmount(replenishQuantity);
        //}

        //public void consumeFoodPersonal(int bla, string somefood)
        //{
        //    switch (somefood)
        //    {
        //        case "fish":
        //            this.fish.ConsumeAmount(bla);
        //            break;
        //        default:
        //            this.fish.ConsumeAmount(bla);
        //            break;
        //    }

        //}

        //public int supplysFoodPersoanl()
        //{
        //    return this.fish.GetQuantity();
        //}
        // food: small fish, cuttlefish

    }
}