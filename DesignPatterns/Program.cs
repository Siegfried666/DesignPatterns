using DesignPatterns.BehavioralsDesignsPatterns;
using DesignPatterns.StructuralsDesignPatterns;

//BehavioralsPatterns();
StructuralsPatterns();


void BehavioralsPatterns()
{
    BehavioralsExamples behaviorals = new BehavioralsExamples();

    behaviorals.MementoPattern();
    behaviorals.StatePattern();
    behaviorals.StrategyPattern();
    behaviorals.IteratorPattern();
    behaviorals.CommandPattern();
    behaviorals.TemplateMethodPattern();
    behaviorals.ObserverPattern();
    behaviorals.MediatorPattern();
    behaviorals.ChainOfResponsabilityPattern();
    behaviorals.InterpreterPattern();
    behaviorals.VisitorPattern();
}

void StructuralsPatterns()
{
    StructuralsExamples structurals = new StructuralsExamples();

    // structurals.CompositePattern();
    // structurals.AdapterPattern();
    structurals.BridgePattern();
}
