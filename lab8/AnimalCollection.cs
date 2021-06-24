using System;
using System.Collections.Generic;

namespace lab8
{
    public class AnimalCollection<T> where T: Animal
    {
        private List<T> _animals = new List<T>();

        public void Add(T obj)
        {
            _animals.Add(obj);
        }
        public void ShowInformation()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal.ToString());
                animal.Speak();
            }
        }

        public void Remove(int index)
        {
            _animals.RemoveAt(index);
        }
    }
    
}