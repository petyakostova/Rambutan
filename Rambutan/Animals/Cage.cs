﻿namespace Zoo.Animals
{
    using System;
    using System.Collections.Generic;

    using Zoo.Interfaces;

    public enum HabitatType 
    { 
        Pool, 
        Aquarium, 
        Steppe 
    }

    public class Cage : ICage
    {
        private long cageID;
        private double width;
        private double height;
        private double depth;
        private decimal price;
        private bool isRepaired;
        private HabitatType type;
        private List<Animal> animalsInCage;        

        public Cage(long id, double width, double height, double depth, HabitatType type)
        {
            this.CageID = id;
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
            this.Price = (decimal)(width * depth);
            this.IsRepaired = true;
            this.Type = type;
            this.AnimalsInCage = new List<Animal>();
        }

        public List<Animal> AnimalsInCage
        {
            get
            {
                return this.animalsInCage;
            }
            private set
            {
                this.animalsInCage = value;
            }
        }

        public HabitatType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }

        public bool IsRepaired
        {
            get
            {
                return this.isRepaired;
            }
            private set
            {
                this.isRepaired = value;
            }
        }

        public long CageID
        {
            get
            {
                return this.cageID;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("CageID can not be null!");
                }

                this.cageID = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The length cannot be negative!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The length cannot be negative!");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The length cannot be negative!");
                }

                this.depth = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public void Break()
        {
            this.IsRepaired = false;
        }

        public void Repair()
        {
            this.IsRepaired = true;
        }
        
        public void AddAnimal(Animal animal)
        {
            if (this.IsRepaired == true)
            {
                this.AnimalsInCage.Add(animal);
                Console.WriteLine(this.AnimalsInCage.Remove(animal));
                if (this.AnimalsInCage.Count > 5) // 5 is the maximum amount of animals in a singe cage
                {
                    Break();
                    Console.WriteLine("The cage is now broken !");
                }
            }
        }

        public void RemoveAnimal(Animal animal)
        {

            // this doesn`t seem to work ,returns false
            this.AnimalsInCage.Remove(animal);
          
        }
    }
}
