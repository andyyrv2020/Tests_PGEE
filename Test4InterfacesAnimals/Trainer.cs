﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test4InterfacesAnimals
{
    class Trainer

    {

        private IAnimal entity;

        private string name;



        public Trainer(string name, IAnimal entity)

        {

            this.Name = name;

            this.Entity = entity;

        }



        public string Name 

        {
            get { return name; } // name

            private set

            {

                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))

                {

                    throw new ArgumentException("Name can't be null or empty!");
                }

                name = value;

            }

        }

        public IAnimal Entity 

        {

            get { return entity; }// entity 

            private set

            {

                entity = value;

            }

        }



        public void Work(IAnimal entity)

        {

            this.Entity = entity;

            Console.WriteLine($"Trainer {name} works with {entity.Name}!");//this.Entity.Name

        }



        public void Make()

        {

            this.Entity.Perform();

        }

    }
}