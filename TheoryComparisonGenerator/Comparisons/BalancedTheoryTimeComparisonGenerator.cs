using LiveSplit.Model;
using LiveSplit.Model.Comparisons;
using System;

namespace LiveSplit.TheoryComparisonGenerator.Comparisons
{
    internal class BalancedTheoryTimeComparisonGenerator : PercentileComparisonGenerator, ITheoryComparisonGenerator
    {
        public BalancedTheoryTimeComparisonGenerator(IRun run, ComparisonData data) : base(run)
        {
            Data = data;
        }

        private ComparisonData Data { get; set; }

        protected override TimeSpan? GetGoalTime(TimingMethod method)
        {
            return Data.TargetT[method];
        }

        public override string Name => Data.FormattedName;

        public bool ShouldAddToSplits(string splitsName)
        {
            return Data != null && Data.SplitsName == splitsName;
        }
    }
}
