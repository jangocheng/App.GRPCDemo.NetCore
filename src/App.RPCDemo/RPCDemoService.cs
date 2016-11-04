// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RPCDemoService.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace App.RPC.Service {

  /// <summary>Holder for reflection information generated from RPCDemoService.proto</summary>
  public static partial class RPCDemoServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for RPCDemoService.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RPCDemoServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRSUENEZW1vU2VydmljZS5wcm90bxIPQXBwLlJQQy5TZXJ2aWNlGgxyZXN1",
            "bHQucHJvdG8iFAoGRGVtb0lkEgoKAklkGAEgASgFIjMKBlNlYXJjaBIMCgRw",
            "YWdlGAEgASgFEgwKBHNpemUYAiABKAUSDQoFcXVlcnkYAyABKAkiPwoLRGVt",
            "b1JlcXVlc3QSCgoCSWQYASABKAkSEQoJQ29tbWVudElkGAIgASgFEhEKCUlz",
            "RGVsZXRlZBgDIAEoCCI5CghEZW1vTGlzdBItCgdkZXRhaWxzGAEgAygLMhwu",
            "QXBwLlJQQy5TZXJ2aWNlLkRlbW9SZXF1ZXN0MtEBCg5SUENEZW1vU2Vydmlj",
            "ZRI+CgNBZGQSHC5BcHAuUlBDLlNlcnZpY2UuRGVtb1JlcXVlc3QaFy5BcHAu",
            "UlBDLk1vZGVsLlJlc3BvbnNlIgASQgoHR2V0QnlJZBIXLkFwcC5SUEMuU2Vy",
            "dmljZS5EZW1vSWQaHC5BcHAuUlBDLlNlcnZpY2UuRGVtb1JlcXVlc3QiABI7",
            "CgNHZXQSFy5BcHAuUlBDLlNlcnZpY2UuU2VhcmNoGhkuQXBwLlJQQy5TZXJ2",
            "aWNlLkRlbW9MaXN0IgBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::App.RPC.Model.ResultReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::App.RPC.Service.DemoId), global::App.RPC.Service.DemoId.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::App.RPC.Service.Search), global::App.RPC.Service.Search.Parser, new[]{ "Page", "Size", "Query" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::App.RPC.Service.DemoRequest), global::App.RPC.Service.DemoRequest.Parser, new[]{ "Id", "CommentId", "IsDeleted" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::App.RPC.Service.DemoList), global::App.RPC.Service.DemoList.Parser, new[]{ "Details" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DemoId : pb::IMessage<DemoId> {
    private static readonly pb::MessageParser<DemoId> _parser = new pb::MessageParser<DemoId>(() => new DemoId());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DemoId> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::App.RPC.Service.RPCDemoServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoId() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoId(DemoId other) : this() {
      id_ = other.id_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoId Clone() {
      return new DemoId(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DemoId);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DemoId other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DemoId other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Search : pb::IMessage<Search> {
    private static readonly pb::MessageParser<Search> _parser = new pb::MessageParser<Search>(() => new Search());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Search> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::App.RPC.Service.RPCDemoServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Search() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Search(Search other) : this() {
      page_ = other.page_;
      size_ = other.size_;
      query_ = other.query_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Search Clone() {
      return new Search(this);
    }

    /// <summary>Field number for the "page" field.</summary>
    public const int PageFieldNumber = 1;
    private int page_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Page {
      get { return page_; }
      set {
        page_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 2;
    private int size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 3;
    private string query_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Search);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Search other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Page != other.Page) return false;
      if (Size != other.Size) return false;
      if (Query != other.Query) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Page != 0) hash ^= Page.GetHashCode();
      if (Size != 0) hash ^= Size.GetHashCode();
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Page != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Page);
      }
      if (Size != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Size);
      }
      if (Query.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Query);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Page != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Page);
      }
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Size);
      }
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Search other) {
      if (other == null) {
        return;
      }
      if (other.Page != 0) {
        Page = other.Page;
      }
      if (other.Size != 0) {
        Size = other.Size;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Page = input.ReadInt32();
            break;
          }
          case 16: {
            Size = input.ReadInt32();
            break;
          }
          case 26: {
            Query = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DemoRequest : pb::IMessage<DemoRequest> {
    private static readonly pb::MessageParser<DemoRequest> _parser = new pb::MessageParser<DemoRequest>(() => new DemoRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DemoRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::App.RPC.Service.RPCDemoServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoRequest(DemoRequest other) : this() {
      id_ = other.id_;
      commentId_ = other.commentId_;
      isDeleted_ = other.isDeleted_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoRequest Clone() {
      return new DemoRequest(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "CommentId" field.</summary>
    public const int CommentIdFieldNumber = 2;
    private int commentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CommentId {
      get { return commentId_; }
      set {
        commentId_ = value;
      }
    }

    /// <summary>Field number for the "IsDeleted" field.</summary>
    public const int IsDeletedFieldNumber = 3;
    private bool isDeleted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDeleted {
      get { return isDeleted_; }
      set {
        isDeleted_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DemoRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DemoRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (CommentId != other.CommentId) return false;
      if (IsDeleted != other.IsDeleted) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (CommentId != 0) hash ^= CommentId.GetHashCode();
      if (IsDeleted != false) hash ^= IsDeleted.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (CommentId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(CommentId);
      }
      if (IsDeleted != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsDeleted);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (CommentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CommentId);
      }
      if (IsDeleted != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DemoRequest other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.CommentId != 0) {
        CommentId = other.CommentId;
      }
      if (other.IsDeleted != false) {
        IsDeleted = other.IsDeleted;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            CommentId = input.ReadInt32();
            break;
          }
          case 24: {
            IsDeleted = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DemoList : pb::IMessage<DemoList> {
    private static readonly pb::MessageParser<DemoList> _parser = new pb::MessageParser<DemoList>(() => new DemoList());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DemoList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::App.RPC.Service.RPCDemoServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoList(DemoList other) : this() {
      details_ = other.details_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DemoList Clone() {
      return new DemoList(this);
    }

    /// <summary>Field number for the "details" field.</summary>
    public const int DetailsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::App.RPC.Service.DemoRequest> _repeated_details_codec
        = pb::FieldCodec.ForMessage(10, global::App.RPC.Service.DemoRequest.Parser);
    private readonly pbc::RepeatedField<global::App.RPC.Service.DemoRequest> details_ = new pbc::RepeatedField<global::App.RPC.Service.DemoRequest>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::App.RPC.Service.DemoRequest> Details {
      get { return details_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DemoList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DemoList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!details_.Equals(other.details_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= details_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      details_.WriteTo(output, _repeated_details_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += details_.CalculateSize(_repeated_details_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DemoList other) {
      if (other == null) {
        return;
      }
      details_.Add(other.details_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            details_.AddEntriesFrom(input, _repeated_details_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code