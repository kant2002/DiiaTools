using JetBrains.Annotations;
using QuikGraph;

namespace ШвидкГраф;

public class Ребро<ТВершина> : Edge<ТВершина>
{
    public Ребро([NotNullAttribute] ТВершина source, [NotNullAttribute] ТВершина target) : base(source, target)
    {
    }
}

public static class РозширенняГрафа
{
    [Pure]
    [NotNull]
    public static AdjacencyGraph<ТВершина, ТРебро> ДоГрафаСуміжності<ТВершина, ТРебро>(
        [NotNull, ItemNotNull] this IEnumerable<ТРебро> ребра,
        bool дозволитиПараллельніРебра = true)
        where ТРебро : IEdge<ТВершина>
    {
        var граф = new AdjacencyGraph<ТВершина, ТРебро>(дозволитиПараллельніРебра);
        граф.AddVerticesAndEdgeRange(ребра);
        return граф;
    }
}