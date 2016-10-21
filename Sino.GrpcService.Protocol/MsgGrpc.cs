// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: msg.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Sino.GrpcService {
  public static class MsgService
  {
    static readonly string __ServiceName = "Sino.GrpcService.MsgService";

    static readonly Marshaller<global::Sino.GrpcService.GetMsgListRequest> __Marshaller_GetMsgListRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.GetMsgListRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.GetMsgListReply> __Marshaller_GetMsgListReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.GetMsgListReply.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.GetMsgOneRequest> __Marshaller_GetMsgOneRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.GetMsgOneRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.GetMsgOneReply> __Marshaller_GetMsgOneReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.GetMsgOneReply.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.EditMsgRequest> __Marshaller_EditMsgRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.EditMsgRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.EditMsgReply> __Marshaller_EditMsgReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.EditMsgReply.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.RemoveMsgRequest> __Marshaller_RemoveMsgRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.RemoveMsgRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Sino.GrpcService.RemoveMsgReply> __Marshaller_RemoveMsgReply = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sino.GrpcService.RemoveMsgReply.Parser.ParseFrom);

    static readonly Method<global::Sino.GrpcService.GetMsgListRequest, global::Sino.GrpcService.GetMsgListReply> __Method_GetList = new Method<global::Sino.GrpcService.GetMsgListRequest, global::Sino.GrpcService.GetMsgListReply>(
        MethodType.Unary,
        __ServiceName,
        "GetList",
        __Marshaller_GetMsgListRequest,
        __Marshaller_GetMsgListReply);

    static readonly Method<global::Sino.GrpcService.GetMsgOneRequest, global::Sino.GrpcService.GetMsgOneReply> __Method_GetOne = new Method<global::Sino.GrpcService.GetMsgOneRequest, global::Sino.GrpcService.GetMsgOneReply>(
        MethodType.Unary,
        __ServiceName,
        "GetOne",
        __Marshaller_GetMsgOneRequest,
        __Marshaller_GetMsgOneReply);

    static readonly Method<global::Sino.GrpcService.EditMsgRequest, global::Sino.GrpcService.EditMsgReply> __Method_Edit = new Method<global::Sino.GrpcService.EditMsgRequest, global::Sino.GrpcService.EditMsgReply>(
        MethodType.Unary,
        __ServiceName,
        "Edit",
        __Marshaller_EditMsgRequest,
        __Marshaller_EditMsgReply);

    static readonly Method<global::Sino.GrpcService.RemoveMsgRequest, global::Sino.GrpcService.RemoveMsgReply> __Method_Remove = new Method<global::Sino.GrpcService.RemoveMsgRequest, global::Sino.GrpcService.RemoveMsgReply>(
        MethodType.Unary,
        __ServiceName,
        "Remove",
        __Marshaller_RemoveMsgRequest,
        __Marshaller_RemoveMsgReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sino.GrpcService.MsgReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MsgService</summary>
    public abstract class MsgServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Sino.GrpcService.GetMsgListReply> GetList(global::Sino.GrpcService.GetMsgListRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Sino.GrpcService.GetMsgOneReply> GetOne(global::Sino.GrpcService.GetMsgOneRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Sino.GrpcService.EditMsgReply> Edit(global::Sino.GrpcService.EditMsgRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Sino.GrpcService.RemoveMsgReply> Remove(global::Sino.GrpcService.RemoveMsgRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MsgService</summary>
    public class MsgServiceClient : ClientBase<MsgServiceClient>
    {
      /// <summary>Creates a new client for MsgService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MsgServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MsgService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MsgServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MsgServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MsgServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Sino.GrpcService.GetMsgListReply GetList(global::Sino.GrpcService.GetMsgListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetList(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sino.GrpcService.GetMsgListReply GetList(global::Sino.GrpcService.GetMsgListRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetList, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.GetMsgListReply> GetListAsync(global::Sino.GrpcService.GetMsgListRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetListAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.GetMsgListReply> GetListAsync(global::Sino.GrpcService.GetMsgListRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetList, null, options, request);
      }
      public virtual global::Sino.GrpcService.GetMsgOneReply GetOne(global::Sino.GrpcService.GetMsgOneRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOne(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sino.GrpcService.GetMsgOneReply GetOne(global::Sino.GrpcService.GetMsgOneRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetOne, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.GetMsgOneReply> GetOneAsync(global::Sino.GrpcService.GetMsgOneRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetOneAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.GetMsgOneReply> GetOneAsync(global::Sino.GrpcService.GetMsgOneRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetOne, null, options, request);
      }
      public virtual global::Sino.GrpcService.EditMsgReply Edit(global::Sino.GrpcService.EditMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Edit(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sino.GrpcService.EditMsgReply Edit(global::Sino.GrpcService.EditMsgRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Edit, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.EditMsgReply> EditAsync(global::Sino.GrpcService.EditMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return EditAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.EditMsgReply> EditAsync(global::Sino.GrpcService.EditMsgRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Edit, null, options, request);
      }
      public virtual global::Sino.GrpcService.RemoveMsgReply Remove(global::Sino.GrpcService.RemoveMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Remove(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sino.GrpcService.RemoveMsgReply Remove(global::Sino.GrpcService.RemoveMsgRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Remove, null, options, request);
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.RemoveMsgReply> RemoveAsync(global::Sino.GrpcService.RemoveMsgRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RemoveAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      public virtual AsyncUnaryCall<global::Sino.GrpcService.RemoveMsgReply> RemoveAsync(global::Sino.GrpcService.RemoveMsgRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Remove, null, options, request);
      }
      protected override MsgServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MsgServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(MsgServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetList, serviceImpl.GetList)
          .AddMethod(__Method_GetOne, serviceImpl.GetOne)
          .AddMethod(__Method_Edit, serviceImpl.Edit)
          .AddMethod(__Method_Remove, serviceImpl.Remove).Build();
    }

  }
}
#endregion
