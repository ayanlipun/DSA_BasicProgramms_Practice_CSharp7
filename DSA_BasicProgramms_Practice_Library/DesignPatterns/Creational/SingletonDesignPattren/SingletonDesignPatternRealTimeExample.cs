using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.SingletonDesignPattren
{
    public class SingletonDesignPatternRealTimeExample
    {
        public static void ExecSingletonDesignPatternRealTimeExample()
        {
            SingletonCache cache = SingletonCache.GetInstance();
            //Adding Keys and Values into the Cache using Add and AddOrUpdate Method
            Console.WriteLine("Adding Keys and Values into Cache");
            Console.WriteLine($" Adding Id in Cache: {cache.Add("Id", 1001)}");
            Console.WriteLine($" Adding Name in Cache: {cache.Add("Name", "Winsome")}");
            Console.WriteLine($" Adding Same Id Key in Cache using Add: {cache.Add("Id", 2001)}");
            Console.WriteLine($" Adding Same Id Key in Cache using AddOrUpdate: {cache.AddOrUpdate("Id", 2001)}");

            //Accessing values from Cache using Keys using the Get Method by passing the Keys
            Console.WriteLine("\nFetching Values from Cache");
            Console.WriteLine($" Fetching Id From Cache: {cache.Get("Id")}");
            Console.WriteLine($" Fetching Name From Cache: {cache.Get("Name")}");

            //Removing Elements from Cache using Remove Method by passing the given keys
            Console.WriteLine("\nRemoving Values from Cache");
            Console.WriteLine($" Remove Id: {cache.Remove("Id")}");
            Console.WriteLine($" Accessing Id From Cache: {cache.Get("Id")}");

            //Removing All Elements from the Cache using the Clear Method
            cache.Clear();
            Console.WriteLine("\nClearing All Keys and Values");
            Console.WriteLine($"Fetching Name From Cache: {cache.Get("Name")}");
        }
    }

    public interface IMyCache
    {
        bool Add(object key, object value);
        bool AddOrUpdate(object key, object value);
        object Get(object key);
        bool Remove(object key);
        void Clear();
    }
    public sealed class SingletonCache : IMyCache
    {       
        private ConcurrentDictionary<object, object> concurrentDictionary = new ConcurrentDictionary<object, object>();       
        private static readonly SingletonCache singletonInstance = new SingletonCache();
       
        public static SingletonCache GetInstance()
        {
            return singletonInstance;
        }
       
        private SingletonCache()
        {
            Console.WriteLine("SingletonCache Instance Created");
        }
        
        public bool Add(object key, object value)
        {
            return concurrentDictionary.TryAdd(key, value);
        }
        
        public bool AddOrUpdate(object key, object value)
        {
            if (concurrentDictionary.ContainsKey(key))
            {
                concurrentDictionary.TryRemove(key, out object RemovedValue);
            }
            return concurrentDictionary.TryAdd(key, value);
        }
        
        public object Get(object key)
        {
            if (concurrentDictionary.ContainsKey(key))
            {
                return concurrentDictionary[key];
            }
            return null;
        }
       
        public bool Remove(object key)
        {
            return concurrentDictionary.TryRemove(key, out object value);
        }
        
        public void Clear()
        {            
            concurrentDictionary.Clear();
        }
    }
}
