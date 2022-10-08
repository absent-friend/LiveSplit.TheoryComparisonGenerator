using LiveSplit.Model.Comparisons;

namespace LiveSplit.TheoryComparisonGenerator.Comparisons
{
    interface ITheoryComparisonGenerator : IComparisonGenerator
    {
        bool ShouldAddToSplits(string splitsName);
    }
}
