using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_BasicProgramms_Practice_Library.DesignPatterns.BuilderDesignpattern
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
           this._product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartA");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC");
        }

        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset();
            return result;
        }
    }
}
