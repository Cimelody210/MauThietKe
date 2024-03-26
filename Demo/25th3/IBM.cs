using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CommandPattern
class IBm: Stock
{
    public IBm(string symbol, double price): base(symbol, price){

    }
}
public interface IInventor
{
  void Update(Stock stock);
}