using System.Collections.Immutable;
using System.Threading.Tasks;
using Envoy.Api.V2;
using Envoy.Api.V2.Core;
using Google.Protobuf;
using Xunit;

namespace Envoy.ControlPlane.Cache.Tests
{
    public class SnapshotCacheTest
    {
        private DiscoveryRequest ClusterRequest =>
            new DiscoveryRequest() {Node = new Node() {Id = "node1"}, TypeUrl = TypeStrings.ClusterType, VersionInfo = "1"};

        private Snapshot BuildSnapshot()
        {
            var clustersBuilder = ImmutableDictionary.CreateBuilder<string, IMessage>();
            clustersBuilder.Add("c1", new Cluster());
            return new Snapshot(null, new Resources("2", clustersBuilder.ToImmutable()), null, null);
        }
        
        [Fact]
        public async Task NoSnapshot_GetResponseForFetch_ReturnsEmpty()
        {
            // Arrange
            var cache = new SnapshotCache(true);
            
            // Act
            var result = await cache.Fetch(ClusterRequest);
            
            // Assert
            Assert.Null(result);
        }
        
        [Fact]
        public async Task NoSnapshot_GetResponseForStream_ReturnsUnresolvedTask()
        {
            // Arrange
            var cache = new SnapshotCache(true);
            
            // Act
            var resultTask = cache.CreateWatch(ClusterRequest);
            
            // Assert
            await Task.Delay(1000);
            Assert.False(resultTask.Response.IsCompleted);
        }
        
        [Fact]
        public async Task Snapshot_GetResponseForStream_ReturnsResolvedTask()
        {
            // Arrange
            var cache = new SnapshotCache(true);
            cache.SetSnapshot("node1", BuildSnapshot());
            
            // Act
            var result = await cache.CreateWatch(ClusterRequest).Response;
            
            // Assert
            Assert.NotNull(result);
            Assert.Equal("2", result.VersionInfo);
        }
        
        [Fact]
        public async Task NoSnapshotAndGetResponseForStream_SnapshotSet_ResolvedTask()
        {
            // Arrange
            var cache = new SnapshotCache(true);
            var resultTask = cache.CreateWatch(ClusterRequest).Response;
            
            // Act
            cache.SetSnapshot("node1", BuildSnapshot());
            var result = await resultTask;
            
            // Assert
            Assert.NotNull(result);
            Assert.Equal("2", result.VersionInfo);
        }
    }
}