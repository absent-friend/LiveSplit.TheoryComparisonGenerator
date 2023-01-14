﻿
using System;
using LiveSplit.Model;
using LiveSplit.UI.Components;

[assembly: ComponentFactory(typeof(TheoryComparisonGeneratorFactory))]

namespace LiveSplit.UI.Components
{
	public class TheoryComparisonGeneratorFactory : IComponentFactory
	{
		public string ComponentName => "Theory Comparison Generator";

		public string Description => "Generates comparisons balanced based on segment gold times.";

		public ComponentCategory Category => ComponentCategory.Other;

		public IComponent Create(LiveSplitState state) => new TheoryComparisonGeneratorComponent(state);

		public string UpdateName => ComponentName;

		public string UpdateURL => "https://raw.githubusercontent.com/thags15/LiveSplit.TheoryComparisonGenerator/main/";

		public string XMLURL => "update.LiveSplit.TheoryComparisonGenerator.xml";

		public Version Version => Version.Parse("1.0.0");
	}
}
