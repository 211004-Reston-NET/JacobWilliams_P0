using System;
using System.Collections.Generic;

namespace Models

{
    public class Product
    {
        public int _productId;
        public string _productName;
        public string _productDescription;
        public int _productPrice;

        public int ProductId
        {
            get
            {
                return _productId;
            }
            set
            {
                _productId = value;
            }
        }
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public string ProductDescription
        {
            get
            {
                return _productDescription;
            }
            set
            {
                _productDescription = value;
            }
        }
        public int ProductPrice
        {
            get
            {
                return _productPrice;
            }
            set
            {
                _productPrice = value;
            }
        }
        public List<LineItems> LineItems { get; set; }
    }
}