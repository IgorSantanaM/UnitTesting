using Xunit;

namespace AdvancedTechniques.Tests.Unit;

[CollectionDefinition("My awesome collection fixture")] // To share the same MyClassFixture to each class collection fixture Tests
public class TestCollectionFixture : ICollectionFixture<MyClassFixture>
{

}
