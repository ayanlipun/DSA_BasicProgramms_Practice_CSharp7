using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.Creational.BuilderDesignpattern
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            _product.Add("PartA");
        }

        public void BuildPartB()
        {
            _product.Add("PartB");
        }

        public void BuildPartC()
        {
            _product.Add("PartC");
        }

        public Product GetProduct()
        {
            Product result = _product;
            Reset();
            return result;
        }
    }
}
