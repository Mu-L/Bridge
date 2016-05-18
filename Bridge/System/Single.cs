using Bridge;

namespace System
{
    [External]
    [Name("Bridge.Single")]
    [Constructor("Number")]
    public struct Single : IComparable, IComparable<Single>, IEquatable<Single>, IFormattable
    {
        private extern Single(int i);

        [InlineConst]
        public const float MaxValue = (float)3.40282346638528859e+38;

        [InlineConst]
        public const float MinValue = (float)-3.40282346638528859e+38;

        [InlineConst]
        public const float Epsilon = (float)1.4e-45;

        [Template("Number.NaN")]
        public static readonly float NaN = 0;

        [Template("Number.NEGATIVE_INFINITY")]
        public static readonly float NegativeInfinity = 0;

        [Template("Number.POSITIVE_INFINITY")]
        public static readonly float PositiveInfinity = 0;

        [Template("Bridge.Single.format({this}, {format})")]
        public extern string Format(string format);

        [Template("Bridge.Single.format({this}, {format}, {provider})")]
        public extern string Format(string format, IFormatProvider provider);

        public extern string ToString(int radix);

        [Template("Bridge.Single.format({this}, {format})")]
        public extern string ToString(string format);

        [Template("Bridge.Single.format({this}, {format}, {provider})")]
        public extern string ToString(string format, IFormatProvider provider);

        [Template("Bridge.Single.format({this}, 'G')")]
        public override extern string ToString();

        [Template("Bridge.Single.format({this}, 'G', {provider})")]
        public extern string ToString(IFormatProvider provider);

        [Template("Bridge.Single.parse({s})")]
        public static extern float Parse(string s);

        [Template("Bridge.Single.parse({s}, {provider})")]
        public static extern float Parse(string s, IFormatProvider provider);

        [Template("Bridge.Single.tryParse({s}, null, {result})")]
        public static extern bool TryParse(string s, out float result);

        [Template("Bridge.Single.tryParse({s}, {provider}, {result})")]
        public static extern bool TryParse(string s, IFormatProvider provider, out float result);

        public extern string ToExponential();

        public extern string ToExponential(int fractionDigits);

        public extern string ToFixed();

        public extern string ToFixed(int fractionDigits);

        public extern string ToPrecision();

        public extern string ToPrecision(int precision);

        [Template("({d} === Number.POSITIVE_INFINITY)")]
        public static extern bool IsPositiveInfinity(float d);

        [Template("({d} === Number.NEGATIVE_INFINITY)")]
        public static extern bool IsNegativeInfinity(float d);

        [Template("(Math.abs({d}) === Number.POSITIVE_INFINITY)")]
        public static extern bool IsInfinity(float d);

        [Template("isFinite({d})")]
        public static extern bool IsFinite(float d);

        [Template("isNaN({d})")]
        public static extern bool IsNaN(float d);

        [Template("Bridge.compare({this}, {other})")]
        public extern int CompareTo(float other);

        [Template("Bridge.compare({this}, {obj})")]
        public extern int CompareTo(object obj);

        [Template("{this} === {other}")]
        public extern bool Equals(float other);
    }
}