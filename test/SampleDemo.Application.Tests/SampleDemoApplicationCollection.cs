using SampleDemo.MongoDB;
using Xunit;

namespace SampleDemo;

[CollectionDefinition(SampleDemoTestConsts.CollectionDefinitionName)]
public class SampleDemoApplicationCollection : SampleDemoMongoDbCollectionFixtureBase
{

}
