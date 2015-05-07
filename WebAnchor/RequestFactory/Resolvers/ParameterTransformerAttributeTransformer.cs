﻿namespace WebAnchor.RequestFactory.Resolvers
{
    public class ParameterTransformerAttributeTransformer : ParameterTransformer<ParameterTransformerAttribute>
    {
        protected override void Transform(Parameter parameter, ParameterTransformerAttribute attribute)
        {
            attribute.Context = this.Context;
            attribute.Apply(parameter);
        }
    }
}