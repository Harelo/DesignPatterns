using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Interpreter
{
    class ThousandExpression : AbstractExpression
    {
        public override string one => "M";
        public override string four => " ";
        public override string five => " "; 
        public override string nine => " ";
        public override int multiplier => 1000;
    }

    class HundredExpression : AbstractExpression
    {
        public override string one => "C";
        public override string four => "CD";
        public override string five => "D";
        public override string nine => "CM";
        public override int multiplier => 100;
    }

    class TenExpression : AbstractExpression
    {
        public override string one => "X";
        public override string four => "XL";
        public override string five => "L";
        public override string nine => "XC";
        public override int multiplier => 10;
    }

    class OneExpression : AbstractExpression
    {
        public override string one => "I";
        public override string four => "IV";
        public override string five => "V";
        public override string nine => "IX";
        public override int multiplier => 1;
    }
}
