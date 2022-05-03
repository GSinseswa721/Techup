using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Products
{
    #region Products
    public class Products
    {
        #region Member Variables
        protected string _Items;
        protected int _Price;
        #endregion
        #region Constructors
        public Products() { }
        public Products(string Items, int Price)
        {
            this._Items=Items;
            this._Price=Price;
        }
        #endregion
        #region Public Properties
        public virtual string Items
        {
            get {return _Items;}
            set {_Items=value;}
        }
        public virtual int Price
        {
            get {return _Price;}
            set {_Price=value;}
        }
        #endregion
    }
    #endregion
}