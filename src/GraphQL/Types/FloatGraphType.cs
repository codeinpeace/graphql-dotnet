using GraphQL.Language;

namespace GraphQL.Types
{
    public class FloatGraphType : ScalarGraphType
    {
        public FloatGraphType()
        {
            Name = "Float";
        }

        public override object ParseValue(object value)
        {
            float result;
            if (float.TryParse(value.ToString(), out result))
            {
                return result;
            }
            return null;
        }

        public override object ParseLiteral(IValue value)
        {
            var floatVal = value as FloatValue;
            return floatVal?.Value;
        }
    }
}
