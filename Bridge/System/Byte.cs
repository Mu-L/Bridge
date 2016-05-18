using Bridge;

namespace System
{
    [External]
    [Name("Bridge.Byte")]
    [Constructor("Number")]
    public struct Byte : IComparable, IComparable<Byte>, IEquatable<Byte>, IFormattable
    {
        private extern Byte(int i);

        [InlineConst]
        public const byte MinValue = 0;

        [InlineConst]
        public const byte MaxValue = 255;

        [Template("Bridge.Byte.parse({s})")]
        public static extern byte Parse(string s);

        [Template("Bridge.Byte.parse({s}, {radix})")]
        public static extern byte Parse(string s, int radix);

        [Template("Bridge.Byte.tryParse({s}, {result})")]
        public static extern bool TryParse(string s, out byte result);

        [Template("Bridge.Byte.tryParse({s}, {result}, {radix})")]
        public static extern bool TryParse(string s, out byte result, int radix);

        public extern string ToString(int radix);

        [Template("Bridge.Byte.format({this}, {format})")]
        public extern string Format(string format);

        [Template("Bridge.Byte.format({this}, {format}, {provider})")]
        public extern string Format(string format, IFormatProvider provider);

        [Template("Bridge.Byte.format({this}, {format})")]
        public extern string ToString(string format);

        [Template("Bridge.Byte.format({this}, {format}, {provider})")]
        public extern string ToString(string format, IFormatProvider provider);

        [Template("Bridge.compare({this}, {other})")]
        public extern int CompareTo(byte other);

        [Template("Bridge.compare({this}, {obj})")]
        public extern int CompareTo(object obj);

        [Template("{this} === {other}")]
        public extern bool Equals(byte other);
    }
}