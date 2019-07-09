﻿using AnimalHusbandryMod.meats;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHusbandryMod.common;

namespace AnimalHusbandryMod.animals
{
    public static class AnimalExtension
    {
        public static Meat GetMeat(this Animal value)
        {
            var field = value.GetType().GetField(value.ToString());

            var attribute = System.Attribute.GetCustomAttribute(field, typeof(MeatAttribute)) as MeatAttribute;

            return attribute.Meat;
        }

        public static Animal? GetAnimalFromType(string type)
        {
            foreach (Animal animal in System.Enum.GetValues(typeof(Animal)))
            {
                if (type.Contains(animal.ToString()))
                {
                    return animal;
                }
            }
            return null;
        }

        public static string GetBabyAnimalName(this Animal value)
        {
            return DataLoader.i18n.Get($"Animal.{value.ToString()}.BabyName");
        }

        public static string GetBabyAnimalNameByType(string type)
        {
            return GetAnimalFromType(type)?.GetBabyAnimalName();
        }
    }
}
