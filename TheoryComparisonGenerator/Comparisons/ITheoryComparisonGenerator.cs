using LiveSplit.Model.Comparisons;

namespace LiveSplit.TheoryComparisonGenerator.Comparisons
{
    internal interface ITheoryComparisonGenerator : IComparisonGenerator
    {
        bool ShouldAddToSplits(string splitsName);
    }
}
