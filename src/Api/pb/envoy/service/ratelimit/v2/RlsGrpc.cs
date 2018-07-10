// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: envoy/service/ratelimit/v2/rls.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Envoy.Service.Ratelimit.V2 {
  public static partial class RateLimitService
  {
    static readonly string __ServiceName = "envoy.service.ratelimit.v2.RateLimitService";

    static readonly grpc::Marshaller<global::Envoy.Service.Ratelimit.V2.RateLimitRequest> __Marshaller_RateLimitRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Service.Ratelimit.V2.RateLimitRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Envoy.Service.Ratelimit.V2.RateLimitResponse> __Marshaller_RateLimitResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Envoy.Service.Ratelimit.V2.RateLimitResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Envoy.Service.Ratelimit.V2.RateLimitRequest, global::Envoy.Service.Ratelimit.V2.RateLimitResponse> __Method_ShouldRateLimit = new grpc::Method<global::Envoy.Service.Ratelimit.V2.RateLimitRequest, global::Envoy.Service.Ratelimit.V2.RateLimitResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ShouldRateLimit",
        __Marshaller_RateLimitRequest,
        __Marshaller_RateLimitResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Envoy.Service.Ratelimit.V2.RlsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RateLimitService</summary>
    public abstract partial class RateLimitServiceBase
    {
      /// <summary>
      /// Determine whether rate limiting should take place.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Envoy.Service.Ratelimit.V2.RateLimitResponse> ShouldRateLimit(global::Envoy.Service.Ratelimit.V2.RateLimitRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RateLimitService</summary>
    public partial class RateLimitServiceClient : grpc::ClientBase<RateLimitServiceClient>
    {
      /// <summary>Creates a new client for RateLimitService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RateLimitServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RateLimitService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RateLimitServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RateLimitServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RateLimitServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Determine whether rate limiting should take place.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Envoy.Service.Ratelimit.V2.RateLimitResponse ShouldRateLimit(global::Envoy.Service.Ratelimit.V2.RateLimitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShouldRateLimit(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Determine whether rate limiting should take place.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Envoy.Service.Ratelimit.V2.RateLimitResponse ShouldRateLimit(global::Envoy.Service.Ratelimit.V2.RateLimitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ShouldRateLimit, null, options, request);
      }
      /// <summary>
      /// Determine whether rate limiting should take place.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Envoy.Service.Ratelimit.V2.RateLimitResponse> ShouldRateLimitAsync(global::Envoy.Service.Ratelimit.V2.RateLimitRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ShouldRateLimitAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Determine whether rate limiting should take place.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Envoy.Service.Ratelimit.V2.RateLimitResponse> ShouldRateLimitAsync(global::Envoy.Service.Ratelimit.V2.RateLimitRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ShouldRateLimit, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RateLimitServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RateLimitServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RateLimitServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ShouldRateLimit, serviceImpl.ShouldRateLimit).Build();
    }

  }
}
#endregion
