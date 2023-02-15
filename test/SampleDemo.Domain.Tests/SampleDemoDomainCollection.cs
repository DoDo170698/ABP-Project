using SampleDemo.MongoDB;
using Xunit;

namespace SampleDemo;

[CollectionDefinition(SampleDemoTestConsts.CollectionDefinitionName)]
public class SampleDemoDomainCollection : SampleDemoMongoDbCollectionFixtureBase
{

}
