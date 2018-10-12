namespace AutoMapper.Attributes
{
    /// <summary>
    /// This is placed on your derived <see cref="MapsFromAttribute"/> class.
    /// </summary>
    public interface IHaveCustomMapping<TSource, TTarget>
    {
        /// <summary>
        /// Allows you to manually configure your maps.
        /// </summary>
        /// <param name="mappingExpression"></param>
        void ConfigureMapping(IMappingExpression<TSource, TTarget> mappingExpression);
    }
}
